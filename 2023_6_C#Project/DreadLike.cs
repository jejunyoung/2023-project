using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace _2023_6_C_Project
{
    public partial class DreadLike : Form
    {
        private string readLikeBookID;
        private string userNum;
        public DreadLike(string readLikeBookID)
        {
            InitializeComponent();
            this.readLikeBookID = readLikeBookID;
            userNum = Program.UserNum;
        }

        private void DreadLike_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT readLikeTbl.bookID, booktbl.bookCover, booktbl.bookName, readLikeTbl.bookReport " +
               "FROM readLikeTbl " +
               "INNER JOIN booktbl ON readLikeTbl.bookID = booktbl.bookID " +
               "WHERE readLikeTbl.userNum = @userNum AND readLikeTbl.bookID = @readLikeBookID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userNum", userNum);
                    command.Parameters.AddWithValue("@readLikeBookID", readLikeBookID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long bookID = reader.GetInt64(0);
                            string imageUrl = reader.GetString(1);
                            string bookName = reader.GetString(2);
                            string bookReport = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);

                            if (!string.IsNullOrEmpty(imageUrl))
                            {
                                using (WebClient webClient = new WebClient())
                                {
                                    byte[] imageData = webClient.DownloadData(imageUrl);

                                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imageData))
                                    {
                                        picCover.Image = Image.FromStream(ms);
                                    }
                                    labName.Text = bookName;

                                    txtReport.Text = bookReport;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            readLike form = new readLike();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }

        private void UpdateBookReport()
        {
            string bookReportText = txtReport.Text; // 라벨2의 텍스트를 가져옵니다.

            string connectionString = "Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE readLikeTbl SET bookReport = @bookReport " +
                "WHERE userNum = @userNum AND bookID = @readLikeBookID";


                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userNum", userNum);
                    command.Parameters.AddWithValue("@readLikeBookID", readLikeBookID);
                    command.Parameters.AddWithValue("@bookReport", bookReportText); // 라벨2의 텍스트를 파라미터로 설정
                    // 필요한 조건을 WHERE 절에 지정

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("메모 저장에 성공했습니다.");
                    }
                    else
                    {
                        MessageBox.Show("업데이트된 행이 없습니다. 조건을 확인하세요.");
                    }
                }
            }
        }

        private void picSave_Click(object sender, EventArgs e)
        {
            UpdateBookReport();
        }

        private void labSave_Click(object sender, EventArgs e)
        {
            UpdateBookReport();
        }

        private void DeleteRecord()
        {
            string connectionString = "Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM readLikeTbl WHERE userNum = @userNum AND bookID = @readLikeBookID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userNum", userNum);
                    command.Parameters.AddWithValue("@readLikeBookID", readLikeBookID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("레코드가 성공적으로 삭제되었습니다.");
                        readLike form = new readLike();
                        this.Hide();
                        form.ShowDialog();
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("삭제할 레코드를 찾지 못했습니다. 조건을 확인하세요.");
                    }
                }
            }
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void labDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void mainLogo_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Preferences form = new Preferences();
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
