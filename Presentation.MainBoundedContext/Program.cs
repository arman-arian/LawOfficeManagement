using System;
using System.Windows.Forms;
using Presentation.MainBoundedContext.Forms;

namespace Presentation.MainBoundedContext
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
