namespace WinFormsApp1
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
            btn_login = new Button();
            txt_id = new TextBox();
            txt_pwd = new TextBox();
            login = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)login).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackgroundImage = (Image)resources.GetObject("btn_login.BackgroundImage");
            btn_login.BackgroundImageLayout = ImageLayout.None;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Location = new Point(718, 472);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(121, 32);
            btn_login.TabIndex = 2;
            btn_login.Text = "로그인";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.WhiteSmoke;
            txt_id.BorderStyle = BorderStyle.None;
            txt_id.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_id.Location = new Point(754, 313);
            txt_id.Margin = new Padding(35, 3, 3, 3);
            txt_id.Name = "txt_id";
            txt_id.PlaceholderText = " 아이디";
            txt_id.Size = new Size(219, 36);
            txt_id.TabIndex = 4;
            txt_id.TextChanged += txt_id_TextChanged;
            // 
            // txt_pwd
            // 
            txt_pwd.BackColor = Color.WhiteSmoke;
            txt_pwd.BorderStyle = BorderStyle.None;
            txt_pwd.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pwd.Location = new Point(754, 382);
            txt_pwd.Name = "txt_pwd";
            txt_pwd.PasswordChar = '*';
            txt_pwd.PlaceholderText = " 비밀번호";
            txt_pwd.Size = new Size(220, 36);
            txt_pwd.TabIndex = 5;
            // 
            // login
            // 
            login.BackColor = Color.WhiteSmoke;
            login.BackgroundImageLayout = ImageLayout.Stretch;
            login.Image = (Image)resources.GetObject("login.Image");
            login.Location = new Point(718, 313);
            login.Name = "login";
            login.Size = new Size(36, 36);
            login.SizeMode = PictureBoxSizeMode.Zoom;
            login.TabIndex = 6;
            login.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(718, 382);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-7, -8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(669, 663);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(719, 106);
            label1.Name = "label1";
            label1.Size = new Size(172, 65);
            label1.TabIndex = 9;
            label1.Text = "내작책";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Location = new Point(728, 169);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(96, 10);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(718, 226);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(253, 49);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "나만의 책 리스트를 작성하고 기록하고 독후감을 작성해 보세요";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(917, 437);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 13;
            label2.Text = "회원가입";
            label2.Click += btn_new_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1061, 649);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(login);
            Controls.Add(txt_pwd);
            Controls.Add(txt_id);
            Controls.Add(btn_login);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)login).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_login;
        private TextBox txt_id;
        private TextBox txt_pwd;
        private PictureBox login;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private RichTextBox richTextBox1;
        private Label label2;
    }
}