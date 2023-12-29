using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21
{
    internal class Program
    {
        static float Shape(char ch1, char ch2)
        {
            if (ch1 == 's' || ch1 == 'S')
            {
                Console.WriteLine("Enter the length of side");
                float side = float.Parse(Console.ReadLine());
                if (ch2 == 'a' || ch2 == 'A')
                {
                    return (float)Math.Pow(side, 2);
                }
                else if (ch2 == 'b' || ch2 == 'B')
                {
                    return (float)(4 * side);
                }
                else if (ch2 == 'c' || ch2 == 'C')
                {
                    Console.WriteLine("The area {0}: and the parameter is:{1}", Math.Pow(side, 2), 4 * side);
                    return 0.0f;
                }
                return 0.0f;
            }
            else if (ch1 == 'c' || ch1 == 'C')
            {
                Console.WriteLine("Enter the length of radius");
                float radius = float.Parse(Console.ReadLine());
                if (ch2 == 'a' || ch2 == 'A')
                {
                    return (float)(3.14f * Math.Pow(radius, 2));
                }
                else if (ch2 == 'b' || ch2 == 'B')
                {
                    return (float)(2 * 3.14f * radius);
                }
                else if (ch2 == 'c' || ch2 == 'C')
                {
                    Console.WriteLine("The area {0}: and the parameter is:{1}", (3.14f * Math.Pow(radius, 2)), 2 * 3.14f * radius);
                    return 0.0f;
                }
                return 0.0f;
            }
            else if (ch1 == 'r' || ch1 == 'R')
            {
                Console.WriteLine("Enter the length ");
                float length = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Width ");
                float width = float.Parse(Console.ReadLine());
                if (ch2 == 'a' || ch2 == 'A')
                {
                    return (float)(length * width);
                }
                else if (ch2 == 'b' || ch2 == 'B')
                {
                    return (float)(2 * (length + width));
                }
                else if (ch2 == 'c' || ch2 == 'C')
                {
                    Console.WriteLine("The area {0}: and the parameter is:{1}", length * width, 2 * (length + width));
                    return 0.0f;
                }
                return 0.0f;
            }
            else
            {
                Console.WriteLine("Enter a valid Character");
                return 0.0f;
            }
        }
        static void Main(string[] args)
        {
            /*
                        Write a menu driven program, which allows user to select one of the following shapes – 
                        Square
                        Circle
                        Rectangle 
                        And perform any of the operations on it.
                        Calculate area.
                        Calculate perimeter.
                        Calculate area and perimeter both.
                        Print the result in main.

             */
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("Eneter Shape initials S R C and x to cancle");
                    char ch1 = char.Parse(Console.ReadLine());
                    if (ch1 == 'x' || ch1 == 'X')
                    {
                        flag = false;
                        break;
                    }
                    Console.WriteLine("Eneter Shape initials A B C");
                    char ch2 = char.Parse(Console.ReadLine());
                    float data = Program.Shape(ch1, ch2);
                    if (data != 0.0f)
                    {
                        Console.WriteLine(data);
                    }

                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                throw;
            }
            Console.ReadKey ();

        }
    }
}
