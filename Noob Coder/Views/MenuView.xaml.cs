
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
            OpenSaveLoadDialogWindow(bluringWindow, new SaveLoadGameDialog(), "load");
        }

        public void OpenSaveLoadDialogWindow(Window bluringWindow, Window opennigWindow, string parametr)
        {
            bluringWindow.Effect = new System.Windows.Media.Effects.BlurEffect(); // затемнить текущее окно
            opennigWindow.DataContext = ActivatorUtilities.CreateInstance<SaveLoadGameDialogViewModel>(App.Host.Services, parametr);
            opennigWindow.ShowDialog(); //открыть новое окно
            bluringWindow.Effect = null; //убрать затемнение
        }

    }
}
