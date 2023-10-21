﻿namespace _2023_6_C_Project
{
    partial class DetailedSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailedSearch));
            mainLogo = new PictureBox();
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            listView1 = new ListView();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)mainLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainLogo
            // 
            mainLogo.Image = (Image)resources.GetObject("mainLogo.Image");
            mainLogo.Location = new Point(146, -33);
            mainLogo.Name = "mainLogo";
            mainLogo.Size = new Size(182, 163);
            mainLogo.SizeMode = PictureBoxSizeMode.Zoom;
            mainLogo.TabIndex = 17;
            mainLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("강원교육현옥샘 Medium", 54.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(286, 9);
            label1.Name = "label1";
            label1.Size = new Size(236, 84);
            label1.TabIndex = 18;
            label1.Text = "책장 모아";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Menu;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("강원교육현옥샘 Medium", 30F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.Location = new Point(58, 110);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(507, 46);
            txtSearch.TabIndex = 19;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(585, 110);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 46);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "검색";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ButtonFace;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Location = new Point(0, 850);
            listView1.Name = "listView1";
            listView1.Size = new Size(734, 112);
            listView1.TabIndex = 21;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ButtonFace;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(70, 845);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(174, 131);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ButtonFace;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(296, 870);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(146, 81);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ButtonFace;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(541, 862);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(149, 89);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 223);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(650, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("강원교육현옥샘 Medium", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(315, 180);
            label2.Name = "label2";
            label2.Size = new Size(80, 37);
            label2.TabIndex = 27;
            label2.Text = "label2";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel1.Location = new Point(58, 840);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 10);
            flowLayoutPanel1.TabIndex = 28;
            // 
            // DetailedSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(734, 961);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(listView1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(mainLogo);
            Name = "DetailedSearch";
            Text = "DetailedSearch";
            Load += DetailedSearch_Load;
            ((System.ComponentModel.ISupportInitialize)mainLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox mainLogo;
        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private ListView listView1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}