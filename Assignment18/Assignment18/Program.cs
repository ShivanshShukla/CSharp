using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to generate all positive combinations of 1,2,3 using for loop.
            try
            {
                for (int i = 1; i <= 3; i++)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        for (int k = 1; k <= 3; k++)
                        {
                            Console.Write("{0}{1}{2} ", i, j, k);
                        }
                    }
                    Console.WriteLine();
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
