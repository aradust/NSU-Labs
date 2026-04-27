
namespace ExampleWithoutDI
{
    public class SimpleLogService
    {
        public void Write(string message) => Console.WriteLine(message);
    }

    public class Logger
    {
        SimpleLogService simpleLogService = new SimpleLogService();

        public void Log(string message) => simpleLogService.Write($"{DateTime.Now}: {message}");

    }
}