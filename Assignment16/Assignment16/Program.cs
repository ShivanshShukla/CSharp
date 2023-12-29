using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to display whether a user entered number is a prime or no.
            //Modify the same program to display first 25 prime numbers using while loop.
            //Also write a same program using for and do-while loops.
            /*Console.WriteLine("Enter a number");
            int num=int.Parse(Console.ReadLine());
            bool flag=true;
            for (int i = 2; i < num; i++) {
                if (num % i == 0)
                {
                    flag = false;
                }
            }
            if(flag)
            {
                Console.WriteLine("your number is prime");
            }
            else
            {
                Console.WriteLine("You number is not a prime");
            }*/

            try
            {
                int count = 0;
                int num = 3;
                while (count != 25)
                {
                    bool flag = true;
                    int i = 2;
                    while (i < num)
                    {
                        if (num % i == 0)
                        {
                            flag = false;
                            break;
                        }
                        i++;
                    }
                    if (flag)
                    {
                        Console.WriteLine(num);
                        count++;
                        num++;
                    }
                    num++;
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
