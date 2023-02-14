
using System;
using System.Windows;
using System.Windows.Controls;

namespace Noob_Coder.Views.GameSceneElements
{
    public partial class SectionMain : UserControl
    {
        public SectionMain()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Window bluringWindow = (Window)button.CommandParameter;
            OpenDialogWindow(bluringWindow, new SampleDialog());
        }

        private void gs_LeftSection_PropertySectionButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Window bluringWindow = (Window)button.CommandParameter;
            OpenDialogWindow(bluringWindow, new SearchWorkDialog());
        }

        public void OpenDialogWindow(Window bluringWindow, Window opennigWindow)
        {
            bluringWindow.Effect = new System.Windows.Media.Effects.BlurEffect(); // затемнить текущее окно
            opennigWindow.DataContext = this.DataContext; //установить VM нового окна
            opennigWindow.ShowDialog(); //открыть новое окно
            bluringWindow.Effect = null; //убрать затемнение
        }


    }
}
