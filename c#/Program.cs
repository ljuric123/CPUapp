using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perf_monitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CPUdata data = new CPUdata();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            data.CPUthread();

        }
    }
}
