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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnZavrsi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.btnOtkaziRezervaciju = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIznosPovrata = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRezervacijaId = new System.Windows.Forms.Label();
            this.lbl_otkazana_header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelInfoOtkazivanje = new System.Windows.Forms.Panel();
            this.lblDatumZavrseno = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelInfoOtkazivanje.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrevious.Location = new System.Drawing.Point(753, 680);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 33);
            this.btnPrevious.TabIndex = 62;
            this.btnPrevious.Text = "Printaj";
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
            this.panel.Controls.Add(this.panelInfoOtkazivanje);
            this.panel.Controls.Add(this.label12);
            this.panel.Controls.Add(this.label10);
            this.panel.Controls.Add(this.label8);
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
            this.panel.Location = new System.Drawing.Point(0, 67);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1170, 985);
            this.panel.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 92;
            this.label6.Text = "KM";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(440, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 17);
            this.label12.TabIndex = 91;
            this.label12.Text = "REZERVACIJA:";
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.BackColor = System.Drawing.Color.Maroon;
            this.btnZavrsi.FlatAppearance.BorderSize = 0;
            this.btnZavrsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZavrsi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnZavrsi.Location = new System.Drawing.Point(10, 119);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(247, 64);
            this.btnZavrsi.TabIndex = 71;
            this.btnZavrsi.Text = "ZAVRŠI";
            this.btnZavrsi.UseVisualStyleBackColor = false;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 90;
            this.label10.Text = "REZERVISAO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(803, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 89;
            this.label8.Text = "PONUDA:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::travelAworld.WinUI.Properties.Resources._219f16ad_2853_479d_9f16_d28c202d7006_200x200;
            this.pictureBox2.Location = new System.Drawing.Point(434, -27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(347, 175);
            this.pictureBox2.TabIndex = 88;
            this.pictureBox2.TabStop = false;
            // 
            // datumPlacanja
            // 
            this.datumPlacanja.AutoSize = true;
            this.datumPlacanja.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.datumPlacanja.Location = new System.Drawing.Point(644, 292);
            this.datumPlacanja.Name = "datumPlacanja";
            this.datumPlacanja.Size = new System.Drawing.Size(48, 17);
            this.datumPlacanja.TabIndex = 87;
            this.datumPlacanja.Text = "Datum";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(440, 287);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(140, 22);
            this.label26.TabIndex = 86;
            this.label26.Text = "Datum plaćanja";
            // 
            // cijena
            // 
            this.cijena.AutoSize = true;
            this.cijena.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cijena.Location = new System.Drawing.Point(644, 256);
            this.cijena.Name = "cijena";
            this.cijena.Size = new System.Drawing.Size(57, 17);
            this.cijena.TabIndex = 85;
            this.cijena.Text = "345 KM";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(440, 251);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(142, 22);
            this.label24.TabIndex = 84;
            this.label24.Text = "Ukupno plaćeno";
            // 
            // brojOsoba
            // 
            this.brojOsoba.AutoSize = true;
            this.brojOsoba.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.brojOsoba.Location = new System.Drawing.Point(644, 221);
            this.brojOsoba.Name = "brojOsoba";
            this.brojOsoba.Size = new System.Drawing.Size(15, 17);
            this.brojOsoba.TabIndex = 83;
            this.brojOsoba.Text = "2";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(440, 216);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 22);
            this.label22.TabIndex = 82;
            this.label22.Text = "Broj osoba";
            // 
            // tipSobe
            // 
            this.tipSobe.AutoSize = true;
            this.tipSobe.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.tipSobe.Location = new System.Drawing.Point(644, 182);
            this.tipSobe.Name = "tipSobe";
            this.tipSobe.Size = new System.Drawing.Size(57, 17);
            this.tipSobe.TabIndex = 81;
            this.tipSobe.Text = "Tip sobe";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(440, 177);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 22);
            this.label20.TabIndex = 80;
            this.label20.Text = "Tip sobe";
            // 
            // datumDo
            // 
            this.datumDo.AutoSize = true;
            this.datumDo.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.datumDo.Location = new System.Drawing.Point(1083, 256);
            this.datumDo.Name = "datumDo";
            this.datumDo.Size = new System.Drawing.Size(66, 17);
            this.datumDo.TabIndex = 79;
            this.datumDo.Text = "Datum do";
            // 
            // datumOd
            // 
            this.datumOd.AutoSize = true;
            this.datumOd.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.datumOd.Location = new System.Drawing.Point(1006, 256);
            this.datumOd.Name = "datumOd";
            this.datumOd.Size = new System.Drawing.Size(66, 17);
            this.datumOd.TabIndex = 78;
            this.datumOd.Text = "Datum od";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(803, 251);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 22);
            this.label17.TabIndex = 77;
            this.label17.Text = "Datum od - do";
            // 
            // mjesto
            // 
            this.mjesto.AutoSize = true;
            this.mjesto.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.mjesto.Location = new System.Drawing.Point(1006, 215);
            this.mjesto.Name = "mjesto";
            this.mjesto.Size = new System.Drawing.Size(48, 17);
            this.mjesto.TabIndex = 76;
            this.mjesto.Text = "Mjesto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(803, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 22);
            this.label15.TabIndex = 75;
            this.label15.Text = "Mjesto";
            // 
            // nazivPonude
            // 
            this.nazivPonude.AutoSize = true;
            this.nazivPonude.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.nazivPonude.Location = new System.Drawing.Point(1006, 182);
            this.nazivPonude.Name = "nazivPonude";
            this.nazivPonude.Size = new System.Drawing.Size(88, 17);
            this.nazivPonude.TabIndex = 74;
            this.nazivPonude.Text = "Naziv ponude";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(802, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 22);
            this.label13.TabIndex = 73;
            this.label13.Text = "Naziv ponude";
            // 
            // telefon
            // 
            this.telefon.AutoSize = true;
            this.telefon.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.telefon.Location = new System.Drawing.Point(221, 328);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(71, 17);
            this.telefon.TabIndex = 71;
            this.telefon.Text = "061234567";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(17, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 22);
            this.label11.TabIndex = 70;
            this.label11.Text = "Telefon";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.email.Location = new System.Drawing.Point(221, 294);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(110, 17);
            this.email.TabIndex = 69;
            this.email.Text = "dhuit@gmail.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(17, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 22);
            this.label7.TabIndex = 68;
            this.label7.Text = "Email";
            // 
            // adresa
            // 
            this.adresa.AutoSize = true;
            this.adresa.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.adresa.Location = new System.Drawing.Point(221, 258);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(50, 17);
            this.adresa.TabIndex = 67;
            this.adresa.Text = "Ulica 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(17, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 22);
            this.label9.TabIndex = 66;
            this.label9.Text = "Adresa";
            // 
            // datumRodjenja
            // 
            this.datumRodjenja.AutoSize = true;
            this.datumRodjenja.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.datumRodjenja.Location = new System.Drawing.Point(221, 220);
            this.datumRodjenja.Name = "datumRodjenja";
            this.datumRodjenja.Size = new System.Drawing.Size(58, 17);
            this.datumRodjenja.TabIndex = 65;
            this.datumRodjenja.Text = "1.2.1990";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(17, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 22);
            this.label4.TabIndex = 64;
            this.label4.Text = "Datum rođenja";
            // 
            // imePrezime
            // 
            this.imePrezime.AutoSize = true;
            this.imePrezime.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imePrezime.Location = new System.Drawing.Point(221, 184);
            this.imePrezime.Name = "imePrezime";
            this.imePrezime.Size = new System.Drawing.Size(57, 17);
            this.imePrezime.TabIndex = 63;
            this.imePrezime.Text = "Doe Joe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 62;
            this.label1.Text = "Ime i prezime";
            // 
            // btnOtkaziRezervaciju
            // 
            this.btnOtkaziRezervaciju.BackColor = System.Drawing.Color.Maroon;
            this.btnOtkaziRezervaciju.FlatAppearance.BorderSize = 0;
            this.btnOtkaziRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtkaziRezervaciju.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOtkaziRezervaciju.Location = new System.Drawing.Point(1035, 15);
            this.btnOtkaziRezervaciju.Name = "btnOtkaziRezervaciju";
            this.btnOtkaziRezervaciju.Size = new System.Drawing.Size(123, 33);
            this.btnOtkaziRezervaciju.TabIndex = 64;
            this.btnOtkaziRezervaciju.Text = "Otkaži";
            this.btnOtkaziRezervaciju.UseVisualStyleBackColor = false;
            this.btnOtkaziRezervaciju.Click += new System.EventHandler(this.btnOtkaziRezervaciju_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(461, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "INFORMACIJE O OTKAZIVANJU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "STATUS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "IZNOS POVRATA";
            // 
            // txtIznosPovrata
            // 
            this.txtIznosPovrata.Location = new System.Drawing.Point(132, 81);
            this.txtIznosPovrata.Name = "txtIznosPovrata";
            this.txtIznosPovrata.Size = new System.Drawing.Size(83, 22);
            this.txtIznosPovrata.TabIndex = 69;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStatus.Location = new System.Drawing.Point(129, 45);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 17);
            this.lblStatus.TabIndex = 70;
            this.lblStatus.Text = "AKTIVNO";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 204);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(812, 24);
            this.textBox2.TabIndex = 72;
            this.textBox2.Text = "Klikom na Završi smatra se da su izvršene obaveze koje se tiču otkazivanja rezerv" +
    "acije (povrat novca, vraćanje dokumentacije , itd...)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::travelAworld.WinUI.Properties.Resources.icons8_calendar_23_24;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 65535);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // lbl_otkazana_header
            // 
            this.lbl_otkazana_header.AutoSize = true;
            this.lbl_otkazana_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_otkazana_header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_otkazana_header.Location = new System.Drawing.Point(239, 15);
            this.lbl_otkazana_header.Name = "lbl_otkazana_header";
            this.lbl_otkazana_header.Size = new System.Drawing.Size(182, 19);
            this.lbl_otkazana_header.TabIndex = 89;
            this.lbl_otkazana_header.Text = "REZERVACIJA OTKAZANA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.lbl_otkazana_header);
            this.panel1.Controls.Add(this.txtRezervacijaId);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnOtkaziRezervaciju);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 65535);
            this.panel1.TabIndex = 17;
            // 
            // panelInfoOtkazivanje
            // 
            this.panelInfoOtkazivanje.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelInfoOtkazivanje.Controls.Add(this.lblDatumZavrseno);
            this.panelInfoOtkazivanje.Controls.Add(this.textBox2);
            this.panelInfoOtkazivanje.Controls.Add(this.label2);
            this.panelInfoOtkazivanje.Controls.Add(this.label6);
            this.panelInfoOtkazivanje.Controls.Add(this.btnZavrsi);
            this.panelInfoOtkazivanje.Controls.Add(this.txtIznosPovrata);
            this.panelInfoOtkazivanje.Controls.Add(this.lblStatus);
            this.panelInfoOtkazivanje.Controls.Add(this.label5);
            this.panelInfoOtkazivanje.Controls.Add(this.label3);
            this.panelInfoOtkazivanje.Location = new System.Drawing.Point(16, 380);
            this.panelInfoOtkazivanje.Name = "panelInfoOtkazivanje";
            this.panelInfoOtkazivanje.Size = new System.Drawing.Size(1135, 292);
            this.panelInfoOtkazivanje.TabIndex = 93;
            // 
            // lblDatumZavrseno
            // 
            this.lblDatumZavrseno.AutoSize = true;
            this.lblDatumZavrseno.Location = new System.Drawing.Point(227, 45);
            this.lblDatumZavrseno.Name = "lblDatumZavrseno";
            this.lblDatumZavrseno.Size = new System.Drawing.Size(61, 21);
            this.lblDatumZavrseno.TabIndex = 93;
            this.lblDatumZavrseno.Text = "Datum";
            // 
            // frmRezervacijaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1163, 853);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRezervacijaInfo";
            this.Text = "frmRezervacijaInfo";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelInfoOtkazivanje.ResumeLayout(false);
            this.panelInfoOtkazivanje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button btnOtkaziRezervaciju;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIznosPovrata;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnZavrsi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtRezervacijaId;
        private System.Windows.Forms.Label lbl_otkazana_header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelInfoOtkazivanje;
        private System.Windows.Forms.Label lblDatumZavrseno;
    }
}