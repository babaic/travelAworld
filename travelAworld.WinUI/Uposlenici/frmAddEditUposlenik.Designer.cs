namespace travelAworld.WinUI.Uposlenici
{
    partial class frmAddEditUposlenik
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.formTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPrebaciOglase = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.btnSaveForm = new System.Windows.Forms.Button();
            this.btnNovaSlika = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDob = new System.Windows.Forms.DateTimePicker();
            this.dropFunkcija = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtUserAdresa = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtUserUsername = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtUserPrezime = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.formTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 60);
            this.panel1.TabIndex = 14;
            // 
            // formTitle
            // 
            this.formTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.formTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.formTitle.Location = new System.Drawing.Point(50, 13);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(141, 20);
            this.formTitle.TabIndex = 1;
            this.formTitle.Text = "Dodaj zaposlenog";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::travelAworld.WinUI.Properties.Resources.icons8_add_user_group_man_man_24;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 29);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnObrisi);
            this.panel2.Controls.Add(this.btnPrebaciOglase);
            this.panel2.Controls.Add(this.txtMail);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.btnSaveForm);
            this.panel2.Controls.Add(this.btnNovaSlika);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateDob);
            this.panel2.Controls.Add(this.dropFunkcija);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtAdresa);
            this.panel2.Controls.Add(this.txtUserAdresa);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.txtUserUsername);
            this.panel2.Controls.Add(this.txtPrezime);
            this.panel2.Controls.Add(this.txtUserPrezime);
            this.panel2.Controls.Add(this.txtIme);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 636);
            this.panel2.TabIndex = 15;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnObrisi.Location = new System.Drawing.Point(882, 358);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(222, 39);
            this.btnObrisi.TabIndex = 27;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Visible = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPrebaciOglase
            // 
            this.btnPrebaciOglase.BackColor = System.Drawing.Color.Green;
            this.btnPrebaciOglase.FlatAppearance.BorderSize = 0;
            this.btnPrebaciOglase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrebaciOglase.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrebaciOglase.Location = new System.Drawing.Point(882, 301);
            this.btnPrebaciOglase.Name = "btnPrebaciOglase";
            this.btnPrebaciOglase.Size = new System.Drawing.Size(222, 39);
            this.btnPrebaciOglase.TabIndex = 26;
            this.btnPrebaciOglase.Text = "Prebaci oglase";
            this.btnPrebaciOglase.UseVisualStyleBackColor = false;
            this.btnPrebaciOglase.Visible = false;
            this.btnPrebaciOglase.Click += new System.EventHandler(this.btnPrebaciOglase_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(192, 155);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(309, 22);
            this.txtMail.TabIndex = 24;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.txtEmail.Location = new System.Drawing.Point(37, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(46, 20);
            this.txtEmail.TabIndex = 25;
            this.txtEmail.Text = "Email";
            // 
            // btnSaveForm
            // 
            this.btnSaveForm.BackColor = System.Drawing.Color.Green;
            this.btnSaveForm.FlatAppearance.BorderSize = 0;
            this.btnSaveForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveForm.Location = new System.Drawing.Point(193, 389);
            this.btnSaveForm.Name = "btnSaveForm";
            this.btnSaveForm.Size = new System.Drawing.Size(178, 44);
            this.btnSaveForm.TabIndex = 23;
            this.btnSaveForm.Text = "Sačuvaj";
            this.btnSaveForm.UseVisualStyleBackColor = false;
            this.btnSaveForm.Click += new System.EventHandler(this.spasiFormu);
            // 
            // btnNovaSlika
            // 
            this.btnNovaSlika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnNovaSlika.FlatAppearance.BorderSize = 0;
            this.btnNovaSlika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaSlika.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNovaSlika.Location = new System.Drawing.Point(882, 261);
            this.btnNovaSlika.Name = "btnNovaSlika";
            this.btnNovaSlika.Size = new System.Drawing.Size(222, 23);
            this.btnNovaSlika.TabIndex = 22;
            this.btnNovaSlika.Text = "Dodaj sliku";
            this.btnNovaSlika.UseVisualStyleBackColor = false;
            this.btnNovaSlika.Click += new System.EventHandler(this.dodajSliku);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.userPicture);
            this.panel3.Location = new System.Drawing.Point(870, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 233);
            this.panel3.TabIndex = 21;
            // 
            // userPicture
            // 
            this.userPicture.Image = global::travelAworld.WinUI.Properties.Resources.blankPhoto;
            this.userPicture.InitialImage = null;
            this.userPicture.Location = new System.Drawing.Point(12, 6);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(222, 219);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 20;
            this.userPicture.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(192, 337);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(179, 22);
            this.txtPassword.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label3.Location = new System.Drawing.Point(37, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Lozinka";
            // 
            // dateDob
            // 
            this.dateDob.Location = new System.Drawing.Point(193, 242);
            this.dateDob.Name = "dateDob";
            this.dateDob.Size = new System.Drawing.Size(178, 22);
            this.dateDob.TabIndex = 17;
            // 
            // dropFunkcija
            // 
            this.dropFunkcija.FormattingEnabled = true;
            this.dropFunkcija.Location = new System.Drawing.Point(192, 289);
            this.dropFunkcija.Name = "dropFunkcija";
            this.dropFunkcija.Size = new System.Drawing.Size(179, 24);
            this.dropFunkcija.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label2.Location = new System.Drawing.Point(37, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Funkcija";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label4.Location = new System.Drawing.Point(37, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Datum rođenja";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(192, 201);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(309, 22);
            this.txtAdresa.TabIndex = 10;
            // 
            // txtUserAdresa
            // 
            this.txtUserAdresa.AutoSize = true;
            this.txtUserAdresa.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.txtUserAdresa.Location = new System.Drawing.Point(37, 200);
            this.txtUserAdresa.Name = "txtUserAdresa";
            this.txtUserAdresa.Size = new System.Drawing.Size(61, 20);
            this.txtUserAdresa.TabIndex = 11;
            this.txtUserAdresa.Text = "Adresa";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(192, 110);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(309, 22);
            this.txtUsername.TabIndex = 8;
            // 
            // txtUserUsername
            // 
            this.txtUserUsername.AutoSize = true;
            this.txtUserUsername.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.txtUserUsername.Location = new System.Drawing.Point(37, 110);
            this.txtUserUsername.Name = "txtUserUsername";
            this.txtUserUsername.Size = new System.Drawing.Size(112, 20);
            this.txtUserUsername.TabIndex = 9;
            this.txtUserUsername.Text = "Korisničko ime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(192, 68);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(309, 22);
            this.txtPrezime.TabIndex = 6;
            // 
            // txtUserPrezime
            // 
            this.txtUserPrezime.AutoSize = true;
            this.txtUserPrezime.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.txtUserPrezime.Location = new System.Drawing.Point(37, 67);
            this.txtUserPrezime.Name = "txtUserPrezime";
            this.txtUserPrezime.Size = new System.Drawing.Size(65, 20);
            this.txtUserPrezime.TabIndex = 7;
            this.txtUserPrezime.Text = "Prezime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(192, 28);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(309, 22);
            this.txtIme.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddEditUposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 715);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditUposlenik";
            this.Text = "AddEditUposlenik";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label txtUserAdresa;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label txtUserUsername;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label txtUserPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dropFunkcija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateDob;
        private System.Windows.Forms.Button btnNovaSlika;
        private System.Windows.Forms.Button btnSaveForm;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPrebaciOglase;
    }
}