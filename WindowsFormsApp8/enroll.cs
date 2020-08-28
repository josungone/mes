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
    public partial class enroll : Form
    {
        public enroll()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string url = "datasource=localhost;port=3306;Database=mes;username=root;password=1234";
            MySqlConnection mySqlConnection
                = new MySqlConnection(url);

            string selectQuery = "SELECT * FROM order_info_head";
            DataTable dataTable = new DataTable(); //빈 테이블 생성
            MySqlDataAdapter mySqlDataAdapter
                = new MySqlDataAdapter(selectQuery, mySqlConnection);  
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string url = "datasource=localhost;port=3306;Database=mes;username=root;password=1234";
            MySqlConnection mySqlConnection
                = new MySqlConnection(url);

            string selectQuery = "SELECT * FROM material_order_body";
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter
                = new MySqlDataAdapter(selectQuery, mySqlConnection);
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string url = "datasource=localhost;port=3306;Database=mes;username=root;password=1234";
            MySqlConnection mySqlConnection
                = new MySqlConnection(url);

            string selectQuery = "SELECT * FROM work_order_body";
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter
                = new MySqlDataAdapter(selectQuery, mySqlConnection);
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string url = "datasource=localhost;port=3306;Database=mes;username=root;password=1234";
            MySqlConnection mySqlConnection
                = new MySqlConnection(url);

            string selectQuery = "SELECT * FROM pro_release_body";
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter
                = new MySqlDataAdapter(selectQuery, mySqlConnection);
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string url = "datasource=localhost;port=3306;Database=mes;username=root;password=1234";
            MySqlConnection mySqlConnection
                = new MySqlConnection(url);

            string order_no = textBox1.Text;
            string order_gubun = textBox2.Text;
            string order_date = textBox3.Text;
            string cust_no = textBox4.Text;
            string memo = textBox5.Text;
            string createuser = textBox6.Text;
            string updateuser = textBox7.Text;
            string date = dateTimePicker1.Value.ToShortDateString();

            string selectQuery = " INSERT INTO `mes`.`order_info_head` (`ORDER_NO`, `ORDER_GUBUN`, `ORDER_DATE`, `CUST_NO`, `MEMO`, `CREATEUSER`, `CREATETIME`, `UPDATEUSER`, `UPDATETIME`) VALUES("+order_no+ ", "+order_gubun+ ", "+order_date+ ", "+cust_no+ ", "+memo+ ", "+createuser+ ", '2020-08-27 10:38:02', " + updateuser+ ", '2020-08-27 10:38:02')";
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter
                = new MySqlDataAdapter(selectQuery, mySqlConnection);
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;


            string selectQuery1 = "SELECT * FROM order_info_head";
            DataTable dataTable1 = new DataTable();
            MySqlDataAdapter mySqlDataAdapter1
                = new MySqlDataAdapter(selectQuery1, mySqlConnection);
            mySqlDataAdapter1.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string url = "datasource=localhost;port=3306;Database=mes;username=root;password=1234";
            MySqlConnection mySqlConnection
                = new MySqlConnection(url);

            string order_no = textBox1.Text;
            string order_gubun = textBox2.Text;
            string order_date = textBox3.Text;
            string cust_no = textBox4.Text;
            string memo = textBox5.Text;
            string createuser = textBox6.Text;
            string updateuser = textBox7.Text;

            string selectQuery = "DELETE FROM `mes`.`order_info_head` WHERE `ORDER_NO`= "+order_no+"";
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter
                = new MySqlDataAdapter(selectQuery, mySqlConnection);
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            string selectQuery1 = "SELECT * FROM order_info_head";
            DataTable dataTable1 = new DataTable();
            MySqlDataAdapter mySqlDataAdapter1
                = new MySqlDataAdapter(selectQuery1, mySqlConnection);
            mySqlDataAdapter1.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string url = "datasource=localhost;port=3306;Database=mes;username=root;password=1234";
            MySqlConnection mySqlConnection
                = new MySqlConnection(url);

            string order_no = textBox1.Text;
            string order_gubun = textBox2.Text;
            string order_date = textBox3.Text;
            string cust_no = textBox4.Text;
            string memo = textBox5.Text;
            string createuser = textBox6.Text;
            string updateuser = textBox7.Text;

            string selectQuery = "UPDATE `mes`.`order_info_head` SET `ORDER_NO`= " + order_no + ", `ORDER_GUBUN`= "+order_gubun+ ", `ORDER_DATE`= "+order_date+ ", `CUST_NO`= "+cust_no+ ", `MEMO`= "+memo+ ", `CREATEUSER`= "+createuser+ ", `UPDATEUSER`= "+updateuser+ " WHERE  `ORDER_NO`= "+order_no+"";
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter
                = new MySqlDataAdapter(selectQuery, mySqlConnection);
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            string selectQuery1 = "SELECT * FROM order_info_head";
            DataTable dataTable1 = new DataTable();
            MySqlDataAdapter mySqlDataAdapter1
                = new MySqlDataAdapter(selectQuery1, mySqlConnection);
            mySqlDataAdapter1.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1; 
        }


        private void button13_Click(object sender, EventArgs e)
        {
            // 엑셀 파일로 저장
            Microsoft.Office.Interop.Excel.Application xcelApp = 
                new Microsoft.Office.Interop.Excel.Application();
            xcelApp.Application.Workbooks.Add(Type.Missing);

            // Head Text 설정
            for(int i = 1; i < dataGridView1.Columns.Count+1; i++)
            {
                xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            // 데이터 설정
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for(int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    xcelApp.Cells[i + 2, j + 1] = 
                        dataGridView1.Rows[i].Cells[j].Value.ToString(); 
                    
                }

            }
            xcelApp.Columns.AutoFit();
            xcelApp.Visible = true;
        }

        private void enroll_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = "회사1";
            comboBox3.SelectedItem = "사업장1";
            comboBox4.SelectedItem = "주문완료";
            comboBox5.SelectedItem = "거래중";
        }
    }
}