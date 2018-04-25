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
    public partial class Form1 : Form
    {
        public gpb1 g1;
        public gpb2 g2;
        public gpb3 g3;
        public  gpb4 g4;
        public Form1()
        {
            InitializeComponent();
        }
        string a ;
         bool bLock = false;
        //串口数据缓冲长度
        public const int MAXLEN = 1024;
        //串口缓冲区
        public byte[] byteRecBuff = new byte[MAXLEN];
        //串口缓冲区现有数据长度
        public int iRecDataLen = 0;
        public void SynReceiveData(SerialPort SerialCon)
        {
            if (bLock == false)
            {
                bLock = true;
                if (SerialCon.IsOpen)
                {
                    try
                    {
                        int bytesRead = SerialCon.BytesToRead;
                        // 创建字节数组
                        byte[] bytesData = new byte[bytesRead];
                        if (bytesRead > 0 && bytesRead + iRecDataLen < MAXLEN)
                        {

                            // 读取缓冲区的数据到数组
                            SerialCon.Read(bytesData, 0, bytesRead);
                            // 将数组存到数据缓冲区
                            for (int i = 0; i < bytesRead; i++)
                            {
                                byteRecBuff[iRecDataLen + i] = bytesData[i];
                            }
                            // 设置缓冲区数据长度
                            iRecDataLen += bytesRead;
                        }
                        a = string.Format("{0:X2}{1:X2}{2:X2}{3:X2}", byteRecBuff[17], byteRecBuff[18], byteRecBuff[19], byteRecBuff[20]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("串口：" + ex.Message);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g1 = new gpb1();
            g2 = new gpb2();
            g3 = new gpb3();
            g4 = new gpb4();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g1.Show();
            gpb.Controls.Clear();
            gpb.Controls.Add(g1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g2.Show();
            gpb.Controls.Clear();
            gpb.Controls.Add(g2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g3.Show();
            gpb.Controls.Clear();
            gpb.Controls.Add(g3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            g4.Show();
            gpb.Controls.Clear();
            gpb.Controls.Add(g4);
        }

        private void 日历ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (日历 rili = new 日历())
            {
                rili.ShowDialog();
            }
        }

        private void 用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (刷卡 sk = new 刷卡())
            {
                sk.ShowDialog();
            }
        }

        private void 宿舍管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 宿舍查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (宿舍查询 sushe = new 宿舍查询())
            {
                sushe.ShowDialog();
            }
        }

        private void 查看报修ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (报修记录 bxjl = new 报修记录())
            {
                bxjl.ShowDialog();
            }
        }

        private void 添加学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (学生添加 xstj = new 学生添加())
            {
                xstj.ShowDialog();
            }
        }

        private void 删除学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (注销 zx = new 注销())
            {
                zx.ShowDialog();
            }
        }

        private void 学生查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (查询 cx = new 查询())
            {
                cx.ShowDialog();
            }
        }

        private void 查寝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (查寝 cq = new 查寝())
            {
                cq.ShowDialog();
            }
        }

        private void 请假ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (请假 qj = new 请假())
            {
                qj.ShowDialog();
            }
        }

        private void 报修ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (报修 bx = new 报修())
            {
                bx.ShowDialog();
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (帮助 bangzhu = new 帮助())
            {
                bangzhu.ShowDialog();
            }
        }
    }
}
