using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.Write("Введіть число від 0 до 100: ");
            int value = Convert.ToInt32(Console.ReadLine());

            if (value >= 0 && value <= 100)
            {
                if (value >= 90) Console.WriteLine("A");
                else if (value >= 70) Console.WriteLine("B");
                else if (value >= 50) Console.WriteLine("C");
                else Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("Число поза діапазоном!");
            }
            //2
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 0 || age > 100) Console.WriteLine("Помилка");
            else if (age <= 6 || age >= 65) Console.WriteLine("Безкоштовно");
            else if (age <= 12) Console.WriteLine("Дитячий квиток (50 грн)");
            else if (age <= 17) Console.WriteLine("Підлітковий квиток (80 грн)");
            else Console.WriteLine("Дорослий квиток (120 грн)");
            //3
            int m = Convert.ToInt32(Console.ReadLine());

            if (m < 1 || m > 12) Console.WriteLine("Помилка");
            else
            {
                if (m == 12 || m <= 2) Console.Write("Зима, ");
                else if (m <= 5) Console.Write("Весна, ");
                else if (m <= 8) Console.Write("Літо, ");
                else Console.Write("Осінь, ");

                if (m == 2) Console.WriteLine("28/29 днів");
                else if (m == 4 || m == 6 || m == 9 || m == 11) Console.WriteLine("30 днів");
                else Console.WriteLine("31 день");
            }
            
        }
    }
}

