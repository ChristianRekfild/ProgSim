using Noob_Coder.ViewModels;
using System;
using System.Windows;
using System.Windows.Input;

namespace Noob_Coder.Views
{
	public partial class LoadGameDialog : Window
	{
		public LoadGameDialog()
		{
			InitializeComponent();
	    }
		private void SearchWorkDialog_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
			{
				this.DragMove();
			}
		}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }

        private void SaveFile_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            LoadButton.IsEnabled = true;
        }
    }
}