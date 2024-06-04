namespace TVPDrugiProjekat
{
    partial class MainForm
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
            this.dgwSvaVozila = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwSveRezervacije = new System.Windows.Forms.DataGridView();
            this.btnFiltrirajPoKategoriji = new System.Windows.Forms.Button();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentACarDBDataSet = new TVPDrugiProjekat.RentACarDBDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDodajKlijenta = new System.Windows.Forms.Button();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.btnDodajRezervaciju = new System.Windows.Forms.Button();
            this.txtCenaDo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.txtCenaOd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFiltrirajPoDatumu = new System.Windows.Forms.Button();
            this.btnFiltrirajPoSatu = new System.Windows.Forms.Button();
            this.kategorijaTableAdapter = new TVPDrugiProjekat.RentACarDBDataSetTableAdapters.KategorijaTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDoRezervacije = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpOdRezervacije = new System.Windows.Forms.DateTimePicker();
            this.btnFiltritajRezervacije = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.kategorijaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kategorijaVoziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voziloTableAdapter = new TVPDrugiProjekat.RentACarDBDataSetTableAdapters.VoziloTableAdapter();
            this.kategorijaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kategorijaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.btnGrafik = new System.Windows.Forms.Button();
            this.lblPrikaz = new System.Windows.Forms.Label();
            this.lblNajposeceniji = new System.Windows.Forms.Label();
            this.btnSveRezervacije = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSvaVozila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSveRezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaVoziloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwSvaVozila
            // 
            this.dgwSvaVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSvaVozila.Location = new System.Drawing.Point(651, 66);
            this.dgwSvaVozila.Name = "dgwSvaVozila";
            this.dgwSvaVozila.Size = new System.Drawing.Size(544, 223);
            this.dgwSvaVozila.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(842, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sva vozila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(807, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sve rezervacije";
            // 
            // dgwSveRezervacije
            // 
            this.dgwSveRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSveRezervacije.Location = new System.Drawing.Point(651, 382);
            this.dgwSveRezervacije.Name = "dgwSveRezervacije";
            this.dgwSveRezervacije.Size = new System.Drawing.Size(544, 276);
            this.dgwSveRezervacije.TabIndex = 4;
            this.dgwSveRezervacije.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgwSveRezervacije_MouseDoubleClick);
            // 
            // btnFiltrirajPoKategoriji
            // 
            this.btnFiltrirajPoKategoriji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrirajPoKategoriji.Location = new System.Drawing.Point(505, 285);
            this.btnFiltrirajPoKategoriji.Name = "btnFiltrirajPoKategoriji";
            this.btnFiltrirajPoKategoriji.Size = new System.Drawing.Size(100, 24);
            this.btnFiltrirajPoKategoriji.TabIndex = 5;
            this.btnFiltrirajPoKategoriji.Text = "Filtriraj";
            this.btnFiltrirajPoKategoriji.UseVisualStyleBackColor = true;
            this.btnFiltrirajPoKategoriji.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // cbKategorija
            // 
            this.cbKategorija.DataSource = this.kategorijaBindingSource;
            this.cbKategorija.DisplayMember = "naziv";
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(495, 260);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(121, 21);
            this.cbKategorija.TabIndex = 6;
            this.cbKategorija.ValueMember = "id_kategorije";
            // 
            // kategorijaBindingSource
            // 
            this.kategorijaBindingSource.DataMember = "Kategorija";
            this.kategorijaBindingSource.DataSource = this.rentACarDBDataSet;
            // 
            // rentACarDBDataSet
            // 
            this.rentACarDBDataSet.DataSetName = "RentACarDBDataSet";
            this.rentACarDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategorija";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnDodajKlijenta);
            this.panel1.Controls.Add(this.btnDodajKategoriju);
            this.panel1.Controls.Add(this.btnDodajVozilo);
            this.panel1.Controls.Add(this.btnDodajRezervaciju);
            this.panel1.Location = new System.Drawing.Point(-1, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 422);
            this.panel1.TabIndex = 9;
            // 
            // btnDodajKlijenta
            // 
            this.btnDodajKlijenta.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDodajKlijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKlijenta.Location = new System.Drawing.Point(47, 259);
            this.btnDodajKlijenta.Name = "btnDodajKlijenta";
            this.btnDodajKlijenta.Size = new System.Drawing.Size(357, 49);
            this.btnDodajKlijenta.TabIndex = 3;
            this.btnDodajKlijenta.Text = "Dodaj klijenta";
            this.btnDodajKlijenta.UseVisualStyleBackColor = false;
            this.btnDodajKlijenta.Click += new System.EventHandler(this.btnDodajKlijenta_Click);
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDodajKategoriju.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKategoriju.Location = new System.Drawing.Point(49, 187);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(357, 49);
            this.btnDodajKategoriju.TabIndex = 2;
            this.btnDodajKategoriju.Text = "Dodaj kategoriju";
            this.btnDodajKategoriju.UseVisualStyleBackColor = false;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDodajVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajVozilo.Location = new System.Drawing.Point(47, 112);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(357, 49);
            this.btnDodajVozilo.TabIndex = 1;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = false;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // btnDodajRezervaciju
            // 
            this.btnDodajRezervaciju.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDodajRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRezervaciju.Location = new System.Drawing.Point(47, 35);
            this.btnDodajRezervaciju.Name = "btnDodajRezervaciju";
            this.btnDodajRezervaciju.Size = new System.Drawing.Size(357, 49);
            this.btnDodajRezervaciju.TabIndex = 0;
            this.btnDodajRezervaciju.Text = "Dodaj rezervaciju";
            this.btnDodajRezervaciju.UseVisualStyleBackColor = false;
            this.btnDodajRezervaciju.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCenaDo
            // 
            this.txtCenaDo.Location = new System.Drawing.Point(582, 177);
            this.txtCenaDo.Name = "txtCenaDo";
            this.txtCenaDo.Size = new System.Drawing.Size(55, 20);
            this.txtCenaDo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cena po satu";
            // 
            // dtpOd
            // 
            this.dtpOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOd.Location = new System.Drawing.Point(518, 69);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(87, 20);
            this.dtpOd.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Da nije iznajmljen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(480, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Od";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(480, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Do";
            // 
            // dtpDo
            // 
            this.dtpDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDo.Location = new System.Drawing.Point(518, 95);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(87, 20);
            this.dtpDo.TabIndex = 15;
            // 
            // txtCenaOd
            // 
            this.txtCenaOd.Location = new System.Drawing.Point(487, 177);
            this.txtCenaOd.Name = "txtCenaOd";
            this.txtCenaOd.Size = new System.Drawing.Size(55, 20);
            this.txtCenaOd.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(458, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Od";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(548, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Do";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TVPDrugiProjekat.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnFiltrirajPoDatumu
            // 
            this.btnFiltrirajPoDatumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrirajPoDatumu.Location = new System.Drawing.Point(505, 121);
            this.btnFiltrirajPoDatumu.Name = "btnFiltrirajPoDatumu";
            this.btnFiltrirajPoDatumu.Size = new System.Drawing.Size(100, 26);
            this.btnFiltrirajPoDatumu.TabIndex = 20;
            this.btnFiltrirajPoDatumu.Text = "Filtriraj";
            this.btnFiltrirajPoDatumu.UseVisualStyleBackColor = true;
            this.btnFiltrirajPoDatumu.Click += new System.EventHandler(this.btnFiltrirajPoDatumu_Click);
            // 
            // btnFiltrirajPoSatu
            // 
            this.btnFiltrirajPoSatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrirajPoSatu.Location = new System.Drawing.Point(505, 203);
            this.btnFiltrirajPoSatu.Name = "btnFiltrirajPoSatu";
            this.btnFiltrirajPoSatu.Size = new System.Drawing.Size(100, 26);
            this.btnFiltrirajPoSatu.TabIndex = 21;
            this.btnFiltrirajPoSatu.Text = "Filtriraj";
            this.btnFiltrirajPoSatu.UseVisualStyleBackColor = true;
            this.btnFiltrirajPoSatu.Click += new System.EventHandler(this.btnFiltrirajPoSatu_Click);
            // 
            // kategorijaTableAdapter
            // 
            this.kategorijaTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(471, 442);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Do";
            // 
            // dtpDoRezervacije
            // 
            this.dtpDoRezervacije.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDoRezervacije.Location = new System.Drawing.Point(509, 442);
            this.dtpDoRezervacije.Name = "dtpDoRezervacije";
            this.dtpDoRezervacije.Size = new System.Drawing.Size(87, 20);
            this.dtpDoRezervacije.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(471, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Od";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(480, 385);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 24);
            this.label12.TabIndex = 23;
            this.label12.Text = "Rezarvacije";
            // 
            // dtpOdRezervacije
            // 
            this.dtpOdRezervacije.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOdRezervacije.Location = new System.Drawing.Point(509, 416);
            this.dtpOdRezervacije.Name = "dtpOdRezervacije";
            this.dtpOdRezervacije.Size = new System.Drawing.Size(87, 20);
            this.dtpOdRezervacije.TabIndex = 22;
            // 
            // btnFiltritajRezervacije
            // 
            this.btnFiltritajRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltritajRezervacije.Location = new System.Drawing.Point(487, 468);
            this.btnFiltritajRezervacije.Name = "btnFiltritajRezervacije";
            this.btnFiltritajRezervacije.Size = new System.Drawing.Size(100, 24);
            this.btnFiltritajRezervacije.TabIndex = 27;
            this.btnFiltritajRezervacije.Text = "Filtriraj";
            this.btnFiltritajRezervacije.UseVisualStyleBackColor = true;
            this.btnFiltritajRezervacije.Click += new System.EventHandler(this.btnFiltritajRezervacije_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1259, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 33);
            this.label13.TabIndex = 28;
            this.label13.Text = "Kategorija";
            // 
            // kategorijaBindingSource2
            // 
            this.kategorijaBindingSource2.DataMember = "Kategorija";
            this.kategorijaBindingSource2.DataSource = this.rentACarDBDataSet;
            // 
            // kategorijaVoziloBindingSource
            // 
            this.kategorijaVoziloBindingSource.DataMember = "KategorijaVozilo";
            this.kategorijaVoziloBindingSource.DataSource = this.kategorijaBindingSource;
            // 
            // voziloTableAdapter
            // 
            this.voziloTableAdapter.ClearBeforeFill = true;
            // 
            // kategorijaBindingSource1
            // 
            this.kategorijaBindingSource1.DataMember = "Kategorija";
            this.kategorijaBindingSource1.DataSource = this.rentACarDBDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.kategorijaBindingSource3;
            this.comboBox1.DisplayMember = "naziv";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1265, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.ValueMember = "naziv";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kategorijaBindingSource3
            // 
            this.kategorijaBindingSource3.DataMember = "Kategorija";
            this.kategorijaBindingSource3.DataSource = this.rentACarDBDataSet;
            // 
            // btnGrafik
            // 
            this.btnGrafik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafik.Location = new System.Drawing.Point(1434, 72);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(75, 23);
            this.btnGrafik.TabIndex = 30;
            this.btnGrafik.Text = "Filtriraj";
            this.btnGrafik.UseVisualStyleBackColor = true;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // lblPrikaz
            // 
            this.lblPrikaz.AutoSize = true;
            this.lblPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrikaz.Location = new System.Drawing.Point(1209, 319);
            this.lblPrikaz.Name = "lblPrikaz";
            this.lblPrikaz.Size = new System.Drawing.Size(0, 25);
            this.lblPrikaz.TabIndex = 31;
            // 
            // lblNajposeceniji
            // 
            this.lblNajposeceniji.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNajposeceniji.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNajposeceniji.Location = new System.Drawing.Point(1249, 442);
            this.lblNajposeceniji.Name = "lblNajposeceniji";
            this.lblNajposeceniji.Size = new System.Drawing.Size(260, 141);
            this.lblNajposeceniji.TabIndex = 32;
            this.lblNajposeceniji.Text = "Vozilo";
            // 
            // btnSveRezervacije
            // 
            this.btnSveRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSveRezervacije.Location = new System.Drawing.Point(475, 559);
            this.btnSveRezervacije.Name = "btnSveRezervacije";
            this.btnSveRezervacije.Size = new System.Drawing.Size(128, 24);
            this.btnSveRezervacije.TabIndex = 33;
            this.btnSveRezervacije.Text = "Sve rezervacije";
            this.btnSveRezervacije.UseVisualStyleBackColor = true;
            this.btnSveRezervacije.Click += new System.EventHandler(this.btnSveRezervacije_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1551, 681);
            this.Controls.Add(this.btnSveRezervacije);
            this.Controls.Add(this.lblNajposeceniji);
            this.Controls.Add(this.lblPrikaz);
            this.Controls.Add(this.btnGrafik);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnFiltritajRezervacije);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpDoRezervacije);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpOdRezervacije);
            this.Controls.Add(this.btnFiltrirajPoSatu);
            this.Controls.Add(this.btnFiltrirajPoDatumu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCenaOd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCenaDo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.btnFiltrirajPoKategoriji);
            this.Controls.Add(this.dgwSveRezervacije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwSvaVozila);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSvaVozila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSveRezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaVoziloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSvaVozila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgwSveRezervacije;
        private System.Windows.Forms.Button btnFiltrirajPoKategoriji;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCenaDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.TextBox txtCenaOd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDodajRezervaciju;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.Button btnFiltrirajPoDatumu;
        private System.Windows.Forms.Button btnFiltrirajPoSatu;
        private RentACarDBDataSet rentACarDBDataSet;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private RentACarDBDataSetTableAdapters.KategorijaTableAdapter kategorijaTableAdapter;
        private System.Windows.Forms.Button btnDodajKlijenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDoRezervacije;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpOdRezervacije;
        private System.Windows.Forms.Button btnFiltritajRezervacije;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource kategorijaVoziloBindingSource;
        private RentACarDBDataSetTableAdapters.VoziloTableAdapter voziloTableAdapter;
        private System.Windows.Forms.BindingSource kategorijaBindingSource1;
        private System.Windows.Forms.BindingSource kategorijaBindingSource2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource kategorijaBindingSource3;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Label lblPrikaz;
        private System.Windows.Forms.Label lblNajposeceniji;
        private System.Windows.Forms.Button btnSveRezervacije;
    }
}