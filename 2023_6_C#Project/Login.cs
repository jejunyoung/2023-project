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
using System.Text.RegularExpressions;


namespace _2023_6_C_Project
{
    public partial class Login : Form
    {
        //정규표현식
        private string idPattern = @"^[a-zA-Z0-9!@#$%^&*()-_+=<>?]{1,12}$"; //영어 숫자 특수문자 가능 길이 1~12
        private string passwordPattern = @"^[a-zA-Z0-9!@#$%^&*()-_+=<>?]{1,12}$"; //영어 숫자 특수문자 가능 길이 1~12

        public Login()
        {
            InitializeComponent();
        }

        public class UserManager
        {
            public static int UserNum { get; set; }
        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                // MySQL 데이터베이스 연결 설정
                MySqlConnection connection = new MySqlConnection("Server = mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;");
                connection.Open();

                // 사용자가 입력한 아이디와 비밀번호 가져오기
                string loginid = txtId.Text;
                string loginpwd = txtPwd.Text;

                // 테이블 연결 쿼리
                string selectQuery = "SELECT userId, userNum FROM usertbl WHERE userId = @loginid AND userPw = @loginpwd";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@loginid", loginid);
                selectCommand.Parameters.AddWithValue("@loginpwd", loginpwd);
                MySqlDataReader userAccount = selectCommand.ExecuteReader();

                // 로그인 성공한 경우
                if (userAccount.Read())
                {
                    Program.UserNum = userAccount["userNum"].ToString(); // userNum 값을 Program의 UserNum 변수에 저장


                    Main form = new Main();
                    Hide();
                    form.ShowDialog();
                    Application.Exit();
                }
                // 로그인 실패 메시지 표시
                else
                {
                    MessageBox.Show("로그인 실패");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJoin_Click(object sender, EventArgs e) //회워가입 버튼으로 회원가입창 열기
        {
            Join form = new Join(); // 새로운 Join 폼 인스턴스 생성
            this.Hide(); // 현재 창 숨기기
            form.ShowDialog();// 회원가입 폼 열기
            this.Show();  // 현재 창 다시 표시하기(회원가입창을 닫으면)
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 아이디에 대한 정규식 검증
            if (!char.IsControl(e.KeyChar) && !Regex.IsMatch(txtId.Text + e.KeyChar, idPattern))
            {
                e.Handled = true; // 입력된 문자를 처리하지 않음
            }
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 비밀번호에 대한 정규식 검증
            if (!char.IsControl(e.KeyChar) && !Regex.IsMatch(txtPwd.Text + e.KeyChar, passwordPattern))
            {
                e.Handled = true; // 입력된 문자를 처리하지 않음
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
