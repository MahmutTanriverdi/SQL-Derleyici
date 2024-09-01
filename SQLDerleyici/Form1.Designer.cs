namespace SQLDerleyici
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnCalistir = new System.Windows.Forms.Button();
            this.BtnEkleSilGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbVeritabani = new System.Windows.Forms.ComboBox();
            this.CmbTablolar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1165, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(825, 268);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // BtnCalistir
            // 
            this.BtnCalistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnCalistir.Location = new System.Drawing.Point(849, 191);
            this.BtnCalistir.Name = "BtnCalistir";
            this.BtnCalistir.Size = new System.Drawing.Size(279, 77);
            this.BtnCalistir.TabIndex = 2;
            this.BtnCalistir.Text = "ÇALIŞTIR";
            this.BtnCalistir.UseVisualStyleBackColor = false;
            this.BtnCalistir.Click += new System.EventHandler(this.BtnCalistir_Click);
            // 
            // BtnEkleSilGuncelle
            // 
            this.BtnEkleSilGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnEkleSilGuncelle.Location = new System.Drawing.Point(849, 274);
            this.BtnEkleSilGuncelle.Name = "BtnEkleSilGuncelle";
            this.BtnEkleSilGuncelle.Size = new System.Drawing.Size(279, 77);
            this.BtnEkleSilGuncelle.TabIndex = 3;
            this.BtnEkleSilGuncelle.Text = "EKLE - SİL - GÜNCELLE";
            this.BtnEkleSilGuncelle.UseVisualStyleBackColor = false;
            this.BtnEkleSilGuncelle.Click += new System.EventHandler(this.BtnEkleSilGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(845, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Veritabanı:";
            // 
            // CmbVeritabani
            // 
            this.CmbVeritabani.FormattingEnabled = true;
            this.CmbVeritabani.Location = new System.Drawing.Point(936, 83);
            this.CmbVeritabani.Name = "CmbVeritabani";
            this.CmbVeritabani.Size = new System.Drawing.Size(179, 26);
            this.CmbVeritabani.TabIndex = 5;
            this.CmbVeritabani.SelectedIndexChanged += new System.EventHandler(this.CmbVeritabani_SelectedIndexChanged);
            // 
            // CmbTablolar
            // 
            this.CmbTablolar.FormattingEnabled = true;
            this.CmbTablolar.Location = new System.Drawing.Point(936, 136);
            this.CmbTablolar.Name = "CmbTablolar";
            this.CmbTablolar.Size = new System.Drawing.Size(179, 26);
            this.CmbTablolar.TabIndex = 7;
            this.CmbTablolar.SelectedIndexChanged += new System.EventHandler(this.CmbTablolar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(861, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tablolar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(84, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(633, 52);
            this.label3.TabIndex = 9;
            this.label3.Text = "SQL VERİ TABANI ARAYÜZÜ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1166, 618);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CmbTablolar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbVeritabani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEkleSilGuncelle);
            this.Controls.Add(this.BtnCalistir);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnCalistir;
        private System.Windows.Forms.Button BtnEkleSilGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbVeritabani;
        private System.Windows.Forms.ComboBox CmbTablolar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

