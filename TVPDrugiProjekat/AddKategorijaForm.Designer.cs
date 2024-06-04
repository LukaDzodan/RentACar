namespace TVPDrugiProjekat
{
    partial class AddKategorijaForm
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
            this.btnNazad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategorija = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpisKategorije = new System.Windows.Forms.TextBox();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(12, 245);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(102, 39);
            this.btnNazad.TabIndex = 12;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naziv Ketegorije:";
            // 
            // txtKategorija
            // 
            this.txtKategorija.Location = new System.Drawing.Point(198, 45);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.Size = new System.Drawing.Size(36, 20);
            this.txtKategorija.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Opis Ketegorije:";
            // 
            // txtOpisKategorije
            // 
            this.txtOpisKategorije.Location = new System.Drawing.Point(192, 92);
            this.txtOpisKategorije.Multiline = true;
            this.txtOpisKategorije.Name = "txtOpisKategorije";
            this.txtOpisKategorije.Size = new System.Drawing.Size(252, 70);
            this.txtOpisKategorije.TabIndex = 16;
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDodajKategoriju.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKategoriju.Location = new System.Drawing.Point(220, 178);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(194, 39);
            this.btnDodajKategoriju.TabIndex = 17;
            this.btnDodajKategoriju.Text = "Dodaj kategoriju";
            this.btnDodajKategoriju.UseVisualStyleBackColor = false;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // AddKategorijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(456, 296);
            this.Controls.Add(this.btnDodajKategoriju);
            this.Controls.Add(this.txtOpisKategorije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKategorija);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNazad);
            this.Name = "AddKategorijaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddKategorijaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddKategorijaForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategorija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpisKategorije;
        private System.Windows.Forms.Button btnDodajKategoriju;
    }
}