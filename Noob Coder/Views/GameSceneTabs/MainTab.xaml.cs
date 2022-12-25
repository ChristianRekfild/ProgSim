
using System;
using System.Windows.Controls;

namespace Noob_Coder.Views.User_Controls
{
    public partial class MainTab : UserControl
    {
        public MainTab()
        {
            InitializeComponent();
        }


     

        private void btnEnterName_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            InputDialogSample inputDialog = new InputDialogSample();
            inputDialog.ShowDialog();
                
        }
    }



}
