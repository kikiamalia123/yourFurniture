namespace You_furniture
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputBarang = new System.Windows.Forms.ComboBox();
            this.inputJumlah = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jumlah = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.ListBox();
            this.tambah = new System.Windows.Forms.Button();
            this.beli = new System.Windows.Forms.Button();
            this.kembali = new System.Windows.Forms.Button();
            this.transaksi = new System.Windows.Forms.Button();
            this.warnaBarang = new System.Windows.Forms.Label();
            this.inputWarna = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataBarang,
            this.deskripsi,
            this.harga});
            this.dataGridView1.Location = new System.Drawing.Point(14, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(560, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataBarang
            // 
            this.dataBarang.HeaderText = "Barang";
            this.dataBarang.MinimumWidth = 6;
            this.dataBarang.Name = "dataBarang";
            this.dataBarang.Width = 150;
            // 
            // deskripsi
            // 
            this.deskripsi.HeaderText = "Deskripsi";
            this.deskripsi.MinimumWidth = 6;
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Width = 200;
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga";
            this.harga.MinimumWidth = 6;
            this.harga.Name = "harga";
            this.harga.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.jumlahBarang,
            this.totalBarang});
            this.dataGridView2.Location = new System.Drawing.Point(634, 16);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(445, 357);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Barang";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // jumlahBarang
            // 
            this.jumlahBarang.HeaderText = "Jumlah Barang";
            this.jumlahBarang.MinimumWidth = 6;
            this.jumlahBarang.Name = "jumlahBarang";
            this.jumlahBarang.Width = 125;
            // 
            // totalBarang
            // 
            this.totalBarang.HeaderText = "Total Harga";
            this.totalBarang.MinimumWidth = 6;
            this.totalBarang.Name = "totalBarang";
            this.totalBarang.Width = 125;
            // 
            // inputBarang
            // 
            this.inputBarang.FormattingEnabled = true;
            this.inputBarang.Location = new System.Drawing.Point(14, 472);
            this.inputBarang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputBarang.Name = "inputBarang";
            this.inputBarang.Size = new System.Drawing.Size(179, 28);
            this.inputBarang.TabIndex = 2;
            // 
            // inputJumlah
            // 
            this.inputJumlah.Location = new System.Drawing.Point(14, 604);
            this.inputJumlah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputJumlah.Name = "inputJumlah";
            this.inputJumlah.Size = new System.Drawing.Size(179, 27);
            this.inputJumlah.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "masukkan barang yang ingin dibeli";
            // 
            // jumlah
            // 
            this.jumlah.AutoSize = true;
            this.jumlah.Location = new System.Drawing.Point(14, 580);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(183, 20);
            this.jumlah.TabIndex = 5;
            this.jumlah.Text = "jumlah barang yang dibeli";
            // 
            // total
            // 
            this.total.FormattingEnabled = true;
            this.total.ItemHeight = 20;
            this.total.Location = new System.Drawing.Point(295, 472);
            this.total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(137, 44);
            this.total.TabIndex = 6;
            // 
            // tambah
            // 
            this.tambah.Location = new System.Drawing.Point(295, 544);
            this.tambah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(104, 31);
            this.tambah.TabIndex = 7;
            this.tambah.Text = "Tambahkan";
            this.tambah.UseVisualStyleBackColor = true;
            // 
            // beli
            // 
            this.beli.Location = new System.Drawing.Point(295, 604);
            this.beli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.beli.Name = "beli";
            this.beli.Size = new System.Drawing.Size(104, 31);
            this.beli.TabIndex = 8;
            this.beli.Text = "Beli";
            this.beli.UseVisualStyleBackColor = true;
            // 
            // kembali
            // 
            this.kembali.Location = new System.Drawing.Point(879, 580);
            this.kembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kembali.Name = "kembali";
            this.kembali.Size = new System.Drawing.Size(104, 31);
            this.kembali.TabIndex = 9;
            this.kembali.Text = "Kembali";
            this.kembali.UseVisualStyleBackColor = true;
            this.kembali.Click += new System.EventHandler(this.kembali_Click);
            // 
            // transaksi
            // 
            this.transaksi.Location = new System.Drawing.Point(735, 580);
            this.transaksi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.transaksi.Name = "transaksi";
            this.transaksi.Size = new System.Drawing.Size(107, 31);
            this.transaksi.TabIndex = 10;
            this.transaksi.Text = "Data Transaksi";
            this.transaksi.UseVisualStyleBackColor = true;
            this.transaksi.Click += new System.EventHandler(this.transaksi_Click);
            // 
            // warnaBarang
            // 
            this.warnaBarang.AutoSize = true;
            this.warnaBarang.Location = new System.Drawing.Point(14, 507);
            this.warnaBarang.Name = "warnaBarang";
            this.warnaBarang.Size = new System.Drawing.Size(100, 20);
            this.warnaBarang.TabIndex = 11;
            this.warnaBarang.Text = "warna barang";
            // 
            // inputWarna
            // 
            this.inputWarna.Location = new System.Drawing.Point(14, 531);
            this.inputWarna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputWarna.Name = "inputWarna";
            this.inputWarna.Size = new System.Drawing.Size(179, 27);
            this.inputWarna.TabIndex = 12;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 681);
            this.Controls.Add(this.inputWarna);
            this.Controls.Add(this.warnaBarang);
            this.Controls.Add(this.transaksi);
            this.Controls.Add(this.kembali);
            this.Controls.Add(this.beli);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.total);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputJumlah);
            this.Controls.Add(this.inputBarang);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn jumlahBarang;
        private DataGridViewTextBoxColumn totalBarang;
        private ComboBox inputBarang;
        private TextBox inputJumlah;
        private Label label1;
        private Label jumlah;
        private ListBox total;
        private Button tambah;
        private Button beli;
        private Button kembali;
        private Button transaksi;
        private Label warnaBarang;
        private TextBox inputWarna;
        private DataGridViewTextBoxColumn dataBarang;
        private DataGridViewTextBoxColumn deskripsi;
        private DataGridViewTextBoxColumn harga;
    }
}