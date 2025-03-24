using System;


namespace OpenUI
{
	public static class Utils 
	{
		public enum LogLevel
		{
			Info,
			Warning,
			Error,
			Critical
		}	

		public static void TraceLog(LogLevel level, string message, params object[] args)
		{
			string formattedMessage = string.Format(message, args);

			var originalColor = Console.ForegroundColor;

			switch (level)
      {
				case LogLevel.Warning:
					Console.ForegroundColor = ConsoleColor.Yellow;
					break;
				case LogLevel.Error:
					Console.ForegroundColor = ConsoleColor.Red;
					break;
				case LogLevel.Critical:
					Console.ForegroundColor = ConsoleColor.Magenta;
					break;
			}

			Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] [{level}] {formattedMessage}");

			Console.ForegroundColor = originalColor;
		}
	}
}
