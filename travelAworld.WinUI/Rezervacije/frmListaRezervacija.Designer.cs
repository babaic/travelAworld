namespace travelAworld.WinUI.Rezervacije
{
    partial class frmListaRezervacija
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
            this.pretragaPonuda = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPonudeUsers = new System.Windows.Forms.DataGridView();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtUkupno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPageCounter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPosaljiObavijest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pretragaDatum = new System.Windows.Forms.DateTimePicker();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonudeUsers)).BeginInit();
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
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Rezervacije";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ponuda";
            // 
            // pretragaPonuda
            // 
            this.pretragaPonuda.FormattingEnabled = true;
            this.pretragaPonuda.Items.AddRange(new object[] {
            "Bilo koja"});
            this.pretragaPonuda.Location = new System.Drawing.Point(110, 82);
            this.pretragaPonuda.Name = "pretragaPonuda";
            this.pretragaPonuda.Size = new System.Drawing.Size(172, 24);
            this.pretragaPonuda.TabIndex = 36;
            this.pretragaPonuda.SelectedIndexChanged += new System.EventHandler(this.pretragaPonuda_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPonudeUsers);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1157, 575);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervacije";
            // 
            // dgvPonudeUsers
            // 
            this.dgvPonudeUsers.AllowUserToAddRows = false;
            this.dgvPonudeUsers.AllowUserToDeleteRows = false;
            this.dgvPonudeUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonudeUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPonudeUsers.Location = new System.Drawing.Point(3, 18);
            this.dgvPonudeUsers.Name = "dgvPonudeUsers";
            this.dgvPonudeUsers.ReadOnly = true;
            this.dgvPonudeUsers.RowHeadersWidth = 51;
            this.dgvPonudeUsers.RowTemplate.Height = 24;
            this.dgvPonudeUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPonudeUsers.Size = new System.Drawing.Size(1151, 554);
            this.dgvPonudeUsers.TabIndex = 0;
            this.dgvPonudeUsers.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPonudeUsers_CellMouseDoubleClick);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrevious.Location = new System.Drawing.Point(1010, 717);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 44;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtUkupno
            // 
            this.txtUkupno.AutoSize = true;
            this.txtUkupno.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.txtUkupno.Location = new System.Drawing.Point(104, 718);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(0, 20);
            this.txtUkupno.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label4.Location = new System.Drawing.Point(12, 718);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Ukupno:";
            // 
            // txtPageCounter
            // 
            this.txtPageCounter.AutoSize = true;
            this.txtPageCounter.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.txtPageCounter.Location = new System.Drawing.Point(964, 718);
            this.txtPageCounter.Name = "txtPageCounter";
            this.txtPageCounter.Size = new System.Drawing.Size(17, 20);
            this.txtPageCounter.TabIndex = 41;
            this.txtPageCounter.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label3.Location = new System.Drawing.Point(868, 718);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Stranica:";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNext.Location = new System.Drawing.Point(1091, 717);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 39;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPosaljiObavijest
            // 
            this.btnPosaljiObavijest.BackColor = System.Drawing.Color.Green;
            this.btnPosaljiObavijest.FlatAppearance.BorderSize = 0;
            this.btnPosaljiObavijest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosaljiObavijest.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPosaljiObavijest.Location = new System.Drawing.Point(297, 74);
            this.btnPosaljiObavijest.Name = "btnPosaljiObavijest";
            this.btnPosaljiObavijest.Size = new System.Drawing.Size(130, 38);
            this.btnPosaljiObavijest.TabIndex = 45;
            this.btnPosaljiObavijest.Text = "Pošalji obavijest";
            this.btnPosaljiObavijest.UseVisualStyleBackColor = false;
            this.btnPosaljiObavijest.Click += new System.EventHandler(this.btnPosaljiObavijest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label2.Location = new System.Drawing.Point(465, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Mjesec rezervacije";
            // 
            // pretragaDatum
            // 
            this.pretragaDatum.Location = new System.Drawing.Point(666, 84);
            this.pretragaDatum.Name = "pretragaDatum";
            this.pretragaDatum.Size = new System.Drawing.Size(249, 22);
            this.pretragaDatum.TabIndex = 46;
            this.pretragaDatum.ValueChanged += new System.EventHandler(this.datumChanged);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.BackColor = System.Drawing.Color.Green;
            this.btnPrintaj.FlatAppearance.BorderSize = 0;
            this.btnPrintaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintaj.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrintaj.Location = new System.Drawing.Point(1082, 76);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(84, 37);
            this.btnPrintaj.TabIndex = 48;
            this.btnPrintaj.Text = "Isprintaj";
            this.btnPrintaj.UseVisualStyleBackColor = false;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // frmListaRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 762);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pretragaDatum);
            this.Controls.Add(this.btnPosaljiObavijest);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPageCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pretragaPonuda);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaRezervacija";
            this.Text = "frmListaRezervacija";
            this.Load += new System.EventHandler(this.frmListaRezervacija_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonudeUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pretragaPonuda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPonudeUsers;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label txtUkupno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtPageCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPosaljiObavijest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker pretragaDatum;
        private System.Windows.Forms.Button btnPrintaj;
    }
}