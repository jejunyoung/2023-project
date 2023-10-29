using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Net;

namespace _2023_6_C_Project
{
    public partial class readDone : Form
    {
        private string userNum;
        private int groupBoxTop = 170;

        public readDone()
        {
            InitializeComponent();
            userNum = Program.UserNum;
        }

        private void readDone_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT readDoneTbl.bookID, booktbl.bookCover, booktbl.bookName FROM readDoneTbl " +
                               "INNER JOIN booktbl ON readDoneTbl.bookID = booktbl.bookID " +
                               "WHERE readDoneTbl.userNum = @userNum";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    int userNumToSearch = int.Parse(userNum);
                    command.Parameters.Add(new MySqlParameter("@userNum", MySqlDbType.Int32));
                    command.Parameters["@userNum"].Value = userNumToSearch;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long bookID = reader.GetInt64(0);
                            string imageUrl = reader.GetString(1);
                            string bookName = reader.GetString(2); // bookName을 가져옴

                            if (!string.IsNullOrEmpty(imageUrl))
                            {
                                using (WebClient webClient = new WebClient())
                                {
                                    byte[] imageData = webClient.DownloadData(imageUrl);
                                    if (imageData != null)
                                    {
                                        GroupBox groupBox = new GroupBox();
                                        groupBox.Text = "";
                                        groupBox.Location = new Point(50, groupBoxTop);
                                        groupBox.Size = new Size(650, 150);

                                        PictureBox pictureBox = new PictureBox();
                                        pictureBox.Location = new Point(20, 20);
                                        pictureBox.Size = new Size(100, 120);

                                        using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imageData))
                                        {
                                            pictureBox.Image = Image.FromStream(ms);
                                        }

                                        groupBox.Controls.Add(pictureBox);

                                        // 라벨 추가 (bookName 표시)
                                        Label nameLabel = new Label();
                                        nameLabel.Location = new Point(150, 50);
                                        nameLabel.Size = new Size(200, 20);
                                        nameLabel.Text = "BookName: " + bookName;
                                        groupBox.Controls.Add(nameLabel);

                                        this.Controls.Add(groupBox);

                                        groupBoxTop += 170;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
