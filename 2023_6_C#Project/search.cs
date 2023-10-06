using System.Net;
using System.IO;
using System.Xml;

namespace _2023_6_C_Project
{
    public partial class search : Form
    {

        const string servicekey = "ttbwere090851412001";
        const string apiUrl = $"http://www.aladin.co.kr/ttb/api/ItemSearch.aspx?";

        public search()
        {
            InitializeComponent();
        }

        public static string getResults()
        {
            string result = string.Empty;
            try
            {
                WebClient client = new WebClient();
                string url = string.Format(@"{0}?serviceKey={1}", apiUrl, servicekey);
                using (Stream data = client.OpenRead(url))
                {
                    using (StreamReader reader = new StreamReader(data))
                    {
                        string s = reader.ReadToEnd();
                        result = s;

                        reader.Close();
                        data.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string result = getResults();

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result);
            XmlNodeList list = xml.GetElementsByTagName("Keyword");

            searchLv.Items.Clear();
            int idx = 0;
            foreach (XmlNode book in list)
            {
                ListViewItem item = new ListViewItem((idx++).ToString());
                item.SubItems.Add(book["title"].InnerText);
                item.SubItems.Add(book["author"].InnerText);
                searchLv.Items.Add(item);
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
    }
}
