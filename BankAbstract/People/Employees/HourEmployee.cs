using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAbstract
{
    public class HourEmployee : BankEmployee
    {
        private double? salaryPerHour;
        private int? nbHour;
        private int? percentageAddHour;

        public double? SalaryPerHour { get { return salaryPerHour; } }
        public int? NbHour { get { return nbHour; } }
        public int? PercentageAddHour { get { return percentageAddHour; } }

        /// <summary>
        /// Constructor for an hour employee 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="firstName"></param>
        /// <param name="birthDate"></param>
        /// <param name="department"></param>
        public HourEmployee(string name, string firstName, DateTime birthDate, int department) : base(name, firstName, birthDate, department) { }

        /// <summary>
        /// Calculates the salary of an employee paid per hour of work
        /// </summary>
        /// <returns></returns>
        /// <exception cref="SalaryInformationMissingException"></exception>
        public override double? GetSalary()
        {
            if (salaryPerHour == null || nbHour == null || percentageAddHour == null) throw new SalaryInformationMissingException();

            if (nbHour <= 40) return salaryPerHour * nbHour;

            return (40 * salaryPerHour) + ((nbHour - 40) * (salaryPerHour + ( salaryPerHour * percentageAddHour / 100.0))) ;
        }

        /// <summary>
        /// Sets all informations relative to an employee's salary
        /// </summary>
        /// <param name="salaryPerHour"></param>
        /// <param name="nbHour"></param>
        /// <param name="percentageAddHour"></param>
        public void SetInfoSalary(double salaryPerHour, int nbHour, int percentageAddHour)
        {
            this.salaryPerHour = salaryPerHour;
            this.nbHour = nbHour;
            this.percentageAddHour = percentageAddHour;
        }

        /// <summary>
        /// Show a summary and salary of an employee pad hourly
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + $";Type of employee : Hourly; Current week salary: {GetSalary()}";
        }
    }
}
