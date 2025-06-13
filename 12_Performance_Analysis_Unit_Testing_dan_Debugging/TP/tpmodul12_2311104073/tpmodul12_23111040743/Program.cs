using System;
using System.Windows.Forms;
using tpmodul12_2311104073;

namespace tpmodul12_2311104073
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}