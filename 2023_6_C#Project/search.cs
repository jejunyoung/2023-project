using System.Net;
using System.IO;
using System.Xml;
using System.Net.Http;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace _2023_6_C_Project
{
    public partial class search : Form
    {
        private readonly HttpClient httpClient = new HttpClient();

        public search()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text;
            string result = await GetAladinApiResults(query);

            DisplaySearchResults(result);
        }

        private async Task<string> GetAladinApiResults(string query)
        {
            string apiUrl = "http://www.aladin.co.kr/ttb/api/ItemSearch.aspx";
            string TTBKey = "ttbwere090851412001";

            try
            {
                string url = $"{apiUrl}?ttbkey={TTBKey}&Query={query}";
                return await httpClient.GetStringAsync(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"API 호출 중 오류 발생: {ex.Message}");
                return string.Empty;
            }
        }

        private void DisplaySearchResults(string result)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result);

            // 네임스페이스 처리를 위한 XmlNamespaceManager 생성
            XmlNamespaceManager nsManager = new XmlNamespaceManager(xml.NameTable);
            nsManager.AddNamespace("ns", "http://www.aladin.co.kr/ttb/apiguide.aspx"); // 네임스페이스 URI를 여기에 지정

            XmlNodeList list = xml.SelectNodes("//ns:item", nsManager); // "item" 요소를 가져옴

            searchLv.Items.Clear();

            foreach (XmlNode itemNode in list)
            {
                XmlNode titleNode = itemNode.SelectSingleNode("ns:title", nsManager); // 네임스페이스를 적용하여 "title" 요소를 가져옴
                XmlNode authorNode = itemNode.SelectSingleNode("ns:author", nsManager); // 네임스페이스를 적용하여 "author" 요소를 가져옴
                XmlNode publisherNode = itemNode.SelectSingleNode("ns:publisher", nsManager); // 네임스페이스를 적용하여 "publisher" 요소를 가져옴
                XmlNode pubdateNode = itemNode.SelectSingleNode("ns:pubDate", nsManager); // 네임스페이스를 적용하여 "pubdate" 요소를 가져옴


                // titleNode와 authorNode가 null인지 확인
                if (titleNode != null && authorNode != null && publisherNode != null && pubdateNode != null)
                {
                    string title = titleNode.InnerText;
                    string author = authorNode.InnerText;
                    string publisher = publisherNode.InnerText;
                    string pubdateStr = pubdateNode.InnerText;
                    DateTime pubDate;
                    string formattedPubDate = ""; // formattedPubDate 변수를 미리 선언
                    if (DateTime.TryParse(pubdateStr, out pubDate))
                    {
                        // 출간일을 원하는 형식으로 출력
                        formattedPubDate = pubDate.ToString("yyyy-MM-dd");
                    }

                    ListViewItem item = new ListViewItem(title); // title이 1 번째 열에 표시될 내용
                    item.SubItems.Add(author); // author가 2 번째 열에 표시될 내용
                    item.SubItems.Add(publisher); // publisher가 3 번째 열에 표시될 내용
                    item.SubItems.Add(formattedPubDate); // pubdate가 4 번째 열에 표시될 내용
                    searchLv.Items.Add(item); // 아이템을 ListView에 추가
                }
                else
                {
                    // titleNode 또는 authorNode가 null이면 기본값 설정
                    ListViewItem item = new ListViewItem("제목을 찾을 수 없습니다");
                    item.SubItems.Add("작가을 찾을 수 없습니다");
                    item.SubItems.Add("출판사를 찾을 수 없습니다");
                    item.SubItems.Add("출간일을 알 수 없습니다");

                    searchLv.Items.Add(item);
                }
            }
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
            Main form = new Main();// search 폼 인스턴스 생성
            this.Close();  // 현재 폼 숨기기
            form.ShowDialog();  // Main 폼 열기
            Application.Exit(); // 프로그램 종료
        }
    }
}
