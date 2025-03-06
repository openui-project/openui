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
        private bool isDebug = true;

        public static void SetDebugMode(bool enabled) {
            isDebug = enabled;
        }

        public static void TraceLog(LogLevel level, string message, params object[] args) {
            if (isDebug == false) 
                return;
            
            string message = string.Format(message, args);

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