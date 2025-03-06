using System;

namespace OpenUI {
    public enum LogLevel {
        None = 0,
        Info,
        Warning,
        Error
        //Fatal
    }
}

namespace OpenUI.Core {
    public static class Utility {

        public static void TraceLog(LogLevel level, string text, params object[] args) {
            if (level == LogLevel.None)
                return;

            string message = string.Format(text, args);

            switch (level)
            {
                case LogLevel.Info:
                    Console.WriteLine(message);
                    break;
                case LogLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(message);
                    Console.ResetColor();
                    break;
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Error.WriteLine(message);
                    Console.ResetColor();
                    break;
            }
        }     
    }
}