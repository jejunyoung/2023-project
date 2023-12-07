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
            try
            {
                // MySQL 데이터베이스에 연결하기 위한 연결 문자열 정의
                string connectionString = "Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;";

                // MySqlConnection을 사용하여 MySQL 데이터베이스에 연결하고 연결 열기
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // 사용자 테이블에서 userId, userPw, userName을 검색하는 SQL 쿼리 정의
                    string query = "SELECT userId, userPw, userName " +
                                   "FROM usertbl " +
                                   "WHERE userNum = @userNum";

                    // MySqlCommand 객체를 생성하고 userNum 매개변수를 추가하여 SQL 쿼리를 설정
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userNum", userNum);

                        // SQL 쿼리를 실행하고 결과를 읽기 위해 MySqlDataReader를 사용
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // 결과 집합을 반복하여 사용자 정보를 읽고 텍스트 상자에 설정
                            while (reader.Read())
                            {
                                string userId = reader.GetString("userId");
                                string userPw = reader.GetString("userPw");
                                string userName = reader.GetString("userName");

                                // 폼의 텍스트 상자에 사용자 정보 설정
                                txtName.Text = userName;
                                txtId.Text = userId;
                                txtPw.Text = userPw;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void labCP_Click(object sender, EventArgs e)
        {
            try
            {
                // 새 비밀번호를 텍스트 상자에서 가져오기
                string txtCPw = txtPw.Text;

                // MySQL 데이터베이스에 연결하기 위한 연결 문자열 정의
                string connectionString = "Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;";

                // MySqlConnection을 사용하여 MySQL 데이터베이스에 연결하고 연결 열기
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // 새 비밀번호와 확인 비밀번호가 일치하는지 확인
                    if (txtPw.Text == txtPw2.Text)
                    {
                        // 사용자 테이블에서 비밀번호를 업데이트하는 SQL 쿼리 정의
                        string query = "UPDATE usertbl " +
                                       "SET userPw = @userPw " +
                                       "WHERE userNum = @userNum";

                        // MySqlCommand 객체를 생성하고 매개변수를 추가하여 SQL 쿼리를 설정
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@userPw", txtCPw);
                            command.Parameters.AddWithValue("@userNum", userNum);

                            try
                            {
                                // SQL 쿼리 실행 및 영향 받은 행 수 확인
                                int rowsAffected = command.ExecuteNonQuery();

                                // 영향 받은 행이 있으면 비밀번호 변경 성공 메시지 출력 및 로그인 폼 열기
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("비밀번호 변경이 성공했습니다");

                                    // 로그인 폼 열기
                                    Login form = new Login();
                                    this.Hide();
                                    form.ShowDialog();
                                    Application.Exit();
                                }
                                else
                                {
                                    // 영향 받은 행이 없는 경우 메시지 출력
                                    MessageBox.Show("업데이트된 행이 없습니다. 조건을 확인하세요.");
                                }
                            }
                            catch (Exception ex)
                            {
                                // 오류가 발생한 경우 메시지 출력
                                MessageBox.Show($"오류 발생: {ex.Message}");
                            }
                        }
                    }
                    else
                    {
                        // 새 비밀번호와 확인 비밀번호가 일치하지 않는 경우 메시지 출력
                        MessageBox.Show("비밀번호 확인과 다른 비밀번호입니다");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
