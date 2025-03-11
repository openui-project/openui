using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OpenUI
{
    internal interface ITexture
    {
        int Width { get; }
        int Height { get; }
    }

    public struct Texture : ITexture
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        private Bitmap Image { get; set; }

        public Texture(string filePath)
        {
            try
            {
                Image = new Bitmap(filePath); 
                Width = Image.Width;
                Height = Image.Height;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading texture: {ex.Message}");
            }
        }
    }

    public struct Texture2D : ITexture
    {
        private Texture _texture;

        public int Width
        {
            get { return _texture.Width; }
        }

        public int Height
        {
            get { return _texture.Height; }
        }

        public Texture2D(string filePath) {
            _texture = new Texture(filePath);
        }
    }

    /// <summary>
	/// The <c>GameWindow</c> class represents the main window of the application, acting as the primary container 
	/// for rendering and user interaction. It manages the window's size, position, and overall layout, handling 
	/// events such as resizing, input handling, and refreshing the display. This class provides the foundation 
	/// for rendering graphical content and serves as the central interface between the application and the user.
	/// </summary>
    public class GameWindow
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
            form.Paint += GameWindow_Paint;
        }

        public void Show()
        {
            Application.EnableVisualStyles();
            form.Show();
            Application.Run(form);
        }

        private void GameWindow_Paint(object sender, PaintEventArgs e) {
            Paint?.Invoke(e);
        }
    }
}