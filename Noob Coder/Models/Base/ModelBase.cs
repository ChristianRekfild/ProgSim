using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Noob_Coder.Models.Base
{
    /// <summary>
    /// Базовый абстрактный класс для модели-представления.
    /// </summary>
    internal abstract class ModelBase : INotifyPropertyChanged
    {
        public virtual string Title { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;
        /// <summary>
        /// Событие оповещает представления о том, что свойство модели изменило значение.
        /// </summary>
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Метод устанавливает значение свойства модели и вызывает событие OnPropertyChanged()
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
