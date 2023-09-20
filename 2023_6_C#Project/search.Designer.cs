namespace _2023_6_C_Project
{
    partial class search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search));
            pictureBox3 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            listView1 = new ListView();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            BookName = new ColumnHeader();
            BookAuthor = new ColumnHeader();
            BookYear = new ColumnHeader();
            BookNum = new ColumnHeader();
            BookPublisher = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(146, -33);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(182, 163);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("강원교육현옥샘 Medium", 54.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(286, 9);
            label1.Name = "label1";
            label1.Size = new Size(236, 84);
            label1.TabIndex = 17;
            label1.Text = "책장 모아";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("강원교육현옥샘 Medium", 30F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(58, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(507, 46);
            textBox1.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(585, 110);
            button1.Name = "button1";
            button1.Size = new Size(105, 46);
            button1.TabIndex = 19;
            button1.Text = "검색";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ButtonFace;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Location = new Point(0, 850);
            listView1.Name = "listView1";
            listView1.Size = new Size(734, 112);
            listView1.TabIndex = 20;
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
            pictureBox4.TabIndex = 21;
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
            pictureBox5.TabIndex = 22;
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
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, BookName, BookAuthor, BookYear, BookNum, BookPublisher, columnHeader2 });
            listView2.Location = new Point(50, 162);
            listView2.Name = "listView2";
            listView2.Size = new Size(650, 677);
            listView2.TabIndex = 24;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            columnHeader1.Width = 1;
            // 
            // BookName
            // 
            BookName.Text = "책 이름";
            BookName.TextAlign = HorizontalAlignment.Center;
            BookName.Width = 130;
            // 
            // BookAuthor
            // 
            BookAuthor.Text = "저자";
            BookAuthor.TextAlign = HorizontalAlignment.Center;
            BookAuthor.Width = 130;
            // 
            // BookYear
            // 
            BookYear.Text = "발행연도";
            BookYear.TextAlign = HorizontalAlignment.Center;
            BookYear.Width = 130;
            // 
            // BookNum
            // 
            BookNum.Text = "청구 기호";
            BookNum.TextAlign = HorizontalAlignment.Center;
            BookNum.Width = 130;
            // 
            // BookPublisher
            // 
            BookPublisher.Text = "발행자";
            BookPublisher.TextAlign = HorizontalAlignment.Center;
            BookPublisher.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "";
            columnHeader2.TextAlign = HorizontalAlignment.Right;
            columnHeader2.Width = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel1.Location = new Point(58, 840);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 10);
            flowLayoutPanel1.TabIndex = 25;
            // 
            // search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(734, 961);
            Controls.Add(listView2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Name = "search";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "search";
            Load += search_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private ListView listView1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private ListView listView2;
        private ColumnHeader BookAuthor;
        private ColumnHeader BookPublisher;
        private ColumnHeader BookYear;
        private ColumnHeader BookNum;
        private ColumnHeader BookName;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}