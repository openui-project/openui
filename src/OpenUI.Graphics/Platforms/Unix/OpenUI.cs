using System;
using OpenGL;
using GLFW;

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
        private IntPtr window;

        public GameWindow(int width, int height, string title)
        {
            if (!Glfw.Init())
            {
                Console.Error.WriteLine("Failed to initialize GLFW");
                return;
            }

            window = Glfw.CreateWindow(width, height, title, Monitor.None, Window.None);
            if (window == IntPtr.Zero)
            {
                Console.Error.WriteLine("Failed to create GLFW window");
                Glfw.Terminate();
                return;
            }

            Glfw.MakeContextCurrent(window);
            GL.LoadBindings(new GLFWBindingsContext());
            GL.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);

            while (!Glfw.WindowShouldClose(window))
            {
                GL.Clear(ClearBufferMask.ColorBufferBit);
                Glfw.SwapBuffers(window);
                Glfw.PollEvents();
            }

            Glfw.DestroyWindow(window);
            Glfw.Terminate();
        }
    }
}