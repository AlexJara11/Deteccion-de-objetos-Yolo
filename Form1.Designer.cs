namespace WinFormsApp3
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button3 = new Button();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            button4 = new Button();
            label8 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(11, 69);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(226, 28);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "yolov2-tiny-voc", "yolov3", "yolov3-tiny" });
            comboBox2.Location = new Point(251, 69);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(197, 28);
            comboBox2.TabIndex = 5;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "20", "50", "100", "300" });
            comboBox3.Location = new Point(467, 69);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(76, 28);
            comboBox3.TabIndex = 6;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(10, 18, 80);
            button3.FlatAppearance.BorderColor = Color.White;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1427, 1);
            button3.Name = "button3";
            button3.Size = new Size(118, 37);
            button3.TabIndex = 13;
            button3.Text = "Log out";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 18, 80);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1544, 37);
            panel1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 9);
            label7.Name = "label7";
            label7.Size = new Size(209, 20);
            label7.TabIndex = 9;
            label7.Text = "Tecnologías de la Información";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Location = new Point(795, 117);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(731, 479);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(206, 117);
            label4.Name = "label4";
            label4.Size = new Size(116, 38);
            label4.TabIndex = 11;
            label4.Text = "OBJECT";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.Location = new Point(687, 235);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 51);
            button1.TabIndex = 0;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(1102, 77);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 12;
            label5.Text = "STUDENT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(467, 45);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 9;
            label3.Text = "Count";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(251, 45);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 8;
            label2.Text = "CNN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(11, 45);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 7;
            label1.Text = "Device";
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.Location = new Point(687, 323);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 51);
            button2.TabIndex = 2;
            button2.Text = "STOP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1544, 676);
            panel2.TabIndex = 16;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(button4);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(11, 175);
            panel3.Name = "panel3";
            panel3.Size = new Size(577, 477);
            panel3.TabIndex = 13;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(3, 5);
            button4.Name = "button4";
            button4.Size = new Size(32, 35);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 76);
            label8.Name = "label8";
            label8.Size = new Size(137, 20);
            label8.TabIndex = 2;
            label8.Text = "Oracion en español";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 12);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 1;
            label6.Text = "Oracion en ingles";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(38, 163);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(494, 311);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1544, 676);
            Controls.Add(panel1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button3;
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Panel panel2;
        private Panel panel3;
        private Label label8;
        private Label label6;
        private PictureBox pictureBox2;
        private Button button4;
    }
}