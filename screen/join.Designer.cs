namespace WinFormsApp1
{
    partial class join
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(join));
            txt_name = new TextBox();
            txt_id = new TextBox();
            txt_pwd = new TextBox();
            btn_new = new Button();
            btn_checkId = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.BackColor = Color.WhiteSmoke;
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(753, 245);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = " 이름";
            txt_name.Size = new Size(219, 36);
            txt_name.TabIndex = 0;
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.WhiteSmoke;
            txt_id.BorderStyle = BorderStyle.None;
            txt_id.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_id.Location = new Point(753, 322);
            txt_id.Name = "txt_id";
            txt_id.PlaceholderText = " 아이디";
            txt_id.Size = new Size(219, 36);
            txt_id.TabIndex = 1;
            // 
            // txt_pwd
            // 
            txt_pwd.BackColor = Color.WhiteSmoke;
            txt_pwd.BorderStyle = BorderStyle.None;
            txt_pwd.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pwd.Location = new Point(753, 393);
            txt_pwd.Name = "txt_pwd";
            txt_pwd.PasswordChar = '*';
            txt_pwd.PlaceholderText = " 비밀번호";
            txt_pwd.Size = new Size(219, 36);
            txt_pwd.TabIndex = 2;
            // 
            // btn_new
            // 
            btn_new.BackgroundImage = (Image)resources.GetObject("btn_new.BackgroundImage");
            btn_new.BackgroundImageLayout = ImageLayout.None;
            btn_new.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_new.FlatAppearance.BorderSize = 0;
            btn_new.FlatStyle = FlatStyle.Flat;
            btn_new.Location = new Point(788, 532);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(121, 32);
            btn_new.TabIndex = 8;
            btn_new.Text = "회원가입";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // btn_checkId
            // 
            btn_checkId.BackgroundImage = (Image)resources.GetObject("btn_checkId.BackgroundImage");
            btn_checkId.FlatAppearance.BorderSize = 0;
            btn_checkId.FlatStyle = FlatStyle.Flat;
            btn_checkId.Location = new Point(978, 322);
            btn_checkId.Name = "btn_checkId";
            btn_checkId.Size = new Size(71, 36);
            btn_checkId.TabIndex = 9;
            btn_checkId.Text = "중복 확인";
            btn_checkId.UseVisualStyleBackColor = true;
            btn_checkId.Click += btn_checkId_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(719, 286);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-7, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(669, 663);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(713, 82);
            label2.Name = "label2";
            label2.Size = new Size(220, 65);
            label2.TabIndex = 13;
            label2.Text = "회원가입";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Location = new Point(719, 147);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(103, 10);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(718, 246);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.WhiteSmoke;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(718, 323);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.WhiteSmoke;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(718, 394);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // join
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1061, 649);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btn_checkId);
            Controls.Add(btn_new);
            Controls.Add(txt_pwd);
            Controls.Add(txt_id);
            Controls.Add(txt_name);
            Name = "join";
            Text = "회원가입";
            Load += join_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private TextBox txt_id;
        private TextBox txt_pwd;
        private Button btn_new;
        private Button btn_checkId;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}