using System;
using System.Runtime.InteropServices;

namespace OpenUI
{
	/// <summary>
	/// <para>Defines constants for the keys on a standard desktop keyboard, including alphanumeric characters, function keys, control keys, and special keys. It provides a unified way to represent keys in desktop applications, simplifying input handling across Windows and Linux platforms.</para>
	/// <para>This enum covers keys like letters (<c>A</c>, <c>B</c>), numbers (<c>1</c>, <c>2</c>), special keys (<c>Enter</c>, <c>Space</c>, <c>Escape</c>), function keys (<c>F1</c> to <c>F12</c>), and modifiers (<c>Shift</c>, <c>Ctrl</c>, <c>Alt</c>). It enables developers to easily manage key events and input validation with clear, readable code.</para>
	/// </summary>
	public enum KeyboardKey {
		None = 0x00,
		Escape = 0x1B
	}

	/// <summary>
	/// The <c>ViewPort</c> class represents the main window of the application, acting as the primary container for rendering and user interaction. It manages the window's size, position, and overall layout, handling events such as resizing, input handling, and refreshing the display. This class provides the foundation for rendering graphical content and serves as the central interface between the application and the user.
	/// </summary>
	public class ViewPort {
		public ViewPort(int width, int height, string title) {
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
				Console.WriteLine("We are running on Windows!");
			}
		}

		public void Notify() {
			return;
		}
	}
}