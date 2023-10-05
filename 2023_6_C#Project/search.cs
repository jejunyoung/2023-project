using System;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _2023_6_C_Project
{
    public partial class search : Form
    {

        const string targetUrl = "http://www.aladin.co.kr/ttb/apiguide.aspx";
        const string servicekey = "ttbwere090851412001";

        public search()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {

                    string searchQuery = txtSearch.Text.Trim();

                    // API 요청 생성
                    string requestUrl = $"{targetUrl}?ttbkey={servicekey}&Query={searchQuery}&QueryType=Keyword&MaxResults=10&start=1&SearchTarget=Book";

                    // API 호출 및 응답 받기
                    HttpResponseMessage response = await client.GetAsync(requestUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        try
                        {
                            JObject data = JObject.Parse(jsonResponse);

                            // ListView 초기화
                            searchLv.Items.Clear();

                            // 도서 정보 추출 및 표시
                            foreach (var item in data["item"])
                            {
                                string title = item["title"].ToString();
                                string author = item["author"].ToString();

                                ListViewItem listViewItem = new ListViewItem(title);
                                listViewItem.SubItems.Add(author);
                                searchLv.Items.Add(listViewItem);
                            }
                        }
                        catch (JsonReaderException ex)
                        {
                            // JSON 파싱 오류 처리
                            MessageBox.Show($"JSON 파싱 오류: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("API 호출 실패.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}");
            }
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void searchLv_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
