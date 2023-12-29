using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment19
{
    internal class Program
    {   
        static bool Check(int num)
        {
            try
            {
                if (num < 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                throw;
            }
        } 
        static void PrimeNumber(int num)
        {
            try
            {
                if (Check(num))
                {
                    bool flag = true;
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        Console.WriteLine("entered number is prime");
                    }
                    else
                    {
                        Console.WriteLine("Not a prime number");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid number2");
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                throw;
            }

        }
        static void Main(string[] args)
        {
            /*
                Write a function Prime() which checks the user entered number 
                passed to it is a prime number or not. In this function call another 
                function called Check() which returns the status of the number whether
                it is positive or negative and pass it to main function. If the number is negative,
                ask user to re-enter the number or else print the positive number.
             */
            try
            {
                Console.WriteLine("Enter a number to check whether prime or not");
                int num = int.Parse(Console.ReadLine());
                Program.PrimeNumber(num);
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
