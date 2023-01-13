using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
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

        private int _health = 100;

        public int Health
        {
            get => _health;
            set => SetField(ref _health, value);
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
            NavigateMenuCommand = new NavigateMenuCommand(navigationStore);
            OpenSampleDialogWindowCommand = new OpenSampleDialogWindowCommand();
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
                GameDate = _gameDate.AddDays(1);
                Health = _health - 1;
            }
        }
    }
}
