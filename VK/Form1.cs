namespace VK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Телефон или почта")
                textBox2.Text = "";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Телефон или почта";
                this.textBox2.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void B_QR_Click(object sender, EventArgs e)
        {
            Form_QR form_QR = new Form_QR();
            form_QR.Show();
        }

        private void B_Login_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Телефон или почта") { MessageBox.Show("Вы не ввели логин!"); }
            else { MessageBox.Show("\tТакого пользователя нет! \nЗарегистрируйтесь или отсканируйте QR!"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_Registration f_Registration = new F_Registration();
            f_Registration.Show();
            this.Opacity = 0.0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}