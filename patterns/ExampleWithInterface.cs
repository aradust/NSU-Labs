namespace ExampleWithInterface
{
    public interface ILogService
    {
        void Write(string message);
    }

    public class SimpleLogService : ILogService
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class GreenLogService : ILogService
    {
        public void Write(string message)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(message);
            Console.ForegroundColor = defaultColor;
        }
    }

    public class Logger
    {
        ILogService logService;

        public Logger(ILogService logService)
        {
            this.logService = logService;
        }

        public void Log(string message) => logService.Write($"{DateTime.Now}, {message}");
    }
}