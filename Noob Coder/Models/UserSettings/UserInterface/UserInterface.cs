using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Noob_Coder.Models.Base;
using System.Data;

namespace Noob_Coder.Models 
{
    /// <summary>
    /// Класс модели UI.
    /// </summary>
    internal class UserInterface : ModelBase
    {
        #region Свойства
        private string _languageName;
        /// <summary>
        /// Название языка.
        /// Должно соответствовать switch SelectedLanguage из SettingMenuViewModel
        /// </summary>
        public string LanguageName
        {
            get => _languageName;
            set => SetField(ref _languageName, value);
        }

        #region MainMenu
        private string _menuViewTitle;
        /// <summary>
        /// Здоровье главного героя игры.
        /// </summary>
        public string MenuViewTitle
        {
            get => _menuViewTitle;
            set => SetField(ref _menuViewTitle, value);
        }

        private string _resumeGameButtonName;
        /// <summary>
        /// Надпись на кнопке продолжения игры.
        /// Имя привязанного элемента в разметке xaml - x:Name="ResumeGameMenuButton".
        /// </summary>
        public string ResumeGameButtonName
        {
            get => _resumeGameButtonName;
            set => SetField(ref _resumeGameButtonName, value);
        }

        private string _newGameButtonName;
        /// <summary>
        /// Надпись на кнопке начала новой игры.
        /// Имя привязанного элемента в разметке xaml - x:Name="NewGameMenuButton".
        /// </summary>
        public string NewGameButtonName
        {
            get => _newGameButtonName;
            set => SetField(ref _newGameButtonName, value);
        }

        private string _loadGameButtonName;
        /// <summary>
        /// Надпись на кнопке загрузки игры.
        /// Имя привязанного элемента в разметке xaml - x:Name="LoadGameMenuButton".
        /// </summary>
        public string LoadGameButtonName
        {
            get => _loadGameButtonName;
            set => SetField(ref _loadGameButtonName, value);
        }
        private string _settingsButtonName;
        /// <summary>
        /// Надпись на кнопке перехода на страницу настроек игры.
        /// Имя привязанного элемента в разметке xaml - x:Name="NavigateSettingsMenuButton".
        /// </summary>
        public string SettingsButtonName
        {
            get => _settingsButtonName;
            set => SetField(ref _settingsButtonName, value);
        }
        private string _feedbackButtonName;
        /// <summary>
        /// Надпись на кнопке перехода на страницу обратной связи
        /// Имя привязанного элемента в разметке xaml - x:Name="NavigateFeedBackFormMenuButton".
        /// </summary>
        public string FeedbackButtonName
        {
            get => _feedbackButtonName;
            set => SetField(ref _feedbackButtonName, value);
        }

        private string _exitButtonName;
        /// <summary>
        /// Надпись на кнопке закрытия приложения.
        /// Имя привязанного элемента в разметке xaml - x:Name="ExitMenuButton".
        /// </summary>
        public string ExitButtonName
        {
            get => _exitButtonName;
            set => SetField(ref _exitButtonName, value);
        }

        #endregion

        #region GameScene
        

        private string _GSTabItemMain;
        /// <summary>
        /// Панель боковых вкладок. Главная.
        /// </summary>
        public string GSTabItemMain
        {
            get => _GSTabItemMain;
            set => SetField(ref _GSTabItemMain, value);
        }

        private string _GSTabItemProperty;
        /// <summary>
        /// Панель боковых вкладок. Имущество.
        /// </summary>
        public string GSTabItemProperty
        {
            get => _GSTabItemProperty;
            set => SetField(ref _GSTabItemProperty, value);
        }

        private string _GSTabItemEducation;
        /// <summary>
        /// Панель боковых вкладок. Образование.
        /// </summary>
        public string GSTabItemEducation
        {
            get => _GSTabItemEducation;
            set => SetField(ref _GSTabItemEducation, value);
        }

        private string _GSTabItemFinance;
        /// <summary>
        /// Панель боковых вкладок. Финансы.
        /// </summary>
        public string GSTabItemFinance
        {
            get => _GSTabItemFinance;
            set => SetField(ref _GSTabItemFinance, value);
        }

        #region подписи индикаторов
        private string _health;
        /// <summary>
        /// Здоровье главного героя.
        /// </summary>
        public string Health
        {
            get => _health;
            set => SetField(ref _health, value);
        }

        private string _stamina;
        /// <summary>
        /// Усталость главного героя.
        /// </summary>
        public string Stamina
        {
            get => _stamina;
            set => SetField(ref _stamina, value);
        }


        private string _appearance;
        /// <summary>
        /// Опрятность главного героя.
        /// </summary>
        public string Appearance
        {
            get => _appearance;
            set => SetField(ref _appearance, value);
        }

        private string _mood;
        /// <summary>
        /// Настроение главного героя.
        /// </summary>
        public string Mood
        {
            get => _mood;
            set => SetField(ref _mood, value);
        }
        #endregion
        #endregion


        #region SettingMenu 
        private string _settingMenuLanguage;
        /// <summary>
        /// Страницы настоек. Язык.
        /// </summary>
        public string SettingMenuLanguage
        {
            get => _settingMenuLanguage;
            set => SetField(ref _settingMenuLanguage, value);
        }

        private string _settingMenuBackButtonName;
        /// <summary>
        /// Страница настроек. Кнопка назад.
        /// </summary>
        public string SettingMenuBackButtonName
        {
            get => _settingMenuBackButtonName;
            set => SetField(ref _settingMenuBackButtonName, value);
        }

        #endregion

        #endregion


        public string Minimarket { get; set; }
        public string Supermarket { get; set; }
        public string Gipermarket { get; set; }
        public string Zoo { get; set; }
        public string SmallITcompany { get; set; }
        public string MediumITcompany { get; set; }
        public string BigItCompany { get; set; }
        public string MacroHard { get; set; }

    }
}
