using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Adder
    {
        internal int AddManyNumbers(int[] args)
        {
            int sum = 0;

            for (int i = 0; i < args.Length; i++)
            {
                sum += args[i];
            }
                return sum;
        }
    }
}
