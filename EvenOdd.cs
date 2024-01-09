using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Even odd program

            //Pattern 1

            //int num = 5;
            //Console.WriteLine(num);
            //Console.ReadLine();
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("It is an Even number");
            //}
            //else
            //{
            //    Console.WriteLine("It is an Odd Number");
            //}
            //Console.ReadLine();

            //Pattern 2

            //for(int i = 0; i<=100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i + "It is a even number");
            //    }
            //    else{
            //        Console.WriteLine(i + "It is an Odd number");
            //    }
            //}
            //Console.ReadLine();

            // Pattern 3

            //for(int i =0; i<=100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();


            //Greater than number program

            //Pateern 1

            //int num1 = 3;
            //int num2 = 15;
            //int num3 = 10;

            //if (num1 > num2 && num1>num3)
            //{
            //    Console.WriteLine("num1 is greater than num2 and num3");
            //}
            //else if(num2>num1 && num2>num3)
            //{
            //    Console.WriteLine("Num2 is greater than num1 and num3");
            //}
            //else if(num3>num1 && num3 > num2)
            //{
            //    Console.WriteLine("Num3 is greter than num1 and num2");
            //}
            //Console.ReadLine();

            //Pattern 2

           int num1 = 10;
            int num2 = 30;
            int num3 = 50;

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("num1 is greater than num3");
                }
                else
                {
                    Console.WriteLine("num3 is greater than num1");
                }
            }
            else
            {
                if (num2>num3)
                {
                    Console.WriteLine("num2 is greater than num3");
                }
                else
                {
                    Console.WriteLine("num3 is greater than num2");
                }
            }
            Console.ReadLine();
        }
    }
}
