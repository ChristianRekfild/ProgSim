using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Noob_Coder.ViewModels;


namespace Noob_Coder.Infrastructure.HostBuilderExtensions
{
    /// <summary>
    /// Инкапсулирует методы добавления классов моделей-представлений в контейнер внедрения зависимостей.
    /// </summary>
    public static class AddViewModelsHostBuilderExtensions
    {
        /// <summary>
        /// Добавляет классы моделей-представлений в контейнер внедрения зависимостей.
        /// </summary>
        /// <returns>IHostBuilder</returns>
        public static IHostBuilder AddViewModels(this IHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.AddSingleton<MainWindowViewModel>();
                services.AddTransient<MenuViewModel>();
                services.AddTransient<GameSceneViewModel>();
                services.AddTransient<SettingMenuViewModel>();
                services.AddTransient<FeedBackFormViewModel>();
            });
            return builder;
        }
    }
}
