using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace You_furniture
{
    public partial class form_data_barang : Form
    {
        public form_data_barang()
        {
            InitializeComponent();
        }
        private string insert_data;
        private string update_data;
        private string delete_data;
        
        private void showdata()
        {
            label_id.Hide();
            label_barang.Hide();
            label_deskripsi.Hide();
            label_harga.Hide();
            box_id.Hide();
            box_barang.Hide();
            box_deskripsi.Hide();
            box_harga.Hide();
            btn_tambah.Hide();
            btn_edit.Hide();
            btn_hapus.Hide();
        }
        private void adddata()
        {
            label_id.Hide();
            label_barang.Show();
            label_deskripsi.Show();
            label_harga.Show();
            box_id.Hide();
            box_barang.Show();
            box_deskripsi.Show();
            box_harga.Show();
            btn_tambah.Show();
            btn_edit.Hide();
            btn_hapus.Hide();
        }

        private void updatedata()
        {
            label_id.Show();
            label_barang.Show();
            label_deskripsi.Show();
            label_harga.Show();
            box_id.Show();
            box_barang.Show();
            box_deskripsi.Show();
            box_harga.Show();
            btn_tambah.Hide();
            btn_edit.Show();
            btn_hapus.Hide();
        }
        private void deletedata()
        {
            label_id.Show();
            label_barang.Hide();
            label_deskripsi.Hide();
            label_harga.Hide();
            box_id.Show();
            box_barang.Hide();
            box_deskripsi.Hide();
            box_harga.Hide();
            btn_tambah.Hide();
            btn_edit.Hide();
            btn_hapus.Show();
        }
        private void refresh()
        {
            dataBarang.Rows.Clear();
            dd_aksi.ResetText();
            box_id.Clear();
            box_barang.Clear();
            box_deskripsi.Clear();
            box_harga.Clear();
            get_data();
        }
        private void get_data()
        {
            project project = new project();

            string[][] data_barang = project.getdata("select * from barang");

            foreach (string[] i in data_barang)
            {
                int indeks = dataBarang.Rows.Add();
                DataGridViewRow dataGridViewRow0 = dataBarang.Rows[indeks];

                dataGridViewRow0.Cells["no"].Value = i[0];
                dataGridViewRow0.Cells["barang"].Value = i[1];
                dataGridViewRow0.Cells["deskripsi"].Value = i[2];
                dataGridViewRow0.Cells["harga"].Value = i[3];

            }
        }

        private void form_data_barang_Load(object sender, EventArgs e)
        {
            get_data();
            showdata();
        }

        private void dd_aksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dd_aksi.Text == "Tambah")
            {
                adddata();
            }
            else if (dd_aksi.Text == "Edit")
            {
                updatedata();
            }
            else if (dd_aksi.Text == "Hapus")
            {
                deletedata();
            }
        }
        private void tambah_Click(object sender, EventArgs e)
        {
            if (dd_aksi.Text != "")
            {
                insert_data = $"insert into barang (nama_barang, deskripsi, harga) values('{box_barang.Text}', '{box_deskripsi.Text}', '{Convert.ToInt32(box_harga.Text)}')";

                project project = new project();
                project.getdata(insert_data);

                MessageBox.Show("Data barang berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            else
            {
                MessageBox.Show("Masukkan data barang dengan benar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dd_aksi.Text != "")
            {
                update_data = $"update barang set nama_barang='{box_barang.Text}', deskripsi='{box_deskripsi.Text}', harga={box_harga.Text} where id_barang={box_id.Text}";

                project project = new project();
                project.getdata(update_data);

                MessageBox.Show("Data barang berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            else
            {
                MessageBox.Show("Masukkan data barang dengan benar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (dd_aksi.Text != "")
            {
                delete_data = $"delete from barang where id_barang={Convert.ToInt32(box_id.Text)}";

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

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.Show();

        }

        private void label_deskripsi_Click(object sender, EventArgs e)
        {

        }

        private void dataBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_id_Click(object sender, EventArgs e)
        {

        }

        private void box_barang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
