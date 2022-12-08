namespace You_furniture
{
    partial class Form4
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
            this.tabelpesanan = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKasir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hapus = new System.Windows.Forms.Button();
            this.kembali = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabelpesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelpesanan
            // 
            this.tabelpesanan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabelpesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelpesanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.namaKasir,
            this.barang,
            this.warna,
            this.total});
            this.tabelpesanan.GridColor = System.Drawing.Color.DarkGray;
            this.tabelpesanan.Location = new System.Drawing.Point(43, 89);
            this.tabelpesanan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabelpesanan.Name = "tabelpesanan";
            this.tabelpesanan.RowHeadersWidth = 51;
            this.tabelpesanan.RowTemplate.Height = 25;
            this.tabelpesanan.Size = new System.Drawing.Size(918, 393);
            this.tabelpesanan.TabIndex = 0;
            this.tabelpesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelpesanan_CellContentClick);
            // 
            // no
            // 
            this.no.HeaderText = "No";
            this.no.MinimumWidth = 6;
            this.no.Name = "no";
            this.no.Width = 50;
            // 
            // namaKasir
            // 
            this.namaKasir.HeaderText = "Nama Kasir";
            this.namaKasir.MinimumWidth = 6;
            this.namaKasir.Name = "namaKasir";
            this.namaKasir.Width = 120;
            // 
            // barang
            // 
            this.barang.HeaderText = "Barang";
            this.barang.MinimumWidth = 6;
            this.barang.Name = "barang";
            this.barang.Width = 150;
            // 
            // warna
            // 
            this.warna.HeaderText = "Warna";
            this.warna.MinimumWidth = 6;
            this.warna.Name = "warna";
            this.warna.Width = 125;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 125;
            // 
            // hapus
            // 
            this.hapus.BackColor = System.Drawing.Color.DarkOrange;
            this.hapus.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hapus.Location = new System.Drawing.Point(43, 604);
            this.hapus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(205, 44);
            this.hapus.TabIndex = 1;
            this.hapus.Text = "Hapus";
            this.hapus.UseVisualStyleBackColor = false;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // kembali
            // 
            this.kembali.BackColor = System.Drawing.Color.DarkOrange;
            this.kembali.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kembali.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kembali.Location = new System.Drawing.Point(756, 604);
            this.kembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kembali.Name = "kembali";
            this.kembali.Size = new System.Drawing.Size(205, 44);
            this.kembali.TabIndex = 2;
            this.kembali.Text = "Kembali";
            this.kembali.UseVisualStyleBackColor = false;
            this.kembali.Click += new System.EventHandler(this.kembali_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(43, 543);
            this.id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(205, 27);
            this.id.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(43, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "No yang ingin dihapus";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::You_furniture.Properties.Resources._21;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1010, 681);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.kembali);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.tabelpesanan);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelpesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView tabelpesanan;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn namaKasir;
        private DataGridViewTextBoxColumn barang;
        private DataGridViewTextBoxColumn warna;
        private DataGridViewTextBoxColumn total;
        private Button hapus;
        private Button kembali;
        private TextBox id;
        private Label label1;
        private PictureBox pictureBox1;
    }
}