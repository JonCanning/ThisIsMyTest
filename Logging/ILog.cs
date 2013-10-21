namespace Logging
{
    public interface ILog
    {
        void Info(string message, params object[] args);
    }
}