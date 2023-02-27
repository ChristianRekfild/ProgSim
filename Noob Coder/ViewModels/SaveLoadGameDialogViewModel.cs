using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Input;
using Noob_Coder.Infrastructure.Commands;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.Models;
using Noob_Coder.ViewModels.Base;

namespace Noob_Coder.ViewModels
{
    /// <summary>
    /// Класс модели-представления всплывающего окна загрузки/сохранения игры.
    /// Содержит свойства отображаемых во всплывающем окне загрузки/сохранения игры элементов
    /// и команды-обработчики событий.
    /// </summary>
    internal class SaveLoadGameDialogViewModel : ViewModelBase
    {

        #region Свойства

        private string _icon;
        /// <summary>
        /// Иконка окна.
        /// </summary>
        public string Icon
        {
            get => _icon;
            set => SetField(ref _icon, value);
        }

        /// <summary>
        /// Коллекция сохраненных файлов. Имя и дата создания.
        /// </summary>
       public ObservableCollection<SaveFile> SaveFiles { get; set; }

        private SaveFile _selectedSaveFile;
        public SaveFile SelectedSaveFile
        {
            get => _selectedSaveFile;
            set => SetField(ref _selectedSaveFile, value);
        }

        private SaveFile _newSaveFile;
        public SaveFile NewSaveFile
        {
            get => _newSaveFile;
            set => SetField(ref _newSaveFile, value);
        }
        

        #endregion

        #region Команды
        /// <summary>
        /// Команда-обработчик перехода на страницу игры.
        /// </summary>
        public ICommand NavigateNewGameCommand { get; }
        public ICommand SaveGameCommand { get; }

        #endregion
        public SaveLoadGameDialogViewModel(NavigationStore navigationStore, string parametr)
        {
            if (parametr == "load")
            {
                Icon = "Upload";
            }
            else
            {
                Icon = "ContentSave";
            }

            NavigateNewGameCommand = new NavigateNewGameCommand(navigationStore);
            SaveGameCommand = new SaveGameCommand();
            readSaveFiles();
            NewSaveFile = new SaveFile("NewGame", DateTime.Now, "NewGame"+".noob");




        }

        private void readSaveFiles()
        {
            var savesDirectoryPath = Path.Combine(App.CurrentAppRunningDirectory(), "Saves");
            if (Directory.Exists(savesDirectoryPath))
            {
                SaveFiles = new ObservableCollection<SaveFile>();
                string[] AllFiles = Directory.GetFiles(savesDirectoryPath, "*.noob", SearchOption.TopDirectoryOnly);
                foreach (string filename in AllFiles)
                {
                 SaveFiles.Add(new SaveFile(Path.GetFileNameWithoutExtension(filename), File.GetLastWriteTime(Path.Combine(savesDirectoryPath, filename)), Path.GetFileName(filename)));
                }

            }
        }

      

    }

    internal class SaveFile
    {
        public string FileName { get; set; }
        public DateTime FileDate { get; set; }

        public string FileNameWithExtension { get; set; }
        public SaveFile(string fileName, DateTime fileDate, string fileNameWithExtension)
        {
            FileName = fileName;
            FileDate = fileDate;
            FileNameWithExtension = fileNameWithExtension;
        }
    }
}
