using System;
using System.Windows.Forms;
using Test_5;

namespace time
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new firmTimeForm());
        }
    }
}
