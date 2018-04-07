using System;

namespace _7Apr18_first
{
    class Program
    {
        static void Main(string[] args)
        {


            // Exam Result

            // 0-40 arasi G
            // 41-50 arasi F
            // 51-60 arasi E
            // 61-70 arasi D
            // 71-80 arasi C
            // 81-90 arasi B
            // 91-100 arasi A

            //byte ExamResult = 91;

            //if (ExamResult > 0 && ExamResult <= 40)
            //{
            //    Console.WriteLine("Xal:" + ExamResult + " " + "Qiymet:G");
            //}
            //else if (ExamResult > 40 && ExamResult <= 50)
            //{
            //    Console.WriteLine("Xal:" + ExamResult + " " + "Qiymet:F");
            //}
            //else if (ExamResult > 50 && ExamResult <= 60)
            //{
            //    Console.WriteLine("Xal:" + ExamResult + " " + "Qiymet:E");
            //}
            //else if (ExamResult > 60 && ExamResult <= 70)
            //{
            //    Console.WriteLine("Xal:" + ExamResult + " " + "Qiymet:D");
            //}
            //else if (ExamResult > 70 && ExamResult <= 80)
            //{
            //    Console.WriteLine("Xal:" + ExamResult + " " + "Qiymet:C");
            //}
            //else if (ExamResult > 80 && ExamResult <= 90)
            //{
            //    Console.WriteLine("Xal:" + ExamResult + " " + "Qiymet:B");
            //}
            //else
            //{
            //    Console.WriteLine("Xal:" + ExamResult + " " + "Qiymet:A");
            //}


            // 3-e, 7-e ve 21-e bolunenler 

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (((i % 3) == 0) && ((i % 7) == 0))
            //    {
            //        Console.WriteLine(i + " 7 ve 3-e bolunur.");
            //    }
            //    else if ((i % 7) == 0)
            //    {
            //        Console.WriteLine(i + " 7-ye bolunur.");
            //    }
            //    else if ((i % 3) == 0)
            //    {
            //        Console.WriteLine(i + " 3-e bolunur.");
            //    }
            //}

            // Faiz hesablayan

            double convertedPrice = 0;
            double convertedNewPrice = 0;
            double percentage = 0;

            Console.WriteLine("Evvelki qiymeti daxil edin:");
            string price = Console.ReadLine();

            while (!double.TryParse(price, out convertedPrice))
            {
                Console.WriteLine("Evvelki qiymeti duzgun daxil edin:");
                price = Console.ReadLine();
            }

            Console.WriteLine("Yeni qiymeti daxil edin:");
            string newPrice = Console.ReadLine();
            while (!double.TryParse(newPrice, out convertedNewPrice))
            {
                Console.WriteLine("Yeni qiymeti duzgun daxil edin:");
                newPrice = Console.ReadLine();
            }
            
            if (convertedPrice > convertedNewPrice)
            {
                percentage = ((convertedPrice - convertedNewPrice) / convertedPrice) * 100;
                Console.WriteLine("Evvelki qiymet:" + convertedPrice + "\nYeni qiymet:" + convertedNewPrice + "\nDeyishiklik: -" + percentage + "%");
            }
            else if (convertedPrice == convertedNewPrice)
            {
                Console.WriteLine("Deyishiklik yoxdur.");
            }
            else
            {
                percentage = ((convertedNewPrice - convertedPrice) / convertedPrice) * 100;
                Console.WriteLine("Evvelki qiymet:" + convertedPrice + "\nYeni qiymet:" + convertedNewPrice + "\nDeyishiklik: +" + percentage + "%");
            }
            Console.ReadLine();
        }
    }
}