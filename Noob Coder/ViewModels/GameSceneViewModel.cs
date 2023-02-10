﻿using System;
using System.Collections.Generic;
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
using System.Linq;

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
        /// Команда открытия всплывающего окна.
        /// </summary>
        public ICommand OpenSampleDialogWindowCommand { get; }

        //TODO может быть объединить команды открытия окно в одну?

        /// <summary>
        /// Команда открытия окна доступных вакансий.
        /// </summary>
        public ICommand OpenSearchWorkDialogWindowCommand { get;}

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
        
        /// <summary>
        /// Команда позволяющая грабить корованы.
        /// </summary>
        public ICommand RobCaravanCommand { get; }

        #endregion

        //Конструктор GameSceneViewModel
        public GameSceneViewModel(NavigationStore navigationStore)
        {
            #region Создание базовых игровых объектов
            Protagonist = new Protagonist(); // Создание нового главного героя игры.
            VacanciesWorks = VacanciesWorksGenerator(); //Генерация доступных вакансий
            #endregion

            #region Создвник команд
            #region Создание навигационных команд.
            NavigateMenuCommand = new NavigateMenuCommand(navigationStore); //возврат в главное меню
            OpenSampleDialogWindowCommand = new OpenSampleDialogWindowCommand(navigationStore); //открытие диалогового окна
            OpenSearchWorkDialogWindowCommand = new OpenSearchWorkDialogWindowCommand(navigationStore); //открытие окна вакансий
            #endregion

            #region Создание комманд взаимодействия с главным героем.
            AddProtagonistHealth10Command = new AddProtagonistHealthCommand(10);//добавить 20 единиц здоровья
            AddProtagonistHealth20Command = new AddProtagonistHealthCommand(20);//добавить 20 единиц здоровья
            RobCaravanCommand = new RobCaravanCommand(); //попробовать ограбить корован
            ChangeMoodCommand = new ChangeMoodCommand(-10); //испортитьт настроение
            #endregion
            #endregion



            //TODO убрать таймер в отдельный класс
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
               await Task.Delay(1000);
               Protagonist.AnotherFuckingDay(); //проживаем один день
               if (!Protagonist.IsNotDie()) System.Windows.Application.Current.Shutdown();//если померли - закрываем приложение (НАДО ПЕРЕДЕЛАТЬ НА КРАСИВУЮ ПЛАШКУ)
               GameDate = _gameDate.AddDays(1);

            }
        }


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
            companyName = "Noob_Coder.Models." + companyName; //добавление пространства имен

            //создаем объект objCompany по ранее сгенерированному имени companyName
            object objCompany = Type.GetType(companyName).GetConstructor(new Type[0]).Invoke(null);

            if (objCompany is Company company) //если получилость создать компанию
            {
                //получаем название должности случайным образом из доступных должностей созданной компании
                
                rndJobIndex = rnd.Next(0, company.PossibleJobs.Count); //случайное число от 0 до максимального элемента в List доступных вакансий
                Jobs rndJob = company.PossibleJobs.ElementAt(rndJobIndex);//получение зачения enum по индексу из списка доступных должностей
                string jobName = rndJob.ToString(); //перевод в строку
                jobName = "Noob_Coder.Models." + jobName; //добавление пространства имен

                //создаем объект objJob по ранее сгенерированному имени jobName
                object objJob = Type.GetType(jobName).GetConstructor(new Type[0]).Invoke(null);

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
