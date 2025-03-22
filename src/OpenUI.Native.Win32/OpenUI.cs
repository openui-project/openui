using System;
using System.Drawing;
using System.Windows.Forms;

namespace OpenUI
{
	/// <summary>
  /// The <c>GameWindow</c> class represents the main window of the application, acting as the primary container 
  /// for rendering and user interaction. It manages the window's size, position, and overall layout, handling 
  /// events such as resizing, input handling, and refreshing the display. This class provides the foundation 
  /// for rendering graphical content and serves as the central interface between the application and the user.
  /// </summary>
	public class GameWindow
	{
		private Form form;

		public GameWindow(int width, int height, string title)
		{
			form = new Form
			{
				ClientSize = new Size(width, height),
				Text = title,
				StartPosition = FormStartPosition.CenterScreen,
			};
		}

		public void SetWindowCaption(string title) 
		{
			form.Text = title;
		}

		public void Run()
		{
			Application.EnableVisualStyles();
			form.Show();
			Application.Run(form);
		}
	}
}
