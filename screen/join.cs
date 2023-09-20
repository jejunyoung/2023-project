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
    public partial class join : Form
    {
        public join()
        {
            InitializeComponent();
        }

        int checkid;

        private void btn_checkId_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;");
                connection.Open();

                string checkQuery = "SELECT COUNT(*) as cnt FROM usertbl WHERE userId = @userId";
                MySqlCommand command = new MySqlCommand(checkQuery, connection);
                command.Parameters.AddWithValue("@userId", txt_id.Text);
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("사용할 수 없는 아이디 입니다.");
                }
                else
                {
                    MessageBox.Show("사용 가능한 아이디 입니다.");
                    checkid = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkid == 1)
                {
                    MySqlConnection connection = new MySqlConnection("Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;");
                    connection.Open();

                    string insertQuery = "INSERT INTO usertbl (userName, userId, userPw) VALUES (@userName, @userId, @userPw)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);

                    // Parameters
                    insertCommand.Parameters.AddWithValue("@userName", txt_name.Text);
                    insertCommand.Parameters.AddWithValue("@userId", txt_id.Text);
                    insertCommand.Parameters.AddWithValue("@userPw", txt_pwd.Text);

                    if (insertCommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show(txt_name.Text + "님 회원가입을 축하합니다.");
                        connection.Close();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("재확인 부탁드립니다");
                    }
                }
                else
                {
                    MessageBox.Show("아이디 중복 확인을 해주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void join_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
