using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Noob_Coder.Handlers;
using Noob_Coder.Services;


namespace Noob_Coder.Infrastructure.HostBuilderExtensions
{
    /// <summary>
    /// Инкапсулирует методы добавления классов сервисов в контейнер внедрения зависимостей.
    /// </summary>
    public static class AddViewServisesBuilderExtensions
    {
        /// <summary>
        /// Добавляет классы сервисов в контейнер внедрения зависимостей.
        /// </summary>
        /// <returns>IHostBuilder</returns>
        public static IHostBuilder AddServises(this IHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.AddSingleton<GameBackgroundService>(); 
                services.AddSingleton<IHandler, ProtagonistStateHandler>(); 
                services.AddSingleton<IHandler, GameSettingsHandler>(); 
        });
            return builder;
        }
    }
}
                    