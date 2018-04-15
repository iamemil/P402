using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15apr18
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();            
            string inputText = "";
            int selection = 0;
            string inputNum = "";
            double targetNum = 0;

            do
            {
                Console.WriteLine("1. Reqem elave et");
                Console.WriteLine("2. Reqem Sil");
                Console.WriteLine("3. Ortalamani goster");
                Console.WriteLine("4. Eded sayini goster");
                Console.WriteLine("5. Cemi goster");
                Console.WriteLine("5. Ededleri goster");
                Console.WriteLine("0. Cixis");

                Console.WriteLine("Seciminizi edin (1, 2, 3, 4, 5, 6, 0)");
                inputText = Console.ReadLine();
                Console.WriteLine("===================================================================");
                while (!int.TryParse(inputText, out selection))
                {
                    Console.WriteLine("Seciminiz reqem olmalidir (1, 2, 3, 4, 5, 6, 0)");
                    inputText = Console.ReadLine();
                }

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Eded daxil edin (Kesrli ola biler):");

                        inputNum = Console.ReadLine();
                        while (!double.TryParse(inputNum, out targetNum))
                        {
                            Console.WriteLine("Ededi duzgun daxil edin");
                            inputNum = Console.ReadLine();
                        }
                        numbers.AddNumber(targetNum);
                        Console.WriteLine(targetNum + " elave olundu. Movcud ededler "+numbers.ShowNumbers());
                        inputNum = "";
                        targetNum = 0;
                        Console.WriteLine("===================================================================");
                        Console.WriteLine("");
                        break;

                    case 2:
                        Console.WriteLine("Silinecek ededi daxil edin (Kesrli ola biler):");

                        inputNum = Console.ReadLine();
                        while (!double.TryParse(inputNum, out targetNum))
                        {
                            Console.WriteLine("Ededi duzgun daxil edin");
                            inputNum = Console.ReadLine();
                        }
                        if (numbers.DeleteNumber(targetNum))
                        {
                            Console.WriteLine(targetNum + " silindi. Movcud ededler " + numbers.ShowNumbers());
                        }
                        else
                        {
                            Console.WriteLine(targetNum + " yoxdur.");
                        }
                        
                        inputNum = "";
                        targetNum = 0;
                        Console.WriteLine("===================================================================");
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("Ededlerin ortalamasi: "+ numbers.Average());
                        Console.WriteLine("===================================================================");
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.WriteLine("Ededlerin sayi: " + numbers.CountNumbers());
                        Console.WriteLine("===================================================================");
                        Console.WriteLine("");
                        break;
                    case 5:
                        Console.WriteLine("Ededlerin cemi: " + numbers.SumOfNumbers());
                        Console.WriteLine("===================================================================");
                        Console.WriteLine("");
                        break;
                    case 6:
                        Console.WriteLine("Ededler: " + numbers.ShowNumbers());
                        Console.WriteLine("===================================================================");
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Secim 1, 2, 3, 4, 5, 6 ve ya 0 ola biler");
                        Console.WriteLine("===================================================================");
                        break;

                }

            } while (selection != 0);

        }
    }
}
