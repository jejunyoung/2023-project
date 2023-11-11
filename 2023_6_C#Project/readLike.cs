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
    public partial class readLike : Form
    {
        private string userNum;
        public readLike()
        {
            InitializeComponent();
            userNum = Program.UserNum;
        }

        private void readLike_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT readLikeTbl.bookID, booktbl.bookCover, booktbl.bookName FROM readLikeTbl " +
                               "INNER JOIN booktbl ON readLikeTbl.bookID = booktbl.bookID " +
                               "WHERE readLikeTbl.userNum = @userNum";

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
                                        groupBox.Tag = bookID;
                                        groupBox.Click += groupBox_Click;
                                        this.Controls.Add(groupBox);

                                        PictureBox pictureBox = new PictureBox();
                                        pictureBox.Location = new Point(40, 20);
                                        pictureBox.Size = new Size(100, 130);
                                        groupBox.Controls.Add(pictureBox);
                                        pictureBox.Click += groupBox_Click;

                                        using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imageData))
                                        {
                                            pictureBox.Image = Image.FromStream(ms);
                                        }

                                        Label nameLabel = new Label();
                                        nameLabel.Location = new Point(20, 160);
                                        nameLabel.Size = new Size(120, 25);
                                        nameLabel.Text = bookName;
                                        groupBox.Controls.Add(nameLabel);
                                        pictureBox.Click += groupBox_Click;

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
        public void groupBox_Click(object sender, EventArgs e)
        {
            // 클릭한 컨트롤을 확인
            Control clickedControl = sender as Control;

            // 클릭한 그룹 박스, 이미지 박스, 라벨을 가져옴
            Control parentControl = GetParentGroupBox(clickedControl);

            // 클릭한 그룹 박스에서 ISBN 정보 가져오기
            if (parentControl is GroupBox)
            {
                string readLikeBookID = GetIsbnInfoFromGroupBox(parentControl as GroupBox);

                DreadLike form = new DreadLike(readLikeBookID);
                this.Hide();
                form.ShowDialog();
                Application.Exit();
            }

        }


        // 클릭한 컨트롤의 부모 그룹 박스를 찾는 메서드
        private Control GetParentGroupBox(Control control)
        {
            while (control != null && !(control is GroupBox))
            {
                control = control.Parent;
            }
            return control;
        }

        // 클릭한 그룹 박스에서 ISBN 정보를 가져오는 메서드
        private string GetIsbnInfoFromGroupBox(GroupBox groupBox)
        {
            if (groupBox != null && groupBox.Tag != null)
            {
                // 그룹 박스의 Tag 속성에서 ISBN 정보를 가져옵니다.
                string readLikeBookID = groupBox.Tag.ToString(); // Tag는 object 형식이므로 ToString()으로 변환
                return readLikeBookID;
            }

            return "ISBN 정보를 찾을 수 없습니다.";
        }

        private void labReadDone_Click(object sender, EventArgs e)
        {
            readDone form = new readDone();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }

        private void labReading_Click(object sender, EventArgs e)
        {
            reading form = new reading();
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Preferences form = new Preferences();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }
    }
}
