namespace OpenUI
{
	public enum KeyboardKey {
		None = 0x00,
		Escape = 0x1B
	}

	/// <summary>
	/// The <c>ViewPort</c> class represents the main window of the application, acting as the primary container for rendering and user interaction. It manages the window's size, position, and overall layout, handling events such as resizing, input handling, and refreshing the display. This class provides the foundation for rendering graphical content and serves as the central interface between the application and the user.
	/// </summary>
	public class ViewPort {
		public ViewPort(int width, int height, string title) {
		}

		public void Notify() {
			return;
		}
	}
}