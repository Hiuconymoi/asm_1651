using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASM.Levels;
using ASM.Position;
using ASM.Positions;
using ASM.Employees;

namespace ASM
{
    internal class Test
    {
        public static void Main(string[] args)
        {

            var intern = new Intern();
            var leader=new Leader();
            var dev = new Developer("Hieu");
            var test=new Tester("Dao");
            var e1 = new Employee(dev, intern, 190, 10, 5);
            var e2 = new Employee(test, leader, 190, 10, 5);
            Company c = new Company();
            c.Employees.Add(e1);
            c.Employees.Add(e2);
            Console.WriteLine(c.TotalSalary());

            Console.WriteLine(e1.CalculateSalary());

            Console.WriteLine(e1.OvertimeSalary());
        }
    }
}
