using Application.Interfaces.Common;
using Microsoft.Extensions.DependencyInjection;

namespace LoggerService;
public static class LoggerServiceExtension
{
    public static void ConfigureLoggerService(this IServiceCollection services)
    {
        services.AddSingleton<ILoggerManager, LoggerManager>();
    }
}
