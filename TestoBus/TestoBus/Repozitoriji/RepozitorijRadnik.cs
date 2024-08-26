using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TestoBus.Models;

namespace TestoBus.Repozitoriji
{
    internal class RepozitorijRadnik
    {
        static Zaposlenik trenutni;
        public static Zaposlenik DohvatiRadnika(string username)
        {
            string sql = $"SELECT * FROM dbo.Zaposlenik WHERE Username ='{username}'";
            return PronadiRadnikaUBazi(sql);
        }

        private static Zaposlenik PronadiRadnikaUBazi(string sql)
        {
            DB.OpenConnection(); //otvaranje konekcije
            var reader = DB.GetDataReader(sql);
            Zaposlenik zaposlenik = null;
            if (reader.HasRows == true)
            {      
                reader.Read();                  
                zaposlenik = KreirajObjekt(reader); 
                reader.Close();
            }
            DB.CloseConnection();
            return zaposlenik;
        }

        private static Zaposlenik KreirajObjekt(SqlDataReader reader)
        {
            //funkcija koja stvara instancu managera koristeći podatke iz baze
            int id = int.Parse(reader["id_zaposlenika"].ToString());
            string ime = reader["ime"].ToString();
            string prezime = reader["prezime"].ToString();
            string adresa = reader["adresa"].ToString();
            string mobitel = reader["broj_mobitela"].ToString();
            string username = reader["username"].ToString();
            string password = reader["password"].ToString();
            var zaposlenik = new Zaposlenik
            {
                Id = id,
                Ime = ime,
                Prezime = prezime,
                Adresa = adresa,
                Mobitel = mobitel,
                Username = username,
                Password = password
            };
            trenutni = zaposlenik;
            return zaposlenik;
        }

        static public string ImePrezime ()
        {
            return $"{trenutni.Ime} {trenutni.Prezime}";
        }
    }
}
