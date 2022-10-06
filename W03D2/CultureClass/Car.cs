using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureClass
{
    internal class Car
    {
        static void Main()
        {
            Console.WriteLine("THIS IS CAR");
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string WhatAmI()
        {
            return "I am a car";
        }

    }
}
