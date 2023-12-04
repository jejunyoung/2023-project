namespace _2023_6_C_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            btnJoin = new Label();
            txtId = new TextBox();
            txtPwd = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Noto Sans KR", 39.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(217, 700);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(301, 74);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // btnJoin
            // 
            btnJoin.AutoSize = true;
            btnJoin.BackColor = Color.Transparent;
            btnJoin.Font = new Font("Noto Sans KR", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnJoin.Location = new Point(249, 804);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(206, 70);
            btnJoin.TabIndex = 1;
            btnJoin.Text = "회원가입";
            btnJoin.Click += btnJoin_Click;
            // 
            // txtId
            // 
            txtId.BackColor = Color.Tan;
            txtId.BorderStyle = BorderStyle.None;
            txtId.Font = new Font("Noto Sans KR", 38.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtId.Location = new Point(186, 400);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "아이디";
            txtId.Size = new Size(350, 74);
            txtId.TabIndex = 2;
            txtId.TextChanged += txtId_TextChanged;
            txtId.KeyPress += txtId_KeyPress;
            // 
            // txtPwd
            // 
            txtPwd.BackColor = Color.Tan;
            txtPwd.BorderStyle = BorderStyle.None;
            txtPwd.Font = new Font("Noto Sans KR", 38.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPwd.Location = new Point(186, 496);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.PlaceholderText = "비밀번호";
            txtPwd.Size = new Size(350, 74);
            txtPwd.TabIndex = 3;
            txtPwd.KeyPress += txtPwd_KeyPress;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(734, 961);
            Controls.Add(txtPwd);
            Controls.Add(txtId);
            Controls.Add(btnJoin);
            Controls.Add(btnLogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label btnJoin;
        private TextBox txtId;
        private TextBox txtPwd;
    }
}