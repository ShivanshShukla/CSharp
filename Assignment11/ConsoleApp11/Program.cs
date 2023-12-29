using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Write a program to find maximum of 3 numbers using – 
                If – else.
                Conditional operators.

             */
            try
            {
                Console.WriteLine("Enter the value of A");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the value of B");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the value of C");
                int c = int.Parse(Console.ReadLine());
                if (a > b && a > c)
                {
                    Console.WriteLine("A is greater than B and C");
                }
                else if (b > a && b > c)
                {
                    Console.WriteLine("B is greater than A and C");
                }
                else if (c > a && c > b)
                {
                    Console.WriteLine("C is greater than B and A");
                }
                else
                {
                    Console.WriteLine("Enither two or more are same");
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                throw;
            }
            Console.ReadKey();
        }
    }
}
