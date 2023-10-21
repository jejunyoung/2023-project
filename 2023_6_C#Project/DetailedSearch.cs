using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023_6_C_Project
{
    public partial class DetailedSearch : Form
    {
        public DetailedSearch(string isbnInfo)
        {
            InitializeComponent();

            // 전달받은 ISBN 정보를 메시지 박스로 출력
            MessageBox.Show("ISBN 정보: " + isbnInfo);
        }

        private void DetailedSearch_Load(object sender, EventArgs e)
        {
        }

    }
}
