namespace travelAworld.WinUI.Rezervacije
{
    partial class frmRezervacijaInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervacijaInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRezervacijaId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel = new System.Windows.Forms.Panel();
            this.datumPlacanja = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cijena = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.brojOsoba = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tipSobe = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.datumDo = new System.Windows.Forms.Label();
            this.datumOd = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.mjesto = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nazivPonude = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.telefon = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.adresa = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.datumRodjenja = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imePrezime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.txtRezervacijaId);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 60);
            this.panel1.TabIndex = 17;
            // 
            // txtRezervacijaId
            // 
            this.txtRezervacijaId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRezervacijaId.AutoSize = true;
            this.txtRezervacijaId.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.txtRezervacijaId.ForeColor = System.Drawing.SystemColors.Control;
            this.txtRezervacijaId.Location = new System.Drawing.Point(50, 13);
            this.txtRezervacijaId.Name = "txtRezervacijaId";
            this.txtRezervacijaId.Size = new System.Drawing.Size(155, 22);
            this.txtRezervacijaId.TabIndex = 1;
            this.txtRezervacijaId.Text = "Rezervacija #ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::travelAworld.WinUI.Properties.Resources.icons8_calendar_23_24;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 29);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrevious.Location = new System.Drawing.Point(753, 680);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 62;
            this.btnPrevious.Text = "¸Printaj";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pictureBox2);
            this.panel.Controls.Add(this.datumPlacanja);
            this.panel.Controls.Add(this.label26);
            this.panel.Controls.Add(this.cijena);
            this.panel.Controls.Add(this.label24);
            this.panel.Controls.Add(this.brojOsoba);
            this.panel.Controls.Add(this.label22);
            this.panel.Controls.Add(this.tipSobe);
            this.panel.Controls.Add(this.label20);
            this.panel.Controls.Add(this.datumDo);
            this.panel.Controls.Add(this.datumOd);
            this.panel.Controls.Add(this.label17);
            this.panel.Controls.Add(this.mjesto);
            this.panel.Controls.Add(this.label15);
            this.panel.Controls.Add(this.nazivPonude);
            this.panel.Controls.Add(this.label13);
            this.panel.Controls.Add(this.panel2);
            this.panel.Controls.Add(this.telefon);
            this.panel.Controls.Add(this.label11);
            this.panel.Controls.Add(this.email);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.adresa);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.datumRodjenja);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.imePrezime);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(13, 67);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(827, 607);
            this.panel.TabIndex = 63;
            // 
            // datumPlacanja
            // 
            this.datumPlacanja.AutoSize = true;
            this.datumPlacanja.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.datumPlacanja.Location = new System.Drawing.Point(703, 292);
            this.datumPlacanja.Name = "datumPlacanja";
            this.datumPlacanja.Size = new System.Drawing.Size(48, 17);
            this.datumPlacanja.TabIndex = 87;
            this.datumPlacanja.Text = "Datum";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(499, 287);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(140, 22);
            this.label26.TabIndex = 86;
            this.label26.Text = "Datum plaćanja";
            // 
            // cijena
            // 
            this.cijena.AutoSize = true;
            this.cijena.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cijena.Location = new System.Drawing.Point(703, 256);
            this.cijena.Name = "cijena";
            this.cijena.Size = new System.Drawing.Size(57, 17);
            this.cijena.TabIndex = 85;
            this.cijena.Text = "345 KM";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(499, 251);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(142, 22);
            this.label24.TabIndex = 84;
            this.label24.Text = "Ukupno plaćeno";
            // 
            // brojOsoba
            // 
            this.brojOsoba.AutoSize = true;
            this.brojOsoba.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.brojOsoba.Location = new System.Drawing.Point(703, 221);
            this.brojOsoba.Name = "brojOsoba";
            this.brojOsoba.Size = new System.Drawing.Size(15, 17);
            this.brojOsoba.TabIndex = 83;
            this.brojOsoba.Text = "2";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(499, 216);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 22);
            this.label22.TabIndex = 82;
            this.label22.Text = "Broj osoba";
            // 
            // tipSobe
            // 
            this.tipSobe.AutoSize = true;
            this.tipSobe.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.tipSobe.Location = new System.Drawing.Point(703, 182);
            this.tipSobe.Name = "tipSobe";
            this.tipSobe.Size = new System.Drawing.Size(57, 17);
            this.tipSobe.TabIndex = 81;
            this.tipSobe.Text = "Tip sobe";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(499, 177);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 22);
            this.label20.TabIndex = 80;
            this.label20.Text = "Tip sobe";
            // 
            // datumDo
            // 
            this.datumDo.AutoSize = true;
            this.datumDo.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.datumDo.Location = new System.Drawing.Point(286, 467);
            this.datumDo.Name = "datumDo";
            this.datumDo.Size = new System.Drawing.Size(66, 17);
            this.datumDo.TabIndex = 79;
            this.datumDo.Text = "Datum do";
            // 
            // datumOd
            // 
            this.datumOd.AutoSize = true;
            this.datumOd.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.datumOd.Location = new System.Drawing.Point(207, 467);
            this.datumOd.Name = "datumOd";
            this.datumOd.Size = new System.Drawing.Size(66, 17);
            this.datumOd.TabIndex = 78;
            this.datumOd.Text = "Datum od";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(4, 462);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 22);
            this.label17.TabIndex = 77;
            this.label17.Text = "Datum od - do";
            // 
            // mjesto
            // 
            this.mjesto.AutoSize = true;
            this.mjesto.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.mjesto.Location = new System.Drawing.Point(207, 432);
            this.mjesto.Name = "mjesto";
            this.mjesto.Size = new System.Drawing.Size(48, 17);
            this.mjesto.TabIndex = 76;
            this.mjesto.Text = "Mjesto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(4, 427);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 22);
            this.label15.TabIndex = 75;
            this.label15.Text = "Mjesto";
            // 
            // nazivPonude
            // 
            this.nazivPonude.AutoSize = true;
            this.nazivPonude.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.nazivPonude.Location = new System.Drawing.Point(208, 395);
            this.nazivPonude.Name = "nazivPonude";
            this.nazivPonude.Size = new System.Drawing.Size(88, 17);
            this.nazivPonude.TabIndex = 74;
            this.nazivPonude.Text = "Naziv ponude";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(4, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 22);
            this.label13.TabIndex = 73;
            this.label13.Text = "Naziv ponude";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(-13, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 10);
            this.panel2.TabIndex = 72;
            // 
            // telefon
            // 
            this.telefon.AutoSize = true;
            this.telefon.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.telefon.Location = new System.Drawing.Point(207, 324);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(71, 17);
            this.telefon.TabIndex = 71;
            this.telefon.Text = "061234567";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(3, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 22);
            this.label11.TabIndex = 70;
            this.label11.Text = "Telefon";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.email.Location = new System.Drawing.Point(207, 290);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(110, 17);
            this.email.TabIndex = 69;
            this.email.Text = "dhuit@gmail.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 22);
            this.label7.TabIndex = 68;
            this.label7.Text = "Email";
            // 
            // adresa
            // 
            this.adresa.AutoSize = true;
            this.adresa.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.adresa.Location = new System.Drawing.Point(207, 254);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(50, 17);
            this.adresa.TabIndex = 67;
            this.adresa.Text = "Ulica 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(3, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 22);
            this.label9.TabIndex = 66;
            this.label9.Text = "Adresa";
            // 
            // datumRodjenja
            // 
            this.datumRodjenja.AutoSize = true;
            this.datumRodjenja.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.datumRodjenja.Location = new System.Drawing.Point(207, 216);
            this.datumRodjenja.Name = "datumRodjenja";
            this.datumRodjenja.Size = new System.Drawing.Size(58, 17);
            this.datumRodjenja.TabIndex = 65;
            this.datumRodjenja.Text = "1.2.1990";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 22);
            this.label4.TabIndex = 64;
            this.label4.Text = "Datum rođenja";
            // 
            // imePrezime
            // 
            this.imePrezime.AutoSize = true;
            this.imePrezime.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imePrezime.Location = new System.Drawing.Point(207, 180);
            this.imePrezime.Name = "imePrezime";
            this.imePrezime.Size = new System.Drawing.Size(57, 17);
            this.imePrezime.TabIndex = 63;
            this.imePrezime.Text = "Doe Joe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 62;
            this.label1.Text = "Ime i prezime";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::travelAworld.WinUI.Properties.Resources._219f16ad_2853_479d_9f16_d28c202d7006_200x200;
            this.pictureBox2.Location = new System.Drawing.Point(274, -54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(347, 175);
            this.pictureBox2.TabIndex = 88;
            this.pictureBox2.TabStop = false;
            // 
            // frmRezervacijaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 715);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRezervacijaInfo";
            this.Text = "frmRezervacijaInfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtRezervacijaId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label datumPlacanja;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label cijena;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label brojOsoba;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label tipSobe;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label datumDo;
        private System.Windows.Forms.Label datumOd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label mjesto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label nazivPonude;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label telefon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label adresa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label datumRodjenja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label imePrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}