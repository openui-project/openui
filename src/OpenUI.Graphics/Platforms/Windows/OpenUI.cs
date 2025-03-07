using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;


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

        private string displayText;
        private Point textPosition;
        private Font font;
        private Brush textBrush;

        public GameWindow(int width, int height, string title)
        {
            form = new Form
            {
                ClientSize = new Size(width, height),
                Text = title,
                BackColor = Color.Black,
                // StartPosition = FormStartPosition.CenterScreen,
            };
            form.Paint += new PaintEventHandler(OnPaint);
        }

        public void DrawText(string text, int posX, int posY, int fontSize, Color color)
        {
            displayText = text;
            font = new Font("Arial", fontSize);
            textPosition = new Point(posX, posY);
            textBrush = new SolidBrush(color);

            form.Invalidate(); // Trigger repaint
        }

        public void Show()
        {
            form.Show();
            Application.Run(form);
        }

        // Private methods
        private void OnPaint(object sender, PaintEventArgs e)
        {
            DrawText(e.Graphics);
        }

        private void DrawText(Graphics graphics)
        {
            graphics.DrawString(displayText, font, textBrush, new Point(50, 50));
        }
    }
}