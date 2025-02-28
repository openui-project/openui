using System;
using System.Runtime.InteropServices;

namespace OpenUI
{
    // <summary>
    // Simplifies interaction with the Windows API.
    // </summary>
    internal static class WinAPI
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
    }
}
