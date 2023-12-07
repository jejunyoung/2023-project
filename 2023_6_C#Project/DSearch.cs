using MySql.Data.MySqlClient;
using System.Xml;
using System.Net.Http;
using System;
using System.Windows.Forms;
using System.Xml.Linq;
using MySqlX.XDevAPI.Common;
using Microsoft.VisualBasic.ApplicationServices;

namespace _2023_6_C_Project
{
    public partial class DSearch : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        private string isbnInfo;
        private string userNum;

        public DSearch(string isbnInfo)
        {
            this.isbnInfo = isbnInfo; //검색한 책 번호 가져오기
            userNum = Program.UserNum; //program에서 사용자 번호 가져오기
            InitializeComponent();

            // 비동기 메서드 호출
            InitializeSearch(isbnInfo);
        }

        // Aladin API에서 책 정보를 가져오는 비동기 메서드
        private async void InitializeSearch(string isbnInfo)
        {
            try
            {
                string result = await GetAladinApiResults(isbnInfo);
                DisplaySearchResults(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류: " + ex.Message); // 예외 발생 시 메시지 박스로 에러 메시지 출력
            }
        }

        // Aladin API에 요청을 보내고 결과를 문자열로 반환하는 메서드
        private async Task<string> GetAladinApiResults(string query)
        {
            string apiUrl = "http://www.aladin.co.kr/ttb/api/ItemSearch.aspx";
            string TTBKey = "ttbwere090851412001";

            try
            {
                string url = $"{apiUrl}?ttbkey={TTBKey}&Query={query}&MaxResults=20";
                return await httpClient.GetStringAsync(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"API 호출 중 오류 발생: {ex.Message}");
                return string.Empty;
            }
        }

        // Aladin API 결과를 파싱하여 화면에 표시하는 메서드
        public void DisplaySearchResults(string result)
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(result);

                XmlNamespaceManager nsManager = new XmlNamespaceManager(xml.NameTable);
                nsManager.AddNamespace("ns", "http://www.aladin.co.kr/ttb/apiguide.aspx");

                XmlNodeList list = xml.SelectNodes("//ns:item", nsManager);
                foreach (XmlNode itemNode in list)
                {
                    // 각 책 정보를 XML에서 추출
                    XmlNode titleNode = itemNode.SelectSingleNode("ns:title", nsManager);
                    XmlNode authorNode = itemNode.SelectSingleNode("ns:author", nsManager);
                    XmlNode publisherNode = itemNode.SelectSingleNode("ns:publisher", nsManager);
                    XmlNode pubdateNode = itemNode.SelectSingleNode("ns:pubDate", nsManager);
                    XmlNode coverNode = itemNode.SelectSingleNode("ns:cover", nsManager);
                    XmlNode descriptionNode = itemNode.SelectSingleNode("ns:description", nsManager);
                    XmlNode customerReviewRankNode = itemNode.SelectSingleNode("ns:customerReviewRank", nsManager);
                    XmlNode isbn13Node = itemNode.SelectSingleNode("ns:isbn13", nsManager); // isbn(국제 표준 도서 번호)정보 가져오기

                    // 가져온 정보가 null이 아닌지 확인
                    if (titleNode != null && authorNode != null && publisherNode != null &&
                        pubdateNode != null && descriptionNode != null && customerReviewRankNode != null && isbn13Node != null)
                    {
                        // 각 정보 추출
                        string title = titleNode.InnerText;
                        string author = authorNode.InnerText;
                        string publisher = publisherNode.InnerText;
                        string pubdateStr = pubdateNode.InnerText;
                        string cover = (coverNode != null) ? coverNode.InnerText : string.Empty;
                        string description = System.Text.RegularExpressions.Regex.Replace(descriptionNode.InnerText, "<.*?>", string.Empty);
                        string customerReviewRank = customerReviewRankNode.InnerText;
                        string isbn = isbn13Node.InnerText;

                        // 화면에 표시
                        titleLabel.Text = title;
                        authorLabel.Text = "저자: " + author;
                        labelpublisher.Text = "출판사: " + publisher;
                        labelpubdate.Text = "출간일: " + pubdateStr;
                        pictureBox.Load(cover);
                        txtDescription.Text = description;
                        labelcustomerReviewRank.Text = customerReviewRank;

                        // 가져온 도서 정보를 데이터베이스에 저장
                        InsertBookData(isbn, title, cover);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // 예외 발생 시 메시지 박스로 에러 메시지 출력
            }
        }


        // 도서 정보를 데이터베이스에 저장하는 메서드
        private void InsertBookData(string isbn, string title, string cover)
        {
            try
            {
                // MySQL 데이터베이스 연결 문자열
                string connectionString = "Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;"; //

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open(); // 데이터베이스 연결

                    // 이미 저장된 책인지 확인
                    string checkQuery = "SELECT bookID FROM booktbl WHERE bookID = @isbn";
                    MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@isbn", isbn);
                    object result = checkCommand.ExecuteScalar();

                    if (result == null)
                    {
                        // 이미 저장된 책이 없는 경우에만 저장
                        string insertQuery = "INSERT INTO booktbl (bookID, bookName, bookCover) VALUES (@isbn, @title, @cover)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@isbn", isbn);
                        insertCommand.Parameters.AddWithValue("@title", title);
                        insertCommand.Parameters.AddWithValue("@cover", cover);
                        insertCommand.ExecuteNonQuery();
                    }

                    connection.Close(); // 데이터베이스 닫기
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // 예외 발생 시 메시지 박스로 에러 메시지 출력
            }
        }

