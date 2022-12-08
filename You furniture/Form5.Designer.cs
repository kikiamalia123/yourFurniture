namespace You_furniture
{
    partial class form_data_barang
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
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dd_aksi = new System.Windows.Forms.ComboBox();
            this.label_aksi = new System.Windows.Forms.Label();
            this.box_barang = new System.Windows.Forms.TextBox();
            this.box_deskripsi = new System.Windows.Forms.TextBox();
            this.box_harga = new System.Windows.Forms.TextBox();
            this.label_barang = new System.Windows.Forms.Label();
            this.label_deskripsi = new System.Windows.Forms.Label();
            this.label_harga = new System.Windows.Forms.Label();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.box_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBarang
            // 
            this.dataBarang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.barang,
            this.deskripsi,
            this.harga});
            this.dataBarang.Location = new System.Drawing.Point(41, 79);
            this.dataBarang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataBarang.Name = "dataBarang";
            this.dataBarang.RowHeadersWidth = 51;
            this.dataBarang.RowTemplate.Height = 25;
            this.dataBarang.Size = new System.Drawing.Size(912, 307);
            this.dataBarang.TabIndex = 0;
            // 
            // no
            // 
            this.no.HeaderText = "No";
            this.no.MinimumWidth = 6;
            this.no.Name = "no";
            this.no.Width = 50;
            // 
            // barang
            // 
            this.barang.HeaderText = "Barang";
            this.barang.MinimumWidth = 6;
            this.barang.Name = "barang";
            this.barang.Width = 150;
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
            // dd_aksi
            // 
            this.dd_aksi.FormattingEnabled = true;
            this.dd_aksi.Items.AddRange(new object[] {
            "Tambah",
            "Edit",
            "Hapus"});
            this.dd_aksi.Location = new System.Drawing.Point(41, 431);
            this.dd_aksi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dd_aksi.Name = "dd_aksi";
            this.dd_aksi.Size = new System.Drawing.Size(580, 28);
            this.dd_aksi.TabIndex = 1;
            this.dd_aksi.SelectedIndexChanged += new System.EventHandler(this.dd_aksi_SelectedIndexChanged);
            // 
            // label_aksi
            // 
            this.label_aksi.AutoSize = true;
            this.label_aksi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_aksi.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_aksi.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_aksi.Location = new System.Drawing.Point(41, 401);
            this.label_aksi.Name = "label_aksi";
            this.label_aksi.Size = new System.Drawing.Size(46, 26);
            this.label_aksi.TabIndex = 2;
            this.label_aksi.Text = "Aksi";
            // 
            // box_barang
            // 
            this.box_barang.Location = new System.Drawing.Point(344, 495);
            this.box_barang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_barang.Name = "box_barang";
            this.box_barang.Size = new System.Drawing.Size(277, 27);
            this.box_barang.TabIndex = 4;
            this.box_barang.TextChanged += new System.EventHandler(this.box_barang_TextChanged);
            // 
            // box_deskripsi
            // 
            this.box_deskripsi.Location = new System.Drawing.Point(41, 556);
            this.box_deskripsi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_deskripsi.Name = "box_deskripsi";
            this.box_deskripsi.Size = new System.Drawing.Size(580, 27);
            this.box_deskripsi.TabIndex = 5;
            // 
            // box_harga
            // 
            this.box_harga.Location = new System.Drawing.Point(41, 620);
            this.box_harga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_harga.Name = "box_harga";
            this.box_harga.Size = new System.Drawing.Size(580, 27);
            this.box_harga.TabIndex = 6;
            // 
            // label_barang
            // 
            this.label_barang.AutoSize = true;
            this.label_barang.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_barang.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_barang.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_barang.Location = new System.Drawing.Point(344, 465);
            this.label_barang.Name = "label_barang";
            this.label_barang.Size = new System.Drawing.Size(73, 26);
            this.label_barang.TabIndex = 8;
            this.label_barang.Text = "Barang";
            // 
            // label_deskripsi
            // 
            this.label_deskripsi.AutoSize = true;
            this.label_deskripsi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_deskripsi.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_deskripsi.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_deskripsi.Location = new System.Drawing.Point(41, 526);
            this.label_deskripsi.Name = "label_deskripsi";
            this.label_deskripsi.Size = new System.Drawing.Size(89, 26);
            this.label_deskripsi.TabIndex = 9;
            this.label_deskripsi.Text = "Deskripsi";
            this.label_deskripsi.Click += new System.EventHandler(this.label_deskripsi_Click);
            // 
            // label_harga
            // 
            this.label_harga.AutoSize = true;
            this.label_harga.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_harga.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_harga.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_harga.Location = new System.Drawing.Point(41, 590);
            this.label_harga.Name = "label_harga";
            this.label_harga.Size = new System.Drawing.Size(64, 26);
            this.label_harga.TabIndex = 10;
            this.label_harga.Text = "Harga";
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_tambah.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_tambah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_tambah.Location = new System.Drawing.Point(787, 431);
            this.btn_tambah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(166, 72);
            this.btn_tambah.TabIndex = 11;
            this.btn_tambah.Text = "tambah";
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_edit.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit.Location = new System.Drawing.Point(787, 511);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(166, 40);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.Text = "edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_hapus.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hapus.Location = new System.Drawing.Point(787, 559);
            this.btn_hapus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(166, 40);
            this.btn_hapus.TabIndex = 13;
            this.btn_hapus.Text = "hapus";
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_kembali
            // 
            this.btn_kembali.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_kembali.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_kembali.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_kembali.Location = new System.Drawing.Point(787, 607);
            this.btn_kembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(166, 40);
            this.btn_kembali.TabIndex = 14;
            this.btn_kembali.Text = "kembali";
            this.btn_kembali.UseVisualStyleBackColor = false;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // box_id
            // 
            this.box_id.Location = new System.Drawing.Point(41, 495);
            this.box_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box_id.Name = "box_id";
            this.box_id.Size = new System.Drawing.Size(277, 27);
            this.box_id.TabIndex = 15;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_id.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_id.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_id.Location = new System.Drawing.Point(41, 465);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(28, 26);
            this.label_id.TabIndex = 16;
            this.label_id.Text = "Id";
            this.label_id.Click += new System.EventHandler(this.label_id_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::You_furniture.Properties.Resources._21;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1011, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // form_data_barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 681);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.box_id);
            this.Controls.Add(this.btn_kembali);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.label_harga);
            this.Controls.Add(this.label_deskripsi);
            this.Controls.Add(this.label_barang);
            this.Controls.Add(this.box_harga);
            this.Controls.Add(this.box_deskripsi);
            this.Controls.Add(this.box_barang);
            this.Controls.Add(this.label_aksi);
            this.Controls.Add(this.dd_aksi);
            this.Controls.Add(this.dataBarang);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_data_barang";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.form_data_barang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataBarang;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn barang;
        private DataGridViewTextBoxColumn deskripsi;
        private DataGridViewTextBoxColumn harga;
        private ComboBox dd_aksi;
        private Label label_aksi;
        private TextBox box_barang;
        private TextBox box_deskripsi;
        private TextBox box_harga;
        private Label label_barang;
        private Label label_deskripsi;
        private Label label_harga;
        private Button btn_tambah;
        private Button btn_edit;
        private Button btn_hapus;
        private Button btn_kembali;
        private TextBox box_id;
        private Label label_id;
        private PictureBox pictureBox1;
    }
}