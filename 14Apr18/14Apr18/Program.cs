using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Apr18
{
    class Program
    {
        static void Main(string[] args)
        {
            Car test = new Car(70,18);
            Console.WriteLine(test.Drive(100));            
        }
    }
}
