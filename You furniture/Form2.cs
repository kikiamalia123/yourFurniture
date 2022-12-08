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
    public partial class Form2 : Form
    {
        public static Form2 f2;
        public TextBox textb;
        public Form2()
        {
            InitializeComponent();
            f2 = this;
            textb = textBox1;
        }


        private void login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Form7 form7 = new Form7();
                this.Hide();
                form7.Show();
            }
            else
            {
                if (textBox2.Text != "")
                {
                    MessageBox.Show("Username Harus diisi!!", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (textBox1.Text != "")
                {
                    MessageBox.Show("Password Harus diisi!!", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
