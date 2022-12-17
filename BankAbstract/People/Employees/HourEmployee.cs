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

        public HourEmployee(string name, string firstName, DateTime birthDate, int department) : base(name, firstName, birthDate, department) { }

        public override double? GetSalary()
        {
            if(salaryPerHour == null || nbHour == null || percentageAddHour == null) throw new SalaryInformationMissingException();

            if (nbHour <= 40) return salaryPerHour * nbHour;

            return (40 * salaryPerHour) + ((nbHour - 40) * (salaryPerHour + ( salaryPerHour * percentageAddHour / 100.0))) ;
        }

        public void SetInfoSalary(double salaryPerHour, int nbHour, int percentageAddHour)
        {
            this.salaryPerHour = salaryPerHour;
            this.nbHour = nbHour;
            this.percentageAddHour = percentageAddHour;
        }
    }
}
