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

            Console.WriteLine("Enter a maximum of 15 integers in rising order (end with 0):");

            do
            {
                // Get input from user
                currentNumber = Convert.ToInt32(Console.ReadKey());

                if (iter < 15 && 0 < currentNumber && currentNumber < 100)
                {

                }

            } while (currentNumber != 0);

        }
    }
}
