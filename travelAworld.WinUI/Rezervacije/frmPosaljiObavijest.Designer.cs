namespace travelAworld.WinUI.Rezervacije
{
    partial class frmPosaljiObavijest
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
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPonudaNaziv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPonudaText = new System.Windows.Forms.RichTextBox();
            this.btnSaveForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 60);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(50, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nova obavijest";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::travelAworld.WinUI.Properties.Resources.icons8_chat_24;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 29);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "Slanje obavijesti za korisnike putovanja";
            // 
            // txtPonudaNaziv
            // 
            this.txtPonudaNaziv.AutoSize = true;
            this.txtPonudaNaziv.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPonudaNaziv.Location = new System.Drawing.Point(406, 73);
            this.txtPonudaNaziv.Name = "txtPonudaNaziv";
            this.txtPonudaNaziv.Size = new System.Drawing.Size(102, 23);
            this.txtPonudaNaziv.TabIndex = 39;
            this.txtPonudaNaziv.Text = "Putovanje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tekst obavijesti";
            // 
            // txtPonudaText
            // 
            this.txtPonudaText.Location = new System.Drawing.Point(16, 159);
            this.txtPonudaText.Name = "txtPonudaText";
            this.txtPonudaText.Size = new System.Drawing.Size(466, 265);
            this.txtPonudaText.TabIndex = 42;
            this.txtPonudaText.Text = "";
            // 
            // btnSaveForm
            // 
            this.btnSaveForm.BackColor = System.Drawing.Color.Green;
            this.btnSaveForm.FlatAppearance.BorderSize = 0;
            this.btnSaveForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveForm.Location = new System.Drawing.Point(304, 450);
            this.btnSaveForm.Name = "btnSaveForm";
            this.btnSaveForm.Size = new System.Drawing.Size(178, 44);
            this.btnSaveForm.TabIndex = 43;
            this.btnSaveForm.Text = "Pošalji";
            this.btnSaveForm.UseVisualStyleBackColor = false;
            this.btnSaveForm.Click += new System.EventHandler(this.btnSaveForm_Click);
            // 
            // frmPosaljiObavijest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 564);
            this.Controls.Add(this.btnSaveForm);
            this.Controls.Add(this.txtPonudaText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPonudaNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmPosaljiObavijest";
            this.Text = "frmPosaljiObavijest";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtPonudaNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtPonudaText;
        private System.Windows.Forms.Button btnSaveForm;
    }
}