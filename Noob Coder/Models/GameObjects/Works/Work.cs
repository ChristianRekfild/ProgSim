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
    /// Базовый класс модели работы.
    /// </summary>
    internal class Work : ModelBase
    {
        #region Свойства

        private WorkNames _name;
        /// <summary>
        /// Название работы
        /// </summary>
        public WorkNames Name
        {
            get => _name;
            set => SetField(ref _name, value);

        }

        private string _companyName;
        /// <summary>
        /// Название компании
        /// </summary>
        public string CompanyName
        {
            get => _companyName;
            set => SetField(ref _companyName, value);

        }

        private bool _isSpecialized;
        /// <summary>
        /// Требует ли работа особой специализации.
        /// </summary>
        public bool IsSpecialized
        {
            get => _isSpecialized;
            set => SetField(ref _isSpecialized, value);

        }

        private int _salaryPerDay;
        /// <summary>
        /// Заработная плата за день.
        /// </summary>
        public int SalaryPerDay
        {
            get => _salaryPerDay;
            set => SetField(ref _salaryPerDay, value);

        }

        private int _payDay;
        /// <summary>
        /// День зарплаты.
        /// </summary>
        public int PayDay
        {
            get => _payDay;
            set => SetField(ref _payDay, value);

        }


        #endregion

        public Work()
        {
           
        }


    }

    enum WorkNames
    {
        loader,
        seller,
        worker,
        courier,
        animator,
        intern,
        junior,
        middle,
        senior,
        lead
    }
    
    

}
