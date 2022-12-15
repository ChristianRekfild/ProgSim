using System.Windows.Input;
using Noob_Coder.Infrastructure.Commands;
using Noob_Coder.Stores;
using Noob_Coder.ViewModels.Base;

namespace Noob_Coder.ViewModels
{
    internal class FeedBackFormViewModel : ViewModelBase
    {
        private string _title = "Симулятор программиста: Обратная связь";

        public FeedBackFormViewModel(NavigationStore navigationStore)
        {
            NavigateMenuCommand = new NavigateMenuCommand(navigationStore);
        }

        public string Title
        {
            get => _title;
            set => SetField(ref _title, value);
        }
        private string _backgroundImagePath = "/Data/Resourses/background.jpg";

        public string BackgroundImagePath
        {
            get => _backgroundImagePath;
            set => SetField(ref _backgroundImagePath, value);
        }
        public ICommand NavigateMenuCommand { get; }

    }
}
