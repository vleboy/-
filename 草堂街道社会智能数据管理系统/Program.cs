using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 草堂街道社会智能数据管理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Main());
            Application.Run(new Login());
        }
    }
}
