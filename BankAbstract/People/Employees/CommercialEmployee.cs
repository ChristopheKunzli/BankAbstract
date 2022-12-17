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

        public override double? GetSalary() 
        {
            if (turnover == null || fix == null) throw new SalaryInformationMissingException();

            return fix + (turnover / 100);
        }

        public void SetInfoSalary(double turnover, double fix)
        {
            this.turnover = turnover;
            this.fix = fix;
        }
    }
}
