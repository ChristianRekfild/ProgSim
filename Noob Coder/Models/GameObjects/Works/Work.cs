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

        private string _titleName;
        /// <summary>
        /// Название работы
        /// </summary>
        public string TitleName
        {
            get => _titleName;
            set => SetField(ref _titleName, value);

        }

        private string _companyTitleName;
        /// <summary>
        /// Название компании
        /// </summary>
        public string CompanyTitleName
        {
            get => _companyTitleName;
            set => SetField(ref _companyTitleName, value);
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

        private List<int> _payDay;
        /// <summary>
        /// День зарплаты.
        /// </summary>
        public List<int> PayDay
        {
            get => _payDay;
            set => SetField(ref _payDay, value);

        }


        #endregion

        public Work(Job job, Company company)
        {
            this.TitleName = job.Title;
            this.CompanyTitleName = company.Title;
            this.SalaryPerDay = SalaryCalculator(job.MinSalaryPerDay, job.MaxSalaryPerDay, company.PayСoefficient);
            this.PayDay = company.PayDay;
        }

        private int SalaryCalculator (int minSalary, int maxSalary, double coefficient)
        {
            double result = new double();
            Random rnd = new Random();
            result = rnd.Next(minSalary, maxSalary);
            result = result * coefficient;
            return Convert.ToInt32(result);
        }

    }

    enum Jobs
    {
        loader,
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
    
    enum Companies
    {
        Minimarket,
        Supermarket,
        Zoo,
        SmallITcompany,
        MediumITcompany,
        BigItCompany
    }

}
