using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASM.Levels;
using ASM.Positions;



namespace ASM.Employees
{
    public class Employee
    {
        public PositionWorker position { get; set; }
        public Ilevel level { get; set; }
        public double HourWork { get; set; }
        public double OverTime { get; set; }
        public int Experience { get; set; }
        public Employee(PositionWorker position, Ilevel level, double hourWork, double overTime, int experience)
        {
            this.position = position;
            this.level = level;
            HourWork = hourWork;
            OverTime = overTime;
            Experience = experience;
        }

        public double CalculateSalary()
        {
            return this.HourWork*position.basicSalary()*level.coeFficientSalary();
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
