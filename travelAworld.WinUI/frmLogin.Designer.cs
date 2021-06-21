namespace travelAworld.WinUI
{
    partial class frmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.ispis = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorBox = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.errorBox.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 179);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "eRent";
            // 
            // ispis
            // 
            this.ispis.AutoSize = true;
            this.ispis.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ispis.Location = new System.Drawing.Point(29, 13);
            this.ispis.Name = "ispis";
            this.ispis.Size = new System.Drawing.Size(324, 23);
            this.ispis.TabIndex = 1;
            this.ispis.Text = "Pogrešno korisničko ime ili lozinka";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.errorBox);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 472);
            this.panel2.TabIndex = 1;
            // 
            // errorBox
            // 
            this.errorBox.BackColor = System.Drawing.Color.IndianRed;
            this.errorBox.Controls.Add(this.ispis);
            this.errorBox.Location = new System.Drawing.Point(219, 304);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(383, 52);
            this.errorBox.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPrijava);
            this.panel3.Controls.Add(this.labelPassword);
            this.panel3.Controls.Add(this.txtLoginPassword);
            this.panel3.Controls.Add(this.txtLoginUser);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtLoginUsername);
            this.panel3.Location = new System.Drawing.Point(219, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 291);
            this.panel3.TabIndex = 1;
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnPrijava.FlatAppearance.BorderSize = 0;
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrijava.Location = new System.Drawing.Point(71, 229);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(109, 48);
            this.btnPrijava.TabIndex = 14;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.login);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.labelPassword.Location = new System.Drawing.Point(71, 151);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(77, 22);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Lozinka";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(71, 185);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(232, 22);
            this.txtLoginPassword.TabIndex = 12;
            this.txtLoginPassword.Text = "123456a";
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.AutoSize = true;
            this.txtLoginUser.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.txtLoginUser.Location = new System.Drawing.Point(71, 77);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(135, 22);
            this.txtLoginUser.TabIndex = 11;
            this.txtLoginUser.Text = "Korisničko ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Prijava";
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Location = new System.Drawing.Point(71, 111);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(232, 22);
            this.txtLoginUsername.TabIndex = 9;
            this.txtLoginUsername.Text = "admin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::travelAworld.WinUI.Properties.Resources.o_sarajevu1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(831, 472);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.errorBox.ResumeLayout(false);
            this.errorBox.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label txtLoginUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.Label ispis;
        private System.Windows.Forms.Panel errorBox;
        private System.Windows.Forms.Label label2;
    }
}