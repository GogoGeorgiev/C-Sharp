using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kvadratno_Uravnenie_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Въведете стойност за а = ");
            double a = Double.Parse(Console.ReadLine());

            Console.Write("Въведете стойност за b = ");
            double b = Double.Parse(Console.ReadLine());

            Console.Write("Въведете стойност за c = ");
            double c = Double.Parse(Console.ReadLine());
            double d = (b * b) - (4 * a * c);
            Console.WriteLine("Дискриминантата е: " + d);



            if (a == 0)
            {
               Console.WriteLine(" Грешка! a = 0, Уравнението не е квадратно!");
               Console.Beep();
            }
            else if (d == 0)
            {
                Console.WriteLine("Дискриминантата има един реален корен: " + (-b + Math.Sqrt(d) / 2 * a));
                
            }
            else if (d > 0)
            {

                Console.WriteLine("Дискриминантата има два реални корена: ");
                Console.WriteLine(" x1 = " + ((-b + Math.Sqrt(d)) / (2 * a)));
                Console.WriteLine(" x2 = " + ((-b - Math.Sqrt(d)) / (2 * a)));
            }
            else
            {
                Console.WriteLine("Дискриминантата няма реални корени!");
            }

            Console.WriteLine("Натиснете бутон за изход!");
            Console.ReadKey();




        }
    }

}