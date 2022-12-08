namespace You_furniture
{
    partial class Form7
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
            this.dataBarang = new System.Windows.Forms.DataGridView();
            this.barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box_barang = new System.Windows.Forms.ComboBox();
            this.text_warna = new System.Windows.Forms.TextBox();
            this.text_jumlah = new System.Windows.Forms.TextBox();
            this.total_harga = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tambah = new System.Windows.Forms.Button();
            this.beli = new System.Windows.Forms.Button();
            this.transaksi = new System.Windows.Forms.Button();
            this.kembali = new System.Windows.Forms.Button();
            this.tabelpesanan = new System.Windows.Forms.DataGridView();
            this.namaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelpesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBarang
            // 
            this.dataBarang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barang,
            this.deskripsi,
            this.harga});
            this.dataBarang.Location = new System.Drawing.Point(38, 76);
            this.dataBarang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataBarang.Name = "dataBarang";
            this.dataBarang.RowHeadersWidth = 51;
            this.dataBarang.RowTemplate.Height = 25;
            this.dataBarang.Size = new System.Drawing.Size(464, 299);
            this.dataBarang.TabIndex = 0;
            // 
            // barang
            // 
            this.barang.HeaderText = "barang";
            this.barang.MinimumWidth = 6;
            this.barang.Name = "barang";
            this.barang.Width = 125;
            // 
            // deskripsi
            // 
            this.deskripsi.HeaderText = "deskripsi";
            this.deskripsi.MinimumWidth = 6;
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Width = 125;
            // 
            // harga
            // 
            this.harga.HeaderText = "harga";
            this.harga.MinimumWidth = 6;
            this.harga.Name = "harga";
            this.harga.Width = 125;
            // 
            // box_barang
            // 
            this.box_barang.FormattingEnabled = true;
            this.box_barang.Location = new System.Drawing.Point(38, 424);
            this.box_barang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_barang.Name = "box_barang";
            this.box_barang.Size = new System.Drawing.Size(464, 28);
            this.box_barang.TabIndex = 2;
            // 
            // text_warna
            // 
            this.text_warna.Location = new System.Drawing.Point(38, 486);
            this.text_warna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_warna.Name = "text_warna";
            this.text_warna.Size = new System.Drawing.Size(464, 27);
            this.text_warna.TabIndex = 3;
            // 
            // text_jumlah
            // 
            this.text_jumlah.Location = new System.Drawing.Point(38, 547);
            this.text_jumlah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_jumlah.Name = "text_jumlah";
            this.text_jumlah.Size = new System.Drawing.Size(464, 27);
            this.text_jumlah.TabIndex = 4;
            // 
            // total_harga
            // 
            this.total_harga.FormattingEnabled = true;
            this.total_harga.ItemHeight = 20;
            this.total_harga.Location = new System.Drawing.Point(529, 424);
            this.total_harga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.total_harga.Name = "total_harga";
            this.total_harga.Size = new System.Drawing.Size(440, 84);
            this.total_harga.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(38, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(38, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "warna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(38, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "jumlah";
            // 
            // tambah
            // 
            this.tambah.BackColor = System.Drawing.Color.DarkOrange;
            this.tambah.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tambah.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tambah.Location = new System.Drawing.Point(529, 538);
            this.tambah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(137, 36);
            this.tambah.TabIndex = 9;
            this.tambah.Text = "tambahkan";
            this.tambah.UseVisualStyleBackColor = false;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // beli
            // 
            this.beli.BackColor = System.Drawing.Color.DarkOrange;
            this.beli.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.beli.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.beli.Location = new System.Drawing.Point(686, 538);
            this.beli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.beli.Name = "beli";
            this.beli.Size = new System.Drawing.Size(137, 36);
            this.beli.TabIndex = 10;
            this.beli.Text = "beli";
            this.beli.UseVisualStyleBackColor = false;
            this.beli.Click += new System.EventHandler(this.beli_Click);
            // 
            // transaksi
            // 
            this.transaksi.BackColor = System.Drawing.Color.DarkOrange;
            this.transaksi.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transaksi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transaksi.Location = new System.Drawing.Point(836, 538);
            this.transaksi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.transaksi.Name = "transaksi";
            this.transaksi.Size = new System.Drawing.Size(133, 36);
            this.transaksi.TabIndex = 11;
            this.transaksi.Text = "transaksi";
            this.transaksi.UseVisualStyleBackColor = false;
            this.transaksi.Click += new System.EventHandler(this.transaksi_Click);
            // 
            // kembali
            // 
            this.kembali.BackColor = System.Drawing.Color.DarkOrange;
            this.kembali.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kembali.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kembali.Location = new System.Drawing.Point(38, 600);
            this.kembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kembali.Name = "kembali";
            this.kembali.Size = new System.Drawing.Size(931, 43);
            this.kembali.TabIndex = 12;
            this.kembali.Text = "kembali";
            this.kembali.UseVisualStyleBackColor = false;
            this.kembali.Click += new System.EventHandler(this.kembali_Click);
            // 
            // tabelpesanan
            // 
            this.tabelpesanan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabelpesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelpesanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaBarang,
            this.jumlah});
            this.tabelpesanan.Location = new System.Drawing.Point(529, 76);
            this.tabelpesanan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabelpesanan.Name = "tabelpesanan";
            this.tabelpesanan.RowHeadersWidth = 51;
            this.tabelpesanan.RowTemplate.Height = 25;
            this.tabelpesanan.Size = new System.Drawing.Size(440, 299);
            this.tabelpesanan.TabIndex = 1;
            // 
            // namaBarang
            // 
            this.namaBarang.HeaderText = "barang";
            this.namaBarang.MinimumWidth = 6;
            this.namaBarang.Name = "namaBarang";
            this.namaBarang.Width = 125;
            // 
            // jumlah
            // 
            this.jumlah.HeaderText = "jumlah";
            this.jumlah.MinimumWidth = 6;
            this.jumlah.Name = "jumlah";
            this.jumlah.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::You_furniture.Properties.Resources._21;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1010, 683);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 681);
            this.Controls.Add(this.kembali);
            this.Controls.Add(this.transaksi);
            this.Controls.Add(this.beli);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total_harga);
            this.Controls.Add(this.text_jumlah);
            this.Controls.Add(this.text_warna);
            this.Controls.Add(this.box_barang);
            this.Controls.Add(this.tabelpesanan);
            this.Controls.Add(this.dataBarang);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelpesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataBarang;
        private ComboBox box_barang;
        private TextBox text_warna;
        private TextBox text_jumlah;
        private ListBox total_harga;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button tambah;
        private Button beli;
        private Button transaksi;
        private Button kembali;
        private DataGridViewTextBoxColumn barang;
        private DataGridViewTextBoxColumn deskripsi;
        private DataGridViewTextBoxColumn harga;
        private DataGridView tabelpesanan;
        private DataGridViewTextBoxColumn namaBarang;
        private DataGridViewTextBoxColumn jumlah;
        private PictureBox pictureBox1;
    }
}