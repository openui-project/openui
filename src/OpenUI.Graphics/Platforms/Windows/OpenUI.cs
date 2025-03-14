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
    public partial class GameWindow
    {
        private Form form;

        public Action<PaintEventArgs>? Paint;

        public GameWindow(int width, int height, string title)
        {
            form = new Form
            {
                ClientSize = new Size(width, height),
                Text = title,
                BackColor = Color.Black,
                StartPosition = FormStartPosition.CenterScreen,
            };
            form.Paint += OnPaint;
        }

				public Mathematics.Vector2 GetWindowPosition() 
				{
					return new Mathematics.Vector2(form.Location.X, form.Location.Y);
				}

        public void Show()
        {
            Application.EnableVisualStyles();
            form.Show();
            Application.Run(form);
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Paint?.Invoke(e);
        }
    }
}
