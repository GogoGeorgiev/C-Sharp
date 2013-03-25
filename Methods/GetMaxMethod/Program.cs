/*Write a method GetMax() with two parameters
 * that returns the bigger of two integers.
 * Write a program that reads 3 integers from 
 * the console and prints the biggest of them 
 * using the method GetMax().
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMaxMethod
{
    class Program
    {
       public static int GetMax(int number1, int number2)
        {
           int maxNumber = number1;
           if (number2 > number1)
            {
                maxNumber = number2;
            }
            return maxNumber;
        }

       public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int biggest = GetMax(a, b);
            biggest = GetMax(biggest, c);
            Console.WriteLine("The biggest number is {0}", biggest);
        }
    }
}
