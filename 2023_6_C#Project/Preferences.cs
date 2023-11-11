using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace _2023_6_C_Project
{
    public partial class Preferences : Form
    {
        private string userNum;

        public Preferences()
        {
            InitializeComponent();
            userNum = Program.UserNum;

        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT userId, userPw, userName " +
                               "FROM usertbl " +
                               "WHERE userNum = @userNum";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userNum", userNum);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userId = reader.GetString("userId");
                            string userPw = reader.GetString("userPw");
                            string userName = reader.GetString("userName");

                            txtName.Text = userName;
                            txtId.Text = userId;
                            txtPw.Text = userPw;
                        }
                    }
                }
            }
        }

        private void labCP_Click(object sender, EventArgs e)
        {
            string txtCPw = txtPw.Text;
            string connectionString = "Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                if (txtPw.Text == txtPw2.Text)
                {
                    string query = "UPDATE usertbl " +
                                   "SET userPw = @userPw " +
                                   "WHERE userNum = @userNum";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userPw", txtCPw);
                        command.Parameters.AddWithValue("@userNum", userNum);

                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("비밀번호 변경이 성공했습니다");

                                Login form = new Login();
                                this.Hide();
                                form.ShowDialog();
                                Application.Exit();
                            }
                            else
                            {
                                MessageBox.Show("업데이트된 행이 없습니다. 조건을 확인하세요.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"오류 발생: {ex.Message}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("비밀번호 확인과 다른 비밀번호입니다");
                }
            }
        }


        private void labLogOut_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }

        private void mainLogo_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            readDone form = new readDone();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }

        private void searchLogo_Click(object sender, EventArgs e)
        {
            search form = new search();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }
    }
}
