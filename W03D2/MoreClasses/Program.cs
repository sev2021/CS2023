using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CultureInfo.CurrentCulture = new CultureInfo("en-IE", false);
            Console.OutputEncoding = Encoding.UTF8;
            Fruit myFruit1 = new Fruit();

            myFruit1.Name = "apple";
            myFruit1.Color = "red";
            myFruit1.Shape = "round";
            myFruit1.Weight = 0.2;  
            myFruit1.Price = 1.1;  

            Console.WriteLine(myFruit1.Name);
            Console.WriteLine(myFruit1.Price);

            myFruit1.ShowDetails();
        }
    }

    class Fruit
    {
        // ////////////////////////////// declare properties
        public string Name { get; set; }
        public string Color { get; set; }
        public string Shape { get; set; }
        public double Weight { get; set; }

        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        // constructor(s)


        // methods
        public void ShowDetails()
        {
            Console.WriteLine($"Price for {Name} equals {Price:C}.");
        }


    }
}
