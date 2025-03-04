using System;
using System.Drawing;
using System.Runtime.InteropServices;

#if WINDOWS
using System.Windows.Forms;
#endif

namespace OpenUI
{
	/// <summary>
	/// The <c>ViewPort</c> class represents the main window of the application, acting as the primary container 
	/// for rendering and user interaction. It manages the window's size, position, and overall layout, handling 
	/// events such as resizing, input handling, and refreshing the display. This class provides the foundation 
	/// for rendering graphical content and serves as the central interface between the application and the user.
	/// </summary>
	public class ViewPort
	{
		private object mainWindow;

		public ViewPort(int width, int height, string title = "OpenUI")
		{
#if WINDOWS
			mainWindow = new Form
			{
				ClientSize = new Size(width, height),
				Text = title,
				BackColor = Color.Black
			};
#endif
		}

// 		public Mathematics.Vector2 GetWindowPosition() 
// 		{
// #if WINDOWS
// 			var form = (Form)mainWindow;
// 			return new Mathematics.Vector2(form.Left, form.Top);
// #else
// 			return default;
// #endif
// 		}

		public void Run()
		{
#if WINDOWS
			((Form)mainWindow).Show();
			Application.Run((Form)mainWindow);
#endif
		}
	}
}