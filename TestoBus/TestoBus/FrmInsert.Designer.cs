namespace TestoBus
{
    partial class FrmInsert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInsert));
            this.btnUnos = new System.Windows.Forms.Button();
            this.lblVrijemeTrajanja = new System.Windows.Forms.Label();
            this.lblOdredisna = new System.Windows.Forms.Label();
            this.lblPolazišna = new System.Windows.Forms.Label();
            this.lblNazivLinije = new System.Windows.Forms.Label();
            this.lblSifra = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtKorime = new System.Windows.Forms.TextBox();
            this.lblNaslovApk = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNazivLinije = new System.Windows.Forms.RichTextBox();
            this.txtPolazisna = new System.Windows.Forms.TextBox();
            this.txtOdredisna = new System.Windows.Forms.TextBox();
            this.txtVrijeme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAutobus = new System.Windows.Forms.Label();
            this.cmbAutobus = new System.Windows.Forms.ComboBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.BackColor = System.Drawing.Color.OldLace;
            this.btnUnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnos.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUnos.Location = new System.Drawing.Point(355, 636);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(253, 70);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unesi vozni red";
            this.btnUnos.UseVisualStyleBackColor = false;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // lblVrijemeTrajanja
            // 
            this.lblVrijemeTrajanja.AutoSize = true;
            this.lblVrijemeTrajanja.BackColor = System.Drawing.Color.Transparent;
            this.lblVrijemeTrajanja.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrijemeTrajanja.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblVrijemeTrajanja.Location = new System.Drawing.Point(127, 474);
            this.lblVrijemeTrajanja.Name = "lblVrijemeTrajanja";
            this.lblVrijemeTrajanja.Size = new System.Drawing.Size(131, 19);
            this.lblVrijemeTrajanja.TabIndex = 1;
            this.lblVrijemeTrajanja.Text = "Vrijeme trajanja:";
            // 
            // lblOdredisna
            // 
            this.lblOdredisna.AutoSize = true;
            this.lblOdredisna.BackColor = System.Drawing.Color.Transparent;
            this.lblOdredisna.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdredisna.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblOdredisna.Location = new System.Drawing.Point(127, 415);
            this.lblOdredisna.Name = "lblOdredisna";
            this.lblOdredisna.Size = new System.Drawing.Size(153, 19);
            this.lblOdredisna.TabIndex = 2;
            this.lblOdredisna.Text = "Odredišna stanica:";
            // 
            // lblPolazišna
            // 
            this.lblPolazišna.AutoSize = true;
            this.lblPolazišna.BackColor = System.Drawing.Color.Transparent;
            this.lblPolazišna.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolazišna.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPolazišna.Location = new System.Drawing.Point(127, 355);
            this.lblPolazišna.Name = "lblPolazišna";
            this.lblPolazišna.Size = new System.Drawing.Size(149, 19);
            this.lblPolazišna.TabIndex = 3;
            this.lblPolazišna.Text = "Polazišna stanica:";
            // 
            // lblNazivLinije
            // 
            this.lblNazivLinije.AutoSize = true;
            this.lblNazivLinije.BackColor = System.Drawing.Color.Transparent;
            this.lblNazivLinije.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivLinije.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNazivLinije.Location = new System.Drawing.Point(153, 257);
            this.lblNazivLinije.Name = "lblNazivLinije";
            this.lblNazivLinije.Size = new System.Drawing.Size(97, 19);
            this.lblNazivLinije.TabIndex = 4;
            this.lblNazivLinije.Text = "Naziv linije:";
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.BackColor = System.Drawing.Color.Transparent;
            this.lblSifra.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifra.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSifra.Location = new System.Drawing.Point(131, 183);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(150, 19);
            this.lblSifra.TabIndex = 5;
            this.lblSifra.Text = "Šifra voznog reda:";
            // 
            // txtDatum
            // 
            this.txtDatum.BackColor = System.Drawing.Color.GhostWhite;
            this.txtDatum.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatum.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtDatum.Location = new System.Drawing.Point(675, 79);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(245, 26);
            this.txtDatum.TabIndex = 8;
            this.txtDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKorime
            // 
            this.txtKorime.BackColor = System.Drawing.Color.GhostWhite;
            this.txtKorime.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtKorime.Location = new System.Drawing.Point(675, 33);
            this.txtKorime.Name = "txtKorime";
            this.txtKorime.Size = new System.Drawing.Size(245, 26);
            this.txtKorime.TabIndex = 7;
            this.txtKorime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNaslovApk
            // 
            this.lblNaslovApk.AutoSize = true;
            this.lblNaslovApk.BackColor = System.Drawing.Color.AliceBlue;
            this.lblNaslovApk.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslovApk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNaslovApk.Location = new System.Drawing.Point(36, 33);
            this.lblNaslovApk.Name = "lblNaslovApk";
            this.lblNaslovApk.Size = new System.Drawing.Size(299, 70);
            this.lblNaslovApk.TabIndex = 6;
            this.lblNaslovApk.Text = "TestoBus";
            // 
            // txtSifra
            // 
            this.txtSifra.BackColor = System.Drawing.Color.GhostWhite;
            this.txtSifra.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifra.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtSifra.Location = new System.Drawing.Point(302, 176);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(433, 26);
            this.txtSifra.TabIndex = 9;
            // 
            // txtNazivLinije
            // 
            this.txtNazivLinije.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNazivLinije.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivLinije.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtNazivLinije.Location = new System.Drawing.Point(302, 217);
            this.txtNazivLinije.Name = "txtNazivLinije";
            this.txtNazivLinije.Size = new System.Drawing.Size(433, 94);
            this.txtNazivLinije.TabIndex = 10;
            this.txtNazivLinije.Text = "";
            // 
            // txtPolazisna
            // 
            this.txtPolazisna.BackColor = System.Drawing.Color.GhostWhite;
            this.txtPolazisna.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPolazisna.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPolazisna.Location = new System.Drawing.Point(302, 351);
            this.txtPolazisna.Name = "txtPolazisna";
            this.txtPolazisna.Size = new System.Drawing.Size(433, 26);
            this.txtPolazisna.TabIndex = 11;
            // 
            // txtOdredisna
            // 
            this.txtOdredisna.BackColor = System.Drawing.Color.GhostWhite;
            this.txtOdredisna.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOdredisna.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtOdredisna.Location = new System.Drawing.Point(302, 408);
            this.txtOdredisna.Name = "txtOdredisna";
            this.txtOdredisna.Size = new System.Drawing.Size(433, 26);
            this.txtOdredisna.TabIndex = 12;
            // 
            // txtVrijeme
            // 
            this.txtVrijeme.BackColor = System.Drawing.Color.GhostWhite;
            this.txtVrijeme.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVrijeme.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtVrijeme.Location = new System.Drawing.Point(302, 467);
            this.txtVrijeme.Name = "txtVrijeme";
            this.txtVrijeme.Size = new System.Drawing.Size(433, 26);
            this.txtVrijeme.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(-4, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1014, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "──────────────────────────────────────────────────";
            // 
            // lblAutobus
            // 
            this.lblAutobus.AutoSize = true;
            this.lblAutobus.BackColor = System.Drawing.Color.Transparent;
            this.lblAutobus.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutobus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAutobus.Location = new System.Drawing.Point(131, 544);
            this.lblAutobus.Name = "lblAutobus";
            this.lblAutobus.Size = new System.Drawing.Size(259, 19);
            this.lblAutobus.TabIndex = 16;
            this.lblAutobus.Text = "Registracijska oznaka autobusa:";
            // 
            // cmbAutobus
            // 
            this.cmbAutobus.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbAutobus.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAutobus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbAutobus.FormattingEnabled = true;
            this.cmbAutobus.Location = new System.Drawing.Point(456, 541);
            this.cmbAutobus.Name = "cmbAutobus";
            this.cmbAutobus.Size = new System.Drawing.Size(279, 27);
            this.cmbAutobus.TabIndex = 17;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.AliceBlue;
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.picLogo.Image = global::TestoBus.Properties.Resources.TestoBus_Logo_Okrugli;
            this.picLogo.InitialImage = global::TestoBus.Properties.Resources.TestoBus_Logo_Okrugli;
            this.picLogo.Location = new System.Drawing.Point(795, 298);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(158, 150);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 18;
            this.picLogo.TabStop = false;
            // 
            // FrmInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(992, 732);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.cmbAutobus);
            this.Controls.Add(this.lblAutobus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVrijeme);
            this.Controls.Add(this.txtOdredisna);
            this.Controls.Add(this.txtPolazisna);
            this.Controls.Add(this.txtNazivLinije);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtKorime);
            this.Controls.Add(this.lblNaslovApk);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.lblNazivLinije);
            this.Controls.Add(this.lblPolazišna);
            this.Controls.Add(this.lblOdredisna);
            this.Controls.Add(this.lblVrijemeTrajanja);
            this.Controls.Add(this.btnUnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestoBus Azuriranje";
            this.Load += new System.EventHandler(this.FrmInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Label lblVrijemeTrajanja;
        private System.Windows.Forms.Label lblOdredisna;
        private System.Windows.Forms.Label lblPolazišna;
        private System.Windows.Forms.Label lblNazivLinije;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtKorime;
        private System.Windows.Forms.Label lblNaslovApk;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.RichTextBox txtNazivLinije;
        private System.Windows.Forms.TextBox txtPolazisna;
        private System.Windows.Forms.TextBox txtOdredisna;
        private System.Windows.Forms.TextBox txtVrijeme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAutobus;
        private System.Windows.Forms.ComboBox cmbAutobus;
        private System.Windows.Forms.PictureBox picLogo;
    }
}