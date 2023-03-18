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
    public partial class F_User_Page : Form
    {
        public F_User_Page()
        {
            InitializeComponent();
            nickName.ForeColor = System.Drawing.Color.WhiteSmoke;

        }

        private void F_User_Page_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Поиск")
                textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Поиск";
                this.textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void BUser_Main_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void User_Pic_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void User_Pic_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void User_Pic_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_News f_News = new F_News();
            f_News.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_Music f_Music = new F_Music();
            f_Music.Show();
        }
    }
}
