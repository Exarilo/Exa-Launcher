using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Exa_Launcher
{
    internal static class User32Interop
    {
        internal const int WM_NCLBUTTONDOWN = 0xA1;
        internal const int HT_CAPTION = 0x2;

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool ReleaseCapture();

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        internal static extern short GetAsyncKeyState(Keys vKey);
    }
}
