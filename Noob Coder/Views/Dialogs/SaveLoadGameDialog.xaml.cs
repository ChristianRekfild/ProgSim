using Noob_Coder.ViewModels;
using System;
using System.Windows;
using System.Windows.Input;

namespace Noob_Coder.Views
{
	public partial class SaveLoadGameDialog : Window
	{
		public SaveLoadGameDialog()
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
	}
}