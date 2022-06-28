using System;
using System.Windows.Forms;

namespace TextFileProcessingEasy
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

            Application.Run(new 行数量拆分计划());
        }
    }
}
