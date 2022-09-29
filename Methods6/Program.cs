using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods6
{
    internal class Program
    {
        static void Main()
        {

            int a = 3;
            int b = 34;
            int c = 355;
            int d = 116;

            decimal e = 3.44m;
            decimal f = 3.44m;

            Console.WriteLine(Add(22, 33, 44));
            Console.WriteLine(Add(3.3m, 5.5m));
        }

        static decimal Add(decimal dec1 = 0, decimal dec2 = 0, int numb1=0, int numb2=0, int numb3=0, int numb4 = 0)
        {    
            return dec1 + dec2 + numb1 + numb2 + numb3 + numb4;
        }
    }
}
