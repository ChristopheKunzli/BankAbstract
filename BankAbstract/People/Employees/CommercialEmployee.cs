using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAbstract
{
    public class CommercialEmployee : BankEmployee
    {
        private double? turnover = null;
        private double? fix = null;

        public double? Turnover { get { return turnover; } }
        public double? Fix { get { return fix; } }

        public CommercialEmployee(string name, string firstName, DateTime birthDate, int department) : base(name, firstName, birthDate, department) { }

        /// <summary>
        /// Calculates the salary of an employee paid for each sale they make
        /// </summary>
        /// <returns></returns>
        /// <exception cref="SalaryInformationMissingException"></exception>
        public override double? GetSalary() 
        {
            if (turnover == null || fix == null) throw new SalaryInformationMissingException();

            return fix + (turnover / 100);
        }

        /// <summary>
        /// Sets all information relative to the employee's salary
        /// </summary>
        /// <param name="turnover"></param>
        /// <param name="fix"></param>
        public void SetInfoSalary(double turnover, double fix)
        {
            this.turnover = turnover;
            this.fix = fix;
        }

        /// <summary>
        /// Show a summary and salary of a commercial employee
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + $";Type of employee: Commercial ; Curent week salary: {GetSalary()}";
        }
    }
}
