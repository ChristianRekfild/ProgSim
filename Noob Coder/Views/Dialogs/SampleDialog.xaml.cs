using Noob_Coder.ViewModels;
using System;
using System.Windows;
using System.Windows.Input;

namespace Noob_Coder.Views
{
	public partial class SampleDialog : Window
	{
		public SampleDialog()
		{
			InitializeComponent();
	    }
		private void SampleDialogWindow_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
			{
				this.DragMove();
			}
		}
	}
}