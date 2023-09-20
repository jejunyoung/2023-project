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

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                //MySQL 데이터베이스 연결 설정
                MySqlConnection connection = new MySqlConnection("Server = mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;");
                connection.Open();

                // 로그인 상태를 나타내는 변수 초기화
                int login_status = 0;

                // 사용자가 입력한 아이디와 비밀번호 가져오기
                String loginid = txtId.Text;
                String loginpwd = txtPwd.Text;

                // 테이블연결 퀴리
                String selectQuery = "SELECT * FROM usertbl";
                MySqlCommand Selectcommand = new MySqlCommand(selectQuery, connection);
                MySqlDataReader userAccount = Selectcommand.ExecuteReader();

                // 사용자 테이블의 각 레코드를 반복하면서 로그인 검사
                while (userAccount.Read())
                {
                    if (loginid == (string)userAccount["userId"] && loginpwd == (string)userAccount["userPw"])
                    {
                        login_status = 1; // 로그인 성공 상태 플래그 설정
                    }
                }
                connection.Close(); // 데이터베이스 연결 닫기

                // 로그인 성공한 경우
                if (login_status == 1)
                {
                    Main form = new Main(); // Main 폼 인스턴스 생성
                    this.Hide();  // 현재 폼 숨기기
                    form.ShowDialog();  // Main 폼 열기
                    this.Show();  // 현재 폼 다시 표시하기(Main 품을 닫았을 경우)
                }
                // 로그인 실패 메시지 표시
                else
                {
                    MessageBox.Show("로그인 실패");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // 예외 발생 시 메시지 박스로 예외 내용 표시
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