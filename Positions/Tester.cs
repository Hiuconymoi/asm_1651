﻿using ASM.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Position
{
    public class Tester:PositionWorker
    {
        public Tester(String name) : base(name) { }

        public override double basicSalary()
        {
            return 6.0;
        }
    }
}
