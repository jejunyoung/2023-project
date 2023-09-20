using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;

namespace _2023_6_C_Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void search_Click(object sender, EventArgs e)
        {
            search form = new search();// search 폼 인스턴스 생성
            this.Hide();  // 현재 폼 숨기기
            form.ShowDialog();  // Main 폼 열기
            this.Show();  // 현재 폼 다시 표시하기(Main 품을 닫았을 경우)
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
