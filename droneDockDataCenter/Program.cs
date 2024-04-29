using log4net;
using log4net.Config;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace droneDockDataCenter
{
    internal static class Program
    {

        private static readonly ILog logger = LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            XmlConfigurator.Configure(LogManager.GetRepository(Assembly.GetCallingAssembly()));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            logger.Info("*********************Application started***********************");
            Application.Run(new MainForm());

            logger.Info("---------------------Application end---------------------------");
        }
    }
}
