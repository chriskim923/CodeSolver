using System;
using System.Windows.Forms;

namespace CipherTool
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SolverConsole());
        }
    }
}
