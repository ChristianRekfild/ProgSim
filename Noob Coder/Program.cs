using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

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

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            var appsettingsPath = Path.Combine(App.CurrentAppRunningDirectory(), "appsettings.json");
            var builder = Host.CreateDefaultBuilder(args)
                              .UseContentRoot(App.CurrentAppRunningDirectory())
                              .ConfigureAppConfiguration((host, config) => 
                                  config.SetBasePath(App.CurrentAppRunningDirectory())
                                        .AddJsonFile(appsettingsPath, optional: false, reloadOnChange: true))
                              .ConfigureServices(App.ConfigureServices);

            return builder;
        }
    }
}
