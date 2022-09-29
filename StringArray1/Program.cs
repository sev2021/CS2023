using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArray1
{
    internal class Program
    {
        static void Main()
        {
            string sen = "Mmmm sss aaa www ee ";

            //foreach(string ss in sen.Split(" ")) Console.WriteLine(ss);

            Console.WriteLine(sen.Replace(" ", ""));

        }
    }
}
