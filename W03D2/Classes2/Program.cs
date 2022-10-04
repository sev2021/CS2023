// fedora
// https://ask.fedoraproject.org/t/how-to-install-snort-intrusion-prevention/5086/3
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    internal class Program
    {
        static void Main()
        {
            Car car1 = new Car();
            Car car2 = new Car("Honda", "Accord", "red", 1.8, 5, "D20D20", true);

            Car car3;

            Console.WriteLine("\n---  Called car2");
            Console.WriteLine($"Car 2 property:  { car2.Made }.");
            Console.WriteLine($"Car 2 property:  { car2.Model }.");
            Console.WriteLine($"Car 2 property:  { car2.Color }.");
            Console.WriteLine($"Car 2 property:  { car2.EngineSize }.");
            Console.WriteLine($"Car 2 property:  { car2.NoOfGears }.");
            Console.WriteLine($"Car 2 property:  { car2.RegNum }.");

            car1.Made = "BMW";
            car1.Model = "S50";
            car1.Color = "black";
            car1.EngineSize = 2.5;
            car1.NoOfGears = 5;
            car1.RegNum = "D22D22";

            car1.Honk();
            car1.StartEngine();
            car1.StartEngine();

            car1.GearDown();
            car1.GearUp();
            car1.GearUp();
            car1.GearUp();
            car1.GearDown();
            car1.GearDown();

            car1.StopEngine();
            car1.StopEngine();
            car1.StartEngine();
            car1.StartEngine();
        }
    }

    public class Car
    {
        // ////////////////////////////////////  properties / Attributes
        public string Made { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double EngineSize { get; set; }
        public int NoOfGears { get; set; }
        public string RegNum { get; set; }
        public bool IsRunning { get; set; }
        public int CurrentGear { get; set; }


        // /////////////////////////////////////  constructor(s)
        public Car()
        {
            Console.WriteLine($"\n--- Object { this. } made by DEFAULT constructor");
        }        
        
        public Car(string Made, string Model, string Color, double EngineSize, int NoOfGears, string RegNum, bool IsRunning)
        {
            Console.WriteLine($"\n--- Object { this } made bt OVERLOADED constructor");

            this.Made = Made;
            this.Model = Model;
            this.Color = Color;    
            this.EngineSize = EngineSize;
            this.NoOfGears = NoOfGears;
            this.RegNum = RegNum;
            this.IsRunning = IsRunning;

        }

        // ///////////////////////////////////////// behaviours / Methods

        public void Honk()
        {
            Console.WriteLine("CAR DO BEEEEP !!!");
        }

        
        public void StartEngine()
        {
            Console.WriteLine($"\nSTARTING ENGINE ? - { (IsRunning ? "ALREDY RUNNING" : "STARTING") }");
            IsRunning = true;
        }
        

        public void StopEngine()
        {
            Console.WriteLine($"\nSTOPPIONG ENGINE ? - { (IsRunning ? "STOPPING" : "ALREADY STOPPED") }");
            IsRunning = false;
        }


        public void GearUp()
        {
            if (CurrentGear < NoOfGears) CurrentGear++;
            Console.WriteLine($"Current gear: { CurrentGear }");
        }


        public void GearDown()
        {
            if (CurrentGear > 0) CurrentGear--;
            Console.WriteLine($"Current gear: { CurrentGear }");
        }
    }
}
