//пример без DI
using ExampleWithInterface;
using Microsoft.Extensions.DependencyInjection;

var logger1 = new ExampleWithoutDI.Logger();
logger1.Log("OLEG1");

//пример с интерфейсом, делаем интерфейс и в логгер передаем конкретный сервис, неудобно так как нужно в конструкторе передавать определенные сервисы
var logger2 = new ExampleWithInterface.Logger(new ExampleWithInterface.SimpleLogService());
logger2.Log("Oleg2");

logger2 = new ExampleWithInterface.Logger(new ExampleWithInterface.GreenLogService());
logger2.Log("Oleg2");

//пример с контейнером, кладем в контейнер (регистрируем) сервис, в конструкторе передаем в логгер.
IServiceCollection serviceCollection = new ServiceCollection()
        .AddTransient<ExampleWithInterface.ILogService, ExampleWithInterface.GreenLogService>();

var serviceProvider1 = serviceCollection.BuildServiceProvider();
ILogService? logService = serviceProvider1.GetService<ILogService>();

Logger logger3 = new Logger(logService);
logger3.Log("Oleg3");

//пример настоящего DI, когда сервис не получаем, а получаем только логгер, сервис неявно создается.

IServiceCollection serviceCollection1 = new ServiceCollection()
    .AddTransient<ExampleWithInterface.ILogService, ExampleWithInterface.GreenLogService>()
    .AddTransient<Logger>();

var serviceProvider2 = serviceCollection1.BuildServiceProvider();

Logger? logger4 = serviceProvider2.GetService<Logger>();
logger4?.Log("Oleg4");


public class Logger
{
    public ILogService? logService1;

    public Logger(ILogService logService1)
    {
        this.logService1 = logService1;
    }

    public void Log(string message) => logService1?.Write($"{DateTime.Now}, {message}");

}
