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
    /// Базовая модель компании
    /// </summary>
    internal class Company : ModelBase
    {
        private Companies _name;
        /// <summary>
        /// Название компании
        /// берется из enum Companies
        /// должно совпадать с именем класса
        /// </summary>
        public Companies Name
        {
            get => _name;
            set => SetField(ref _name, value);

        }

        private string _title;
        /// <summary>
        /// Отображаемое название компании
        /// берется из словаря, зависит от языка
        /// </summary>
        public string Title
        {
            get => _title;
            set => SetField(ref _title, value);

        }

        private  List<int> _payDay;
        /// <summary>
        /// Список со днями зарплаты
        /// </summary>
        public List<int> PayDay
        {
            get => _payDay;
            set => _payDay = value;

        }

        private List<Jobs> _possibleJobs;
        /// <summary>
        /// Список возможных должностей
        /// берется из enum Jibs
        /// </summary>
        public List<Jobs> PossibleJobs
        {
            get => _possibleJobs;
            set => _possibleJobs = value;

        }

        private double _payСoefficient;
        /// <summary>
        /// Зарплатный коэффициент данной компании
        /// зависит от "крутости" компании
        /// при генерации вакансии умножается на ставку заработной платы конкретной должности
        /// </summary>
        public double PayСoefficient
        {
            get => _payСoefficient;
            set => _payСoefficient = value;

        }
        
        
        public Company()
        {
            Title = "безработный"; //отображаемое название из словаря
            PayDay = new List<int> { 0 }; //список дней зарплаты
            PossibleJobs = new List<Jobs>(); //список возможных должностей из enum Jobs
            PayСoefficient = 0; //зарплатный коэффициент
        }
    }

    enum Companies
    {
        Minimarket,
        Supermarket,
        Gipermarket,
        Zoo,
        SmallITcompany,
        MediumITcompany,
        BigItCompany,
        MacroHard,
    }
}
