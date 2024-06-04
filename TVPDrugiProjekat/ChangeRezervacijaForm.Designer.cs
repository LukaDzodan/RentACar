namespace TVPDrugiProjekat
{
    partial class ChangeRezervacijaForm
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
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.cbKlijenti = new System.Windows.Forms.ComboBox();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentACarDBDataSet = new TVPDrugiProjekat.RentACarDBDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.klijentTableAdapter = new TVPDrugiProjekat.RentACarDBDataSetTableAdapters.KlijentTableAdapter();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dtpPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPocetak.Location = new System.Drawing.Point(220, 148);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(200, 20);
            this.dtpPocetak.TabIndex = 0;
            // 
            // dtpKraj
            // 
            this.dtpKraj.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dtpKraj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKraj.Location = new System.Drawing.Point(220, 225);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(200, 20);
            this.dtpKraj.TabIndex = 1;
            // 
            // cbKlijenti
            // 
            this.cbKlijenti.DataSource = this.klijentBindingSource;
            this.cbKlijenti.FormattingEnabled = true;
            this.cbKlijenti.Location = new System.Drawing.Point(220, 69);
            this.cbKlijenti.Name = "cbKlijenti";
            this.cbKlijenti.Size = new System.Drawing.Size(200, 21);
            this.cbKlijenti.TabIndex = 2;
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataMember = "Klijent";
            this.klijentBindingSource.DataSource = this.rentACarDBDataSet;
            // 
            // rentACarDBDataSet
            // 
            this.rentACarDBDataSet.DataSetName = "RentACarDBDataSet";
            this.rentACarDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 167);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Klijent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum pocetka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datum kraja";
            // 
            // klijentTableAdapter
            // 
            this.klijentTableAdapter.ClearBeforeFill = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(243, 476);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(136, 38);
            this.btnSacuvaj.TabIndex = 8;
            this.btnSacuvaj.Text = "SACUVAJ";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.Crimson;
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(243, 520);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(136, 38);
            this.btnObrisi.TabIndex = 9;
            this.btnObrisi.Text = "OBRISI";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(12, 533);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(102, 39);
            this.btnNazad.TabIndex = 12;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // ChangeRezervacijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(673, 584);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbKlijenti);
            this.Controls.Add(this.dtpKraj);
            this.Controls.Add(this.dtpPocetak);
            this.Name = "ChangeRezervacijaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeRezervacijaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeRezervacijaForm_FormClosing);
            this.Load += new System.EventHandler(this.ChangeRezervacijaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.ComboBox cbKlijenti;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RentACarDBDataSet rentACarDBDataSet;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private RentACarDBDataSetTableAdapters.KlijentTableAdapter klijentTableAdapter;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnNazad;
    }
}