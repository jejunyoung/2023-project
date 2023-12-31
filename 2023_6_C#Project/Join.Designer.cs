﻿namespace _2023_6_C_Project
{
    partial class Join
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Join));
            txtId = new TextBox();
            txtPwd = new TextBox();
            txtName = new TextBox();
            btnCheckId = new Label();
            btnJoin = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.BackColor = Color.Tan;
            txtId.BorderStyle = BorderStyle.None;
            txtId.Font = new Font("Noto Sans KR", 38.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtId.Location = new Point(203, 383);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "아이디";
            txtId.Size = new Size(311, 74);
            txtId.TabIndex = 0;
            // 
            // txtPwd
            // 
            txtPwd.BackColor = Color.Tan;
            txtPwd.BorderStyle = BorderStyle.None;
            txtPwd.Font = new Font("Noto Sans KR", 38.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPwd.Location = new Point(203, 502);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.PlaceholderText = "비밀번호";
            txtPwd.Size = new Size(350, 74);
            txtPwd.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Tan;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Noto Sans KR", 38.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(203, 656);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "이름";
            txtName.Size = new Size(350, 74);
            txtName.TabIndex = 2;
            // 
            // btnCheckId
            // 
            btnCheckId.AutoSize = true;
            btnCheckId.BackColor = Color.Transparent;
            btnCheckId.Font = new Font("강원교육현옥샘 Medium", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCheckId.ForeColor = SystemColors.ControlText;
            btnCheckId.Location = new Point(520, 392);
            btnCheckId.Name = "btnCheckId";
            btnCheckId.Size = new Size(123, 37);
            btnCheckId.TabIndex = 3;
            btnCheckId.Text = "아이디 확인";
            btnCheckId.Click += btnCheckId_Click;
            // 
            // btnJoin
            // 
            btnJoin.AutoSize = true;
            btnJoin.BackColor = Color.Transparent;
            btnJoin.Font = new Font("Noto Sans KR", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnJoin.Location = new Point(250, 806);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(206, 70);
            btnJoin.TabIndex = 4;
            btnJoin.Text = "회원가입";
            btnJoin.Click += btnJoin_Click;
            // 
            // Join
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(734, 961);
            Controls.Add(btnJoin);
            Controls.Add(btnCheckId);
            Controls.Add(txtName);
            Controls.Add(txtPwd);
            Controls.Add(txtId);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Join";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Join";
            Load += Join_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtPwd;
        private TextBox txtName;
        private Label btnCheckId;
        private Label btnJoin;
    }
}