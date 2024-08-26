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
    public partial class FrmLogin : Form
    {
        public static Zaposlenik LoggedWorker { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoggedWorker = RepozitorijRadnik.DohvatiRadnika(txtUsername.Text);
                if (LoggedWorker != null && LoggedWorker.Password == txtPassword.Text)
                {
                    FrmMain pregledZahtjeva = new FrmMain();
                    Hide();
                    MessageBox.Show("Uspješno logiranje!", "Dobrodošli", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pregledZahtjeva.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
