using System;
using OpenUI;
using OpenUI.Platform.Storage;

public static class Program
{
	public static void Main(string[] args)
	{
		FileStatus();
		var game = new GameWindow(800, 600, "Simpile Example");
		game.SetWindowCaption("Hello");
		game.Run();
	}

	private static void FileStatus() 
	{
		try {
			using (FileObject file = new FileObject("test.txt")) 
			{
				Utils.TraceLog(Utils.LogLevel.Info, "Name: {0}", file.Name);
				Utils.TraceLog(Utils.LogLevel.Warning, "Path: {0}", file.Path);
				Utils.TraceLog(Utils.LogLevel.Error, "File Exists: {0}", file.Exists());
				Utils.TraceLog(Utils.LogLevel.Critical, "File Size: {0}", file.GetSize());
				Utils.TraceLog(Utils.LogLevel.Info, "Hello, World!");
			}
		}
		catch (Exception ex)
		{
			Utils.TraceLog(Utils.LogLevel.Error, "Error: {0}", ex.Message);
		}
	}
}
