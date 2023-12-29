using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to display ASCII characters in the range (0-255). Pause after displaying every 10 characters.

            try
            {
                for (int i = 0; i <= 255; i++)
                {
                    Console.Write(" {0} {1} ", i, (char)i);
                    if (i % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                }
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
