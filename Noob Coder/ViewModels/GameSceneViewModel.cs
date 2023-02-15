using System;
using System.Threading;
using System.Windows.Input;
using Noob_Coder.Models;
using Noob_Coder.Infrastructure.Commands;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Noob_Coder.Services;

namespace Noob_Coder.ViewModels
{
    /// <summary>
    /// Класс модели-представления основного окна игры.
    /// </summary>
    internal class GameSceneViewModel : ViewModelBase
    {

        #region Свойства

        private string _title;
        /// <summary>
        /// Заголовок окна.
        /// </summary>
        public override string Title
        {
            get => _title;
            set => SetField(ref _title, value);
        }
        //TODO убрать в класс GameSettings
        private DateTime _gameDate = DateTime.Now;

        public DateTime GameDate
        {
            get => _gameDate;
            set => SetField(ref _gameDate, value);
        }

        #region игровые объекты

        private Protagonist _protagonist;
        /// <summary>
        /// Переменная главного героя игры.
        /// </summary>
        public Protagonist Protagonist
        {
            get => _protagonist;
            set => SetField(ref _protagonist, value);
        }

        #region работа все что с ней связано
        /// <summary>
        /// коллекция доступных вакансий
        /// </summary>
        public ObservableCollection<Work> VacanciesWorks { get; set; }

        #endregion
        #endregion
        #endregion

        #region Команды
        /// <summary>
        /// Команда перехода в главное меню.
        /// </summary>
        public ICommand NavigateMenuCommand { get; }

        /// <summary>
        /// Команда управления здоровьем главного герою.
        /// </summary>
        public ICommand AddProtagonistHealthCommand { get; }//Базоая команда
        public ICommand AddProtagonistHealth10Command { get; }//Добавить 10 единиц
        public ICommand AddProtagonistHealth20Command { get; }//Добавить 20 единиц

        /// <summary>
        /// Команда управления настроением главного дероя.
        /// </summary>
        public ICommand ChangeMoodCommand { get; }

        ///<summary>
        ///Команда устройства на работу
        /// </summary>
        public ICommand TakeWorkCommand { get; }

        /// <summary>
        /// Команда позволяющая грабить корованы.
        /// </summary>
        public ICommand RobCaravanCommand { get; }


        public ICommand SpeedUpCommand { get; }
        #endregion

        //Конструктор GameSceneViewModel
        public GameSceneViewModel(NavigationStore navigationStore, Protagonist protagonist)
        {
            #region Создание базовых игровых объектов
            Protagonist = protagonist; // Создание нового главного героя игры.
            VacanciesWorks = VacanciesWorksGenerator(); //Генерация доступных вакансий
            #endregion

            #region Создвние команд
            #region Создание навигационных команд.
            NavigateMenuCommand = new NavigateMenuCommand(navigationStore); //возврат в главное меню
            #endregion

            #region Создание комманд взаимодействия с главным героем.
            AddProtagonistHealth10Command = new AddProtagonistHealthCommand(10);//добавить 20 единиц здоровья
            AddProtagonistHealth20Command = new AddProtagonistHealthCommand(20);//добавить 20 единиц здоровья
            TakeWorkCommand = new TakeWorkCommand(Protagonist); //принять работу
            RobCaravanCommand = new RobCaravanCommand(); //попробовать ограбить корован
            ChangeMoodCommand = new ChangeMoodCommand(-10); //испортить настроение
            #endregion

            SpeedUpCommand = new SpeedUpCommand();//ускориться
            #endregion


            var service = App.Host.Services.GetRequiredService<GameBackgroundService>();
            service.RunTimer(_cts.Token).WaitAsync(CancellationToken.None);
        }

        private readonly CancellationTokenSource _cts = new();

        public void CancelGameTimer() => _cts.Cancel();

        /// <summary>
        /// Генератор вакансий
        /// создает случайным образом список из 10 вакансий
        /// </summary>
        /// <returns></returns>
        private ObservableCollection<Work> VacanciesWorksGenerator()
        {
            ObservableCollection<Work> vacancies = new ObservableCollection<Work>();

            Random rnd = new Random(); // новый генеротор случайных чисел
            int rndCompanyIndex = new int();
            int rndJobIndex = new int();

            for (int i = 0; i<10; i++) //цмкл для создания 10 вакансий
            {
            //получаем название компании случайным образом из enum Companies

            rndCompanyIndex = rnd.Next(0, Enum.GetNames(typeof(Companies)).Length); //случайное число от 0 до максимального элемента в enum Companies
            Companies rndCompany = (Companies)rndCompanyIndex; //получение значения из enum по индкусу
            string companyName = rndCompany.ToString(); //перевод в строку

            //создаем объект objCompany по ранее сгенерированному имени companyName
            object objCompany = Type.GetType("Noob_Coder.Models." + companyName).GetConstructor(new Type[0]).Invoke(null);

            if (objCompany is Company company) //если получилость создать компанию
            {
                //получаем название должности случайным образом из доступных должностей созданной компании

                rndJobIndex = rnd.Next(0, company.PossibleJobs.Count); //случайное число от 0 до максимального элемента в List доступных вакансий
                Jobs rndJob = company.PossibleJobs.ElementAt(rndJobIndex);//получение зачения enum по индексу из списка доступных должностей
                string jobName = rndJob.ToString(); //перевод в строку

                //создаем объект objJob по ранее сгенерированному имени jobName
                object objJob = Type.GetType("Noob_Coder.Models." + jobName).GetConstructor(new Type[0]).Invoke(null);

                if (objJob is Job job) //если получилость создать еще и должность
                {
                    Work work = new Work(job, company);//создаем новую вакансию
                    vacancies.Add(work);//добавляем в коолекцию
                }
            }
            }
            return vacancies; //возвращаем коллекцию вакансий
        }
    }
}
