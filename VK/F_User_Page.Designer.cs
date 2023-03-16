namespace VK
{
    partial class F_User_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_User_Page));
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            nickName = new Label();
            User_Pic_Little = new PictureBox();
            User_Pic_Gal = new PictureBox();
            User_Pic = new PictureBox();
            textBox1 = new TextBox();
            BUser_Main = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)User_Pic_Little).BeginInit();
            ((System.ComponentModel.ISupportInitialize)User_Pic_Gal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)User_Pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(nickName);
            panel1.Controls.Add(User_Pic_Little);
            panel1.Controls.Add(User_Pic_Gal);
            panel1.Controls.Add(User_Pic);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(BUser_Main);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 457);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(78, 140);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(78, 60);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nickName
            // 
            nickName.BackColor = Color.FromArgb(34, 34, 34);
            nickName.FlatStyle = FlatStyle.Popup;
            nickName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nickName.Location = new Point(290, 198);
            nickName.Name = "nickName";
            nickName.Size = new Size(162, 28);
            nickName.TabIndex = 5;
            nickName.Click += label1_Click;
            // 
            // User_Pic_Little
            // 
            User_Pic_Little.BackgroundImageLayout = ImageLayout.Stretch;
            User_Pic_Little.Location = new Point(682, 5);
            User_Pic_Little.Name = "User_Pic_Little";
            User_Pic_Little.Size = new Size(27, 28);
            User_Pic_Little.SizeMode = PictureBoxSizeMode.Zoom;
            User_Pic_Little.TabIndex = 4;
            User_Pic_Little.TabStop = false;
            // 
            // User_Pic_Gal
            // 
            User_Pic_Gal.BackgroundImageLayout = ImageLayout.Stretch;
            User_Pic_Gal.Location = new Point(189, 301);
            User_Pic_Gal.Name = "User_Pic_Gal";
            User_Pic_Gal.Size = new Size(110, 120);
            User_Pic_Gal.SizeMode = PictureBoxSizeMode.Zoom;
            User_Pic_Gal.TabIndex = 3;
            User_Pic_Gal.TabStop = false;
            // 
            // User_Pic
            // 
            User_Pic.BackgroundImageLayout = ImageLayout.Center;
            User_Pic.Location = new Point(185, 140);
            User_Pic.Name = "User_Pic";
            User_Pic.Size = new Size(104, 102);
            User_Pic.SizeMode = PictureBoxSizeMode.Zoom;
            User_Pic.TabIndex = 2;
            User_Pic.TabStop = false;
            User_Pic.LoadCompleted += User_Pic_LoadCompleted;
            User_Pic.Click += User_Pic_Click;
            User_Pic.MouseEnter += User_Pic_MouseEnter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(66, 66, 66);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(175, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 22);
            textBox1.TabIndex = 1;
            textBox1.Text = "Поиск";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // BUser_Main
            // 
            BUser_Main.BackgroundImage = (Image)resources.GetObject("BUser_Main.BackgroundImage");
            BUser_Main.BackgroundImageLayout = ImageLayout.Stretch;
            BUser_Main.FlatAppearance.BorderSize = 0;
            BUser_Main.FlatStyle = FlatStyle.Flat;
            BUser_Main.Location = new Point(76, 3);
            BUser_Main.Name = "BUser_Main";
            BUser_Main.Size = new Size(93, 30);
            BUser_Main.TabIndex = 0;
            BUser_Main.UseVisualStyleBackColor = true;
            BUser_Main.Click += BUser_Main_Click;
            // 
            // F_User_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 457);
            Controls.Add(panel1);
            Name = "F_User_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_User_Page";
            Load += F_User_Page_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)User_Pic_Little).EndInit();
            ((System.ComponentModel.ISupportInitialize)User_Pic_Gal).EndInit();
            ((System.ComponentModel.ISupportInitialize)User_Pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Button BUser_Main;
        public PictureBox User_Pic;
        public PictureBox User_Pic_Little;
        public PictureBox User_Pic_Gal;
        public Label nickName;
        private Button button2;
        private Button button1;
    }
}