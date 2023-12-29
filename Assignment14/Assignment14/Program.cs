using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to accept a number from user and find its absolute value. Absolute always returns a positive value.
            try
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Abs(num));
                Console.ReadKey();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                throw;
            }
        }
    }
}
