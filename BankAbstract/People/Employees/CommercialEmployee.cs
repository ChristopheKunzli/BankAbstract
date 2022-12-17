using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAbstract
{
    public class CommercialEmployee : BankEmployee
    {
        private double turnover;
        private double fix;

        public double Turnover { get { return turnover; } }
        public double Fix { get { return fix; } }

        public CommercialEmployee(string name, string firstName, DateTime birthDate, int department, double turnover, double fix) : base(name, firstName, birthDate, department) 
        {
            this.turnover = turnover;
            this.fix = fix;
        }

        public override double GetSalary() 
        {
            return fix + (turnover / 100);
        }

        public void SetInfoSalary(double turnover, double fix)
        {
            this.turnover = turnover;
            this.fix = fix;
        }
    }
}
