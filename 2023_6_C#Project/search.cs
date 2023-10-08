using System;
using System.Net.Http;
using System.Windows.Forms;
using System.Drawing;
using System.Xml;

namespace _2023_6_C_Project
{
    public partial class search : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        private int currentPage = 1;
        private int itemsPerPage = 4; // 페이지당 그룹 박스 개수
        private int groupBoxTop = 10; // 그룹 박스의 위치 조정을 위한 변수

        public search()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            // 검색 시작 시 currentPage 초기화
            currentPage = 1;

            string query = txtSearch.Text;
            string result = await GetAladinApiResults(query);

            // 현재 페이지(currentPage)를 전달하면서 DisplaySearchResults 호출
            DisplaySearchResults(result, currentPage);
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

        private void DisplaySearchResults(string result, int currentPage)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result);

            // 네임스페이스 처리를 위한 XmlNamespaceManager 생성
            XmlNamespaceManager nsManager = new XmlNamespaceManager(xml.NameTable);
            nsManager.AddNamespace("ns", "http://www.aladin.co.kr/ttb/apiguide.aspx"); // 네임스페이스 URI를 여기에 지정

            XmlNodeList list = xml.SelectNodes("//ns:item", nsManager); // "item" 요소를 가져옴

            // 이전에 추가된 그룹 박스와 그룹 내 컨트롤들을 모두 제거
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox)
                {
                    this.Controls.Remove(control);
                    control.Dispose();
                }
            }

            int groupBoxTop = 170;

            int startIndex = (currentPage - 1) * itemsPerPage;
            int endIndex = startIndex + itemsPerPage;

            for (int i = startIndex; i < endIndex && i < list.Count; i++)
            {
                XmlNode itemNode = list[i];
                XmlNode titleNode = itemNode.SelectSingleNode("ns:title", nsManager);
                XmlNode authorNode = itemNode.SelectSingleNode("ns:author", nsManager);
                XmlNode publisherNode = itemNode.SelectSingleNode("ns:publisher", nsManager);
                XmlNode pubdateNode = itemNode.SelectSingleNode("ns:pubDate", nsManager);
                XmlNode coverNode = itemNode.SelectSingleNode("ns:cover", nsManager);

                if (titleNode != null && authorNode != null && publisherNode != null && pubdateNode != null)
                {
                    string title = titleNode.InnerText;
                    string author = authorNode.InnerText;
                    string publisher = publisherNode.InnerText;
                    string pubdateStr = pubdateNode.InnerText;
                    string cover = (coverNode != null) ? coverNode.InnerText : string.Empty;
                    DateTime pubDate;
                    string formattedPubDate = "";

                    if (DateTime.TryParse(pubdateStr, out pubDate))
                    {
                        formattedPubDate = pubDate.ToString("yyyy-MM-dd");
                    }

                    // 그룹 박스 생성
                    GroupBox groupBox = new GroupBox();
                    groupBox.Text = "";
                    groupBox.Location = new Point(50, groupBoxTop);
                    groupBox.Size = new Size(650, 150);
                    this.Controls.Add(groupBox);

                    // 이미지 박스 추가
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point(20, 20);
                    pictureBox.Size = new Size(100, 120);
                    groupBox.Controls.Add(pictureBox);

                    // 라벨 추가 (제목)
                    Label titleLabel = new Label();
                    titleLabel.Location = new Point(150, 20);
                    groupBox.Controls.Add(titleLabel);

                    // 라벨 추가 (저자)
                    Label authorLabel = new Label();
                    authorLabel.Location = new Point(150, 40);
                    groupBox.Controls.Add(authorLabel);

                    // 라벨 추가 (출판사)
                    Label publisherLabel = new Label();
                    publisherLabel.Location = new Point(150, 60);
                    groupBox.Controls.Add(publisherLabel);

                    // 라벨 추가 (출간일)
                    Label pubdateLabel = new Label();
                    pubdateLabel.Location = new Point(150, 80);
                    groupBox.Controls.Add(pubdateLabel);

                    titleLabel.Text = "제목: " + title;
                    authorLabel.Text = "저자: " + author;
                    publisherLabel.Text = "출판사: " + publisher;
                    pubdateLabel.Text = "출간일: " + formattedPubDate;

                    try
                    {
                        pictureBox.Load(cover);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("이미지 로드 중 오류 발생: " + ex.Message);
                    }

                    groupBoxTop += groupBox.Height + 10;
                }
            }

            Button prevPageButton = new Button();
            prevPageButton.Text = "이전 페이지";
            prevPageButton.Location = new Point(10, groupBoxTop);
            prevPageButton.Click += (sender, e) =>
            {
                if (currentPage > 1)
                {
                    currentPage--;
                    groupBoxTop = 10;
                    DisplaySearchResults(result, currentPage); // 현재 페이지(currentPage) 전달
                }
            };
            this.Controls.Add(prevPageButton);

            Button nextPageButton = new Button();
            nextPageButton.Text = "다음 페이지";
            nextPageButton.Location = new Point(110, groupBoxTop);
            nextPageButton.Click += (sender, e) =>
            {
                if (currentPage < 5 && endIndex < list.Count)
                {
                    currentPage++;
                    groupBoxTop = 10;
                    DisplaySearchResults(result, currentPage); // 현재 페이지(currentPage) 전달
                }
            };
            this.Controls.Add(nextPageButton);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void searchLv_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void mainLogo_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }
    }
}
