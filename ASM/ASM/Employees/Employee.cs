using ASM.Experiences;
using ASM.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Employees
{
    public class Employee
    {
        public string Name { get; set; }
        public PositionWorker Position { get; set; }
        public IExperience Level { get; set; }
        public double HourWork { get; set; }
        public double OverTime { get; set; }
        public int Experience { get; set; }

        public Employee() { }
        public Employee(String name,PositionWorker position, IExperience level, double hourWork, double overTime, int experience)
        {
            this.Name = name;
            this.Position = position;
            this.Level = level;
            HourWork = hourWork;
            OverTime = overTime;
            Experience = experience;
        }

        public double CalculateSalary()
        {
            return this.HourWork * Position.basicSalary() * Level.coeFficientSalary();
        }
        public double OvertimeSalary()
        {
            return this.OverTime * 15;
        }
        public double SubtractionSalary()
        {
            double salary = 0;
            if (this.HourWork < 200)
            {
                salary = (200 - this.HourWork) * 2;
            }
            return salary;
        }
    }
}
