using Microsoft.Extensions.DependencyInjection;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.Models;
using Noob_Coder.Services;
using Noob_Coder.ViewModels;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Animation;
using static System.Net.Mime.MediaTypeNames;

namespace Noob_Coder.Views
{
    /// <summary>
    /// Interaction logic for GameSceneView.xaml
    /// </summary>
    public partial class GameSceneView : UserControl
    {
        public GameSceneView()
        {
            InitializeComponent();
        }

        private void gs_LeftSection_MainSectionButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var currentSection = VisibilityGrid();
            var openSection = SectionMain;
            if (currentSection != openSection)
            {
                CloseSection(currentSection);
                OpenSection(openSection);
            }
   
        }

        private void gs_LeftSection_PropertySectionButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var currentSection = VisibilityGrid();
            var openSection = SectionProperty;
            if (currentSection != openSection)
            {
                CloseSection(currentSection);
                OpenSection(openSection);
            }

        }

        private void gs_LeftSection_EducationSectionButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var currentSection = VisibilityGrid();
            var openSection = SectionEducation;
            if (currentSection != openSection)
            {
                CloseSection(currentSection);
                OpenSection(openSection);
            }

        }

        private void gs_LeftSection_FinanceSectionButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var currentSection = VisibilityGrid();
            var openSection = SectionFinance;
            if (currentSection != openSection)
            {
                CloseSection(currentSection);
                OpenSection(openSection);
            }

        }

        private Grid VisibilityGrid()
        {
            var currentSection = new Grid();
            if (SectionMain.Visibility == Visibility.Visible) currentSection = SectionMain;
            if (SectionEducation.Visibility == Visibility.Visible) currentSection = SectionEducation;
            if (SectionFinance.Visibility == Visibility.Visible) currentSection = SectionFinance;
            if (SectionProperty.Visibility == Visibility.Visible) currentSection = SectionProperty;
            return currentSection;
        }

        private void CloseSection(Grid Section)
        {
            var Storyboard = new Storyboard();
            DoubleAnimationUsingKeyFrames animation = new DoubleAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, Section);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Grid.OpacityProperty));

            var keyFrame = new EasingDoubleKeyFrame
            {
                Value = 0,
                KeyTime = TimeSpan.FromMilliseconds(500)
            };

            animation.KeyFrames.Add(keyFrame);
            Storyboard.Children.Add(animation);
            Storyboard.Begin();

            var StoryboardVisibility = new Storyboard();
            ObjectAnimationUsingKeyFrames animationVisibility = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(animationVisibility, Section);
            Storyboard.SetTargetProperty(animationVisibility, new PropertyPath(Grid.VisibilityProperty));

            var keyFrameVisibility = new DiscreteObjectKeyFrame
            {
                Value = Visibility.Hidden,
                KeyTime = TimeSpan.FromMilliseconds(500)
            };

            animationVisibility.KeyFrames.Add(keyFrameVisibility);
            Storyboard.Children.Add(animationVisibility);
            Storyboard.Begin();
        }




        private void OpenSection(Grid Section)
        {

            var Storyboard = new Storyboard();
            DoubleAnimationUsingKeyFrames animation = new DoubleAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, Section);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Grid.OpacityProperty));

            var keyFrame1 = new EasingDoubleKeyFrame
            {
                Value = 0,
                KeyTime = TimeSpan.FromMilliseconds(300)
            };

            var keyFrame = new EasingDoubleKeyFrame
            {
                Value = 1,
                KeyTime = TimeSpan.FromMilliseconds(600)
            };

            animation.KeyFrames.Add(keyFrame1);
            animation.KeyFrames.Add(keyFrame);
            Storyboard.Children.Add(animation);
            Storyboard.Begin();

            var StoryboardVisibility = new Storyboard();
            ObjectAnimationUsingKeyFrames animationVisibility = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(animationVisibility, Section);
            Storyboard.SetTargetProperty(animationVisibility, new PropertyPath(Grid.VisibilityProperty));

            var keyFrameVisibility = new DiscreteObjectKeyFrame
            {
                Value = Visibility.Visible,
                KeyTime = TimeSpan.FromMilliseconds(300)
            };

            animationVisibility.KeyFrames.Add(keyFrameVisibility);
            Storyboard.Children.Add(animationVisibility);
            Storyboard.Begin();


        }



        private void gs_LeftSection_LoadButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Window bluringWindow = (Window)button.CommandParameter;
            OpenSaveLoadDialogWindow(bluringWindow, new SaveLoadGameDialog(), "load");
        }

        public void OpenSaveLoadDialogWindow(Window bluringWindow, Window opennigWindow, string parametr)
        {
            App.Host.Services.GetRequiredService<GameBackgroundService>().Pause = true;
            bluringWindow.Effect = new System.Windows.Media.Effects.BlurEffect(); // затемнить текущее окно
            opennigWindow.DataContext = ActivatorUtilities.CreateInstance<SaveLoadGameDialogViewModel>(App.Host.Services, parametr);
            opennigWindow.ShowDialog(); //открыть новое окно
            App.Host.Services.GetRequiredService<GameBackgroundService>().Pause = false;
            bluringWindow.Effect = null; //убрать затемнение
        }



    }
}
