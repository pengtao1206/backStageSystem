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
using System.Threading;


namespace 门禁系统
{
    public partial class 刷卡 : Form
    {
        public 刷卡()
        {
            InitializeComponent();
        }
        
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
                                byteRecBuff[i] = bytesData[i];
                            }
                            // 设置缓冲区数据长度
                            iRecDataLen += bytesData.Length;
                        }
                        textBox1.Text = string.Format("{0:X2}{1:X2}{2:X2}{3:X2}{4:X2}", byteRecBuff[20], byteRecBuff[21], byteRecBuff[22], byteRecBuff[23], byteRecBuff[24]);
                        bLock = false;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("串口：" + ex.Message);
                    }

                    string connstring = "server=localhost;database=学生宿舍管理;integrated security=SSPI";
                    SqlConnection connection = new SqlConnection(connstring);
                    connection.ConnectionString = connstring;
                    connection.Open();
                    //表中插入数据，dbo.Table_1为表名


                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "select * from 学生信息表 where 卡号='" + textBox1.Text + "'";
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("打开成功");
                    }
                    else
                    {
                        MessageBox.Show("打开失败");
                    }
                    serialPort1.Close();
                    
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.BaudRate = 9600;
            byte[] bytesSend1 = new byte[] { 0x43, 0xbc, 0x09, 0x02, 0x02, 0x13, 0x01, 0x63, 0x44 };
            byte[] bytesSend2 = new byte[] { 0x43, 0xbc, 0x09, 0x02, 0x02, 0x12, 0x41, 0x38, 0x98 };
            byte[] bytesSend3 = new byte[] { 0x43, 0xbc, 0x09, 0x02, 0x02, 0x02, 0x26, 0xba, 0xb0 };
            byte[] bytesSend4 = new byte[] { 0x43, 0xbc, 0x08, 0x02, 0x01, 0x03, 0xab, 0xb4 };
            if (serialPort1.IsOpen)
            {
                try
                {

                    serialPort1.Write(bytesSend1, 0,9);
                    //MessageBox.Show("开启天线");
                    Thread.Sleep(500);
                    
                    serialPort1.Write(bytesSend2, 0, 9);
                    //MessageBox.Show("切换");
                    Thread.Sleep(500);
                    serialPort1.Write(bytesSend3, 0, 9);
                    //MessageBox.Show("寻卡");
                    Thread.Sleep(500);
                    serialPort1.Write(bytesSend4, 0, 8);
                    //MessageBox.Show("防冲突");
                    Thread.Sleep(500);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
            SynReceiveData(serialPort1);
            
        }
    }
}
