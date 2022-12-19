using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Noob_Coder.ViewModels;

namespace Noob_Coder.Infrastructure.HostBuilderExtensions
{
    /// <summary>
    /// Инкапсулирует методы добавления классов представлений в контейнер внедрения зависимостей.
    /// </summary>
    public static class AddViewsHostBuilderExtensions
    {
        /// <summary>
        /// Добавляет классы моделей-представлений в контейнер внедрения зависимостей.
        /// </summary>
        /// <returns>IHostBuilder</returns>
        public static IHostBuilder AddViews(this IHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.AddSingleton<MainWindow>(provider => new MainWindow()
                {
                    DataContext = provider.GetService<MainWindowViewModel>(),
                });
            });
            return builder;
        }
    }
}
