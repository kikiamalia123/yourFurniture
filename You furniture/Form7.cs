using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace You_furniture
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private string[][] data_barang;
        private void Form7_Load(object sender, EventArgs e)
        {
            project project = new project();

            data_barang = project.getdata("select * from barang");

            foreach (string[] i in data_barang)
            {
                int indeks = dataBarang.Rows.Add();
                DataGridViewRow dataGridViewRow0 = dataBarang.Rows[indeks];

                dataGridViewRow0.Cells["barang"].Value = i[1];
                dataGridViewRow0.Cells["deskripsi"].Value = i[2];
                dataGridViewRow0.Cells["harga"].Value = i[3];

                box_barang.Items.Add(i[1]);
            }
        }

        private void kembali_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void transaksi_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private int totalharga;


        private void tabel_pesanan(string kolom_barang, string kolom_jumlah, string brg, string jml)
        {
            int indeks = tabelpesanan.Rows.Add();
            DataGridViewRow dataGridViewRow0 = tabelpesanan.Rows[indeks];

            dataGridViewRow0.Cells[kolom_barang].Value = brg;
            dataGridViewRow0.Cells[kolom_jumlah].Value = jml;
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            string? barang = Convert.ToString(box_barang.SelectedItem);
            string? warna = Convert.ToString(text_warna.Text);
            int jumlah = Convert.ToInt32(text_jumlah.Text);

            totalharga = 0;

            if (barang != "" && warna != "" && jumlah > 0)
            {

                tabel_pesanan("namaBarang", "jumlah", box_barang.Text, text_jumlah.Text);
                foreach (string[] i in data_barang)
                {
                    if (i[1] == barang)
                    {
                        totalharga += Convert.ToInt32(i[3]) * jumlah;
                    }
                }
                total_harga.Items.Add(Convert.ToInt32(totalharga));


            }
            else if (jumlah <= 0 )
            {
                MessageBox.Show("jumlah pesanan harus lebih dari 0", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("anda harus memilih pesanan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void setdatapesanan(string nama, string barang, int jmlBrg)
        {
            string query = $"insert into transaksi(nama_kasir, barang, warna, total_harga, jumlah_barang) values('{nama}', '{barang}', '{text_warna.Text}', {totalharga},{jmlBrg})";

            project project = new project();
            project.getdata(query);
        }

        private void beli_Click(object sender, EventArgs e)
        {
            if (tabelpesanan.Rows.Count != 0)
            {
                
                DialogResult dr = MessageBox.Show($"jumlah yang harus dibayar sebanyak {total_harga.Items[0]}", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string nama = Form2.f2.textb.Text;

                setdatapesanan(nama, Convert.ToString(box_barang.SelectedItem), Convert.ToInt32(text_jumlah.Text));

                box_barang.ResetText();
                text_warna.ResetText();
                text_jumlah.ResetText();

                tabelpesanan.Rows.Clear();
                total_harga.Items.Clear();

                if (dr == DialogResult.OK)
                {
                    Form4 form4 = new Form4();
                    this.Hide();
                    form4.Show();
                }
            }
            else
            {
                MessageBox.Show("anda harus memesan terlebih dahulu", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
