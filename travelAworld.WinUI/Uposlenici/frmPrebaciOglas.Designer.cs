
namespace travelAworld.WinUI.Uposlenici
{
    partial class frmPrebaciOglas
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
            this.cbOglasi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUposlenik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbOglasi
            // 
            this.cbOglasi.FormattingEnabled = true;
            this.cbOglasi.Location = new System.Drawing.Point(12, 39);
            this.cbOglasi.Name = "cbOglasi";
            this.cbOglasi.Size = new System.Drawing.Size(264, 24);
            this.cbOglasi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberi oglas";
            // 
            // cbUposlenik
            // 
            this.cbUposlenik.FormattingEnabled = true;
            this.cbUposlenik.Location = new System.Drawing.Point(12, 99);
            this.cbUposlenik.Name = "cbUposlenik";
            this.cbUposlenik.Size = new System.Drawing.Size(264, 24);
            this.cbUposlenik.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odaberi korisnika";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Prebaci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPrebaciOglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 229);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbUposlenik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOglasi);
            this.Name = "frmPrebaciOglas";
            this.Text = "frmPrebaciOglas";
            this.Load += new System.EventHandler(this.frmPrebaciOglas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOglasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUposlenik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}