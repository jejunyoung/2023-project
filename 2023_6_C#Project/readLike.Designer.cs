namespace _2023_6_C_Project
{
    partial class readLike
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(readLike));
            mainLogo = new PictureBox();
            label1 = new Label();
            labReadDone = new Label();
            labReading = new Label();
            labReadLike = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            listView1 = new ListView();
            pictureBox4 = new PictureBox();
            searchLogo = new PictureBox();
            pictureBox6 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)mainLogo).BeginInit();
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
            mainLogo.TabIndex = 20;
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
            label1.TabIndex = 21;
            label1.Text = "책장 모아";
            label1.Click += mainLogo_Click;
            // 
            // labReadDone
            // 
            labReadDone.AutoSize = true;
            labReadDone.Font = new Font("Noto Sans KR", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labReadDone.Location = new Point(89, 116);
            labReadDone.Name = "labReadDone";
            labReadDone.Size = new Size(109, 27);
            labReadDone.TabIndex = 32;
            labReadDone.Text = "다 읽었어요!";
            labReadDone.Click += labReadDone_Click;
            // 
            // labReading
            // 
            labReading.AutoSize = true;
            labReading.Font = new Font("Noto Sans KR", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labReading.Location = new Point(326, 116);
            labReading.Name = "labReading";
            labReading.Size = new Size(90, 27);
            labReading.TabIndex = 33;
            labReading.Text = "읽는 중~~";
            labReading.Click += labReading_Click;
            // 
            // labReadLike
            // 
            labReadLike.AutoSize = true;
            labReadLike.Font = new Font("Noto Sans KR", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labReadLike.Location = new Point(542, 106);
            labReadLike.Name = "labReadLike";
            labReadLike.Size = new Size(126, 30);
            labReadLike.TabIndex = 34;
            labReadLike.Text = "읽고 싶어요~";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.GradientInactiveCaption;
            flowLayoutPanel2.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Location = new Point(542, 136);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(140, 5);
            flowLayoutPanel2.TabIndex = 40;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ButtonFace;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Location = new Point(0, 850);
            listView1.Name = "listView1";
            listView1.Size = new Size(734, 112);
            listView1.TabIndex = 41;
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
            pictureBox4.TabIndex = 42;
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
            searchLogo.TabIndex = 43;
            searchLogo.TabStop = false;
            searchLogo.Click += searchLogo_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ButtonFace;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(564, 862);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(149, 89);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 44;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel1.Location = new Point(205, 840);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 10);
            flowLayoutPanel1.TabIndex = 45;
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
            pictureBox7.Click += mainLogo_Click;
            // 
            // readLike
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
            Controls.Add(flowLayoutPanel2);
            Controls.Add(labReadLike);
            Controls.Add(labReading);
            Controls.Add(labReadDone);
            Controls.Add(label1);
            Controls.Add(mainLogo);
            Name = "readLike";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "readLike";
            Load += readLike_Load;
            ((System.ComponentModel.ISupportInitialize)mainLogo).EndInit();
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
        private Label labReadDone;
        private Label labReading;
        private Label labReadLike;
        private FlowLayoutPanel flowLayoutPanel2;
        private ListView listView1;
        private PictureBox pictureBox4;
        private PictureBox searchLogo;
        private PictureBox pictureBox6;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox7;
    }
}