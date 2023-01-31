using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Noob_Coder.Models;
using Noob_Coder.Infrastructure.Commands;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.ViewModels.Base;


namespace Noob_Coder.ViewModels
{
    /// <summary>
    /// Класс модели-представления основного окна игры.
    /// </summary>
    internal class GameSceneViewModel : ViewModelBase
    {

        #region Свойства

        private string _title = "Симулятор программиста.";
        /// <summary>
        /// Заголовок окна.
        /// </summary>
        public override string Title
        {
            get => _title;
            set => SetField(ref _title, value);
        }

        private DateTime _gameDate = DateTime.Now;

        public DateTime GameDate
        {
            get => _gameDate;
            set => SetField(ref _gameDate, value);
        }


        /// <summary>
        /// Переменная главного героя игры.
        /// </summary>
        private Protagonist _protagonist;

        public Protagonist Protagonist
        {
            get => _protagonist;
            set => SetField(ref _protagonist, value);
        }

        #endregion

        #region Команды
        /// <summary>
        /// Команда перехода в главное меню.
        /// </summary>
        public ICommand NavigateMenuCommand { get; }

        /// <summary>
        /// Команда открытия всплывающего окна.
        /// </summary>
        public ICommand OpenSampleDialogWindowCommand { get; }


        /// <summary>
        /// Команда добавления здоровья главному герою.
        /// </summary>
        public ICommand AddProtagonistHealthCommand { get; }

        /// <summary>
        /// Команда позволяющая грабить корованы.
        /// </summary>
        public ICommand RobCaravanCommand { get; }

        /// <summary>
        /// Команда смены языка интерфейса.
        /// </summary>
        public ICommand ChangeLanguageToENGCommand { get;  }
        public ICommand ChangeLanguageToRUSCommand { get; }

        #endregion
        public GameSceneViewModel(NavigationStore navigationStore)
        {

            /// <summary>
            /// Создание навигационных команд.
            /// </summary>
            NavigateMenuCommand = new NavigateMenuCommand(navigationStore);
            OpenSampleDialogWindowCommand = new OpenSampleDialogWindowCommand();

            /// <summary>
            /// Создание интерфейсных комманд.
            /// </summary>
            ChangeLanguageToENGCommand = new ChangeLanguageToENGCommand();
            ChangeLanguageToRUSCommand = new ChangeLanguageToRUSCommand();

            /// <summary>
            /// Создание нового главного героя игры.
            /// </summary>
            Protagonist = new Protagonist();

            /// <summary>
            /// Создание комманд взаимодействия с главным героем.
            /// </summary>
            AddProtagonistHealthCommand = new AddProtagonistHealthCommand();//добавить 20 единиц здоровья
            RobCaravanCommand = new RobCaravanCommand(); //попробовать ограбить корован

            RunTimer().WaitAsync(_cts.Token);

         }


        private CancellationTokenSource _cts = new CancellationTokenSource();

        public void CancelTimer()
        {
            _cts.Cancel();
        }

        private async Task RunTimer()
        {
            while (!_cts.IsCancellationRequested)
            {
                Task.Yield();
                await Task.Delay(1000);
                Protagonist.AnowerFuckingDay(); //проживаем один день
                if (!Protagonist.IsNotDie()) System.Windows.Application.Current.Shutdown();//если померли - закрываем приложение (НАДО ПЕРЕДЕЛАТЬ НА КРАСИВУЮ ПЛАШКУ)

                GameDate = _gameDate.AddDays(1);

            }
        }
    }
}
