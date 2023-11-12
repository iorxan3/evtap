using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse.Models
{
    internal class Factorial
    {
        public int Number;

        public Factorial(int number)
        {
            Number = number;
        }
        public int Function(int Number)
        {
            int result = 1;
            while (Number > 0)
            {
                result *= Number;
                Number--;
            }
            return result;
        }
    }
}