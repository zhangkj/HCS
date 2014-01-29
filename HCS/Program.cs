using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HCS
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
            HCSLogin login = new HCSLogin();
            if (DialogResult.OK == login.ShowDialog())
            {
                Application.Run(new HCSAdmin(ModuleBase.UserName));
            }
        }
    }
}
