﻿namespace travelAworld.WinUI.Ponude
{
    partial class frmListaPonuda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPonude = new System.Windows.Forms.DataGridView();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtUkupno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPageCounter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.pretragaDrzava = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pretragaDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPretragaPonisti = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonude)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1183, 60);
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
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lista ponuda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::travelAworld.WinUI.Properties.Resources.icons8_airplane_mode_on_24__1_;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 29);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPonude);
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1157, 575);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ponude";
            // 
            // dgvPonude
            // 
            this.dgvPonude.AllowUserToAddRows = false;
            this.dgvPonude.AllowUserToDeleteRows = false;
            this.dgvPonude.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPonude.Location = new System.Drawing.Point(3, 18);
            this.dgvPonude.Name = "dgvPonude";
            this.dgvPonude.ReadOnly = true;
            this.dgvPonude.RowHeadersWidth = 51;
            this.dgvPonude.RowTemplate.Height = 24;
            this.dgvPonude.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPonude.Size = new System.Drawing.Size(1151, 554);
            this.dgvPonude.TabIndex = 0;
            this.dgvPonude.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPonude_CellDoubleClick);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrevious.Location = new System.Drawing.Point(1009, 724);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 33;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // txtUkupno
            // 
            this.txtUkupno.AutoSize = true;
            this.txtUkupno.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.txtUkupno.Location = new System.Drawing.Point(103, 725);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(0, 22);
            this.txtUkupno.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label4.Location = new System.Drawing.Point(11, 725);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ukupno:";
            // 
            // txtPageCounter
            // 
            this.txtPageCounter.AutoSize = true;
            this.txtPageCounter.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.txtPageCounter.Location = new System.Drawing.Point(963, 725);
            this.txtPageCounter.Name = "txtPageCounter";
            this.txtPageCounter.Size = new System.Drawing.Size(21, 22);
            this.txtPageCounter.TabIndex = 30;
            this.txtPageCounter.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label3.Location = new System.Drawing.Point(867, 725);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Stranica:";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNext.Location = new System.Drawing.Point(1090, 724);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // pretragaDrzava
            // 
            this.pretragaDrzava.FormattingEnabled = true;
            this.pretragaDrzava.Items.AddRange(new object[] {
            "Bilo koja"});
            this.pretragaDrzava.Location = new System.Drawing.Point(100, 93);
            this.pretragaDrzava.Name = "pretragaDrzava";
            this.pretragaDrzava.Size = new System.Drawing.Size(121, 24);
            this.pretragaDrzava.TabIndex = 34;
            this.pretragaDrzava.SelectedIndexChanged += new System.EventHandler(this.drzavaChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label1.Location = new System.Drawing.Point(17, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 35;
            this.label1.Text = "Država";
            // 
            // pretragaDatum
            // 
            this.pretragaDatum.Location = new System.Drawing.Point(409, 95);
            this.pretragaDatum.Name = "pretragaDatum";
            this.pretragaDatum.Size = new System.Drawing.Size(200, 22);
            this.pretragaDatum.TabIndex = 36;
            this.pretragaDatum.ValueChanged += new System.EventHandler(this.datumChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label2.Location = new System.Drawing.Point(245, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "Datum polaska";
            // 
            // btnPretragaPonisti
            // 
            this.btnPretragaPonisti.BackColor = System.Drawing.Color.Maroon;
            this.btnPretragaPonisti.FlatAppearance.BorderSize = 0;
            this.btnPretragaPonisti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretragaPonisti.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPretragaPonisti.Location = new System.Drawing.Point(651, 95);
            this.btnPretragaPonisti.Name = "btnPretragaPonisti";
            this.btnPretragaPonisti.Size = new System.Drawing.Size(75, 23);
            this.btnPretragaPonisti.TabIndex = 38;
            this.btnPretragaPonisti.Text = "Poništi";
            this.btnPretragaPonisti.UseVisualStyleBackColor = false;
            this.btnPretragaPonisti.Click += new System.EventHandler(this.btnPretragaPonisti_Click);
            // 
            // frmListaPonuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 762);
            this.Controls.Add(this.btnPretragaPonisti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pretragaDatum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pretragaDrzava);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPageCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaPonuda";
            this.Text = "frmListaPonuda";
            this.Load += new System.EventHandler(this.frmListaPonuda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPonude;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label txtUkupno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtPageCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox pretragaDrzava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker pretragaDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPretragaPonisti;
    }
}