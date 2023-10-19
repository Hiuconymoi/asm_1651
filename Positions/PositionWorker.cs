using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Positions
{
    public abstract class PositionWorker
    {
        public String name { get; private set; }

        public PositionWorker(String name)
        {
            this.name= name;
        }
        public abstract double basicSalary();

    }
}
