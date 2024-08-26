using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestoBus.Models;
using TestoBus.Repozitoriji;

namespace TestoBus
{
    public partial class FrmUpdate : Form
    {
        public event EventHandler RequestUpdated;
        private VozniRed vozni;
        public FrmUpdate(VozniRed oznaceni)
        {
            InitializeComponent();
            vozni = oznaceni;
            vozni.Id = oznaceni.Id;
            vozni.Naziv = oznaceni.Naziv;
            vozni.Polazisna = oznaceni.Polazisna;
            vozni.Odredisna = oznaceni.Odredisna;
            vozni.Vrijeme = oznaceni.Vrijeme;
            vozni.Autobus = oznaceni.Autobus;

            UcitajRegistracijskeOznake(); // Učitavanje registracijskih oznaka
            UcitajZaposlenika();
            PrikazVoznogReda();
        }
        public void UcitajZaposlenika()
        {
            txtKorime.Text = RepozitorijRadnik.ImePrezime();
            txtDatum.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void UcitajRegistracijskeOznake()
        {
            List<string> registracijskeOznake = RepozitorijZahtjeva.GetRegistracijskeOznake();
            cmb_Az_Autobus.DataSource = registracijskeOznake;
        }

        private void PrikazVoznogReda()
        {
            txt_Az_Sifra.Text = Convert.ToString(vozni.Id);
            txt_Az_NazivLinije.Text = Convert.ToString(vozni.Naziv);
            txt_Az_Polazisna.Text = Convert.ToString(vozni.Polazisna);
            txt_Az_Odredisna.Text = Convert.ToString(vozni.Odredisna);
            txt_Az_Vrijeme.Text = Convert.ToString(vozni.Vrijeme);
            cmb_Az_Autobus.Text = Convert.ToString(vozni.Autobus);
        }

        private void btn_Az_Unos_Click(object sender, EventArgs e)
        {
            int sifra = Convert.ToInt32(txt_Az_Sifra.Text);
            string naziv = txt_Az_NazivLinije.Text;
            string polazisna = txt_Az_Polazisna.Text;
            string odredisna = txt_Az_Odredisna.Text;
            int vrijeme = Convert.ToInt32(txt_Az_Vrijeme.Text);
            string registracija = cmb_Az_Autobus.Text;

            RepozitorijZahtjeva.AzurirajVozniRed(sifra, naziv, polazisna, odredisna, vrijeme, registracija);
            RequestUpdated?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}
