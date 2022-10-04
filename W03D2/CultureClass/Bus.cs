using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureClass
{
    internal class Bus
    {
        static void Main()
        {
            Console.WriteLine("THIS IS BUS");
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Decks { get; set; }
        public string WhatAmI()
        {
            return "I am a bus";
        }
    }
}
