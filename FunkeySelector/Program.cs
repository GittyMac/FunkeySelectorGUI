using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunkeySelector
{
    static class Program
    {
        public static bool IsMBMode;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main(string[] args)
        {
            // If called with an argument
            if (args != null && args.Length > 0)
            {
                if (args[0] != "-MBRun")
                {
                    CustomF.SetFunkey(args[0]);
                    return;
                }
                else 
                {
                    IsMBMode = true;
                    Thread.Sleep(1000); //Allows for the Flash container to load.
                    CustomF.SetFunkey("FFFFFFF0");
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
