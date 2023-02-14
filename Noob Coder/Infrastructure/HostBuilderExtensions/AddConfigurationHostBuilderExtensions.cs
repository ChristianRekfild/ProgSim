using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Noob_Coder.Infrastructure.HostBuilderExtensions
{
    /// <summary>
    /// Инкапсулирует базовые настройки IHostBuilder
    /// </summary>
    public static class AddConfigurationHostBuilderExtensions
    {
        /// <summary>
        /// Задаёт базовые настройки IHostBuilder
        /// </summary>
        /// <returns>IHostBuilder</returns>
        public static IHostBuilder AddConfiguration(this IHostBuilder builder)
        {
           // var appsettingsPath = Path.Combine(App.CurrentAppRunningDirectory(), "appsettings.json"); //строка создает файл json при запуске приложения. в настоящее время не используется
            
            builder.UseContentRoot(App.CurrentAppRunningDirectory())
                   .ConfigureAppConfiguration((host, config) =>
                        config.SetBasePath(App.CurrentAppRunningDirectory())
             //                 .AddJsonFile(appsettingsPath, optional: false, reloadOnChange: true)
                        );

            return builder;
        }
    }
}
