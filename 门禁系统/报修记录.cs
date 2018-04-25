using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO.Ports;

namespace 门禁系统
{
    public partial class 报修记录 : Form
    {
        public 报修记录()
        {
            InitializeComponent();
        }

        private void 报修记录_Load(object sender, EventArgs e)
        {
            string connstring = "server=localhost;database=学生宿舍管理;integrated security=SSPI";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from 报修";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
            DataTable dt = new DataTable();
            dt = ds.Tables[0].Copy();
            this.dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
