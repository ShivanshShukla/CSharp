using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a date");
                string[] date = Console.ReadLine().Split('/');
                int dd = int.Parse(date[0]);
                int mm = int.Parse(date[1]);
                int yy = int.Parse(date[2]);
                switch (mm)
                {
                    case 1:
                        Console.WriteLine("You month name is Janurary and the number of days are 31");
                        break;
                    case 2:
                        if (DateTime.IsLeapYear(yy))
                        {
                            Console.WriteLine("You month name is Feburary and the number of days are 29");
                        }
                        else
                        {
                            Console.WriteLine("You month name is Feburary and the number of days are 28");
                        }
                        break;
                    case 3:
                        Console.WriteLine("You month name is March and the number of days are 31"); break;
                    case 4:
                        Console.WriteLine("You month name is April and the number of days are 3");
                        break;
                    case 5: Console.WriteLine("You month name is May and the number of days are 31"); break;
                    case 6: Console.WriteLine("You month name is June and the number of days are 30"); break;
                    case 7: Console.WriteLine("You month name is July and the number of days are 31"); break;
                    case 8: Console.WriteLine("You month name is August and the number of days are 31"); break;
                    case 9: Console.WriteLine("You month name is September and the number of days are 30"); break;
                    case 10: Console.WriteLine("You month name is October  and the number of days are 31"); break;
                    case 11: Console.WriteLine("You month name is Noverber and the number of days are 30"); break;
                    case 12: Console.WriteLine("You month name is December and the number of days are 31"); break;
                    default:
                        Console.WriteLine("Enter a valid date");
                        break;
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

