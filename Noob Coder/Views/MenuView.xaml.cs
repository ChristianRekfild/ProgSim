
using Microsoft.Extensions.DependencyInjection;
using Noob_Coder.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Noob_Coder.Views
{
    /// <summary>
    /// Interaction logic for MenuView.xaml
    /// </summary>
    public partial class MenuView : UserControl
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void LoadGameMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Window bluringWindow = (Window)button.CommandParameter;
            OpenSaveLoadDialogWindow(bluringWindow, new LoadGameDialog(), "load");
        }

        public void OpenSaveLoadDialogWindow(Window bluringWindow, Window opennigWindow, string parametr)
        {
            bluringWindow.Effect = new System.Windows.Media.Effects.BlurEffect(); // затемнить текущее окно
            opennigWindow.DataContext = App.Host.Services.GetRequiredService<FeedBackFormViewModel>(); //установить VM нового окна
            opennigWindow.ShowDialog(); //открыть новое окно
            bluringWindow.Effect = null; //убрать затемнение
        }

    }
}
