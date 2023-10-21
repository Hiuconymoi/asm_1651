using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Positions
{
    public abstract class PositionWorker
    {
            public string name { get; private set; }

            public PositionWorker(string name)
            {
                this.name = name;
            }
            public abstract double basicSalary();
    }
}
