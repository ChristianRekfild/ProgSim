using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Noob_Coder.Models;
using Noob_Coder.Infrastructure.Commands;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.ViewModels.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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



        private Protagonist _protagonist;
        /// <summary>
        /// Переменная главного героя игры.
        /// </summary>
        public Protagonist Protagonist
        {
            get => _protagonist;
            set => SetField(ref _protagonist, value);
        }

        public ObservableCollection<Work> Works { get; set; }


        private int _addedHealthValue;
        /// <summary>
        /// Количество добавляемого здоровья.
        /// </summary>
        public int AddedHealthValue
        {
            get => _addedHealthValue;
            set => SetField(ref _addedHealthValue, value);
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


        public ICommand OpenSearchWorkDialogWindowCommand { get;}

        /// <summary>
        /// Команда добавления здоровья главному герою.
        /// </summary>
        public ICommand AddProtagonistHealthCommand { get; }
        public ICommand AddProtagonistHealth10Command { get; }
        public ICommand AddProtagonistHealth20Command { get; }

        public ICommand ChangeMoodCommand { get; }
        /// <summary>
        /// Команда позволяющая грабить корованы.
        /// </summary>
        public ICommand RobCaravanCommand { get; }

        #endregion
        public GameSceneViewModel(NavigationStore navigationStore)
        {

            /// <summary>
            /// Создание навигационных команд.
            /// </summary>
            NavigateMenuCommand = new NavigateMenuCommand(navigationStore);
            OpenSampleDialogWindowCommand = new OpenSampleDialogWindowCommand(navigationStore);
            OpenSearchWorkDialogWindowCommand = new OpenSearchWorkDialogWindowCommand(navigationStore);

            /// <summary>
            /// Создание нового главного героя игры.
            /// </summary>
            Protagonist = new Protagonist();

            /// <summary>
            /// Создание комманд взаимодействия с главным героем.
            /// </summary>
            AddProtagonistHealth10Command = new AddProtagonistHealthCommand(10);//добавить 20 единиц здоровья
            AddProtagonistHealth20Command = new AddProtagonistHealthCommand(20);//добавить 20 единиц здоровья
            RobCaravanCommand = new RobCaravanCommand(); //попробовать ограбить корован

            
            ChangeMoodCommand = new ChangeMoodCommand(-10); //испортитьт настроение

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
               // Task.Yield();
                await Task.Delay(1000);
                //Protagonist.AnotherFuckingDay(); //проживаем один день


                object obj = Type.GetType("Noob_Coder.Models.Loader").GetConstructor(new Type[0]).Invoke(null);
                if (obj is Job job)
                {
                    job.Title = UserSettings.UserInterface.Health;
                    Company company = new MacroHard();
                    Work work = new Work(job, company);
                    Works = new ObservableCollection<Work>();
                    Works.Add(work);
                };

                if (!Protagonist.IsNotDie()) System.Windows.Application.Current.Shutdown();//если померли - закрываем приложение (НАДО ПЕРЕДЕЛАТЬ НА КРАСИВУЮ ПЛАШКУ)

                GameDate = _gameDate.AddDays(1);

            }
        }
    }
}
