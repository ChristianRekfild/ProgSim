using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

namespace NoobCoder.Views;

public partial class Menu  : NcPage
{
    public Menu()
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
        var newGame = GetMenuButton("НОВАЯ ИГРА");
        var loadGame = GetMenuButton("ЗАГРУЗИТЬ ИГРУ");
        var saveGame = GetMenuButton("СОХРАНИТЬ ИГРУ");
        var settings = GetMenuButton("НАСТРОЙКИ");
        var feedBack = GetMenuButton("ОБРАТНАЯ СВЯЗЬ");
        var exit = GetMenuButton("ВЫХОД");

        MainMenu.Children.Add(newGame);
        MainMenu.Children.Add(loadGame);
        MainMenu.Children.Add(saveGame);
        MainMenu.Children.Add(settings);
        MainMenu.Children.Add(feedBack);
        MainMenu.Children.Add(exit);

        AddAction<FeedBackPage>(feedBack);
        AddAction<GameScenePage>(newGame);
        exit.Click += (sender, args) => System.Windows.Application.Current.Shutdown();


        this.MinWidth = BtnMinWidth * 2;
        this.MinHeight = MainMenu.Children.Count * 70;

        CreateSizeChangedAction(MainMenu);
    }

    /// <summary>
    /// Добавить Action открытия нового окна к кнопке
    /// </summary>
    /// <param name="btn">К какой кнопке добавляем Action</param>
    /// <typeparam name="TPage">Какое окно открываем</typeparam>
    private static void AddAction<TPage>(ButtonBase btn) where TPage : new()
    {
        btn.Click += (sender, args) =>
        {
            MainWindow.MainWindowLink.Content = (new TPage()) as NcPage;
        };
    }
}