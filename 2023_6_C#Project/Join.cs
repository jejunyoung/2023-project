using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _2023_6_C_Project
{
    public partial class Join : Form
    {
        //정규표현식
        private string namePattern = @" ^ [a-zA-Z]{2,6}$"; //한국어만 가능 길이 3~6
        public Join()
        {
            InitializeComponent();
        }

        int checkid;

        private void btnCheckId_Click(object sender, EventArgs e)
        {
            try
            {
                // MySQL 데이터베이스 연결 설정
                MySqlConnection connection = new MySqlConnection("Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;");
                connection.Open();

                // 입력된 아이디가 이미 존재하는지 확인하기 위한 쿼리
                string checkQuery = "SELECT COUNT(*) as cnt FROM usertbl WHERE userId = @userId";
                MySqlCommand command = new MySqlCommand(checkQuery, connection);
                command.Parameters.AddWithValue("@userId", txtId.Text);
                // 쿼리 실행 결과로 아이디 중복 여부 확인
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("사용할 수 없는 아이디입니다"); // 이미 존재하는 아이디인 경우 메시지 표시
                }
                else if (!ValidateUserId(txtId.Text)){
                    MessageBox.Show("아이디는 영어, 숫자, 한국어만 사용이 가능합니다");
                }
                else
                {
                    MessageBox.Show("사용 가능한 아이디입니다");  // 아이디가 사용 가능한 경우 메시지 표시 
                    checkid = 1;
                }
                // 데이터베이스 연결 닫기
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // 예외 발생 시 예외 메시지를 표시
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateUserId(txtId.Text) && (ValidateUserPw(txtPwd.Text)) && (ValidateUserName(txtName.Text)))
                {
                    // 아이디 중복 확인이 완료된 경우
                    if (checkid == 1)
                    {
                        // MySQL 데이터베이스 연결 설정
                        MySqlConnection connection = new MySqlConnection("Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;");
                        connection.Open();

                        // 사용자 정보를 데이터베이스에 삽입하기 위한 쿼리
                        string insertQuery = "INSERT INTO usertbl (userName, userId, userPw) VALUES (@userName, @userId, @userPwd)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);

                        // MySqlCommand를 생성하고 파라미터 추가
                        insertCommand.Parameters.AddWithValue("@userName", txtName.Text);
                        insertCommand.Parameters.AddWithValue("@userId", txtId.Text);
                        insertCommand.Parameters.AddWithValue("@userPwd", txtPwd.Text);

                        // 데이터베이스에 삽입 쿼리 실행 후 결과 확인
                        if (insertCommand.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show(txtName.Text + "님 회원가입을 축하합니다"); // 회원가입 성공 메시지 표시
                            connection.Close();
                            Close(); //화면 닫기(로그인 화면으로 이동)
                        }
                        else
                        {
                            MessageBox.Show("재확인 부탁드립니다");// 회원가입 실패 메시지 표시
                        }
                    }
                    else
                    {
                        MessageBox.Show("아이디 중복 확인을 해주세요."); // 아이디 중복 확인을 하지 않은 경우 메시지 표시
                    }
                }
                else if (!ValidateUserId(txtId.Text))
                {
                    MessageBox.Show("아이디는 영어,숫자만 사용이 가능합니다");
                }
                else if (!ValidateUserPw(txtPwd.Text))
                {
                    MessageBox.Show("비밀번호는 영어, 숫자, 특수문자만 사용이 가능합니다");
                }
                else if (!ValidateUserName(txtName.Text))
                {
                    MessageBox.Show("이름은 영어, 한국어만 사용이 가능합니다");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // 예외 발생 시 예외 메시지 표시
            }
        }



        private bool ValidateUserId(string userId)
        {
            string pattern = "^[a-zA-Z0-9]+$";
            return Regex.IsMatch(userId, pattern);
        }

        private bool ValidateUserPw(string userPw)
        {
            string pattern = "^[a-zA-Z0-9!@#$%^&*()-_+=<>?]+$";
            return Regex.IsMatch(userPw, pattern);
        }
        private bool ValidateUserName(string userName)
        {
            string pattern = "^[a-zA-Z가-힣]+$";
            return Regex.IsMatch(userName, pattern);
        }
    }
}

