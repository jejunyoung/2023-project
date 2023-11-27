namespace _2023_6_C_Project
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            mainLogo = new PictureBox();
            label1 = new Label();
            listView1 = new ListView();
            pictureBox7 = new PictureBox();
            pictureBox4 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            searchLogo = new PictureBox();
            pictureBox6 = new PictureBox();
            labName = new Label();
            txtName = new TextBox();
            txtId = new TextBox();
            txtPw = new TextBox();
            txtPw2 = new TextBox();
            labId = new Label();
            labPw = new Label();
            labPw2 = new Label();
            labLogOut = new Label();
            labCP = new Label();
            ((System.ComponentModel.ISupportInitialize)mainLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
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
            label1.Click += mainLogo_Click;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ButtonFace;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Location = new Point(0, 850);
            listView1.Name = "listView1";
            listView1.Size = new Size(734, 112);
            listView1.TabIndex = 43;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = SystemColors.ButtonFace;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(86, 868);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(82, 81);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 78;
            pictureBox7.TabStop = false;
            pictureBox7.Click += mainLogo_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ButtonFace;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(215, 841);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(174, 131);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 79;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel1.Location = new Point(205, 840);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 10);
            flowLayoutPanel1.TabIndex = 80;
            // 
            // searchLogo
            // 
            searchLogo.BackColor = SystemColors.ButtonFace;
            searchLogo.Image = (Image)resources.GetObject("searchLogo.Image");
            searchLogo.Location = new Point(399, 868);
            searchLogo.Name = "searchLogo";
            searchLogo.Size = new Size(146, 81);
            searchLogo.SizeMode = PictureBoxSizeMode.Zoom;
            searchLogo.TabIndex = 81;
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
            pictureBox6.TabIndex = 82;
            pictureBox6.TabStop = false;
            // 
            // labName
            // 
            labName.AutoSize = true;
            labName.Font = new Font("Noto Sans KR", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labName.Location = new Point(108, 206);
            labName.Name = "labName";
            labName.Size = new Size(82, 39);
            labName.TabIndex = 83;
            labName.Text = "이름: ";
            // 
            // txtName
            // 
            txtName.Font = new Font("Noto Sans KR", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(206, 206);
            txtName.Name = "txtName";
            txtName.Size = new Size(406, 47);
            txtName.TabIndex = 84;
            // 
            // txtId
            // 
            txtId.Font = new Font("Noto Sans KR", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            txtId.Location = new Point(228, 333);
            txtId.Name = "txtId";
            txtId.Size = new Size(384, 47);
            txtId.TabIndex = 85;
            // 
            // txtPw
            // 
            txtPw.Font = new Font("Noto Sans KR", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            txtPw.Location = new Point(246, 464);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(366, 47);
            txtPw.TabIndex = 86;
            // 
            // txtPw2
            // 
            txtPw2.Font = new Font("Noto Sans KR", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            txtPw2.Location = new Point(309, 591);
            txtPw2.Name = "txtPw2";
            txtPw2.Size = new Size(303, 47);
            txtPw2.TabIndex = 87;
            // 
            // labId
            // 
            labId.AutoSize = true;
            labId.Font = new Font("Noto Sans KR", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labId.Location = new Point(108, 333);
            labId.Name = "labId";
            labId.Size = new Size(107, 39);
            labId.TabIndex = 88;
            labId.Text = "아이디: ";
            // 
            // labPw
            // 
            labPw.AutoSize = true;
            labPw.Font = new Font("Noto Sans KR", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labPw.Location = new Point(108, 464);
            labPw.Name = "labPw";
            labPw.Size = new Size(126, 39);
            labPw.TabIndex = 89;
            labPw.Text = "비밀번호:";
            // 
            // labPw2
            // 
            labPw2.AutoSize = true;
            labPw2.Font = new Font("Noto Sans KR", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labPw2.Location = new Point(108, 591);
            labPw2.Name = "labPw2";
            labPw2.Size = new Size(184, 39);
            labPw2.TabIndex = 90;
            labPw2.Text = "비밀번호 확인:";
            // 
            // labLogOut
            // 
            labLogOut.AutoSize = true;
            labLogOut.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labLogOut.Location = new Point(89, 728);
            labLogOut.Name = "labLogOut";
            labLogOut.Size = new Size(133, 40);
            labLogOut.TabIndex = 91;
            labLogOut.Text = "로그아웃";
            labLogOut.Click += labLogOut_Click;
            // 
            // labCP
            // 
            labCP.AutoSize = true;
            labCP.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labCP.Location = new Point(411, 728);
            labCP.Name = "labCP";
            labCP.Size = new Size(201, 40);
            labCP.TabIndex = 92;
            labCP.Text = "비밀번호 변경";
            labCP.Click += labCP_Click;
            // 
            // Preferences
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(734, 961);
            Controls.Add(labCP);
            Controls.Add(labLogOut);
            Controls.Add(labPw2);
            Controls.Add(labPw);
            Controls.Add(labId);
            Controls.Add(txtPw2);
            Controls.Add(txtPw);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(labName);
            Controls.Add(pictureBox6);
            Controls.Add(searchLogo);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox7);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(mainLogo);
            Name = "Preferences";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Preferences";
            Load += Preferences_Load;
            ((System.ComponentModel.ISupportInitialize)mainLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox mainLogo;
        private Label label1;
        private ListView listView1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox4;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox searchLogo;
        private PictureBox pictureBox6;
        private Label labName;
        private TextBox txtName;
        private TextBox txtId;
        private TextBox txtPw;
        private TextBox txtPw2;
        private Label labId;
        private Label labPw;
        private Label labPw2;
        private Label labLogOut;
        private Label labCP;
    }
}