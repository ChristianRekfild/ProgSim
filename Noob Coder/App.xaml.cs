using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using Noob_Coder.ViewModels;
using Noob_Coder.Views.Windows;

namespace Noob_Coder
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
      protected override void OnStartup(StartupEventArgs e)
      {
          MainWindow = new MainWindow()
          {
              DataContext = new MainWindowViewModel(),
          };
          base.OnStartup(e);
      }
  }
}
