using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_integers
{
    class Program
    {
        static void Main(string[] args)
        {            
            // Variables
            int currentNumber = 0;
            int oldNumber = 0;
            int iter = 0;

            Console.WriteLine("Enter a maximum of 15 integers between 0 and 100 in rising order (end with 0):");

            do
            {
                // Get input from user
                currentNumber = Convert.ToInt32(Console.ReadLine());

                if (iter < 15 && 0 < currentNumber && currentNumber < 100)
                {
                    if (currentNumber > oldNumber)
                    {
                        iter++;
                        var numberString = Convert.ToString(currentNumber);
                        Console.WriteLine("OK > " + numberString);
                        oldNumber = currentNumber;
                    }
                    else
                        Console.WriteLine("Number needs to be larger than the last one!");
                }
                else if (currentNumber > 99)
                {
                    Console.WriteLine("Number can't be lager than 99!");
                }

            } while (currentNumber != 0);
            Console.WriteLine("Done!");
        }
    }
}
