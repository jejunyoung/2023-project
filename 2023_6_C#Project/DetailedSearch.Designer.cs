namespace _2023_6_C_Project
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
            searchLogo = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox = new PictureBox();
            titleLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            authorLabel = new Label();
            labelpubdate = new Label();
            labelpublisher = new Label();
            labelbestRank = new Label();
            labelcustomerReviewRank = new Label();
            txtDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)mainLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
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
            label1.TabIndex = 18;
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
            // searchLogo
            // 
            searchLogo.BackColor = SystemColors.ButtonFace;
            searchLogo.Image = (Image)resources.GetObject("searchLogo.Image");
            searchLogo.Location = new Point(296, 870);
            searchLogo.Name = "searchLogo";
            searchLogo.Size = new Size(146, 81);
            searchLogo.SizeMode = PictureBoxSizeMode.Zoom;
            searchLogo.TabIndex = 23;
            searchLogo.TabStop = false;
            searchLogo.Click += searchLogo_Click;
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
            // pictureBox
            // 
            pictureBox.Location = new Point(49, 223);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(650, 179);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 26;
            pictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("강원교육현옥샘 Medium", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(49, 162);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(650, 55);
            titleLabel.TabIndex = 27;
            titleLabel.Text = "이름";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel1.Location = new Point(58, 840);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 10);
            flowLayoutPanel1.TabIndex = 28;
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Font = new Font("강원교육현옥샘 Medium", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            authorLabel.Location = new Point(49, 414);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(47, 31);
            authorLabel.TabIndex = 29;
            authorLabel.Text = "저자";
            // 
            // labelpubdate
            // 
            labelpubdate.Font = new Font("강원교육현옥샘 Medium", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelpubdate.Location = new Point(394, 414);
            labelpubdate.Name = "labelpubdate";
            labelpubdate.Size = new Size(305, 31);
            labelpubdate.TabIndex = 30;
            labelpubdate.Text = "출간일";
            labelpubdate.TextAlign = ContentAlignment.TopRight;
            // 
            // labelpublisher
            // 
            labelpublisher.AutoSize = true;
            labelpublisher.Font = new Font("강원교육현옥샘 Medium", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelpublisher.Location = new Point(49, 445);
            labelpublisher.Name = "labelpublisher";
            labelpublisher.Size = new Size(62, 31);
            labelpublisher.TabIndex = 32;
            labelpublisher.Text = "출판사";
            // 
            // labelbestRank
            // 
            labelbestRank.AutoSize = true;
            labelbestRank.Location = new Point(585, 765);
            labelbestRank.Name = "labelbestRank";
            labelbestRank.Size = new Size(95, 15);
            labelbestRank.TabIndex = 33;
            labelbestRank.Text = "배스트셀러 순위";
            // 
            // labelcustomerReviewRank
            // 
            labelcustomerReviewRank.AutoSize = true;
            labelcustomerReviewRank.Font = new Font("강원교육현옥샘 Medium", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelcustomerReviewRank.Location = new Point(58, 765);
            labelcustomerReviewRank.Name = "labelcustomerReviewRank";
            labelcustomerReviewRank.Size = new Size(46, 31);
            labelcustomerReviewRank.TabIndex = 34;
            labelcustomerReviewRank.Text = "별점";
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtDescription.ForeColor = SystemColors.WindowText;
            txtDescription.Location = new Point(40, 490);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(650, 225);
            txtDescription.TabIndex = 35;
            txtDescription.Text = "설명";
            // 
            // DetailedSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(734, 961);
            Controls.Add(txtDescription);
            Controls.Add(labelcustomerReviewRank);
            Controls.Add(labelbestRank);
            Controls.Add(labelpublisher);
            Controls.Add(labelpubdate);
            Controls.Add(authorLabel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(titleLabel);
            Controls.Add(pictureBox);
            Controls.Add(pictureBox6);
            Controls.Add(searchLogo);
            Controls.Add(pictureBox4);
            Controls.Add(listView1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(mainLogo);
            Name = "DetailedSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetailedSearch";
            Load += DetailedSearch_Load;
            ((System.ComponentModel.ISupportInitialize)mainLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
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
        private PictureBox searchLogo;
        private PictureBox pictureBox6;
        private PictureBox pictureBox;
        private Label titleLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label authorLabel;
        private Label labelpubdate;
        private Label labelpublisher;
        private Label labelbestRank;
        private Label labelcustomerReviewRank;
        private TextBox txtDescription;
    }
}