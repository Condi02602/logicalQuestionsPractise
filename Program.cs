using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
               factorial *= i;
            }
            Console.WriteLine("the factorial is: " +  factorial);
            Console.ReadLine();
            Console.ReadKey();*/

            //Star pattern program

            /*
            for (int i = 1; i <= 5; i++)
            {
                for (int y=1; y <= i; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            for (int i = 1; i <= 4; i++)
            {
                for (int y = i; y <= 4; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

            Console.ReadLine();*/

            //Star Pyramid Program


            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 4; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i=2; i<=5; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <=5 ; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <= 5; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 2; i <= 5; i++)
            {
                for (int j = i; j <= 4; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

}
