using Microsoft.Extensions.DependencyInjection;
using Noob_Coder.Services;
using System;
using System.Windows;
using System.Windows.Input;

namespace Noob_Coder
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        public void OpenDialogWindow(Window bluringWindow, Window opennigWindow)
        {
            bluringWindow.Effect = new System.Windows.Media.Effects.BlurEffect(); // затемнить текущее окно
            App.Host.Services.GetRequiredService<GameBackgroundService>().Pause = true; // поставить счетчик дней на паузу для спокойного выбора вакансии
            opennigWindow.DataContext = this.DataContext; //установить VM нового окна
            opennigWindow.ShowDialog(); //открыть новое окно
            App.Host.Services.GetRequiredService<GameBackgroundService>().Pause = false; //снять счетчик дней с паузы
            bluringWindow.Effect = null; //убрать затемнение
        }

    }
}
