namespace VK
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            B_Main = new Button();
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            checkBox1 = new CheckBox();
            B_QR = new Button();
            textBox2 = new TextBox();
            B_Login = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // B_Main
            // 
            B_Main.BackgroundImage = (Image)resources.GetObject("B_Main.BackgroundImage");
            B_Main.BackgroundImageLayout = ImageLayout.Stretch;
            B_Main.FlatAppearance.BorderSize = 0;
            B_Main.FlatStyle = FlatStyle.Flat;
            B_Main.Location = new Point(151, 0);
            B_Main.Name = "B_Main";
            B_Main.Size = new Size(110, 39);
            B_Main.TabIndex = 0;
            B_Main.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 34, 34);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(B_Main);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 40);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = Color.FromArgb(225, 227, 230);
            label1.Location = new Point(586, 11);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 2;
            label1.Text = "Switch to English";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(66, 66, 66);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(277, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 16);
            textBox1.TabIndex = 2;
            textBox1.Text = "Поиск";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 413);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(button1);
            panel4.Location = new Point(492, 288);
            panel4.Name = "panel4";
            panel4.Size = new Size(228, 104);
            panel4.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(10, 12);
            button1.Name = "button1";
            button1.Size = new Size(200, 38);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(checkBox1);
            panel3.Controls.Add(B_QR);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(B_Login);
            panel3.Location = new Point(492, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 270);
            panel3.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.FlatAppearance.BorderSize = 0;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(18, 132);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(12, 11);
            checkBox1.TabIndex = 3;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // B_QR
            // 
            B_QR.BackgroundImage = (Image)resources.GetObject("B_QR.BackgroundImage");
            B_QR.BackgroundImageLayout = ImageLayout.Stretch;
            B_QR.FlatAppearance.BorderSize = 0;
            B_QR.FlatStyle = FlatStyle.Flat;
            B_QR.Location = new Point(18, 219);
            B_QR.Name = "B_QR";
            B_QR.Size = new Size(192, 30);
            B_QR.TabIndex = 2;
            B_QR.UseVisualStyleBackColor = true;
            B_QR.Click += B_QR_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(66, 66, 66);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(18, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 22);
            textBox2.TabIndex = 1;
            textBox2.Text = "Телефон или почта";
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // B_Login
            // 
            B_Login.BackgroundImage = (Image)resources.GetObject("B_Login.BackgroundImage");
            B_Login.BackgroundImageLayout = ImageLayout.Stretch;
            B_Login.FlatAppearance.BorderSize = 0;
            B_Login.FlatStyle = FlatStyle.Flat;
            B_Login.Location = new Point(18, 159);
            B_Login.Name = "B_Login";
            B_Login.Size = new Size(192, 28);
            B_Login.TabIndex = 1;
            B_Login.UseVisualStyleBackColor = true;
            B_Login.Click += B_Login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button B_Main;
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox2;
        private Button B_QR;
        private Button B_Login;
        private Panel panel4;
        private Button button1;
        private CheckBox checkBox1;
    }
}