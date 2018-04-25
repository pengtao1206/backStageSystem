using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO.Ports;
namespace 门禁系统
{
    public partial class gpb1 : UserControl
    {
        public gpb1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //连接到数据库，第一个参数为服务器名称，第二个参数为数据库名称
            string connstring = "server=localhost;database=学生宿舍管理;integrated security=SSPI";
            SqlConnection mysqlconnection = new SqlConnection(connstring);



            mysqlconnection.Open();

            string sqlstring = "select 宿舍号 from 学生信息表  where 姓名 = '" + textBox1.Text + "' and 学号='" + textBox2.Text + "'";

            SqlCommand command = mysqlconnection.CreateCommand();
            command.CommandText = sqlstring;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
            DataTable dt = new DataTable();
            dt = ds.Tables[0].Copy();
            this.dataGridView1.DataSource = dt;
        }
    }
}
