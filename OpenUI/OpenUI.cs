using System;

namespace OpenUI
{
    public class ViewPort
    {
        public ViewPort(int width, int height, string title)
        {
            WinAPI.MessageBox(IntPtr.Zero, "Hello, World!", "WinAPI in C#", 0);
        }

        public Vector2 GetWindowPosition()
        {
            return new Vector2(0, 0);
        }
    }
}