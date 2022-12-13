using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Noob_Coder
{
  
  public partial class MainWindow : NcWindow
  {
    public MainWindow()
    {
      InitializeComponent();
      AfterCreation();
    }

    /// <summary>
    /// Заполнение стартового окна кнопками, создание Action на изменение размера экрана
    /// </summary>
    private void AfterCreation()
    {
      MainMenu.VerticalAlignment = VerticalAlignment.Center;
      var NewGame = GetMenuButton("НОВАЯ ИГРА");
      var LoadGame = GetMenuButton("ЗАГРУЗИТЬ ИГРУ");
      var SaveGame = GetMenuButton("СОХРАНИТЬ ИГРУ");
      var Settings = GetMenuButton("НАСТРОЙКИ");
      var FeedBack = GetMenuButton("ОБРАТНАЯ СВЯЗЬ");
      var Exit = GetMenuButton("ВЫХОД");

      MainMenu.Children.Add(NewGame);
      MainMenu.Children.Add(LoadGame);
      MainMenu.Children.Add(SaveGame);
      MainMenu.Children.Add(Settings);
      MainMenu.Children.Add(FeedBack);
      MainMenu.Children.Add(Exit);

      this.MinWidth = BtnMinWidth * 2;
      this.MinHeight = MainMenu.Children.Count * 70;

      CreateSizeChangedAction(MainMenu);

    }
  }
}
