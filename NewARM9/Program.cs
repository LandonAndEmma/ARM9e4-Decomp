using System;
using System.Windows.Forms;
namespace NewARM9
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new arm9ed());
        }
    }
}