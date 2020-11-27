namespace PizzaKulesiEF
{
    partial class Form1
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
            if (disposing)
            {
                db.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cboPizzaCesidi = new System.Windows.Forms.ComboBox();
            this.txtMusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPizzaCesitEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.clbEkstraMalzemeler = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTeslimatAdresi = new System.Windows.Forms.TextBox();
            this.chkTeslimEdildi = new System.Windows.Forms.CheckBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.chkTeslimEdilenleriGizle = new System.Windows.Forms.CheckBox();
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEkstraMalzemeEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cboPizzaCesidi
            // 
            this.cboPizzaCesidi.DisplayMember = "PizzaAd";
            this.cboPizzaCesidi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPizzaCesidi.FormattingEnabled = true;
            resources.ApplyResources(this.cboPizzaCesidi, "cboPizzaCesidi");
            this.cboPizzaCesidi.Name = "cboPizzaCesidi";
            this.cboPizzaCesidi.ValueMember = "Id";
            // 
            // txtMusteriAdSoyad
            // 
            resources.ApplyResources(this.txtMusteriAdSoyad, "txtMusteriAdSoyad");
            this.txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnPizzaCesitEkle
            // 
            resources.ApplyResources(this.btnPizzaCesitEkle, "btnPizzaCesitEkle");
            this.btnPizzaCesitEkle.Name = "btnPizzaCesitEkle";
            this.btnPizzaCesitEkle.UseVisualStyleBackColor = true;
            this.btnPizzaCesitEkle.Click += new System.EventHandler(this.btnPizzaCesitEkle_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // clbEkstraMalzemeler
            // 
            this.clbEkstraMalzemeler.CheckOnClick = true;
            this.clbEkstraMalzemeler.FormattingEnabled = true;
            resources.ApplyResources(this.clbEkstraMalzemeler, "clbEkstraMalzemeler");
            this.clbEkstraMalzemeler.Name = "clbEkstraMalzemeler";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtTeslimatAdresi
            // 
            resources.ApplyResources(this.txtTeslimatAdresi, "txtTeslimatAdresi");
            this.txtTeslimatAdresi.Name = "txtTeslimatAdresi";
            // 
            // chkTeslimEdildi
            // 
            resources.ApplyResources(this.chkTeslimEdildi, "chkTeslimEdildi");
            this.chkTeslimEdildi.Name = "chkTeslimEdildi";
            this.chkTeslimEdildi.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.WindowFrame;
            resources.ApplyResources(this.btnEkle, "btnEkle");
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // chkTeslimEdilenleriGizle
            // 
            resources.ApplyResources(this.chkTeslimEdilenleriGizle, "chkTeslimEdilenleriGizle");
            this.chkTeslimEdilenleriGizle.Name = "chkTeslimEdilenleriGizle";
            this.chkTeslimEdilenleriGizle.UseVisualStyleBackColor = true;
            this.chkTeslimEdilenleriGizle.CheckedChanged += new System.EventHandler(this.chkTeslimEdilenleriGizle_CheckedChanged);
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.AllowUserToAddRows = false;
            this.dgvSiparisler.AllowUserToDeleteRows = false;
            this.dgvSiparisler.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgvSiparisler, "dgvSiparisler");
            this.dgvSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSiparisler.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvSiparisler.MultiSelect = false;
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.ReadOnly = true;
            this.dgvSiparisler.RowHeadersVisible = false;
            this.dgvSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MusteriAdSoyad";
            this.Column1.FillWeight = 70F;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PizzaCesit";
            this.Column2.FillWeight = 70F;
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "VirgulluMalzemeler";
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Adres";
            this.Column4.FillWeight = 200F;
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TeslimEdildiMi";
            this.Column5.FillWeight = 70F;
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnEkstraMalzemeEkle
            // 
            resources.ApplyResources(this.btnEkstraMalzemeEkle, "btnEkstraMalzemeEkle");
            this.btnEkstraMalzemeEkle.Name = "btnEkstraMalzemeEkle";
            this.btnEkstraMalzemeEkle.UseVisualStyleBackColor = true;
            this.btnEkstraMalzemeEkle.Click += new System.EventHandler(this.btnEkstraMalzemeEkle_Click);
            // 
            // btnSil
            // 
            resources.ApplyResources(this.btnSil, "btnSil");
            this.btnSil.BackColor = System.Drawing.Color.Maroon;
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.Name = "btnSil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            resources.ApplyResources(this.btnDuzenle, "btnDuzenle");
            this.btnDuzenle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDuzenle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnIptal
            // 
            resources.ApplyResources(this.btnIptal, "btnIptal");
            this.btnIptal.BackColor = System.Drawing.Color.Purple;
            this.btnIptal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            resources.ApplyResources(this.btnKaydet, "btnKaydet");
            this.btnKaydet.BackColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkstraMalzemeEkle);
            this.Controls.Add(this.dgvSiparisler);
            this.Controls.Add(this.chkTeslimEdilenleriGizle);
            this.Controls.Add(this.chkTeslimEdildi);
            this.Controls.Add(this.txtTeslimatAdresi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clbEkstraMalzemeler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPizzaCesitEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMusteriAdSoyad);
            this.Controls.Add(this.cboPizzaCesidi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPizzaCesidi;
        private System.Windows.Forms.TextBox txtMusteriAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPizzaCesitEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbEkstraMalzemeler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTeslimatAdresi;
        private System.Windows.Forms.CheckBox chkTeslimEdildi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox chkTeslimEdilenleriGizle;
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.Button btnEkstraMalzemeEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
    }
}

