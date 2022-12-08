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
    public partial class Form4 : Form
    {
        private string delete_data;
        public Form4()
        {
            InitializeComponent();
        }

        private void kembali_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide();
            form7.Show();        
        }

        private string[][] datapesanan;
        private void loaddata()
        {
            string query = "select * from transaksi";

            project project = new project();
            datapesanan = project.getTransaksi(query);

            foreach (string[] i in datapesanan)
            {
                int indeks = tabelpesanan.Rows.Add();
                DataGridViewRow dataGridViewRow0 = tabelpesanan.Rows[indeks];

                dataGridViewRow0.Cells["no"].Value = i[0];
                dataGridViewRow0.Cells["namaKasir"].Value = i[1];
                dataGridViewRow0.Cells["barang"].Value = i[2];
                dataGridViewRow0.Cells["warna"].Value = i[3];
                dataGridViewRow0.Cells["total"].Value = i[4];
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void refresh()
        {
            tabelpesanan.Rows.Clear();
            id.Clear();
            loaddata();

        }
        private void hapus_Click(object sender, EventArgs e)
        {
            if (id.Text != "")
            {
                delete_data = $"delete from transaksi where id_transaksi={Convert.ToInt32(id.Text)}";

                project project = new project();
                project.getdata(delete_data);

                MessageBox.Show("Data berhasil dihapus", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            else
            {
                MessageBox.Show("Pilih jenis menu", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabelpesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
