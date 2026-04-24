namespace OOP_Project_Concept2
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            label8 = new Label();
            chk_PartnerAlive = new CheckBox();
            label7 = new Label();
            button1 = new Button();
            chk_Father = new CheckBox();
            rb_Female = new RadioButton();
            chk_Mother = new CheckBox();
            rb_Male = new RadioButton();
            label6 = new Label();
            num_Daughters = new NumericUpDown();
            num_Sons = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            textBox_Total = new TextBox();
            label3 = new Label();
            num_FullBrothers = new NumericUpDown();
            num_FullSisters = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_Daughters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Sons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_FullBrothers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_FullSisters).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-261, -479);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1039, 1021);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(202, 154, 114);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(125, 54);
            label1.TabIndex = 1;
            label1.Text = "ميراثك";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(217, 217, 217);
            button2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1268, 13);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(221, 46);
            button2.TabIndex = 2;
            button2.Text = "الصفحة الرئيسية";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(90, 70, 53);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(chk_PartnerAlive);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(chk_Father);
            panel1.Controls.Add(rb_Female);
            panel1.Controls.Add(chk_Mother);
            panel1.Controls.Add(rb_Male);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(num_Daughters);
            panel1.Controls.Add(num_Sons);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox_Total);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(505, 299);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 393);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(390, 84);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(188, 31);
            label8.TabIndex = 12;
            label8.Text = "عدد الأخوة الذكور";
            // 
            // chk_PartnerAlive
            // 
            chk_PartnerAlive.AutoSize = true;
            chk_PartnerAlive.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chk_PartnerAlive.ForeColor = SystemColors.ButtonHighlight;
            chk_PartnerAlive.Location = new Point(213, 280);
            chk_PartnerAlive.Margin = new Padding(2);
            chk_PartnerAlive.Name = "chk_PartnerAlive";
            chk_PartnerAlive.Size = new Size(194, 29);
            chk_PartnerAlive.TabIndex = 11;
            chk_PartnerAlive.Text = "الزوجة على قيد الحياة";
            chk_PartnerAlive.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(60, 84);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(184, 31);
            label7.TabIndex = 14;
            label7.Text = "عدد الاخوة الاناث";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(160, 127, 52);
            button1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(210, 339);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(194, 51);
            button1.TabIndex = 0;
            button1.Text = "ابدء الحساب";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // chk_Father
            // 
            chk_Father.AutoSize = true;
            chk_Father.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chk_Father.ForeColor = SystemColors.ButtonHighlight;
            chk_Father.Location = new Point(127, 304);
            chk_Father.Margin = new Padding(2);
            chk_Father.Name = "chk_Father";
            chk_Father.Size = new Size(79, 35);
            chk_Father.TabIndex = 10;
            chk_Father.Text = "الاب";
            chk_Father.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            rb_Female.AutoSize = true;
            rb_Female.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_Female.ForeColor = SystemColors.ButtonHighlight;
            rb_Female.Location = new Point(406, 256);
            rb_Female.Margin = new Padding(2);
            rb_Female.Name = "rb_Female";
            rb_Female.Size = new Size(75, 35);
            rb_Female.TabIndex = 8;
            rb_Female.TabStop = true;
            rb_Female.Text = "أنثى";
            rb_Female.UseVisualStyleBackColor = true;
            rb_Female.CheckedChanged += rb_Female_CheckedChanged;
            // 
            // chk_Mother
            // 
            chk_Mother.AutoSize = true;
            chk_Mother.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chk_Mother.ForeColor = SystemColors.ButtonHighlight;
            chk_Mother.Location = new Point(413, 304);
            chk_Mother.Margin = new Padding(2);
            chk_Mother.Name = "chk_Mother";
            chk_Mother.Size = new Size(69, 35);
            chk_Mother.TabIndex = 9;
            chk_Mother.Text = "الام";
            chk_Mother.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            rb_Male.AutoSize = true;
            rb_Male.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_Male.ForeColor = SystemColors.ButtonHighlight;
            rb_Male.Location = new Point(138, 256);
            rb_Male.Margin = new Padding(2);
            rb_Male.Name = "rb_Male";
            rb_Male.Size = new Size(71, 35);
            rb_Male.TabIndex = 7;
            rb_Male.TabStop = true;
            rb_Male.Text = "ذكر";
            rb_Male.UseVisualStyleBackColor = true;
            rb_Male.CheckedChanged += rb_Male_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(221, 210);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(141, 31);
            label6.TabIndex = 6;
            label6.Text = "جنس المتوفي";
            // 
            // num_Daughters
            // 
            num_Daughters.Location = new Point(505, 148);
            num_Daughters.Margin = new Padding(2);
            num_Daughters.Name = "num_Daughters";
            num_Daughters.Size = new Size(144, 27);
            num_Daughters.TabIndex = 5;
            // 
            // num_Sons
            // 
            num_Sons.Location = new Point(74, 161);
            num_Sons.Margin = new Padding(2);
            num_Sons.Name = "num_Sons";
            num_Sons.Size = new Size(144, 27);
            num_Sons.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(44, 115);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(186, 31);
            label5.TabIndex = 3;
            label5.Text = "عدد الابناء الذكور";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(422, 115);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 31);
            label4.TabIndex = 2;
            label4.Text = "عدد الاناث";
            // 
            // textBox_Total
            // 
            textBox_Total.Location = new Point(185, 68);
            textBox_Total.Margin = new Padding(2);
            textBox_Total.Name = "textBox_Total";
            textBox_Total.Size = new Size(219, 27);
            textBox_Total.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(197, 20);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(184, 31);
            label3.TabIndex = 0;
            label3.Text = "ادخال مبلغ التركة";
            // 
            // num_FullBrothers
            // 
            num_FullBrothers.Location = new Point(531, 241);
            num_FullBrothers.Margin = new Padding(2);
            num_FullBrothers.Name = "num_FullBrothers";
            num_FullBrothers.Size = new Size(144, 27);
            num_FullBrothers.TabIndex = 12;
            num_FullBrothers.Tag = "الأخوة الأشقاء";
            // 
            // num_FullSisters
            // 
            num_FullSisters.Location = new Point(945, 241);
            num_FullSisters.Margin = new Padding(2);
            num_FullSisters.Name = "num_FullSisters";
            num_FullSisters.Size = new Size(144, 27);
            num_FullSisters.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 19.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(724, 241);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 39);
            label2.TabIndex = 4;
            label2.Text = "بيانات الميراث";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 43, 83);
            ClientSize = new Size(1539, 804);
            Controls.Add(num_FullSisters);
            Controls.Add(num_FullBrothers);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            Text = "ميراثك";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_Daughters).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Sons).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_FullBrothers).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_FullSisters).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button2;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox textBox_Total;
        private Label label5;
        private Label label4;
        private NumericUpDown num_Sons;
        private NumericUpDown num_Daughters;
        private Label label6;
        private RadioButton rb_Female;
        private RadioButton rb_Male;
        private Button button1;
        private CheckBox chk_Mother;
        private CheckBox chk_Father;
        private CheckBox chk_PartnerAlive;
        private NumericUpDown num_FullBrothers;
        private NumericUpDown num_FullSisters;
        private Label label7;
        private Label label8;
    }
}
