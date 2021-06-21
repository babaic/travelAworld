namespace travelAworld.WinUI
{
    partial class frmIndex
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.panelPonudeSubMenu = new System.Windows.Forms.Panel();
            this.btnListaPonuda = new System.Windows.Forms.Button();
            this.btnNovaPonuda = new System.Windows.Forms.Button();
            this.btnPonude = new System.Windows.Forms.Button();
            this.panelKorisniciSubMenu = new System.Windows.Forms.Panel();
            this.btnUplate = new System.Windows.Forms.Button();
            this.btnPoruke = new System.Windows.Forms.Button();
            this.btnListaKorisnika = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.panelUposleniciSubmenu = new System.Windows.Forms.Panel();
            this.btnListaUposlenika = new System.Windows.Forms.Button();
            this.btnNoviUposlenik = new System.Windows.Forms.Button();
            this.btnUposlenici = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.txtUserFullName = new System.Windows.Forms.Label();
            this.txtUserRole = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelMainMenu.SuspendLayout();
            this.panelPonudeSubMenu.SuspendLayout();
            this.panelKorisniciSubMenu.SuspendLayout();
            this.panelUposleniciSubmenu.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.panelMainMenu);
            this.panel1.Controls.Add(this.panelUser);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 762);
            this.panel1.TabIndex = 4;
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.AutoScroll = true;
            this.panelMainMenu.Controls.Add(this.btnOdjava);
            this.panelMainMenu.Controls.Add(this.btnStatistika);
            this.panelMainMenu.Controls.Add(this.panelPonudeSubMenu);
            this.panelMainMenu.Controls.Add(this.btnPonude);
            this.panelMainMenu.Controls.Add(this.panelKorisniciSubMenu);
            this.panelMainMenu.Controls.Add(this.btnKorisnici);
            this.panelMainMenu.Controls.Add(this.panelUposleniciSubmenu);
            this.panelMainMenu.Controls.Add(this.btnUposlenici);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 191);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(227, 549);
            this.panelMainMenu.TabIndex = 14;
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.Maroon;
            this.btnOdjava.FlatAppearance.BorderSize = 0;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOdjava.Location = new System.Drawing.Point(74, 523);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(75, 23);
            this.btnOdjava.TabIndex = 11;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(135)))), ((int)(((byte)(146)))));
            this.btnStatistika.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistika.FlatAppearance.BorderSize = 0;
            this.btnStatistika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistika.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistika.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStatistika.Image = global::travelAworld.WinUI.Properties.Resources.icons8_bar_chart_24;
            this.btnStatistika.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistika.Location = new System.Drawing.Point(0, 415);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(227, 45);
            this.btnStatistika.TabIndex = 20;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseVisualStyleBackColor = false;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // panelPonudeSubMenu
            // 
            this.panelPonudeSubMenu.AutoSize = true;
            this.panelPonudeSubMenu.Controls.Add(this.btnListaPonuda);
            this.panelPonudeSubMenu.Controls.Add(this.btnNovaPonuda);
            this.panelPonudeSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPonudeSubMenu.Location = new System.Drawing.Point(0, 335);
            this.panelPonudeSubMenu.Name = "panelPonudeSubMenu";
            this.panelPonudeSubMenu.Size = new System.Drawing.Size(227, 80);
            this.panelPonudeSubMenu.TabIndex = 19;
            // 
            // btnListaPonuda
            // 
            this.btnListaPonuda.BackColor = System.Drawing.Color.Gray;
            this.btnListaPonuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaPonuda.FlatAppearance.BorderSize = 0;
            this.btnListaPonuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaPonuda.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaPonuda.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListaPonuda.Image = global::travelAworld.WinUI.Properties.Resources.icons8_airplane_mode_on_24__1_;
            this.btnListaPonuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaPonuda.Location = new System.Drawing.Point(0, 40);
            this.btnListaPonuda.Name = "btnListaPonuda";
            this.btnListaPonuda.Size = new System.Drawing.Size(227, 40);
            this.btnListaPonuda.TabIndex = 16;
            this.btnListaPonuda.Text = "Lista ponuda";
            this.btnListaPonuda.UseVisualStyleBackColor = false;
            this.btnListaPonuda.Click += new System.EventHandler(this.btnListaPonuda_Click);
            // 
            // btnNovaPonuda
            // 
            this.btnNovaPonuda.BackColor = System.Drawing.Color.Gray;
            this.btnNovaPonuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovaPonuda.FlatAppearance.BorderSize = 0;
            this.btnNovaPonuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaPonuda.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaPonuda.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNovaPonuda.Image = global::travelAworld.WinUI.Properties.Resources.icons8_airplane_mode_on_24;
            this.btnNovaPonuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovaPonuda.Location = new System.Drawing.Point(0, 0);
            this.btnNovaPonuda.Name = "btnNovaPonuda";
            this.btnNovaPonuda.Size = new System.Drawing.Size(227, 40);
            this.btnNovaPonuda.TabIndex = 15;
            this.btnNovaPonuda.Text = "Nova ponuda";
            this.btnNovaPonuda.UseVisualStyleBackColor = false;
            this.btnNovaPonuda.Click += new System.EventHandler(this.btnNovaPonuda_Click);
            // 
            // btnPonude
            // 
            this.btnPonude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(135)))), ((int)(((byte)(146)))));
            this.btnPonude.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPonude.FlatAppearance.BorderSize = 0;
            this.btnPonude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonude.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonude.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPonude.Image = global::travelAworld.WinUI.Properties.Resources.icons8_airplane_take_off_24;
            this.btnPonude.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPonude.Location = new System.Drawing.Point(0, 290);
            this.btnPonude.Name = "btnPonude";
            this.btnPonude.Size = new System.Drawing.Size(227, 45);
            this.btnPonude.TabIndex = 18;
            this.btnPonude.Text = "Ponude";
            this.btnPonude.UseVisualStyleBackColor = false;
            this.btnPonude.Click += new System.EventHandler(this.btnPonude_Click);
            // 
            // panelKorisniciSubMenu
            // 
            this.panelKorisniciSubMenu.AutoSize = true;
            this.panelKorisniciSubMenu.Controls.Add(this.btnUplate);
            this.panelKorisniciSubMenu.Controls.Add(this.btnPoruke);
            this.panelKorisniciSubMenu.Controls.Add(this.btnListaKorisnika);
            this.panelKorisniciSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKorisniciSubMenu.Location = new System.Drawing.Point(0, 170);
            this.panelKorisniciSubMenu.Name = "panelKorisniciSubMenu";
            this.panelKorisniciSubMenu.Size = new System.Drawing.Size(227, 120);
            this.panelKorisniciSubMenu.TabIndex = 17;
            // 
            // btnUplate
            // 
            this.btnUplate.BackColor = System.Drawing.Color.Gray;
            this.btnUplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUplate.FlatAppearance.BorderSize = 0;
            this.btnUplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUplate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUplate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUplate.Image = global::travelAworld.WinUI.Properties.Resources.icons8_money_24;
            this.btnUplate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUplate.Location = new System.Drawing.Point(0, 80);
            this.btnUplate.Name = "btnUplate";
            this.btnUplate.Size = new System.Drawing.Size(227, 40);
            this.btnUplate.TabIndex = 16;
            this.btnUplate.Text = "Uplate";
            this.btnUplate.UseVisualStyleBackColor = false;
            // 
            // btnPoruke
            // 
            this.btnPoruke.BackColor = System.Drawing.Color.Gray;
            this.btnPoruke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPoruke.FlatAppearance.BorderSize = 0;
            this.btnPoruke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoruke.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoruke.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPoruke.Image = global::travelAworld.WinUI.Properties.Resources.icons8_chat_24;
            this.btnPoruke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPoruke.Location = new System.Drawing.Point(0, 40);
            this.btnPoruke.Name = "btnPoruke";
            this.btnPoruke.Size = new System.Drawing.Size(227, 40);
            this.btnPoruke.TabIndex = 15;
            this.btnPoruke.Text = "Poruke";
            this.btnPoruke.UseVisualStyleBackColor = false;
            // 
            // btnListaKorisnika
            // 
            this.btnListaKorisnika.BackColor = System.Drawing.Color.Gray;
            this.btnListaKorisnika.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaKorisnika.FlatAppearance.BorderSize = 0;
            this.btnListaKorisnika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaKorisnika.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaKorisnika.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListaKorisnika.Image = global::travelAworld.WinUI.Properties.Resources.icons8_traveler_24;
            this.btnListaKorisnika.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaKorisnika.Location = new System.Drawing.Point(0, 0);
            this.btnListaKorisnika.Name = "btnListaKorisnika";
            this.btnListaKorisnika.Size = new System.Drawing.Size(227, 40);
            this.btnListaKorisnika.TabIndex = 14;
            this.btnListaKorisnika.Text = "Lista Koris.";
            this.btnListaKorisnika.UseVisualStyleBackColor = false;
            this.btnListaKorisnika.Click += new System.EventHandler(this.btnListaKorisnika_Click);
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(135)))), ((int)(((byte)(146)))));
            this.btnKorisnici.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKorisnici.FlatAppearance.BorderSize = 0;
            this.btnKorisnici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKorisnici.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKorisnici.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKorisnici.Image = global::travelAworld.WinUI.Properties.Resources.icons8_traveler_24;
            this.btnKorisnici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKorisnici.Location = new System.Drawing.Point(0, 125);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(227, 45);
            this.btnKorisnici.TabIndex = 16;
            this.btnKorisnici.Text = "Korisnici";
            this.btnKorisnici.UseVisualStyleBackColor = false;
            this.btnKorisnici.Click += new System.EventHandler(this.btnKorisnici_Click);
            // 
            // panelUposleniciSubmenu
            // 
            this.panelUposleniciSubmenu.AutoSize = true;
            this.panelUposleniciSubmenu.Controls.Add(this.btnListaUposlenika);
            this.panelUposleniciSubmenu.Controls.Add(this.btnNoviUposlenik);
            this.panelUposleniciSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUposleniciSubmenu.Location = new System.Drawing.Point(0, 45);
            this.panelUposleniciSubmenu.Name = "panelUposleniciSubmenu";
            this.panelUposleniciSubmenu.Size = new System.Drawing.Size(227, 80);
            this.panelUposleniciSubmenu.TabIndex = 3;
            // 
            // btnListaUposlenika
            // 
            this.btnListaUposlenika.BackColor = System.Drawing.Color.Gray;
            this.btnListaUposlenika.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaUposlenika.FlatAppearance.BorderSize = 0;
            this.btnListaUposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaUposlenika.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaUposlenika.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListaUposlenika.Image = global::travelAworld.WinUI.Properties.Resources.icons8_user_account_24__2_;
            this.btnListaUposlenika.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaUposlenika.Location = new System.Drawing.Point(0, 40);
            this.btnListaUposlenika.Name = "btnListaUposlenika";
            this.btnListaUposlenika.Size = new System.Drawing.Size(227, 40);
            this.btnListaUposlenika.TabIndex = 12;
            this.btnListaUposlenika.Text = "Lista uposl.";
            this.btnListaUposlenika.UseVisualStyleBackColor = false;
            this.btnListaUposlenika.Click += new System.EventHandler(this.btnListaUposlenika_Click);
            // 
            // btnNoviUposlenik
            // 
            this.btnNoviUposlenik.BackColor = System.Drawing.Color.Gray;
            this.btnNoviUposlenik.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNoviUposlenik.FlatAppearance.BorderSize = 0;
            this.btnNoviUposlenik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoviUposlenik.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviUposlenik.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNoviUposlenik.Image = global::travelAworld.WinUI.Properties.Resources.icons8_add_user_group_man_man_24;
            this.btnNoviUposlenik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoviUposlenik.Location = new System.Drawing.Point(0, 0);
            this.btnNoviUposlenik.Name = "btnNoviUposlenik";
            this.btnNoviUposlenik.Size = new System.Drawing.Size(227, 40);
            this.btnNoviUposlenik.TabIndex = 13;
            this.btnNoviUposlenik.Text = "Novi uposl.";
            this.btnNoviUposlenik.UseVisualStyleBackColor = false;
            this.btnNoviUposlenik.Click += new System.EventHandler(this.btnNoviUposlenik_Click);
            // 
            // btnUposlenici
            // 
            this.btnUposlenici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(135)))), ((int)(((byte)(146)))));
            this.btnUposlenici.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUposlenici.FlatAppearance.BorderSize = 0;
            this.btnUposlenici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUposlenici.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUposlenici.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUposlenici.Image = global::travelAworld.WinUI.Properties.Resources.icons8_user_account_24__2_;
            this.btnUposlenici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUposlenici.Location = new System.Drawing.Point(0, 0);
            this.btnUposlenici.Name = "btnUposlenici";
            this.btnUposlenici.Size = new System.Drawing.Size(227, 45);
            this.btnUposlenici.TabIndex = 2;
            this.btnUposlenici.Text = "Uposlenici";
            this.btnUposlenici.UseVisualStyleBackColor = false;
            this.btnUposlenici.Click += new System.EventHandler(this.btnUposlenici_Click);
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.profilePic);
            this.panelUser.Controls.Add(this.txtUserFullName);
            this.panelUser.Controls.Add(this.txtUserRole);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(0, 100);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(227, 91);
            this.panelUser.TabIndex = 13;
            // 
            // profilePic
            // 
            this.profilePic.Location = new System.Drawing.Point(12, 6);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(58, 59);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePic.TabIndex = 8;
            this.profilePic.TabStop = false;
            // 
            // txtUserFullName
            // 
            this.txtUserFullName.AutoSize = true;
            this.txtUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserFullName.ForeColor = System.Drawing.SystemColors.Control;
            this.txtUserFullName.Location = new System.Drawing.Point(77, 7);
            this.txtUserFullName.Name = "txtUserFullName";
            this.txtUserFullName.Size = new System.Drawing.Size(72, 20);
            this.txtUserFullName.TabIndex = 9;
            this.txtUserFullName.Text = "Doe Joe";
            // 
            // txtUserRole
            // 
            this.txtUserRole.AutoSize = true;
            this.txtUserRole.ForeColor = System.Drawing.SystemColors.Control;
            this.txtUserRole.Location = new System.Drawing.Point(78, 27);
            this.txtUserRole.Name = "txtUserRole";
            this.txtUserRole.Size = new System.Drawing.Size(45, 17);
            this.txtUserRole.TabIndex = 10;
            this.txtUserRole.Text = "Agent";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 100);
            this.panel5.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(57, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "eRent";
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(227, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1183, 762);
            this.panelChildForm.TabIndex = 7;
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 762);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIndex";
            this.panel1.ResumeLayout(false);
            this.panelMainMenu.ResumeLayout(false);
            this.panelMainMenu.PerformLayout();
            this.panelPonudeSubMenu.ResumeLayout(false);
            this.panelKorisniciSubMenu.ResumeLayout(false);
            this.panelUposleniciSubmenu.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUposlenici;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Label txtUserRole;
        private System.Windows.Forms.Label txtUserFullName;
        private System.Windows.Forms.Button btnNoviUposlenik;
        private System.Windows.Forms.Button btnListaUposlenika;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Panel panelUposleniciSubmenu;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Panel panelPonudeSubMenu;
        private System.Windows.Forms.Button btnListaPonuda;
        private System.Windows.Forms.Button btnNovaPonuda;
        private System.Windows.Forms.Button btnPonude;
        private System.Windows.Forms.Panel panelKorisniciSubMenu;
        private System.Windows.Forms.Button btnUplate;
        private System.Windows.Forms.Button btnPoruke;
        private System.Windows.Forms.Button btnListaKorisnika;
        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Label label1;
    }
}



