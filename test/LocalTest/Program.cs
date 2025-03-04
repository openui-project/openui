using OpenUI;
using OpenUI.Core;

public static class Program {
	public static void Main(string[] args) {
		Utility.TraceLog(0, "Starting application...");
		ViewPort viewPort = new ViewPort(800, 600, "Local Test");
		viewPort.Run();
		Utility.TraceLog(0, "Application terminated.");
	}
}
