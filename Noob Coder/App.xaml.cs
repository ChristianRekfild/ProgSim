using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Noob_Coder.Handlers;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.Models;
using Noob_Coder.Services;
using Noob_Coder.ViewModels;

namespace Noob_Coder
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
      private static IHost _host;
      public static IHost Host => _host ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

      /// <summary>
      ///Метод возвращает путь к папке, в которой запущено приложение.
      /// </summary>
      /// <returns>Путь к текущей папке из которого запущено приложение в формате string </returns>
      public static string CurrentAppRunningDirectory() => AppDomain.CurrentDomain.BaseDirectory;

      /// <summary>
      /// Действия, выполняемые при старте приложения.
      /// </summary>
      /// <param name="e"></param>
      protected override async void OnStartup(StartupEventArgs e)
      {
          var settingsSaveModel = new SettingsSaveModel();
          settingsSaveModel.Load();

          var navigationStore = Host.Services.GetRequiredService<NavigationStore>();
          navigationStore.CurrentViewModel = Host.Services.GetRequiredService<MenuViewModel>();
          MainWindow = Host.Services.GetRequiredService<MainWindow>();
          MainWindow.Show();

          AddHandlers();

          base.OnStartup(e);
          await Host.StartAsync().ConfigureAwait(false);
      }

      private static void AddHandlers()
      {
          var backgroundService = Host.Services.GetRequiredService<GameBackgroundService>();

          foreach (var handler in Host.Services.GetServices<IHandler>())
          {
              backgroundService.DayChanged += handler.HandleNewDayEvent;
          }
      }

      /// <summary>
      /// Действия, выполняемые при завершении работы приложения.
      /// </summary>
      /// <param name="e"></param>
      protected override async void OnExit(ExitEventArgs e)
      {
          base.OnExit(e);
          var host = Host;
          await host.StopAsync().ConfigureAwait(false);
          host.Dispose();
      }
  }
}
