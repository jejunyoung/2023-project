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
        private List<GroupBox> groupBoxList = new List<GroupBox>();
        private int currentPageIndex = 0;
        private int booksPerPage = 9;

        public reading()
        {
            InitializeComponent();
            userNum = Program.UserNum; //program에서 사용자 번호 가져오기

            // "이전" 버튼 초기화
            Button btnPrevious = new Button();
            btnPrevious.Text = "이전";
            btnPrevious.Location = new Point(150, 790);
            btnPrevious.Size = new Size(100, 40);
            btnPrevious.Click += btnPrevious_Click;
            this.Controls.Add(btnPrevious);

            // "다음" 버튼 초기화
            Button btnNext = new Button();
            btnNext.Text = "다음";
            btnNext.Location = new Point(500, 790);
            btnNext.Size = new Size(100, 40);
            btnNext.Click += btnNext_Click;
            this.Controls.Add(btnNext);
        }

        private void reading_Load(object sender, EventArgs e)
        {
            try
            {
                readingBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPageIndex >= booksPerPage)
            {
                currentPageIndex -= booksPerPage;
                DisplayBooks();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPageIndex + booksPerPage < groupBoxList.Count)
            {
                currentPageIndex += booksPerPage;
                DisplayBooks();
            }
        }

        private void DisplayBooks()
        {
            int startIndex = currentPageIndex;
            int endIndex = Math.Min(currentPageIndex + booksPerPage, groupBoxList.Count);

            for (int i = 0; i < groupBoxList.Count; i++)
            {
                if (i >= startIndex && i < endIndex)
                {
                    groupBoxList[i].Visible = true;
                }
                else
                {
                    groupBoxList[i].Visible = false;
                }
            }
        }

        private void readingBooks()
        {
            try
            {
                groupBoxList.Clear(); // 기존의 그룹박스 리스트를 모두 제거

                // MySQL 데이터베이스 연결 문자열
                string connectionString = "Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();// 데이터베이스 연결

                    // MySQL 쿼리문
                    string query = "SELECT readingTbl.bookID, booktbl.bookCover, booktbl.bookName FROM readingTbl " +
                                   "INNER JOIN booktbl ON readingTbl.bookID = booktbl.bookID " +
                                   "WHERE readingTbl.userNum = @userNum";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // 쿼리 파라미터 설정
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

                            // 현재 페이지의 시작 인덱스 계산
                            int startIndex = currentPageIndex * booksPerPage;

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
                                            //그룹박스 생성
                                            GroupBox groupBox = new GroupBox();
                                            groupBox.Text = "";
                                            // 현재 페이지에서의 인덱스 계산
                                            int currentIndex = groupBoxList.Count % booksPerPage;

                                            // 현재 페이지의 행 및 열 계산
                                            int row = currentIndex / columnCount;
                                            int col = currentIndex % columnCount;

                                            int x = 70 + col * (itemWidth + horizontalSpacing);
                                            int y = 150 + row * (itemHeight + verticalSpacing);
                                            groupBox.Location = new Point(x, y);
                                            groupBox.Size = new Size(itemWidth, itemHeight);
                                            groupBox.Tag = bookID;
                                            groupBox.Click += groupBox_Click;
                                            this.Controls.Add(groupBox);

                                            // 그룹박스 리스트에 추가
                                            groupBoxList.Add(groupBox);

                                            //그룹박스 안 이미지 생성
                                            PictureBox pictureBox = new PictureBox();
                                            pictureBox.Location = new Point(40, 20);
                                            pictureBox.Size = new Size(100, 130);
                                            groupBox.Controls.Add(pictureBox);
                                            pictureBox.Click += groupBox_Click;
                                            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imageData))
                                            {
                                                pictureBox.Image = Image.FromStream(ms);
                                            }
                                            groupBox.Controls.Add(pictureBox);

                                            //그룹박스 안 책 이름 생성
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // 예외 발생 시 메시지 박스로 에러 메시지 출력
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
                string readingBookID = GetIsbnInfoFromGroupBox(parentControl as GroupBox);

                Dreading form = new Dreading(readingBookID);
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
                string readingBookID = groupBox.Tag.ToString(); // Tag는 object 형식이므로 ToString()으로 변환
                return readingBookID;
            }

            return "ISBN 정보를 찾을 수 없습니다.";
        }

        //이동(다 읽은 책)
        private void labReadDone_Click(object sender, EventArgs e)
        {
            readDone form = new readDone();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }

        //이동(좋아하는 책)
        private void labReadLike_Click(object sender, EventArgs e)
        {
            readLike form = new readLike();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }

        //이동(메인화면)
        private void mainLogo_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }

        //이동(사용자 설정)
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Preferences form = new Preferences();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }

        //이동(책 저장관)
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            readDone form = new readDone();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }

        //이동(검색창)
        private void searchLogo_Click(object sender, EventArgs e)
        {
            search form = new search();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }
    }
}
