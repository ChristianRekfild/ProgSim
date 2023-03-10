using System.Text.Json;
using Noob_Coder.Models;
using Noob_Coder.Infrastructure.Commands.Base;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.ViewModels;
using System.IO;
using System;
using System.Text;
using Microsoft.Extensions.DependencyInjection;


namespace Noob_Coder.Infrastructure.Commands
{
    /// <summary>
    /// Команда перехода на страницу главного меню.
    /// </summary>
    internal class NavigateMenuCommand : CommandBase
    {
        private NavigationStore _navigationStore;

        public NavigateMenuCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object? parameter)
        {
            if (_navigationStore.CurrentViewModel is GameSceneViewModel ClosingGameScene)
            {
                /// <summary>
                /// Заверение работы таймера.
                /// </summary>
                ClosingGameScene.CancelGameTimer();

                /// <summary>
                /// Автосохранение параметров главного героя в файл LastAutoSave.noob в формате JSON.
                /// </summary>
                GameSaveModel gameSaveModel = new GameSaveModel(ClosingGameScene.Protagonist, ClosingGameScene.GameSettings);
                gameSaveModel.Save("LastAutoSave.noob");


            }
            if (_navigationStore.CurrentViewModel is SettingMenuViewModel ClosingSettingMenu)
            {
                SettingsSaveModel settingsSaveModel = new SettingsSaveModel();
                settingsSaveModel.Save(); // Автосохранение параметров пользовательских настроек в файл settings.noob в формате JSON.
            }

            _navigationStore.CurrentViewModel = App.Host.Services.GetRequiredService<MenuViewModel>();

        }
    }
}
