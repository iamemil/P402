using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Apr18_first
{
    class Program
    {
        static void Main(string[] args)
        {
            byte ExamResult = 91;

            // 0-40 arasi G
            // 41-50 arasi F
            // 51-60 arasi E
            // 61-70 arasi D
            // 71-80 arasi C
            // 81-90 arasi B
            // 91-100 arasi A

            if (ExamResult > 0 && ExamResult <= 40)
            {
                Console.WriteLine("Xal:" + ExamResult + " " + "Qiymet:G");
            }
            else if (ExamResult > 40 && ExamResult <= 50)
            {
                Console.WriteLine("Xal:" + ExamResult + " " + "Qiymet:F");
            }
            else if(ExamResult > 50 && ExamResult <= 60)
            {
                Console.WriteLine("Xal:" + ExamResult + " " + "Qiymet:E");
            }
            //else if (ExamResult > 60 && ExamResult <= 70)
            {
                Console.WriteLine("Xal:" + ExamResult + " " + "Qiymet:D");
            }
            else if (ExamResult > 70 && ExamResult <= 80)
            {
                Console.WriteLine("Xal:" + ExamResult + " " + "Qiymet:C");
            }
            else if (ExamResult > 80 && ExamResult <= 90)
            {
                Console.WriteLine("Xal:" + ExamResult + " " + "Qiymet:B");
            }
            else
            {
                Console.WriteLine("Xal:" + ExamResult + " " + "Qiymet:A");
            }

            Console.ReadLine();
        }
    }
}