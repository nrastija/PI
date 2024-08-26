using DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TestoBus.Models
{
    public class RepozitorijZahtjeva
    {
        public static List<VozniRed> DohvatiVozneRedove()
        {
            List<VozniRed> zahtjevi = new List<VozniRed>();

            string sql = "SELECT * FROM dbo.VozniRed";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    VozniRed zahtjev = KreirajObjekt(reader);
                    zahtjevi.Add(zahtjev);
                }
            }
            reader.Close();
            DB.CloseConnection();
            return zahtjevi;
        }

        public static List<VozniRed> PretraziVozneRedove(string parametar)
        {
            int.TryParse(parametar, out int numericParametar);
            string sql;

            if (numericParametar >= 1 && numericParametar <= 5)
            {
                sql = $"SELECT * FROM dbo.VozniRed where id_voznog_reda = {parametar}";
            }
            else if (parametar == "reset")
            {
                sql = "SELECT * FROM dbo.VozniRed";
            }
            else
            {
                sql = $"SELECT * FROM dbo.VozniRed where vrijeme_trajanja = {parametar}";
            }

            if (!int.TryParse(parametar, out _) && parametar != "reset")
            {
                MessageBox.Show("Error: Parametar sadrži tekst.");
                return null;
            }

            List<VozniRed> zahtjevi = new List<VozniRed>();
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    VozniRed zahtjev = KreirajObjekt(reader);
                    zahtjevi.Add(zahtjev);
                }
            }
            reader.Close();
            DB.CloseConnection();
            return zahtjevi;
        }
        public static VozniRed KreirajObjekt(SqlDataReader reader)
        {
            int id = int.Parse(reader["id_voznog_reda"].ToString());
            string naziv = reader["naziv_linije"].ToString();
            string polazisna = reader["polazisna_stanica"].ToString();
            string odredisna = reader["odredisna_stanica"].ToString();
            int vrijeme = int.Parse(reader["vrijeme_trajanja"].ToString());
            string autobus = reader["registracijska_oznaka"].ToString();
            var novi = new VozniRed
            {
                Id = id,
                Naziv = naziv,
                Polazisna = polazisna,
                Odredisna = odredisna,
                Vrijeme = vrijeme,
                Autobus = autobus
            };
            return novi;
        }

        public static void UnesiVozniRed(string sifraVoznog, string nazivVoznog, string polazisnaStanica, string odredisnaStanica, string vrijemeTrajanja, string registracijskaOznaka)
        {
            
            if (!System.Text.RegularExpressions.Regex.IsMatch(sifraVoznog, @"^\d+$") || !System.Text.RegularExpressions.Regex.IsMatch(vrijemeTrajanja, @"^\d+$"))
            {
                MessageBox.Show("Vrijeme trajanja i šifra mogu sadržavati samo brojeve!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int sifra = Convert.ToInt32(sifraVoznog);
            int vrijeme = Convert.ToInt32(vrijemeTrajanja);

            string sql = $"INSERT INTO dbo.VozniRed (id_voznog_reda, naziv_linije, polazisna_stanica, odredisna_stanica, vrijeme_trajanja, registracijska_oznaka) " +
                         $"VALUES ({sifra}, '{nazivVoznog}', '{polazisnaStanica}', '{odredisnaStanica}', {vrijeme}, '{registracijskaOznaka}')";

            try
            {
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
                MessageBox.Show($"Unos voznog reda sa šifrom {sifra} je uspešan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom unosa voznog reda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AzurirajVozniRed(int sifraVoznog, string nazivVoznog, string polazisnaStanica, string odredisnaStanica, int vrijemeTrajanja, string registracijskaOznaka)
        {
            string sql = $"UPDATE dbo.VozniRed SET naziv_linije = '{nazivVoznog}', polazisna_stanica = '{polazisnaStanica}', odredisna_stanica = '{odredisnaStanica}', vrijeme_trajanja = {vrijemeTrajanja}, registracijska_oznaka = '{registracijskaOznaka}' WHERE id_voznog_reda = {sifraVoznog}";

            try
            {
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
                MessageBox.Show($"Ažuriranje voznog reda sa šifrom {sifraVoznog} je uspešno.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom ažuriranja voznog reda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ObrisiVozniRed(int sifra)
        {
            string sql = $"DELETE FROM dbo.VozniRed WHERE id_voznog_reda = {sifra}";
            try
            {
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
                MessageBox.Show($"Brisanje voznog reda sa šifrom {sifra} je uspešan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom brisanja voznog reda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<string> GetRegistracijskeOznake()
        {
            List<string> registracijskeOznake = new List<string>();

            string sql = "SELECT registracijska_oznaka FROM dbo.Vozilo";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    registracijskeOznake.Add(reader["registracijska_oznaka"].ToString());
                }
            }
            return registracijskeOznake;
        }
    }
}
