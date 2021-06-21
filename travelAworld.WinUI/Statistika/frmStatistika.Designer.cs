namespace travelAworld.WinUI.Statistika
{
    partial class frmStatistika
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrKorisnika = new System.Windows.Forms.Label();
            this.txtBrIzdatihStanova = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBrUgovori = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBrTotalStanovi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Cross;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 144);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(411, 209);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 60);
            this.panel1.TabIndex = 17;
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
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Statistika";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::travelAworld.WinUI.Properties.Resources.icons8_bar_chart_24;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 29);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 33);
            this.label1.TabIndex = 38;
            this.label1.Text = "TOP 3 nekretnine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(482, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 33);
            this.label2.TabIndex = 39;
            this.label2.Text = "Broj korisnika";
            // 
            // txtBrKorisnika
            // 
            this.txtBrKorisnika.AutoSize = true;
            this.txtBrKorisnika.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrKorisnika.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBrKorisnika.Location = new System.Drawing.Point(482, 144);
            this.txtBrKorisnika.Name = "txtBrKorisnika";
            this.txtBrKorisnika.Size = new System.Drawing.Size(60, 33);
            this.txtBrKorisnika.TabIndex = 40;
            this.txtBrKorisnika.Text = "128";
            // 
            // txtBrIzdatihStanova
            // 
            this.txtBrIzdatihStanova.AutoSize = true;
            this.txtBrIzdatihStanova.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrIzdatihStanova.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBrIzdatihStanova.Location = new System.Drawing.Point(826, 144);
            this.txtBrIzdatihStanova.Name = "txtBrIzdatihStanova";
            this.txtBrIzdatihStanova.Size = new System.Drawing.Size(30, 33);
            this.txtBrIzdatihStanova.TabIndex = 42;
            this.txtBrIzdatihStanova.Text = "7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(826, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 33);
            this.label6.TabIndex = 41;
            this.label6.Text = "Trenutno izdatih stanova";
            // 
            // txtBrUgovori
            // 
            this.txtBrUgovori.AutoSize = true;
            this.txtBrUgovori.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrUgovori.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBrUgovori.Location = new System.Drawing.Point(482, 313);
            this.txtBrUgovori.Name = "txtBrUgovori";
            this.txtBrUgovori.Size = new System.Drawing.Size(60, 33);
            this.txtBrUgovori.TabIndex = 44;
            this.txtBrUgovori.Text = "128";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(482, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 33);
            this.label8.TabIndex = 43;
            this.label8.Text = "Zaključenih ugovora";
            // 
            // txtBrTotalStanovi
            // 
            this.txtBrTotalStanovi.AutoSize = true;
            this.txtBrTotalStanovi.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrTotalStanovi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBrTotalStanovi.Location = new System.Drawing.Point(826, 313);
            this.txtBrTotalStanovi.Name = "txtBrTotalStanovi";
            this.txtBrTotalStanovi.Size = new System.Drawing.Size(60, 33);
            this.txtBrTotalStanovi.TabIndex = 46;
            this.txtBrTotalStanovi.Text = "128";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(826, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(321, 33);
            this.label10.TabIndex = 45;
            this.label10.Text = "Ukupno izdatih stanova";
            // 
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 715);
            this.Controls.Add(this.txtBrTotalStanovi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBrUgovori);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBrIzdatihStanova);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBrKorisnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStatistika";
            this.Text = "frmStatistika";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtBrKorisnika;
        private System.Windows.Forms.Label txtBrIzdatihStanova;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtBrUgovori;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtBrTotalStanovi;
        private System.Windows.Forms.Label label10;
    }
}