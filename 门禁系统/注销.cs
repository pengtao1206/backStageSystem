using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 门禁系统
{
    public partial class 注销 : Form
    {
        public 注销()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstring = "server=localhost;database=学生宿舍管理;integrated security=SSPI";
            SqlConnection mysqlconnection = new SqlConnection(connstring);
            mysqlconnection.ConnectionString = connstring;
            mysqlconnection.Open();
            //表中插入数据，dbo.Table_1为表名
            string sqlstring = "delete from 学生信息表  where 学号= '" + textBox2.Text + "'and 姓名='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlstring, mysqlconnection);

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
