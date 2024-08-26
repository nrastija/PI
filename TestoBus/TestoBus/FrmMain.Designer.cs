namespace TestoBus
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblNaslovApk = new System.Windows.Forms.Label();
            this.txtKorime = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.lblVozniRedovi = new System.Windows.Forms.Label();
            this.btn_NoviVozniRed = new System.Windows.Forms.Button();
            this.btn_AzurirajVozniRed = new System.Windows.Forms.Button();
            this.vozniRedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI2324_nrastija22_DBDataSet = new TestoBus.PI2324_nrastija22_DBDataSet();
            this.vozniRedTableAdapter = new TestoBus.PI2324_nrastija22_DBDataSetTableAdapters.VozniRedTableAdapter();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.txtPretrazivanje = new System.Windows.Forms.RichTextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.vozniRedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVozniRedovi = new System.Windows.Forms.DataGridView();
            this.idvoznogredaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivlinijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polazisnastanicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odredisnastanicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemetrajanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozniRedBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnPonistiFilter = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vozniRedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_nrastija22_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozniRedBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozniRedovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozniRedBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslovApk
            // 
            this.lblNaslovApk.AutoSize = true;
            this.lblNaslovApk.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslovApk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNaslovApk.Location = new System.Drawing.Point(51, 28);
            this.lblNaslovApk.Name = "lblNaslovApk";
            this.lblNaslovApk.Size = new System.Drawing.Size(299, 70);
            this.lblNaslovApk.TabIndex = 0;
            this.lblNaslovApk.Text = "TestoBus";
            // 
            // txtKorime
            // 
            this.txtKorime.BackColor = System.Drawing.Color.GhostWhite;
            this.txtKorime.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtKorime.Location = new System.Drawing.Point(1371, 28);
            this.txtKorime.Name = "txtKorime";
            this.txtKorime.ReadOnly = true;
            this.txtKorime.Size = new System.Drawing.Size(245, 26);
            this.txtKorime.TabIndex = 1;
            this.txtKorime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKorime.TextChanged += new System.EventHandler(this.txtKorime_TextChanged);
            // 
            // txtDatum
            // 
            this.txtDatum.BackColor = System.Drawing.Color.GhostWhite;
            this.txtDatum.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatum.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtDatum.Location = new System.Drawing.Point(1371, 65);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(245, 26);
            this.txtDatum.TabIndex = 2;
            this.txtDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDatum.TextChanged += new System.EventHandler(this.txtDatum_TextChanged);
            // 
            // lblVozniRedovi
            // 
            this.lblVozniRedovi.AutoSize = true;
            this.lblVozniRedovi.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVozniRedovi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblVozniRedovi.Location = new System.Drawing.Point(56, 247);
            this.lblVozniRedovi.Name = "lblVozniRedovi";
            this.lblVozniRedovi.Size = new System.Drawing.Size(226, 43);
            this.lblVozniRedovi.TabIndex = 4;
            this.lblVozniRedovi.Text = "Vozni redovi";
            // 
            // btn_NoviVozniRed
            // 
            this.btn_NoviVozniRed.BackColor = System.Drawing.Color.OldLace;
            this.btn_NoviVozniRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NoviVozniRed.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NoviVozniRed.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_NoviVozniRed.Location = new System.Drawing.Point(1458, 378);
            this.btn_NoviVozniRed.Name = "btn_NoviVozniRed";
            this.btn_NoviVozniRed.Size = new System.Drawing.Size(158, 82);
            this.btn_NoviVozniRed.TabIndex = 5;
            this.btn_NoviVozniRed.Text = "Unesi novi vozni red";
            this.btn_NoviVozniRed.UseVisualStyleBackColor = false;
            this.btn_NoviVozniRed.Click += new System.EventHandler(this.btn_NoviVozniRed_Click);
            // 
            // btn_AzurirajVozniRed
            // 
            this.btn_AzurirajVozniRed.BackColor = System.Drawing.Color.OldLace;
            this.btn_AzurirajVozniRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AzurirajVozniRed.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AzurirajVozniRed.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_AzurirajVozniRed.Location = new System.Drawing.Point(1458, 544);
            this.btn_AzurirajVozniRed.Name = "btn_AzurirajVozniRed";
            this.btn_AzurirajVozniRed.Size = new System.Drawing.Size(158, 82);
            this.btn_AzurirajVozniRed.TabIndex = 6;
            this.btn_AzurirajVozniRed.Text = "Ažuriraj označeni vozni red";
            this.btn_AzurirajVozniRed.UseVisualStyleBackColor = false;
            this.btn_AzurirajVozniRed.Click += new System.EventHandler(this.btn_AzurirajVozniRed_Click);
            // 
            // vozniRedBindingSource
            // 
            this.vozniRedBindingSource.DataMember = "VozniRed";
            this.vozniRedBindingSource.DataSource = this.pI2324_nrastija22_DBDataSet;
            // 
            // pI2324_nrastija22_DBDataSet
            // 
            this.pI2324_nrastija22_DBDataSet.DataSetName = "PI2324_nrastija22_DBDataSet";
            this.pI2324_nrastija22_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vozniRedTableAdapter
            // 
            this.vozniRedTableAdapter.ClearBeforeFill = true;
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretrazivanje.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPretrazivanje.Location = new System.Drawing.Point(443, 215);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(200, 33);
            this.lblPretrazivanje.TabIndex = 8;
            this.lblPretrazivanje.Text = "Pretraživanje:";
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.BackColor = System.Drawing.Color.GhostWhite;
            this.txtPretrazivanje.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretrazivanje.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPretrazivanje.Location = new System.Drawing.Point(658, 205);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(249, 54);
            this.txtPretrazivanje.TabIndex = 9;
            this.txtPretrazivanje.Text = "";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.OldLace;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPretrazi.Location = new System.Drawing.Point(953, 232);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(149, 55);
            this.btnPretrazi.TabIndex = 10;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // vozniRedBindingSource1
            // 
            this.vozniRedBindingSource1.DataMember = "VozniRed";
            this.vozniRedBindingSource1.DataSource = this.pI2324_nrastija22_DBDataSet;
            // 
            // dgvVozniRedovi
            // 
            this.dgvVozniRedovi.AllowUserToAddRows = false;
            this.dgvVozniRedovi.AllowUserToDeleteRows = false;
            this.dgvVozniRedovi.AllowUserToResizeColumns = false;
            this.dgvVozniRedovi.AllowUserToResizeRows = false;
            this.dgvVozniRedovi.AutoGenerateColumns = false;
            this.dgvVozniRedovi.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvVozniRedovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozniRedovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvoznogredaDataGridViewTextBoxColumn,
            this.nazivlinijeDataGridViewTextBoxColumn,
            this.polazisnastanicaDataGridViewTextBoxColumn,
            this.odredisnastanicaDataGridViewTextBoxColumn,
            this.vrijemetrajanjaDataGridViewTextBoxColumn});
            this.dgvVozniRedovi.DataSource = this.vozniRedBindingSource;
            this.dgvVozniRedovi.GridColor = System.Drawing.Color.OldLace;
            this.dgvVozniRedovi.Location = new System.Drawing.Point(63, 305);
            this.dgvVozniRedovi.Name = "dgvVozniRedovi";
            this.dgvVozniRedovi.RowHeadersWidth = 62;
            this.dgvVozniRedovi.RowTemplate.Height = 28;
            this.dgvVozniRedovi.Size = new System.Drawing.Size(1367, 507);
            this.dgvVozniRedovi.TabIndex = 11;
            this.dgvVozniRedovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVozniRedovi_CellContentClick);
            // 
            // idvoznogredaDataGridViewTextBoxColumn
            // 
            this.idvoznogredaDataGridViewTextBoxColumn.DataPropertyName = "id_voznog_reda";
            this.idvoznogredaDataGridViewTextBoxColumn.HeaderText = "id_voznog_reda";
            this.idvoznogredaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idvoznogredaDataGridViewTextBoxColumn.Name = "idvoznogredaDataGridViewTextBoxColumn";
            this.idvoznogredaDataGridViewTextBoxColumn.Width = 150;
            // 
            // nazivlinijeDataGridViewTextBoxColumn
            // 
            this.nazivlinijeDataGridViewTextBoxColumn.DataPropertyName = "naziv_linije";
            this.nazivlinijeDataGridViewTextBoxColumn.HeaderText = "naziv_linije";
            this.nazivlinijeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nazivlinijeDataGridViewTextBoxColumn.Name = "nazivlinijeDataGridViewTextBoxColumn";
            this.nazivlinijeDataGridViewTextBoxColumn.Width = 150;
            // 
            // polazisnastanicaDataGridViewTextBoxColumn
            // 
            this.polazisnastanicaDataGridViewTextBoxColumn.DataPropertyName = "polazisna_stanica";
            this.polazisnastanicaDataGridViewTextBoxColumn.HeaderText = "polazisna_stanica";
            this.polazisnastanicaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.polazisnastanicaDataGridViewTextBoxColumn.Name = "polazisnastanicaDataGridViewTextBoxColumn";
            this.polazisnastanicaDataGridViewTextBoxColumn.Width = 150;
            // 
            // odredisnastanicaDataGridViewTextBoxColumn
            // 
            this.odredisnastanicaDataGridViewTextBoxColumn.DataPropertyName = "odredisna_stanica";
            this.odredisnastanicaDataGridViewTextBoxColumn.HeaderText = "odredisna_stanica";
            this.odredisnastanicaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.odredisnastanicaDataGridViewTextBoxColumn.Name = "odredisnastanicaDataGridViewTextBoxColumn";
            this.odredisnastanicaDataGridViewTextBoxColumn.Width = 150;
            // 
            // vrijemetrajanjaDataGridViewTextBoxColumn
            // 
            this.vrijemetrajanjaDataGridViewTextBoxColumn.DataPropertyName = "vrijeme_trajanja";
            this.vrijemetrajanjaDataGridViewTextBoxColumn.HeaderText = "vrijeme_trajanja";
            this.vrijemetrajanjaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vrijemetrajanjaDataGridViewTextBoxColumn.Name = "vrijemetrajanjaDataGridViewTextBoxColumn";
            this.vrijemetrajanjaDataGridViewTextBoxColumn.Width = 150;
            // 
            // vozniRedBindingSource2
            // 
            this.vozniRedBindingSource2.DataMember = "VozniRed";
            this.vozniRedBindingSource2.DataSource = this.pI2324_nrastija22_DBDataSet;
            // 
            // btnPonistiFilter
            // 
            this.btnPonistiFilter.BackColor = System.Drawing.Color.OldLace;
            this.btnPonistiFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonistiFilter.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonistiFilter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPonistiFilter.Location = new System.Drawing.Point(953, 180);
            this.btnPonistiFilter.Name = "btnPonistiFilter";
            this.btnPonistiFilter.Size = new System.Drawing.Size(149, 46);
            this.btnPonistiFilter.TabIndex = 12;
            this.btnPonistiFilter.Text = "Poništi";
            this.btnPonistiFilter.UseVisualStyleBackColor = false;
            this.btnPonistiFilter.Click += new System.EventHandler(this.btnPonistiFilter_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.BackColor = System.Drawing.Color.OldLace;
            this.btnBrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisi.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBrisi.Location = new System.Drawing.Point(1458, 709);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(158, 82);
            this.btnBrisi.TabIndex = 13;
            this.btnBrisi.Text = "Obriši označeni vozni red";
            this.btnBrisi.UseVisualStyleBackColor = false;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(-29, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2494, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "─────────────────────────────────────────────────────────────────────────────────" +
    "───────────────────────────────────────────";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(498, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Napomena: pretraživanje po šifri ili vremenu trajanja.";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.AliceBlue;
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.picLogo.Image = global::TestoBus.Properties.Resources.TestoBus_Logo_Okrugli;
            this.picLogo.InitialImage = global::TestoBus.Properties.Resources.TestoBus_Logo_Okrugli;
            this.picLogo.Location = new System.Drawing.Point(1458, 140);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(158, 150);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 16;
            this.picLogo.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1659, 858);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnPonistiFilter);
            this.Controls.Add(this.dgvVozniRedovi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.btn_AzurirajVozniRed);
            this.Controls.Add(this.btn_NoviVozniRed);
            this.Controls.Add(this.lblVozniRedovi);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtKorime);
            this.Controls.Add(this.lblNaslovApk);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "TestoBus HR";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vozniRedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_nrastija22_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozniRedBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozniRedovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozniRedBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslovApk;
        private System.Windows.Forms.TextBox txtKorime;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label lblVozniRedovi;
        private System.Windows.Forms.Button btn_NoviVozniRed;
        private System.Windows.Forms.Button btn_AzurirajVozniRed;
        private PI2324_nrastija22_DBDataSet pI2324_nrastija22_DBDataSet;
        private System.Windows.Forms.BindingSource vozniRedBindingSource;
        private PI2324_nrastija22_DBDataSetTableAdapters.VozniRedTableAdapter vozniRedTableAdapter;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.RichTextBox txtPretrazivanje;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.BindingSource vozniRedBindingSource1;
        private System.Windows.Forms.DataGridView dgvVozniRedovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvoznogredaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivlinijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polazisnastanicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odredisnastanicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemetrajanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vozniRedBindingSource2;
        private System.Windows.Forms.Button btnPonistiFilter;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picLogo;
    }
}