using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace SSMS
{
    static class Program
    {
        public static string[] args;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Program.args = args;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormHome());
        }
    }
}
