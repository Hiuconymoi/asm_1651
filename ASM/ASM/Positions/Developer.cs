using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Positions
{
    public class Developer:PositionWorker
    {
        public Developer(String name) : base(name) { }

        public override double basicSalary()
        {
            return 7.0;
        }
    }
}
