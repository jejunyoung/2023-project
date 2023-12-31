﻿namespace _2023_6_C_Project
{
    partial class Dreading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dreading));
            mainLogo = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            labSave = new Label();
            labDelete = new Label();
            picSave = new PictureBox();
            picDelete = new PictureBox();
            txtReport = new TextBox();
            labName = new Label();
            picCover = new PictureBox();
            label3 = new Label();
            picBack = new PictureBox();
            listView1 = new ListView();
            pictureBox4 = new PictureBox();
            searchLogo = new PictureBox();
            pictureBox6 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)mainLogo).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // mainLogo
            // 
            mainLogo.Image = (Image)resources.GetObject("mainLogo.Image");
            mainLogo.Location = new Point(146, -33);
            mainLogo.Name = "mainLogo";
            mainLogo.Size = new Size(182, 163);
            mainLogo.SizeMode = PictureBoxSizeMode.Zoom;
            mainLogo.TabIndex = 22;
            mainLogo.TabStop = false;
            mainLogo.Click += mainLogo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("강원교육현옥샘 Medium", 54.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(286, 9);
            label1.Name = "label1";
            label1.Size = new Size(236, 84);
            label1.TabIndex = 23;
            label1.Text = "책장 모아";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(labSave);
            groupBox1.Controls.Add(labDelete);
            groupBox1.Controls.Add(picSave);
            groupBox1.Controls.Add(picDelete);
            groupBox1.Controls.Add(txtReport);
            groupBox1.Controls.Add(labName);
            groupBox1.Controls.Add(picCover);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(51, 143);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(650, 676);
            groupBox1.TabIndex = 48;
            groupBox1.TabStop = false;
            // 
            // labSave
            // 
            labSave.AutoSize = true;
            labSave.Font = new Font("Noto Sans KR", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labSave.Location = new Point(516, 604);
            labSave.Name = "labSave";
            labSave.Size = new Size(89, 30);
            labSave.TabIndex = 7;
            labSave.Text = "저장하기";
            labSave.Click += labSave_Click;
            // 
            // labDelete
            // 
            labDelete.AutoSize = true;
            labDelete.Font = new Font("Noto Sans KR", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labDelete.Location = new Point(108, 604);
            labDelete.Name = "labDelete";
            labDelete.Size = new Size(51, 30);
            labDelete.TabIndex = 6;
            labDelete.Text = "삭제";
            labDelete.Click += labDelete_Click;
            // 
            // picSave
            // 
            picSave.Image = (Image)resources.GetObject("picSave.Image");
            picSave.Location = new Point(443, 591);
            picSave.Name = "picSave";
            picSave.Size = new Size(100, 52);
            picSave.SizeMode = PictureBoxSizeMode.Zoom;
            picSave.TabIndex = 5;
            picSave.TabStop = false;
            picSave.Click += picSave_Click;
            // 
            // picDelete
            // 
            picDelete.Image = (Image)resources.GetObject("picDelete.Image");
            picDelete.Location = new Point(29, 591);
            picDelete.Name = "picDelete";
            picDelete.Size = new Size(109, 52);
            picDelete.SizeMode = PictureBoxSizeMode.Zoom;
            picDelete.TabIndex = 4;
            picDelete.TabStop = false;
            picDelete.Click += picDelete_Click;
            // 
            // txtReport
            // 
            txtReport.Font = new Font("Noto Sans KR", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtReport.Location = new Point(29, 345);
            txtReport.Margin = new Padding(10);
            txtReport.Multiline = true;
            txtReport.Name = "txtReport";
            txtReport.Size = new Size(600, 211);
            txtReport.TabIndex = 2;
            // 
            // labName
            // 
            labName.Font = new Font("Noto Sans KR", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labName.Location = new Point(25, 273);
            labName.Name = "labName";
            labName.Size = new Size(596, 37);
            labName.TabIndex = 1;
            labName.Text = "label2";
            labName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picCover
            // 
            picCover.BackgroundImageLayout = ImageLayout.Zoom;
            picCover.Location = new Point(25, 25);
            picCover.Name = "picCover";
            picCover.Size = new Size(600, 230);
            picCover.SizeMode = PictureBoxSizeMode.Zoom;
            picCover.TabIndex = 0;
            picCover.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans KR", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 310);
            label3.Name = "label3";
            label3.Size = new Size(63, 27);
            label3.TabIndex = 3;
            label3.Text = "메모장";
            // 
            // picBack
            // 
            picBack.Image = (Image)resources.GetObject("picBack.Image");
            picBack.Location = new Point(663, 120);
            picBack.Name = "picBack";
            picBack.Size = new Size(68, 53);
            picBack.SizeMode = PictureBoxSizeMode.Zoom;
            picBack.TabIndex = 9;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ButtonFace;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Location = new Point(0, 850);
            listView1.Name = "listView1";
            listView1.Size = new Size(734, 112);
            listView1.TabIndex = 49;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ButtonFace;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(215, 841);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(174, 131);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 50;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // searchLogo
            // 
            searchLogo.BackColor = SystemColors.ButtonFace;
            searchLogo.Image = (Image)resources.GetObject("searchLogo.Image");
            searchLogo.Location = new Point(399, 868);
            searchLogo.Name = "searchLogo";
            searchLogo.Size = new Size(146, 81);
            searchLogo.SizeMode = PictureBoxSizeMode.Zoom;
            searchLogo.TabIndex = 51;
            searchLogo.TabStop = false;
            searchLogo.Click += searchLogo_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ButtonFace;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(573, 841);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(149, 89);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 52;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel1.Location = new Point(205, 840);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 10);
            flowLayoutPanel1.TabIndex = 53;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = SystemColors.ButtonFace;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(86, 868);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(82, 81);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 77;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // Dreading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(734, 961);
            Controls.Add(pictureBox7);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox6);
            Controls.Add(searchLogo);
            Controls.Add(pictureBox4);
            Controls.Add(listView1);
            Controls.Add(picBack);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(mainLogo);
            Name = "Dreading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dreading";
            Load += Dreading_Load;
            ((System.ComponentModel.ISupportInitialize)mainLogo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox mainLogo;
        private Label label1;
        private GroupBox groupBox1;
        private Label labSave;
        private Label labDelete;
        private PictureBox picSave;
        private PictureBox picDelete;
        private TextBox txtReport;
        private Label labName;
        private PictureBox picCover;
        private Label label3;
        private PictureBox picBack;
        private ListView listView1;
        private PictureBox pictureBox4;
        private PictureBox searchLogo;
        private PictureBox pictureBox6;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox7;
    }
}