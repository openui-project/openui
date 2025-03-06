using System;

namespace OpenUI {
    public enum LogLevel {
        Info = 0,
        Warning,
        Error,
        Fatal
    }
}

namespace OpenUI.Core {
    public static class Utility {
        private static bool isDebug = true;

        public static void SetDebugMode(bool enabled) {
            isDebug = enabled;
        }

        public static void TraceLog(LogLevel level, string text, params object[] args) {
            if (isDebug)
                return;

            string message = string.Format(text, args);

            switch (level) 
            {
                case LogLevel.Info:
                    Console.WriteLine($"[INFO] {message}");
                    break;
                case LogLevel.Warning:
                    Console.WriteLine($"[WARNING] {message}");
                    break;
                case LogLevel.Error:
                    Console.Error.WriteLine($"[ERROR] {message}");
                    break;
                case LogLevel.Fatal:
                    throw new Exception($"[FATAL] {message}");
            }
        }
    }
}