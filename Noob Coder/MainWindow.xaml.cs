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
  
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      AfterCreation();
    }



    /// <summary>
    /// Минимальный размер кнопки, он же отступ границы кнопки от края экрана
    /// </summary>
    private const int BtnMinWidth = 300;

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


      SizeChanged += (sender, args) =>
      {
        var newWidth = this.Width - BtnMinWidth;
        if (this.Width <= BtnMinWidth * 2)
        {
          NewGame.Width = this.Width;
          LoadGame.Width = this.Width;
          SaveGame.Width = this.Width;
          Settings.Width = this.Width;
          FeedBack.Width = this.Width;
          Exit.Width = this.Width;
        }
        else
        {
          NewGame.Width = newWidth;
          LoadGame.Width = newWidth;
          SaveGame.Width = newWidth;
          Settings.Width = newWidth;
          FeedBack.Width = newWidth;
          Exit.Width = newWidth;
        }
      };

    }

    /// <summary>
    /// Создать кнопку в основное меню
    /// </summary>
    /// <param name="text">Текст, с которым создаётся кнопка</param>
    /// <returns></returns>
    private Button GetMenuButton(string text)
    {
      return new Button
      {
        MaxWidth = 1080,
        VerticalAlignment = VerticalAlignment.Top,
        Width = this.Width - BtnMinWidth,
        Height = 40,
        HorizontalContentAlignment = HorizontalAlignment.Center,
        VerticalContentAlignment = VerticalAlignment.Top,
        Content = text,
        FontSize=24,
        Background = Brushes.Indigo,
        Foreground = Brushes.White,
        FontFamily = new FontFamily("Corbel Light")
      };
    }
  }
}
