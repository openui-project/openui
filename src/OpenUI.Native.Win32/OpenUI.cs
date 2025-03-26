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
				KeyPreview = true,
			};

			form.KeyDown += OnKeyDown;
		}

    ~GameWindow() 
    {
      form.Close();
    }

    /// <summary>
    /// Triggers an event when a key is pressed.
    /// </summary>
    /// <code>
    /// GameWindow game = new GameWindow(800, 600, "Simpile Example");
    /// 
    /// game.KeyPressed = (key) => Console.WriteLine($"Key Pressed: {key}");
    ///
    /// game.Run()
    /// </code>
    public Action<Keys> KeyPressed;

    public Vector2 GetWindowPosition() => new Vector2(form.Left, form.Right);

		public void Run()
		{
			Application.EnableVisualStyles();
			form.Show();
			Application.Run(form);
		}

		private void OnKeyDown(object sender, KeyEventArgs e)
    {
        KeyPressed?.Invoke(e.KeyCode);
    }
	}
}
