﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023_6_C_Project
{
    public partial class Dreading : Form
    {
        private string readingBookID;
        private string userNum;
        public Dreading(string readingBookID)
        {
            InitializeComponent();
            this.readingBookID = readingBookID;
            userNum = Program.UserNum;
        }

        private void Dreading_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT readingTbl.bookID, booktbl.bookCover, booktbl.bookName, readingTbl.bookReport " +
               "FROM readingTbl " +
               "INNER JOIN booktbl ON readingTbl.bookID = booktbl.bookID " +
               "WHERE readingTbl.userNum = @userNum AND readingTbl.bookID = @readingBookID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userNum", userNum);
                    command.Parameters.AddWithValue("@readingBookID", readingBookID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long bookID = reader.GetInt64(0);
                            string imageUrl = reader.GetString(1);
                            string bookName = reader.GetString(2);
                            string bookReport = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);

                            if (!string.IsNullOrEmpty(imageUrl))
                            {
                                using (WebClient webClient = new WebClient())
                                {
                                    byte[] imageData = webClient.DownloadData(imageUrl);

                                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imageData))
                                    {
                                        picCover.Image = Image.FromStream(ms);
                                    }
                                    labName.Text = bookName;

                                    txtReport.Text = bookReport;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            reading form = new reading();
            this.Hide();
            form.ShowDialog();
            Application.Exit();
        }

        private void UpdateBookReport()
        {
            string bookReportText = txtReport.Text; // 라벨2의 텍스트를 가져옵니다.

            string connectionString = "Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE readingTbl SET bookReport = @bookReport " +
                "WHERE userNum = @userNum AND bookID = @readingBookID";


                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userNum", userNum);
                    command.Parameters.AddWithValue("@readingBookID", readingBookID);
                    command.Parameters.AddWithValue("@bookReport", bookReportText); // 라벨2의 텍스트를 파라미터로 설정
                    // 필요한 조건을 WHERE 절에 지정

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("메모 저장에 성공했습니다.");
                    }
                    else
                    {
                        MessageBox.Show("업데이트된 행이 없습니다. 조건을 확인하세요.");
                    }
                }
            }
        }

        private void picSave_Click(object sender, EventArgs e)
        {
            UpdateBookReport();
        }

        private void labSave_Click(object sender, EventArgs e)
        {
            UpdateBookReport();
        }

        private void DeleteRecord()
        {
            string connectionString = "Server=mysql6.c3ts2gxxyaaf.ap-northeast-2.rds.amazonaws.com;Database=mybook;Uid=mydb;Pwd=12345678;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM readingTbl WHERE userNum = @userNum AND bookID = @readingBookID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userNum", userNum);
                    command.Parameters.AddWithValue("@readingBookID", readingBookID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("레코드가 성공적으로 삭제되었습니다.");
                        reading form = new reading();
                        this.Hide();
                        form.ShowDialog();
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("삭제할 레코드를 찾지 못했습니다. 조건을 확인하세요.");
                    }
                }
            }
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void labDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }
    }
}
