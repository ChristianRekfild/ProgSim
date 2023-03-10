using System.Windows;
using System.Windows.Input;

namespace Noob_Coder.Views
{
	public partial class SaveGameDialog : Window
	{
		public SaveGameDialog()
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


    }
}