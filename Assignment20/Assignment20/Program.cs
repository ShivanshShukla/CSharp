using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int n1 = 0, n2 = 1, n3;
                Console.Write("Enter the number of terms: ");
                int count = int.Parse(Console.ReadLine());

                if (count < 0)
                {
                    throw new ArgumentOutOfRangeException("count", "Number of terms cannot be negative.");
                }

                Console.Write("Fibonacci Series: ");
                Console.Write(n1 + " " + n2);

                for (int i = 2; i < count; ++i)
                {
                    n3 = n1 + n2;
                    Console.Write(" " + n3);
                    n1 = n2;
                    n2 = n3;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadKey();

        }
    }
}
