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
using Newtonsoft.Json.Linq;

namespace _2023_6_C_Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        
        private void search_Click(object sender, EventArgs e)
        {
            search form = new search(); // 새로운 search 폼 인스턴스 생성
            this.Hide(); // 현재 창 숨기기
            form.ShowDialog();//  폼 열기
        }
        private void textBox1_Click_1(object sender, EventArgs e)
        {
            search form = new search();// search 폼 인스턴스 생성
            this.Close();  // 현재 폼 숨기기
            form.ShowDialog();  // search 폼 열기
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
        }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
