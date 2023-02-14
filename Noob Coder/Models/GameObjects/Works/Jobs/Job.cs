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
    /// <summary>
    /// Базовая модель должности
    /// </summary>
    internal class Job : ModelBase
    {
        private string _name;
        /// <summary>
        /// Название должности
        /// берется из enum Jobs
        /// должно совпадать с именем класса
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = value;

        }

        private int _minSalaryPerDay;
        /// <summary>
        /// Минимальная заработная плата за день.
        /// </summary>
        public int MinSalaryPerDay
        {
            get => _minSalaryPerDay;
            set => _minSalaryPerDay = value;

        }

        private int _maxSalaryPerDay;
        /// <summary>
        /// Максимальная заработная плата за день.
        /// </summary>
        public int MaxSalaryPerDay
        {
            get => _maxSalaryPerDay;
            set => _maxSalaryPerDay = value;

        }

        public Job()
        {
        }

    }

    enum Jobs
    {
        Loader,
        Seller,
        Worker,
        Courier,
        Animator,
        Cleaner,
        Intern,
        Junior,
        Middle,
        Senior,
        Lead,
    }
}
