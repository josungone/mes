using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
       //

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* DataTable dataTable = new DataTable();
             dataTable.Columns.Add("ID", typeof(int));
             dataTable.Columns.Add("First Name", typeof(string));
             dataTable.Columns.Add("Last Name", typeof(string));
             dataTable.Columns.Add("Age", typeof(int));

             dataTable.Rows.Add(1, "First Name A", "Last Name A", 10);
             dataTable.Rows.Add(2, "First Name B", "Last Name B", 20);
             dataTable.Rows.Add(3, "First Name C", "Last Name C", 30);
             dataTable.Rows.Add(4, "First Name D", "Last Name D", 40);
             dataTable.Rows.Add(5, "First Name E", "Last Name E", 50);
             dataTable.Rows.Add(6, "First Name F", "Last Name F", 60);
             dataTable.Rows.Add(7, "First Name G", "Last Name G", 70);

             dataGridView1.DataSource = dataTable;*/
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string url = "datasource=localhost;port=3306;Database=mes;username=root;password=1234";
            MySqlConnection mySqlConnection
                = new MySqlConnection(url);

            string selectQuery = "SELECT * FROM order_info_body";
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter
                = new MySqlDataAdapter(selectQuery, mySqlConnection);
            mySqlDataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }
        /////////////////////
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            enroll Form = new enroll();
            Form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "datasource=localhost;port=3306;Database=mes;username=root;password=1234";
            MySqlConnection mySqlConnection
                = new MySqlConnection(url);

            string selectQuery = "SELECT * FROM order_info_head";
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter
                = new MySqlDataAdapter(selectQuery, mySqlConnection);
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // 엑셀 파일로 저장
            Microsoft.Office.Interop.Excel.Application xcelApp =
                new Microsoft.Office.Interop.Excel.Application();
            xcelApp.Application.Workbooks.Add(Type.Missing);

            // 엑셀 서식 지정
            string rangStr = "A2:A" + (dataGridView1.Rows.Count + 1);
            MessageBox.Show(rangStr);
            Microsoft.Office.Interop.Excel.Range range =
                xcelApp.get_Range(rangStr, Type.Missing);
            range.NumberFormat = "0";

            // Head Text 설정
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            // 데이터 설정
            for (int i = 0; i < dataGridView1.Rows.Count -1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    xcelApp.Cells[i + 2, j + 1] =
                        dataGridView1.Rows[i].Cells[j].Value.ToString();
                }

            }
            xcelApp.Columns.AutoFit();
            xcelApp.Visible = true;
        }
    }
}
