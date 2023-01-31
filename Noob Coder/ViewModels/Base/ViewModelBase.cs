using Noob_Coder.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Noob_Coder.ViewModels.Base
{
    /// <summary>
    /// Базовый абстрактный класс для модели-представления.
    /// </summary>
    internal abstract class ViewModelBase : INotifyPropertyChanged
    {

        /// <summary>
        /// Свойсто заголовка окна
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// Свойсто, хранящее пользовательские настойки интерфейса
        /// </summary>
        public virtual UserSettings UserSettings { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        /// <summary>
        /// Событие оповещает представления о том, что свойство модели-представления изменило значение.
        /// </summary>
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Метод устанавливает значение свойства модели-представления и вызывает событие OnPropertyChanged()
        /// </summary>
        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }   
    }
}
