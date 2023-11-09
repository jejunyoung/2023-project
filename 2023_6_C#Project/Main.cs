using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;

namespace _2023_6_C_Project
{
    public partial class Main : Form
    {
        private string userNum;

        public Main()
        {
            InitializeComponent();
            userNum = Program.UserNum;
            this.DoubleBuffered = true;
            SetupLable();
        }

        private void search_Click(object sender, EventArgs e)
        {
            search form = new search(); // 새로운 search 폼 인스턴스 생성
            this.Hide(); // 현재 창 숨기기
            form.ShowDialog();//  폼 열기
        }
        private void textBox1_Click_1(object sender, EventArgs e)
        {
            search form = new search();// search 폼 인스턴스 생성
            this.Close();  // 현재 폼 숨기기
            form.ShowDialog();  // search 폼 열기
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            readDone form = new readDone();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT readDoneTbl.bookID, booktbl.bookName " +
                               "FROM readDoneTbl " +
                               "INNER JOIN booktbl ON readDoneTbl.bookID = booktbl.bookID " +
                               "WHERE readDoneTbl.userNum = @userNum";

                int controlIndex = 1; // 이미지 박스와 라벨의 인덱스

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userNum", userNum);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read() && controlIndex <= 30)
                        {
                            long bookID = reader.GetInt64("bookID");
                            string bookName = reader.GetString("bookName");

                            // 이미지 박스와 라벨을 폼에서 찾기
                            PictureBox pictureBox = (PictureBox)this.Controls.Find("picBook" + controlIndex, true).FirstOrDefault();
                            Label label = (Label)this.Controls.Find("labBook" + controlIndex, true).FirstOrDefault();

                            if (pictureBox != null && label != null)
                            {
                                label.Text = bookName;

                                pictureBox.Visible = true;

                                // 인덱스 증가
                                controlIndex++;
                            }
                        }
                    }
                }
            }
        }

        private void SetupLable()
        {
            labBook1.Parent = picBook1;
            labBook1.BackColor = Color.Transparent;
            labBook1.Location = new Point(10, 30);

            labBook2.Parent = picBook2;
            labBook2.BackColor = Color.Transparent;
            labBook2.Location = new Point(10, 30);

            labBook3.Parent = picBook3;
            labBook3.BackColor = Color.Transparent;
            labBook3.Location = new Point(10, 30);

            labBook4.Parent = picBook4;
            labBook4.BackColor = Color.Transparent;
            labBook4.Location = new Point(10, 30);

            labBook5.Parent = picBook5;
            labBook5.BackColor = Color.Transparent;
            labBook5.Location = new Point(10, 20);

            labBook6.Parent = picBook6;
            labBook6.BackColor = Color.Transparent;
            labBook6.Location = new Point(10, 20);

            labBook7.Parent = picBook7;
            labBook7.BackColor = Color.Transparent;
            labBook7.Location = new Point(10, 30);

            labBook8.Parent = picBook8;
            labBook8.BackColor = Color.Transparent;
            labBook8.Location = new Point(10, 20);

            labBook9.Parent = picBook9;
            labBook9.BackColor = Color.Transparent;
            labBook9.Location = new Point(10, 20);

            labBook10.Parent = picBook10;
            labBook10.BackColor = Color.Transparent;
            labBook10.Location = new Point(10, 30);

            labBook11.Parent = picBook11;
            labBook11.BackColor = Color.Transparent;
            labBook11.Location = new Point(10, 20);

            labBook12.Parent = picBook12;
            labBook12.BackColor = Color.Transparent;
            labBook12.Location = new Point(10, 30);

            labBook13.Parent = picBook13;
            labBook13.BackColor = Color.Transparent;
            labBook13.Location = new Point(10, 20);

            labBook14.Parent = picBook14;
            labBook14.BackColor = Color.Transparent;
            labBook14.Location = new Point(10, 30);

            labBook15.Parent = picBook15;
            labBook15.BackColor = Color.Transparent;
            labBook15.Location = new Point(10, 30);

            labBook16.Parent = picBook16;
            labBook16.BackColor = Color.Transparent;
            labBook16.Location = new Point(10, 20);

            labBook17.Parent = picBook17;
            labBook17.BackColor = Color.Transparent;
            labBook17.Location = new Point(10, 30);

            labBook18.Parent = picBook18;
            labBook18.BackColor = Color.Transparent;
            labBook18.Location = new Point(10, 30);

            labBook19.Parent = picBook19;
            labBook19.BackColor = Color.Transparent;
            labBook19.Location = new Point(10, 20);

            labBook20.Parent = picBook20;
            labBook20.BackColor = Color.Transparent;
            labBook20.Location = new Point(10, 30);

            labBook21.Parent = picBook21;
            labBook21.BackColor = Color.Transparent;
            labBook21.Location = new Point(10, 20);

            labBook22.Parent = picBook22;
            labBook22.BackColor = Color.Transparent;
            labBook22.Location = new Point(10, 20);

            labBook23.Parent = picBook23;
            labBook23.BackColor = Color.Transparent;
            labBook23.Location = new Point(10, 30);

            labBook24.Parent = picBook24;
            labBook24.BackColor = Color.Transparent;
            labBook24.Location = new Point(10, 20);

            labBook25.Parent = picBook25;
            labBook25.BackColor = Color.Transparent;
            labBook25.Location = new Point(10, 20);

            labBook26.Parent = picBook26;
            labBook26.BackColor = Color.Transparent;
            labBook26.Location = new Point(10, 30);

            labBook27.Parent = picBook27;
            labBook27.BackColor = Color.Transparent;
            labBook27.Location = new Point(10, 30);

            labBook28.Parent = picBook28;
            labBook28.BackColor = Color.Transparent;
            labBook28.Location = new Point(10, 30);

            labBook29.Parent = picBook29;
            labBook29.BackColor = Color.Transparent;
            labBook29.Location = new Point(10, 30);

            labBook30.Parent = picBook30;
            labBook30.BackColor = Color.Transparent;
            labBook30.Location = new Point(10, 20);
        }
    }
}
