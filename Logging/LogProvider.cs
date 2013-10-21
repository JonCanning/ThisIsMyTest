using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace Logging
{
    public static class LogProvider
    {
        static readonly ConcurrentDictionary<Type, ILog> Loggers = new ConcurrentDictionary<Type, ILog>();

        static LogProvider()
        {
            Reset();
        }

        public static Func<string, ILog> LoggerFunc { get; set; }

        public static void Reset()
        {
            Loggers.Clear();
            LoggerFunc = s => new Log(s);
        }

        public static ILog GetLogger()
        {
            var type = new StackFrame(1).GetMethod().DeclaringType;
            return GetLogger(type);
        }

        public static ILog GetLogger<T>()
        {
            return GetLogger(typeof (T));
        }

        public static ILog GetLogger(Type type)
        {
            return Loggers.GetOrAdd(type, t => LoggerFunc(type.FullName));
        }
    }
}