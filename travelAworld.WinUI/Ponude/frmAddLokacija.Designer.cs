namespace travelAworld.WinUI.Ponude
{
    partial class frmAddLokacija
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
            this.txtMjesto = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.Label();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(460, 60);
            this.panel1.TabIndex = 16;
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
            this.formTitle.Size = new System.Drawing.Size(138, 22);
            this.formTitle.TabIndex = 1;
            this.formTitle.Text = "Dodaj lokaciju";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::travelAworld.WinUI.Properties.Resources.icons8_airplane_mode_on_24;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 29);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtMjesto
            // 
            this.txtMjesto.Location = new System.Drawing.Point(182, 84);
            this.txtMjesto.Name = "txtMjesto";
            this.txtMjesto.Size = new System.Drawing.Size(207, 22);
            this.txtMjesto.TabIndex = 6;
            // 
            // txtNaziv
            // 
            this.txtNaziv.AutoSize = true;
            this.txtNaziv.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.txtNaziv.Location = new System.Drawing.Point(12, 82);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(125, 22);
            this.txtNaziv.TabIndex = 7;
            this.txtNaziv.Text = "Mjesto/Grad";
            // 
            // txtDrzava
            // 
            this.txtDrzava.Location = new System.Drawing.Point(182, 142);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(207, 22);
            this.txtDrzava.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Država";
            // 
            // btnSaveForm
            // 
            this.btnSaveForm.BackColor = System.Drawing.Color.Green;
            this.btnSaveForm.FlatAppearance.BorderSize = 0;
            this.btnSaveForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveForm.Location = new System.Drawing.Point(182, 197);
            this.btnSaveForm.Name = "btnSaveForm";
            this.btnSaveForm.Size = new System.Drawing.Size(178, 44);
            this.btnSaveForm.TabIndex = 24;
            this.btnSaveForm.Text = "Dodaj";
            this.btnSaveForm.UseVisualStyleBackColor = false;
            this.btnSaveForm.Click += new System.EventHandler(this.btnSaveForm_Click);
            // 
            // frmAddLokacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.btnSaveForm);
            this.Controls.Add(this.txtDrzava);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMjesto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmAddLokacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddLokacija";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMjesto;
        private System.Windows.Forms.Label txtNaziv;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveForm;
    }
}