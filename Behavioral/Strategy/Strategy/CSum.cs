using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class CSum : IOperation
    {
        public double Operation(double a, double b)
        {
            return a + b;
        }
    }
}
