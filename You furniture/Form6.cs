using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace You_furniture
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                form_data_barang form5 = new form_data_barang();
                this.Hide();
                form5.Show();
            }
            else
            {
                if (textBox2.Text != "")
                {
                    MessageBox.Show("Masukkan username", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (textBox1.Text != "")
                {
                    MessageBox.Show("Masukkan password", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Masukkan username dan password", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void kembali_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
