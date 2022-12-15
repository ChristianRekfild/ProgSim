using System.Windows;
using Noob_Coder.Stores;
using Noob_Coder.ViewModels;

namespace Noob_Coder
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
      protected override void OnStartup(StartupEventArgs e)
      {
          var navigationStore = new NavigationStore();
          navigationStore.CurrentViewModel = new MenuViewModel(navigationStore);
          MainWindow = new MainWindow()
          {
              DataContext = new MainWindowViewModel(navigationStore),
          };
          MainWindow.Show();
          base.OnStartup(e);
        }
  }
}
