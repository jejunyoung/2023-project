using System;
using System.Net.Http;
using System.Windows.Forms;
using System.Drawing;
using System.Xml;
using MySqlX.XDevAPI.Common;

namespace _2023_6_C_Project //test
{
    public partial class search : Form
    {
        private readonly HttpClient httpClient = new HttpClient(); // HttpClient 인스턴스를 생성하여 웹 요청을 보내는 데 사용

        private int currentPage = 1; // 현재 페이지 번호를 나타내는 변수
        private int itemsPerPage = 4; // 페이지당 표시할 항목 수를 나타내는 변수 (그룹 박스 개수)
        private string userNumber;
        private string userNum;

        public string isbn13 { get; private set; }

        public search()
        {
            userNum = Program.UserNum; // UserNum을 userNum으로 설정
            InitializeComponent(); // Windows Forms 애플리케이션의 초기화를 수행
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            // 검색 시작 시 currentPage 초기화
            currentPage = 1;

            string query = txtSearch.Text; // 검색어를 텍스트 상자에서 가져오기
            string result = await GetAladinApiResults(query); // Aladin API에서 결과를 비동기적으로 가져오기

            // 현재 페이지(currentPage)를 전달하면서 DisplaySearchResults 호출
            DisplaySearchResults(result, currentPage); // 검색 결과를 화면에 표시
        }

        private async Task<string> GetAladinApiResults(string query)
        {
            string apiUrl = "http://www.aladin.co.kr/ttb/api/ItemSearch.aspx"; // Aladin API의 엔드포인트 URL
            string TTBKey = "ttbwere090851412001"; // Aladin API 키

            try
            {
                // API 요청을 위한 URL 생성
                string url = $"{apiUrl}?ttbkey={TTBKey}&Query={query}&MaxResults=20";
                return await httpClient.GetStringAsync(url); // 비동기적으로 API 요청 및 결과를 문자열로 반환
            }
            catch (Exception ex)
            {
                MessageBox.Show($"API 호출 중 오류 발생: {ex.Message}"); // API 호출 중 오류 발생 시 메시지 표시
                return string.Empty; // 빈 문자열 반환
            }
        }

        public void DisplaySearchResults(string result, int currentPage)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result); // XML 형식의 검색 결과를 XmlDocument로 로드

            // 네임스페이스 처리를 위한 XmlNamespaceManager 생성
            XmlNamespaceManager nsManager = new XmlNamespaceManager(xml.NameTable);
            nsManager.AddNamespace("ns", "http://www.aladin.co.kr/ttb/apiguide.aspx"); // Aladin API의 네임스페이스 지정

            XmlNodeList list = xml.SelectNodes("//ns:item", nsManager); // "item" 요소를 선택

