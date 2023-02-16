using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Noob_Coder.Handlers;
using Noob_Coder.Infrastructure.HostBuilderExtensions;
using Noob_Coder.Services;

namespace Noob_Coder
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }
        /// <summary>
        /// Сборка хоста приложения и конфигурация контейнера внедрения зависимостей.
        /// </summary>
        /// <returns>Сконфигурированный экземпляр IHostBuilder</returns>
        public static IHostBuilder CreateHostBuilder(string[] args = null)
        {
            var builder = Host.CreateDefaultBuilder(args)
                              .AddConfiguration()
                              .AddStores()
                              .AddServises()
                              .AddViewModels()
                              .AddViews();

       

            return builder;
        }
    }
}
