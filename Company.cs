using ASM.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
    public class Company
    {
        public List<Employee> Employees { get; set; }
        public Company() { Employees = new List<Employee>();}

        public double TotalSalary()
        {
            double totalSalary = 0;
            foreach(var e in Employees)
            {
                totalSalary += e.CalculateSalary();
            }
            return totalSalary;
        }
    }
}
