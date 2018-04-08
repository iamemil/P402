using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Apr18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil edin");

            string input = Console.ReadLine();

            int eded;

            while (!int.TryParse(input, out eded))
            {
                Console.WriteLine("Ededi duzgun daxil edin:");
                input = Console.ReadLine();
            }

            Console.WriteLine(eded+" "+HeddFinder(eded)+" heddlidir ve ededleri ceminin heddleri nisbeti "+EdedDivider(eded)+" dur/dir.");

            
        }
        public static int HeddFinder(int a)
        {
            int length=0;

            while(a >= 1)
            {               
                a = a / 10;
                length +=1;
            }
            return length;
        }

        public static int EdedDivider(int a)
        {
            int length = 0;

            int ededCemi = 0;

            while (a >= 1)
            {
                ededCemi += a % 10;
                a = a / 10;
                length += 1;
            }
            return ededCemi/length;
        }
    }
}
