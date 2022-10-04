// fedora
// https://ask.fedoraproject.org/t/how-to-install-snort-intrusion-prevention/5086/3
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("jjj");
            Console.WriteLine(myCar.Made);

        }
    }

    public class Car
    {
        // properties / Attributes
        public string Made { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double EngineSize { get; set; }
        public int NoOfGears { get; set; }
        public string RegNum { get; set; }

        // constructor(s)
        public Car()
        {

        }        
        
        public Car(string made)
        {
            Made = made;
        }

        // behaviours / Methods

    }
}
