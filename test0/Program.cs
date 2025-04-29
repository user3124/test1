using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Fact(int x)
            {
                if (x <= 1) return 1;
                return x * Fact(x - 1);
            }

            Fact(6);
        }
    }
}
