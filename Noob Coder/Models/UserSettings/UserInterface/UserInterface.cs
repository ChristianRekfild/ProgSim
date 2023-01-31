using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Noob_Coder.Models.Base;

namespace Noob_Coder.Models 
{
    /// <summary>
    /// Класс модели UI.
    /// </summary>
    internal class UserInterface : ModelBase
    {
        #region Свойства
        #region Главное меню
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
        private string _health;
        /// <summary>
        /// Здоровье главного героя игры.
        /// </summary>
        public string Health
        {
            get => _health;
            set => SetField(ref _health, value);
        }

        #endregion

        


    }
}
