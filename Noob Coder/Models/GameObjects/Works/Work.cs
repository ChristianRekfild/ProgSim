using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Noob_Coder.Models.Base;
using System.Xml.Linq;
using Noob_Coder.UserInterface;
using System.Runtime;
using System.Reflection;

namespace Noob_Coder.Models 
{
    /// <summary>
    /// Базовый класс модели работы.
    /// </summary>
    internal class Work : ModelBase
    {
        #region Свойства

        private string _jobName;
        /// <summary>
        /// Название должности
        /// </summary>
        public string JobName
        {
            get => _jobName;
            set => SetField(ref _jobName, value);
        }
        /// <summary>
        /// Отображаемое название должности берется из словаря UI
        /// </summary>
        public string Job
        {
            get => UI.GetPropValue(JobName);
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

        /// <summary>
        /// Отображаемое название компании берется из словаря UI
        /// </summary>
        public string Company
        {
            get => UI.GetPropValue(CompanyName);
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
        /// Дени зарплаты.
        /// </summary>
        public List<int> PayDay
        {
            get => _payDay;
            set => SetField(ref _payDay, value);

        }


        #endregion

        public Work()
        {

        }

        //конструктор работы
        public Work(Job job, Company company)
        {
            JobName = job.Name; //название должности
            CompanyName = company.Name; //название компании
            SalaryPerDay = SalaryCalculator(job.MinSalaryPerDay, job.MaxSalaryPerDay, company.PayСoefficient);//зарплата
            PayDay = company.PayDay;//дни зарплаты
        }

        /// <summary>
        /// Расчет зарплаты для конкретной работы
        /// </summary>
        private int SalaryCalculator (int minSalary, int maxSalary, double coefficient)
        {
            //выбор случейного числа между минимальной и максимальной зарплатой на данной должности
            double result = new double();
            Random rnd = new Random();
            result = rnd.Next(minSalary, maxSalary);
            //умножение на зарплатный коэффициент данной компании
            result = result * coefficient;
            //результат в целом числе
            return Convert.ToInt32(result);
        }

   



    }

   
}
