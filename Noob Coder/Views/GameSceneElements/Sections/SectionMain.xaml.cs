
using Microsoft.Extensions.DependencyInjection;
using Noob_Coder.Services;
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




    }
}
