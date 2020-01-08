using System;
using IPALogger = IPA.Logging.Logger;

namespace BS_Utils.Utilities
{
    public class Logger
    {
        internal static IPALogger log { get; set; }

        internal static void Log(string message) => log.Info(message);
        internal static void Log(string message, IPALogger.Level level) => log.Log(level, message);

        [Obsolete("This is legacy code from the old IPA days, please use your own logger")]
        public static void Log(string modName, string message) => log.Info($"[{modName}]  {message}");
    }
}
