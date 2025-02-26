using System;
using System.Runtime.InteropServices;

namespace OpenUI
{
    internal static class WinAPI
    {
        public const int CW_USERDEFAULT = unchecked((int)0x80000000);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr CreateWindowEx(
            int exStyle, string className, string windowName,
            int style, int x, int y, int width, int height,
            IntPtr hwndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        [StructLayout(LayoutKind.Sequential)]
        public struct MSG
        {

        }
    }
}