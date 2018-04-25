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
    public partial class gpb3 : UserControl
    {
        public gpb3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //连接到数据库，第一个参数为服务器名称，第二个参数为数据库名称
            string connstring = "server=localhost;database=学生宿舍管理;integrated security=SSPI";
            SqlConnection mysqlconnection = new SqlConnection(connstring);
            mysqlconnection.Open();
            //表中插入数据，dbo.Table_1为表名
            string sqlstring = "insert into 请假表  values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            SqlCommand cmd = new SqlCommand(sqlstring, mysqlconnection);
            int row = cmd.ExecuteNonQuery();
            if (row == 1)
                MessageBox.Show("添加成功");
            else
                MessageBox.Show("添加失败");
        }
    }
}
