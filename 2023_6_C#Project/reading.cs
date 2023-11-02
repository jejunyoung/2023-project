using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023_6_C_Project
{
    public partial class reading : Form
    {
        private string userNum;
        public reading()
        {
            InitializeComponent();
            userNum = Program.UserNum;
        }

        private void reading_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT readingTbl.bookID, booktbl.bookCover, booktbl.bookName FROM readingTbl " +
                               "INNER JOIN booktbl ON readingTbl.bookID = booktbl.bookID " +
                               "WHERE readingTbl.userNum = @userNum";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    int userNumToSearch = int.Parse(userNum);
                    command.Parameters.Add(new MySqlParameter("@userNum", MySqlDbType.Int32));
                    command.Parameters["@userNum"].Value = userNumToSearch;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        Panel panel = new Panel(); // 패널 생성
                        panel.Dock = DockStyle.Fill;
                        this.Controls.Add(panel); // 패널을 폼에 추가

                        int verticalSpacing = 10; // 수직 간격을 원하는 크기로 설정
                        int horizontalSpacing = 65; // 수평 간격을 원하는 크기로 설정

                        int columnCount = 3; // 세로로 표시할 열의 수
                        int itemWidth = 160; // 각 항목의 너비
                        int itemHeight = 200; // 각 항목의 높이
                        int x = 70; // 초기 X 위치
                        int y = 210; // 초기 Y 위치

                        while (reader.Read())
                        {
                            long bookID = reader.GetInt64(0);
                            string imageUrl = reader.GetString(1);
                            string bookName = reader.GetString(2);

                            if (!string.IsNullOrEmpty(imageUrl))
                            {
                                using (WebClient webClient = new WebClient())
                                {
                                    byte[] imageData = webClient.DownloadData(imageUrl);

                                    if (imageData != null)
                                    {
                                        GroupBox groupBox = new GroupBox();
                                        groupBox.Text = "";
                                        groupBox.Location = new Point(x, y);
                                        groupBox.Size = new Size(itemWidth, itemHeight);

                                        PictureBox pictureBox = new PictureBox();
                                        pictureBox.Location = new Point(40, 20);
                                        pictureBox.Size = new Size(100, 130);

                                        using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imageData))
                                        {
                                            pictureBox.Image = Image.FromStream(ms);
                                        }

                                        groupBox.Controls.Add(pictureBox);

                                        Label nameLabel = new Label();
                                        nameLabel.Location = new Point(20, 160);
                                        nameLabel.Size = new Size(120, 25);
                                        nameLabel.Text = bookName;
                                        groupBox.Controls.Add(nameLabel);

                                        panel.Controls.Add(groupBox); // 패널에 그룹박스 추가

                                        // 열을 다 채우면 다음 행으로 이동
                                        x += itemWidth + horizontalSpacing; // 수평 간격 추가
                                        if (x >= columnCount * (itemWidth + horizontalSpacing))
                                        {
                                            x = 70;
                                            y += itemHeight + verticalSpacing; // 수직 간격 추가
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void labReadDone_Click(object sender, EventArgs e)
        {
            readDone form = new readDone();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }

        private void labReadLike_Click(object sender, EventArgs e)
        {
            readLike form = new readLike();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }
    }
}
