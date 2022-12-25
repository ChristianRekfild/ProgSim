using System;
using System.Windows;

namespace Noob_Coder
{
	public partial class InputDialogSample : Window
	{
		public InputDialogSample()
		{
			InitializeComponent();
		}

		private void btnDialogOk_Click(object sender, RoutedEventArgs e)
		{
			this.DialogResult = true;
		}

	}
}