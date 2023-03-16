using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK
{
    public partial class F_Registration : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        public F_Registration()
        {
            InitializeComponent();

        }

        public void button2_Click(object sender, EventArgs e)
        {






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.textBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Имя")
                textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Имя";
                this.textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Фамилия")
                textBox2.Text = "";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Фамилия";
                this.textBox2.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_User_Page f_User_Page = new F_User_Page();
            f_User_Page.User_Pic.Image = f_User_Page.User_Pic_Gal.Image = f_User_Page.User_Pic_Little.Image = new Bitmap(ofd.FileName);
            f_User_Page.nickName.Text = textBox1.Text + "" + textBox2.Text;







            if (textBox1.Text == "Имя")
            {
                MessageBox.Show("Вы не ввели Имя!");
                return;
            }

            if (textBox2.Text == "Фамилия")
            {
                MessageBox.Show("Вы не ввели Фамилию!");
                return;
            }

            if (ofd.FileName == null)
            {
                MessageBox.Show("Вы не выбрали фотографию!");
                return;
            }




            f_User_Page.Show();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image Files(*.BMP,*.JPG;*.PNG) |*.BMP, *.JPG,*.PNG| All files(*.*)|*.*";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try { pictureBox1.Image = new Bitmap(ofd.FileName); }
                catch { MessageBox.Show("Невозможно открыть выбраный файл"); }
            }
        }
    }
}
