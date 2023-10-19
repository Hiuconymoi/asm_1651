using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Positions
{
    public class BusinessAnalyst:PositionWorker
    {
        public BusinessAnalyst(String name) : base(name) { }

        public override double basicSalary()
        {
            return 5.0;
        }
    }
}
