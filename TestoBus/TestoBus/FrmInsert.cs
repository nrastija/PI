using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TestoBus.Models;
using TestoBus.Repozitoriji;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestoBus
{
    public partial class FrmInsert : Form
    { 
        public FrmInsert()
        {
            InitializeComponent();
            UcitajZaposlenika();
            LoadRegistracijskeOznake();
        }

        public void UcitajZaposlenika()
        {
            txtKorime.Text = RepozitorijRadnik.ImePrezime();
            txtDatum.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }


        private void LoadRegistracijskeOznake()
        {
            List<string> dt = RepozitorijZahtjeva.GetRegistracijskeOznake();
            cmbAutobus.DataSource = dt;
            cmbAutobus.DisplayMember = "RegistracijskaOznaka";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmInsert_Load(object sender, EventArgs e)
        {

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            string sifraVoznog = txtSifra.Text;
            string nazivVoznog = txtNazivLinije.Text;
            string polazisnaStanica = txtPolazisna.Text;
            string odredisnaStanica = txtOdredisna.Text;
            string vrijemeTrajanja = txtVrijeme.Text;
            string registracija = cmbAutobus.Text;
            RepozitorijZahtjeva.UnesiVozniRed(sifraVoznog, nazivVoznog, polazisnaStanica, odredisnaStanica, vrijemeTrajanja, registracija);

            this.Close();
        }
    }
}
