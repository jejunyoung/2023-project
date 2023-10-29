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
            this.isbnInfo = isbnInfo;
            userNum = Program.UserNum;
            InitializeComponent(); // Initialize 메서드는 파라미터를 받지 않도록 변경했습니다.

            MessageBox.Show(isbnInfo);
            MessageBox.Show(userNum);

            // 비동기 메서드 호출
            InitializeSearch(isbnInfo);
        }

        private void DetailedSearch_Load(object sender, EventArgs e)
        {
        }

        private async void InitializeSearch(string isbnInfo)
        {
            try
            {
                string result = await GetAladinApiResults(isbnInfo);
                DisplaySearchResults(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류: " + ex.Message);
            }
        }

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

        public void DisplaySearchResults(string result)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result);

            XmlNamespaceManager nsManager = new XmlNamespaceManager(xml.NameTable);
            nsManager.AddNamespace("ns", "http://www.aladin.co.kr/ttb/apiguide.aspx");

            XmlNodeList list = xml.SelectNodes("//ns:item", nsManager);
            foreach (XmlNode itemNode in list)
            {
                XmlNode titleNode = itemNode.SelectSingleNode("ns:title", nsManager);
                XmlNode authorNode = itemNode.SelectSingleNode("ns:author", nsManager);
                XmlNode publisherNode = itemNode.SelectSingleNode("ns:publisher", nsManager);
                XmlNode pubdateNode = itemNode.SelectSingleNode("ns:pubDate", nsManager);
                XmlNode coverNode = itemNode.SelectSingleNode("ns:cover", nsManager);
                XmlNode descriptionNode = itemNode.SelectSingleNode("ns:description", nsManager);
                XmlNode customerReviewRankNode = itemNode.SelectSingleNode("ns:customerReviewRank", nsManager);
                XmlNode isbn13Node = itemNode.SelectSingleNode("ns:isbn13", nsManager); // isbn(국제 표준 도서 번호)정보 가져오기

                if (titleNode != null && authorNode != null && publisherNode != null &&
                    pubdateNode != null && descriptionNode != null && customerReviewRankNode != null && isbn13Node != null)
                {
                    string title = titleNode.InnerText;
                    string author = authorNode.InnerText;
                    string publisher = publisherNode.InnerText;
                    string pubdateStr = pubdateNode.InnerText;
                    string cover = (coverNode != null) ? coverNode.InnerText : string.Empty;
                    string description = System.Text.RegularExpressions.Regex.Replace(descriptionNode.InnerText, "<.*?>", string.Empty);
                    string customerReviewRank = customerReviewRankNode.InnerText;
                    string isbn = isbn13Node.InnerText;

                    titleLabel.Text = title;
                    authorLabel.Text = "저자: " + author;
                    labelpublisher.Text = "출판사: " + publisher;
                    labelpubdate.Text = "출간일: " + pubdateStr;
                    pictureBox.Load(cover);
                    txtDescription.Text = description;
                    labelcustomerReviewRank.Text = customerReviewRank;

                    InsertBookData(isbn, title, cover);
                }
            }
        }


        private void InsertBookData(string isbn, string title, string cover)
        {
            string connectionString = "Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

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

                connection.Close();
            }
        }


        private void mainLogo_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void searchLogo_Click(object sender, EventArgs e)
        {
            search form = new search();
            this.Hide();
            form.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void picReadDone_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;");
            connection.Open();

            try
            {
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
                    // 중복이 아닌 경우에만 저장
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
                MessageBox.Show("데이터베이스 오류: " + ex.Message);
            }
        }

        private void readDonePic_Click(object sender, EventArgs e)
        {
            readDone form = new readDone();
            this.Hide();
            form.ShowDialog();
        }
    }
}
