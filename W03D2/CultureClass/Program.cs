using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureClass
{
    internal class Program
    {
        static void Main()
        {
            Car c1 = new Car();
            Console.WriteLine(c1.WhatAmI());

            Bus b1 = new Bus();
            Console.WriteLine(b1.WhatAmI());
        }
    }

   
}
