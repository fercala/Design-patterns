using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class CDiv : IOperation
    {
        public double Operation(double a, double b)
        {
            return a / b;
        }
    }
}