            // 이전에 추가된 그룹 박스와 그룹 내 컨트롤들을 모두 제거
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox)
                {
                    this.Controls.Remove(control);
                    control.Dispose();
                }
            }

            int groupBoxTop = 170; // 그룹 박스의 위치 상단 여백

            // 현재 페이지에 표시할 항목 범위 계산
            int startIndex = (currentPage - 1) * itemsPerPage;
            int endIndex = startIndex + itemsPerPage;

            for (int i = startIndex; i < endIndex && i < list.Count; i++)
            {
                XmlNode itemNode = list[i];
                XmlNode titleNode = itemNode.SelectSingleNode("ns:title", nsManager); // 제목 정보 가져오기
                XmlNode authorNode = itemNode.SelectSingleNode("ns:author", nsManager); // 저자 정보 가져오기
                XmlNode publisherNode = itemNode.SelectSingleNode("ns:publisher", nsManager); // 출판사 정보 가져오기
                XmlNode pubdateNode = itemNode.SelectSingleNode("ns:pubDate", nsManager); // 출간일 정보 가져오기
                XmlNode coverNode = itemNode.SelectSingleNode("ns:cover", nsManager); // 표지 이미지 URL 정보 가져오기
                XmlNode isbn13Node = itemNode.SelectSingleNode("ns:isbn13", nsManager); // isbn(국제 표준 도서 번호)정보 가져오기

                if (titleNode != null && authorNode != null && publisherNode != null && pubdateNode != null && isbn13Node != null)
                {
                    // 각 항목의 정보 추출
                    string title = titleNode.InnerText;
                    string author = authorNode.InnerText;
                    string publisher = publisherNode.InnerText;
                    string pubdateStr = pubdateNode.InnerText;
                    string cover = (coverNode != null) ? coverNode.InnerText : string.Empty; // 표지 이미지 URL
                    string isbn13 = isbn13Node.InnerText;

                    DateTime pubDate;
                    string formattedPubDate = "";

                    if (DateTime.TryParse(pubdateStr, out pubDate))
                    {
                        formattedPubDate = pubDate.ToString("yyyy-MM-dd"); // 출간일을 형식화
                    }

                    // 그룹 박스 생성
                    GroupBox groupBox = new GroupBox();
                    groupBox.Text = "";
                    groupBox.Location = new Point(50, groupBoxTop);
                    groupBox.Size = new Size(650, 150);
                    groupBox.Tag = isbn13; // ISBN 정보를 그룹 박스의 Tag 속성에 저장
                    // Click 이벤트 핸들러를 등록
                    groupBox.Click += groupBox_Click;
                    // 그룹 박스를 폼에 추가
                    this.Controls.Add(groupBox);

                    // 이미지 박스 추가
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point(20, 20);
                    pictureBox.Size = new Size(100, 120);
                    groupBox.Controls.Add(pictureBox);
                    // Click 이벤트 핸들러를 등록
                    pictureBox.Click += groupBox_Click;

                    // 라벨 추가 (제목)
                    Label titleLabel = new Label();
                    titleLabel.Location = new Point(150, 20);
                    groupBox.Controls.Add(titleLabel);
                    // Click 이벤트 핸들러를 등록
                    titleLabel.Click += groupBox_Click;

                    // 라벨 추가 (저자)
                    Label authorLabel = new Label();
                    authorLabel.Location = new Point(150, 40);
                    groupBox.Controls.Add(authorLabel);
                    // Click 이벤트 핸들러를 등록
                    authorLabel.Click += groupBox_Click;

                    // 라벨 추가 (출판사)
                    Label publisherLabel = new Label();
                    publisherLabel.Location = new Point(150, 60);
                    groupBox.Controls.Add(publisherLabel);
                    // Click 이벤트 핸들러를 등록
                    publisherLabel.Click += groupBox_Click;

                    // 라벨 추가 (출간일)
                    Label pubdateLabel = new Label();
                    pubdateLabel.Location = new Point(150, 80);
                    groupBox.Controls.Add(pubdateLabel);
                    // Click 이벤트 핸들러를 등록
                    pubdateLabel.Click += groupBox_Click;

                    titleLabel.Text = "제목: " + title;
                    authorLabel.Text = "저자: " + author;
                    publisherLabel.Text = "출판사: " + publisher;
                    pubdateLabel.Text = "출간일: " + formattedPubDate;

                    try
                    {
                        pictureBox.Load(cover); // 표지 이미지 로드
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("이미지 로드 중 오류 발생: " + ex.Message); // 이미지 로딩 중 오류 발생 시 콘솔에 메시지 출력
                    }

                    groupBoxTop += groupBox.Height + 10; // 다음 그룹 박스의 위치 설정
                }
            }

            // 이전 페이지 및 다음 페이지 버튼 생성
            Button prevPageButton = new Button();
            prevPageButton.Text = "이전 페이지";
            prevPageButton.Location = new Point(10, groupBoxTop);
            prevPageButton.Click += (sender, e) =>
            {
                if (currentPage > 1)
                {
                    currentPage--;
                    groupBoxTop = 10;
                    DisplaySearchResults(result, currentPage); // 현재 페이지(currentPage) 전달하여 이전 페이지 표시
                }
            };
            this.Controls.Add(prevPageButton);

            Button nextPageButton = new Button();
            nextPageButton.Text = "다음 페이지";
            nextPageButton.Location = new Point(110, groupBoxTop);
            nextPageButton.Click += (sender, e) =>
            {
                if (currentPage < 5 && endIndex < list.Count) // 페이지 수 최대 5 페이지
                {
                    currentPage++;
                    groupBoxTop = 10;
                    DisplaySearchResults(result, currentPage); // 현재 페이지(currentPage) 전달하여 다음 페이지 표시
                }
            };
            this.Controls.Add(nextPageButton);
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
                string isbnInfo = GetIsbnInfoFromGroupBox(parentControl as GroupBox);
                MessageBox.Show(isbnInfo);

                DSearch form = new DSearch(isbnInfo); // userNumber를 전달
                this.Hide();
                form.ShowDialog();

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
                string isbnInfo = groupBox.Tag.ToString(); // Tag는 object 형식이므로 ToString()으로 변환
                return isbnInfo;
            }

            return "ISBN 정보를 찾을 수 없습니다.";
        }
        private void mainLogo_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            readDone form = new readDone();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }
    }
}
