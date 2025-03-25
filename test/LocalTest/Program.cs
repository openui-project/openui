using System;
using System.Windows.Forms;
using OpenUI;

public static class Program
{
	public static void Main(string[] args)
	{
		GameWindow game = new GameWindow(800, 600, "Example");
		game.KeyPressed = (key) => {
			if (key == Keys.Escape)
			{
				Utils.TraceLog(Utils.LogLevel.Info, "Closing...");
				return;
			}
		};
		game.Run();
	}
}

