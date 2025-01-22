using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommissionSystem
{
    public class CommissionEmpoylee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        private string SSN { get; set; }
        private decimal grossSales { get; set; }
        private decimal empoyleeSalary {  get; set; }
        private decimal commissionRate {  get; set; }

        public CommissionEmpoylee(string firstName, string lastName, string ssn, decimal commissionRate, decimal empoyleeSalary) 
        {
            Firstname = firstName;
            Lastname = lastName;
            SSN = ssn;
            this.commissionRate = commissionRate;
            this.empoyleeSalary = empoyleeSalary;
        }

        public void SetGrossSales(decimal sales)
        {
            if (sales >= 0) { grossSales = sales; }
            else Console.WriteLine("gross sales cannot be a negative.");
        }
        public decimal GetGrossSales() { return grossSales; }

        // will get the earnings from grosssales times the commissionrate and returns the salary of the empolyee plus the commission
        public decimal CalculateEarnings()
        {
            decimal commission = grossSales * commissionRate;
            return empoyleeSalary + commission;
        }

        public decimal EmpoyleeSalary
        {
            get
            {
                return empoyleeSalary;
            }
            set
            {
                if (value < 0)// validation
                {
                    throw new ArgumentException(nameof(value));
                }
                empoyleeSalary = value;
            }
        }
        public decimal CommissionRate
        {
            get { 
                return commissionRate; 
                }
            set
            {
                if (value <= 0) // validation for ocmmission rate
                {
                    throw new ArgumentException("commision rate must be greater than 0.");
                }

                if (value % 1 == 0) // ensure the value has a fractional part
                {
                    throw new ArgumentException("Commission rate must have a fractional part");
                }
                commissionRate = value;
            }
        }
    }
}
