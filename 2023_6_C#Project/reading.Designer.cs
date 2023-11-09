namespace _2023_6_C_Project
{
    partial class reading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reading));
            mainLogo = new PictureBox();
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            labReadDone = new Label();
            labReading = new Label();
            labReadLike = new Label();
            listView1 = new ListView();
            pictureBox4 = new PictureBox();
            searchLogo = new PictureBox();
            pictureBox6 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
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
            mainLogo.TabIndex = 19;
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
            label1.TabIndex = 20;
            label1.Text = "책장 모아";
            label1.Click += mainLogo_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Menu;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("강원교육현옥샘 Medium", 30F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.Location = new Point(58, 110);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(507, 46);
            txtSearch.TabIndex = 21;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(585, 110);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 46);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "검색";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // labReadDone
            // 
            labReadDone.AutoSize = true;
            labReadDone.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labReadDone.Location = new Point(89, 181);
            labReadDone.Name = "labReadDone";
            labReadDone.Size = new Size(120, 25);
            labReadDone.TabIndex = 31;
            labReadDone.Text = "다 읽었어요!";
            labReadDone.Click += labReadDone_Click;
            // 
            // labReading
            // 
            labReading.AutoSize = true;
            labReading.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labReading.Location = new Point(326, 176);
            labReading.Name = "labReading";
            labReading.Size = new Size(113, 30);
            labReading.TabIndex = 32;
            labReading.Text = "읽는 중~~";
            // 
            // labReadLike
            // 
            labReadLike.AutoSize = true;
            labReadLike.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labReadLike.Location = new Point(542, 181);
            labReadLike.Name = "labReadLike";
            labReadLike.Size = new Size(128, 25);
            labReadLike.TabIndex = 33;
            labReadLike.Text = "읽고 싶어요~";
            labReadLike.Click += labReadLike_Click;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ButtonFace;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Location = new Point(0, 850);
            listView1.Name = "listView1";
            listView1.Size = new Size(734, 112);
            listView1.TabIndex = 34;
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
            pictureBox4.TabIndex = 35;
            pictureBox4.TabStop = false;
            // 
            // searchLogo
            // 
            searchLogo.BackColor = SystemColors.ButtonFace;
            searchLogo.Image = (Image)resources.GetObject("searchLogo.Image");
            searchLogo.Location = new Point(399, 868);
            searchLogo.Name = "searchLogo";
            searchLogo.Size = new Size(146, 81);
            searchLogo.SizeMode = PictureBoxSizeMode.Zoom;
            searchLogo.TabIndex = 36;
            searchLogo.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ButtonFace;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(564, 862);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(149, 89);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 37;
            pictureBox6.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel1.Location = new Point(205, 840);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 10);
            flowLayoutPanel1.TabIndex = 38;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.GradientInactiveCaption;
            flowLayoutPanel2.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Location = new Point(319, 206);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(120, 5);
            flowLayoutPanel2.TabIndex = 39;
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
            // reading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(734, 961);
            Controls.Add(pictureBox7);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox6);
            Controls.Add(searchLogo);
            Controls.Add(pictureBox4);
            Controls.Add(listView1);
            Controls.Add(labReadLike);
            Controls.Add(labReading);
            Controls.Add(labReadDone);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(mainLogo);
            Name = "reading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "reading";
            Load += reading_Load;
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
        private TextBox txtSearch;
        private Button btnSearch;
        private Label labReadDone;
        private Label labReading;
        private Label labReadLike;
        private ListView listView1;
        private PictureBox pictureBox4;
        private PictureBox searchLogo;
        private PictureBox pictureBox6;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox7;
    }
}