using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OpenUI
{
    internal interface ITexture {
			int Width { get; }
			int Height { get; }
			Bitmap Image { get; }
		}

		public struct Texture : ITexture {
			public int Width { get; private set; }
			public int Height { get; private set; }
			public Bitmap Image { get; private set; }

			public Texture(string filePath) {
				try
				{
					Image = new Bitmap(filePath); 
					Width = Image.Width;
					Height = Image.Height;
				}
				catch (Exception e)
				{
					Console.WriteLine($"Error loading texture: {e.Message}");
				}
			}
		}

		public struct Texture2D : ITexture {
			private Texture _texture;

			public int Width => _texture.Width;
			public int Height => _texture.Height;
			public Bitmap Image => _texture.Image;

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
            form.Paint += OnPaint;
        }

        public void DrawTexture(Texture2D texture, int posX, int posY, Color tint)
        {
            if (texture.Width > 0 && texture.Height > 0)
            {
                using (var image = texture.Image)
                {
                    var tintedImage = new Bitmap(image);
                    using (Graphics g2d = Graphics.FromImage(tintedImage))
                    {
                        var tintMatrix = new ColorMatrix(new[]
                        {
                            new float[] { tint.R / 255f, 0, 0, 0, 0 },
                            new float[] { 0, tint.G / 255f, 0, 0, 0 },
                            new float[] { 0, 0, tint.B / 255f, 0, 0 },
                            new float[] { 0, 0, 0, 1f, 0 },
                            new float[] { 0, 0, 0, 0, 1f }
                        });
                        
                        var imageAttributes = new ImageAttributes();
                        imageAttributes.SetColorMatrix(tintMatrix);
                        g2d.DrawImage(tintedImage, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
                    }
                    // Draw the tinted image at the specified position.
                    form.CreateGraphics().DrawImage(tintedImage, posX, posY);
                }
            }
        }

        public void DrawTexture(Graphics g, Texture2D texture, int posX, int posY, Color tint) 
        {
            return;
        }

        public void Show()
        {
            Application.EnableVisualStyles();
            form.Show();
            Application.Run(form);
        }

        private void OnPaint(object sender, PaintEventArgs e) {
            Paint?.Invoke(e);
        }
    }
}
