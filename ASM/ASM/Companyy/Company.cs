using ASM.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Companyy
{
    public class Company
    {
        public List<Employee> Employees  {get; set; }
        public Company()
        {
            Employees = new List<Employee>();
        }
        public void Add(Employee employee)
        {
            Employees.Add(employee);
        }

    }
}
