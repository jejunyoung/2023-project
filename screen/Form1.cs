using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;");
                connection.Open();

                int login_status = 0;
                String loginid = txt_id.Text;
                String loginpwd = txt_pwd.Text;

                String selectQuery = "SELECT * FROM usertbl";
                MySqlCommand Selectcommand = new MySqlCommand(selectQuery, connection);
                MySqlDataReader userAccount = Selectcommand.ExecuteReader();

                while (userAccount.Read())
                {
                    if (loginid == (string)userAccount["userId"] && loginpwd == (string)userAccount["userPw"])
                    {
                        login_status = 1;
                    }
                }
                connection.Close();

                if (login_status == 1)
                {
                    MessageBox.Show("로그인 성공");

                    // Form3 인스턴스 생성
                    home form3 = new home();
                    this.Hide();
                    form3.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("로그인 실패");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            // Form2 인스턴스 생성
            join form2 = new join();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}