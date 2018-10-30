using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Network.Packet.Analyzer.App.Forms.Main;

namespace Network.Packet.Analyzer.App
{
    static class Program
    {

        public static FrmAnalyzer form = new FrmAnalyzer();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmAnalyzer());
            Application.Run(form);
        }
    }
}
