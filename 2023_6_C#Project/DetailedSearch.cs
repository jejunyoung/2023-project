using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _2023_6_C_Project
{
    public partial class DetailedSearch : Form
    {
        private readonly HttpClient httpClient = new HttpClient(); // HttpClient 인스턴스를 생성하여 웹 요청을 보내는 데 사용
        private string isbnInfo;
        public DetailedSearch(string isbnInfo)
        {
            InitializeComponent();
            this.isbnInfo = isbnInfo;

            InitializeSearch(isbnInfo); // 비동기 메서드를 호출
        }
        private void DetailedSearch_Load(object sender, EventArgs e)
        {
        }
        private async void InitializeSearch(string isbnInfo)
        {
            string result = await GetAladinApiResults(isbnInfo); // 비동기 메서드를 대기하고 결과를 추출

            DisplaySearchResults(result);
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
        public void DisplaySearchResults(string result)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result); // XML 형식의 검색 결과를 XmlDocument로 로드

            // 네임스페이스 처리를 위한 XmlNamespaceManager 생성
            XmlNamespaceManager nsManager = new XmlNamespaceManager(xml.NameTable);
            nsManager.AddNamespace("ns", "http://www.aladin.co.kr/ttb/apiguide.aspx"); // Aladin API의 네임스페이스 지정

            XmlNodeList list = xml.SelectNodes("//ns:item", nsManager); // "item" 요소를 선택
            for (int i = 0; i < list.Count; i++)
            {
                XmlNode itemNode = list[i];
                XmlNode titleNode = itemNode.SelectSingleNode("ns:title", nsManager); // 제목 정보 가져오기
                XmlNode authorNode = itemNode.SelectSingleNode("ns:author", nsManager); // 저자 정보 가져오기
                XmlNode publisherNode = itemNode.SelectSingleNode("ns:publisher", nsManager); // 출판사 정보 가져오기
                XmlNode pubdateNode = itemNode.SelectSingleNode("ns:pubDate", nsManager); // 출간일 정보 가져오기
                XmlNode coverNode = itemNode.SelectSingleNode("ns:cover", nsManager); // 표지 이미지 URL 정보 가져오기
                XmlNode descriptionNode = itemNode.SelectSingleNode("ns:description", nsManager); // 상품 설명 정보 가져오기
                XmlNode customerReviewRankNode = itemNode.SelectSingleNode("ns:customerReviewRank", nsManager); //별점 점수 가져오기
                XmlNode bestRankNode = itemNode.SelectSingleNode("ns:bestRank", nsManager); //배스트 순위

                if (titleNode != null && authorNode != null && publisherNode != null && pubdateNode != null && descriptionNode != null && customerReviewRankNode != null)
                {
                    // 각 항목의 정보 추출
                    string title = titleNode.InnerText; // 이름
                    string author = authorNode.InnerText; //저자
                    string publisher = publisherNode.InnerText; //출판사
                    string pubdateStr = pubdateNode.InnerText; // 출간이일
                    string cover = (coverNode != null) ? coverNode.InnerText : string.Empty; // 표지 이미지 URL
                    string description = System.Text.RegularExpressions.Regex.Replace(descriptionNode.InnerText, "<.*?>", string.Empty);// 상품설명
                    string customerReviewRank = customerReviewRankNode.InnerText; //별점
                    string bestRank = (bestRankNode != null) ? bestRankNode.InnerText : string.Empty; //배스트 순위

                    titleLabel.Text = title;
                    authorLabel.Text = "저자: " + author;
                    labelpublisher.Text = "출판사: " + publisher;
                    labelpubdate.Text = "출간일: " + pubdateStr;
                    pictureBox.Load(cover); // 표지 이미지 로드
                    txtDescription.Text = description;
                    labelcustomerReviewRank.Text = customerReviewRank;
                    labelbestRank.Text = bestRank;
                }
            }
        }

        private void mainLogo_Click(object sender, EventArgs e)
        {
            Main form = new Main(); // 새로운 Join 폼 인스턴스 생성
            this.Hide(); // 현재 창 숨기기
            form.ShowDialog();// 회원가입 폼 열기
            this.Show();  // 현재 창 다시 표시하기(회원가입창을 닫으면)
        }

        private void searchLogo_Click(object sender, EventArgs e)
        {
            search form = new search(); // 새로운 Join 폼 인스턴스 생성
            this.Hide(); // 현재 창 숨기기
            form.ShowDialog();// 회원가입 폼 열기
        }
    }
}

