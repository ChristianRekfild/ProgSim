using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Ribbon.Primitives;
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
            var builder = Host.CreateDefaultBuilder(args);
            var appsettingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            builder.UseContentRoot(AppDomain.CurrentDomain.BaseDirectory);
            builder.ConfigureAppConfiguration((host, config) =>
            {
                config.SetBasePath(AppDomain.CurrentDomain.BaseDirectory);
                config.AddJsonFile(appsettingsPath, optional:false, reloadOnChange:true);
            });

            builder.ConfigureServices(App.ConfigureServices);

            return builder;
        }
    }
}
