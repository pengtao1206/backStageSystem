using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 门禁系统
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // textBox1.Text = "123";
            //textBox2.Text = "123";
            if ((textBox1.Text == "123" && textBox2.Text == "123") && (Program.isw = true))
            {
                login f = new login();
                f.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("登陆失败");
            } 
        }
    }
}
