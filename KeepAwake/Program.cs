using System;
using System.Windows.Forms;

namespace KeepAwake
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Notifier.SetupNotifyIcon();
            KeepAwakeService.KeepAwake();
            Application.Run();
        }
    }
}