using System;

namespace OpenUI.Core {
    public static class Utility {
        public static void TraceLog(int level, string? text, params object[] args) {
            // If the log level is None, we don't log anything.
            if (level == 4 || text == null)
                return;

            string message = string.Format(text, args);

            switch (level)
            {
                case 0: // Info
                    Console.WriteLine($"[INFO] {message}");
                    break;
                case 1: // Warning
                    Console.WriteLine($"[WARN] {message}");
                    break;
                case 2: // Error
                    Console.Error.WriteLine($"[ERROR] {message}");
                    break;
                case 3: // Fatal
                    throw new Exception($"[FATAL] {message}");
            }
        }
    }
}