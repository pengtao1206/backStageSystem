using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 门禁系统
{
    static class Program
    {
        public static bool isw;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
            if (isw == true)
            {
                Application.Run(new Form1());
            }
            
        }
    }
}
