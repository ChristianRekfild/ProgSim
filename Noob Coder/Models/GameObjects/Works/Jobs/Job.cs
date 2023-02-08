using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Noob_Coder.Models.Base;
using System.Xml.Linq;

namespace Noob_Coder.Models
{
    internal class Job : ModelBase
    {
        private Jobs _name;
        /// <summary>
        /// Название работы
        /// </summary>
        public Jobs Name
        {
            get => _name;
            set => SetField(ref _name, value);

        }

        private string _title;
        /// <summary>
        /// Выводимое название работы
        /// </summary>
        public string Title
        {
            get => _title;
            set => SetField(ref _title, value);

        }

        private int _minSalaryPerDay;
        /// <summary>
        /// Минимальная заработная плата за день.
        /// </summary>
        public int MinSalaryPerDay
        {
            get => _minSalaryPerDay;
            set => SetField(ref _minSalaryPerDay, value);

        }

        private int _maxSalaryPerDay;
        /// <summary>
        /// Максимальная заработная плата за день.
        /// </summary>
        public int MaxSalaryPerDay
        {
            get => _maxSalaryPerDay;
            set => SetField(ref _maxSalaryPerDay, value);

        }

        public Job()
        {

        }

    }
}
