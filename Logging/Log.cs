namespace Logging
{
    public class Log : ILog
    {
        readonly Logger log;

        public Log(string logName)
        {
            log = LogManager.GetLogger(logName);
        }

        public void Info(string message, params object[] args)
        {
            log.Info(message, args);
        }
    }
}