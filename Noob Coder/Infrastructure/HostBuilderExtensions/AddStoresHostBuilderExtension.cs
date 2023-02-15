using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Noob_Coder.Infrastructure.Stores;

namespace Noob_Coder.Infrastructure.HostBuilderExtensions
{
    /// <summary>
    /// Инкапсулирует методы добавление классов, хранящих промежуточное состояние приложения, в контейнер внедрения зависимостей.  
    /// </summary>
    public static class AddStoresHostBuilderExtensions
    {
        /// <summary>
        /// Добавляет классы, хранящие промежуточное состояние приложения, в контейнер внедрения зависимостей. 
        /// </summary>
        /// <returns>IHostBuilder</returns>
        public static IHostBuilder AddStores(this IHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.AddSingleton<NavigationStore>();
            });

            return builder;
        }
    }
}
