using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boogie
{
    class Problemo
    {
        
        static int x = 0;
        static int y = 0;
        static int z = 0;
        static int b = 0;
        static string end = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Problems are being solved! :)");
            ProblemOne();
            ProblemTwo();
            ProblemThree();

        }

        static void ProblemOne()
        {
            Console.WriteLine("All these numbers are divisible by 3!");
            while (x < 101)
            {
                if (x % 3 == 0)
                {
                    Console.Write(x + ", ");
                }
                x++;
            }
            Console.WriteLine(" ");


        }

        static void ProblemTwo()
        {
            do
            {
                Console.WriteLine("Enter a number or type 'ok' to end this");
                end = Console.ReadLine();
                if (end != "ok")
                {
                    y = Convert.ToInt32(end);
                    z = z + y;

                }

            }
            while (end != "ok");
            Console.WriteLine(z + " was the total!");

        }
        static void ProblemThree()
        {
            Console.WriteLine("Enter a number you want multiplied!");
            end = Console.ReadLine();
            y = Convert.ToInt32(end);
            z = y;

            while (y > 1)
            {
                x = y - 1;
                z = x * z;
                y--;
            }
            Console.WriteLine("Multiplying your number turned it into: " + z);

        }
    }

}
