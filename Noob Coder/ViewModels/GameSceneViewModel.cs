﻿using System;
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

        #endregion
        public GameSceneViewModel(NavigationStore navigationStore)
        {

            /// <summary>
            /// Создание команд.
            /// </summary>
            NavigateMenuCommand = new NavigateMenuCommand(navigationStore);
            OpenSampleDialogWindowCommand = new OpenSampleDialogWindowCommand();

            /// <summary>
            /// Создание нового главного героя игры.
            /// </summary>
            Protagonist = new Protagonist();
            Protagonist.Health = 100; // значение здоровья главного героя игры по умолчанию
            Protagonist.Money = 10000; // значение наличных денег по умолчанию
            Protagonist.Mustache = 0;  // значение усатости главного героя игры по умолчанию

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