        //이동(메인화면)
        private void mainLogo_Click(object sender, EventArgs e)
        {
            Main form = new Main();
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
        }

        // 저장 버튼 클릭 시 그룹박스 표시
        private void btnSave_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        // 읽은 책으로 저장하는 메서드
        private void picReadDone_Click(object sender, EventArgs e)
        {
            // MySQL 데이터베이스 연결 문자열
            MySqlConnection connection = new MySqlConnection("Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;");

            connection.Open(); // 데이터베이스 연결

            try
            {
                // MySQL 쿼리문
                string checkQuery = "SELECT COUNT(*) FROM readDoneTbl WHERE bookID = @bookID AND userNum = @userNum";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@bookID", isbnInfo);
                checkCommand.Parameters.AddWithValue("@userNum", userNum);

                int rowCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (rowCount > 0)
                {
                    MessageBox.Show("이미 저장된 책입니다");
                }
                else
                {
                    // 중복이 아닌 경우에만 저장 , MySQL 쿼리문
                    string insertQuery = "INSERT INTO readDoneTbl (bookID, userNum) VALUES (@bookID, @userNum)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@bookID", isbnInfo);
                    insertCommand.Parameters.AddWithValue("@userNum", userNum);

                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("읽은 책에 저장되었습니다.");
                    }
                    else
                    {
                        MessageBox.Show("책 저장 중 오류 발생");
                    }
                }

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("데이터베이스 오류: " + ex.Message); // 예외 발생 시 메시지 박스로 에러 메시지 출력
            }
        }

        //이동(책 저장관)
        private void readDonePic_Click(object sender, EventArgs e)
        {
            readDone form = new readDone();
            this.Hide();
            form.ShowDialog();
        }

        // 읽는 중인 책으로 저장하는 메서드
        private void picReading_Click(object sender, EventArgs e)
        {
            // MySQL 데이터베이스 연결 문자열
            MySqlConnection connection = new MySqlConnection("Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;");

            connection.Open();// 데이터베이스 연결

            try
            {
                // MySQL 쿼리문
                string checkQuery = "SELECT COUNT(*) FROM readingTbl WHERE bookID = @bookID AND userNum = @userNum";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@bookID", isbnInfo);
                checkCommand.Parameters.AddWithValue("@userNum", userNum);

                int rowCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (rowCount > 0)
                {
                    MessageBox.Show("이미 저장된 책입니다");
                }
                else
                {
                    // 중복이 아닌 경우에만 저장 , MySQL 쿼리문
                    string insertQuery = "INSERT INTO readingTbl (bookID, userNum) VALUES (@bookID, @userNum)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@bookID", isbnInfo);
                    insertCommand.Parameters.AddWithValue("@userNum", userNum);

                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("읽은 책에 저장되었습니다.");
                    }
                    else
                    {
                        MessageBox.Show("책 저장 중 오류 발생");
                    }
                }

                connection.Close(); // 데이터베이스 닫기
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("데이터베이스 오류: " + ex.Message); // 예외 발생 시 메시지 박스로 에러 메시지 출력
            }
        }

        // 좋아하는 책으로 저장하는 메서드
        private void picReadLike_Click(object sender, EventArgs e)
        {
            // MySQL 데이터베이스 연결 문자열
            MySqlConnection connection = new MySqlConnection("Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;");

            connection.Open();// 데이터베이스 연결

            try
            {
                // MySQL 쿼리문
                string checkQuery = "SELECT COUNT(*) FROM readLikeTbl WHERE bookID = @bookID AND userNum = @userNum";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@bookID", isbnInfo);
                checkCommand.Parameters.AddWithValue("@userNum", userNum);

                int rowCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (rowCount > 0)
                {
                    MessageBox.Show("이미 저장된 책입니다");
                }
                else
                {
                    // 중복이 아닌 경우에만 저장 , MySQL 쿼리문
                    string insertQuery = "INSERT INTO readLikeTbl (bookID, userNum) VALUES (@bookID, @userNum)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@bookID", isbnInfo);
                    insertCommand.Parameters.AddWithValue("@userNum", userNum);

                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("읽은 책에 저장되었습니다.");
                    }
                    else
                    {
                        MessageBox.Show("책 저장 중 오류 발생");
                    }
                }

                connection.Close(); // 데이터베이스 닫기
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message); // 예외 발생 시 메시지 박스로 에러 메시지 출력
            }
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
        private void readDonePic_Click_1(object sender, EventArgs e)
        {
            readDone form = new readDone();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }
    }
}
