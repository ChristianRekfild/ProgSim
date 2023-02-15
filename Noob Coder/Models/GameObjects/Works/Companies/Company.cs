using System.Collections.Generic;


namespace Noob_Coder.Models
{
    /// <summary>
    /// Базовая модель компании
    /// </summary>
    internal class Company : ModelBase
    {
        private string _name;
        /// <summary>
        /// Название компании
        /// берется из enum Companies
        /// должно совпадать с именем класса
        /// </summary>
        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);

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
