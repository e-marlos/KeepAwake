using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace KeepAwake
{
    internal static class Notifier
    {
        public static void SetupNotifyIcon()
        {
            var menuItems = new[] {new MenuItem("Exit", (s, e) => Application.Exit())};
            var unused = new NotifyIcon
            {
                Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location),
                ContextMenu = new ContextMenu(menuItems),
                Text = "Keeping this machine awake...",
                Visible = true
            };
        }
    }
}