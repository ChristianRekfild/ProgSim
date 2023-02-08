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
    internal class Company : ModelBase
    {
        private Companies _name;
        /// <summary>
        /// Название компании
        /// </summary>
        public Companies Name
        {
            get => _name;
            set => SetField(ref _name, value);

        }

        private string _title;
        /// <summary>
        /// Выводимое название компании
        /// </summary>
        public string Title
        {
            get => _title;
            set => SetField(ref _title, value);

        }

        private  List<int> _payDay;
        /// <summary>
        /// день зарплаты.
        /// </summary>
        public List<int> PayDay
        {
            get => _payDay;
            set => SetField(ref _payDay, value);

        }

        private List<Job> _possibleJobs;
        /// <summary>
        /// день зарплаты.
        /// </summary>
        public List<Job> PossibleJobs
        {
            get => _possibleJobs;
            set => SetField(ref _possibleJobs, value);

        }

        private double _payСoefficient;
        /// <summary>
        /// день зарплаты.
        /// </summary>
        public double PayСoefficient
        {
            get => _payСoefficient;
            set => SetField(ref _payСoefficient, value);

        }

        public Company()
        {

        }
    }
}
