namespace Percetakan
{
    partial class Transaksi
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKertas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericJumlah = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKertas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbKategori = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTanggal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.lbTelp = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericJumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(236, 78);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(294, 24);
            this.cbKategori.TabIndex = 1;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pilihan Kertas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbKertas
            // 
            this.cbKertas.FormattingEnabled = true;
            this.cbKertas.Location = new System.Drawing.Point(236, 141);
            this.cbKertas.Name = "cbKertas";
            this.cbKertas.Size = new System.Drawing.Size(294, 24);
            this.cbKertas.TabIndex = 3;
            this.cbKertas.SelectedIndexChanged += new System.EventHandler(this.cbKertas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jumlah";
            // 
            // numericJumlah
            // 
            this.numericJumlah.Location = new System.Drawing.Point(236, 247);
            this.numericJumlah.Name = "numericJumlah";
            this.numericJumlah.Size = new System.Drawing.Size(120, 22);
            this.numericJumlah.TabIndex = 7;
            this.numericJumlah.ValueChanged += new System.EventHandler(this.numericJumlah_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Harga";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(236, 275);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(120, 22);
            this.tbHarga.TabIndex = 9;
            this.tbHarga.TextChanged += new System.EventHandler(this.tbHarga_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Harga Kertas";
            // 
            // tbKertas
            // 
            this.tbKertas.Location = new System.Drawing.Point(236, 172);
            this.tbKertas.Name = "tbKertas";
            this.tbKertas.Size = new System.Drawing.Size(294, 22);
            this.tbKertas.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Harga Kategori";
            // 
            // tbKategori
            // 
            this.tbKategori.Location = new System.Drawing.Point(236, 110);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(294, 22);
            this.tbKategori.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tanggal Transaksi";
            // 
            // tbTanggal
            // 
            this.tbTanggal.Location = new System.Drawing.Point(236, 201);
            this.tbTanggal.Name = "tbTanggal";
            this.tbTanggal.Size = new System.Drawing.Size(120, 22);
            this.tbTanggal.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nama";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(233, 48);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(55, 16);
            this.lbNama.TabIndex = 19;
            this.lbNama.Text = "lbNama";
            // 
            // lbTelp
            // 
            this.lbTelp.AutoSize = true;
            this.lbTelp.Location = new System.Drawing.Point(486, 48);
            this.lbTelp.Name = "lbTelp";
            this.lbTelp.Size = new System.Drawing.Size(44, 16);
            this.lbTelp.TabIndex = 21;
            this.lbTelp.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(404, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Telepon";
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.lbTelp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbNama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTanggal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbKategori);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbKertas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericJumlah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbKertas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.label1);
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericJumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKertas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericJumlah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKertas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbKategori;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTanggal;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lbNama;
        public System.Windows.Forms.Label lbTelp;
        private System.Windows.Forms.Label label10;
    }
}

