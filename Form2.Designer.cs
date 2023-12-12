namespace WebCamYolo
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(63, 97);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(63, 185);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(64, 208);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(294, 27);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(127, 279);
            button1.Name = "button1";
            button1.Size = new Size(179, 56);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(1140, 3);
            button2.Name = "button2";
            button2.Size = new Size(37, 32);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 18, 80);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1177, 37);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(167, 20);
            label3.TabIndex = 9;
            label3.Text = "Information Technology";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left;
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(34, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 421);
            panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 208);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.ForeColor = Color.White;
            linkLabel2.LinkColor = Color.WhiteSmoke;
            linkLabel2.Location = new Point(139, 339);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(144, 20);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Create New Account";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkColor = Color.WhiteSmoke;
            linkLabel1.Location = new Point(152, 243);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(118, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(182, 14);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 1;
            label4.Text = "Login";
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1177, 668);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 668);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private LinkLabel linkLabel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private LinkLabel linkLabel1;
    }
}