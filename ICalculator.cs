using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface ICalculator
    {
        int add(int a, int b);
        int subtract(int a, int b);
        int multiply(int a, int b);
        double divide(int a, int b);
    }
}
