using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nLove_inclass04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            const int LIMIT = 4;
            int counter = 0;
            string name = "Natasha";

            while (counter < LIMIT)
            {
                Console.WriteLine(name);
                counter++;
            }

            Console.WriteLine();
            counter = 0;

            do
            {
                Console.WriteLine(name);
                counter++;
            } while (counter < LIMIT);

            Console.WriteLine();

            
            for (counter = 0; counter < LIMIT; counter++)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            //the inner loop - goes through rows 1-2-3-4-5 (multiplying by 1st row, then goes through 2 - multiplying by 2nd row...
            //outer loop gives rows 
            for (int i = 1; i <=5; i++)
            {
                //inner loop gives columns
                for (int j = 1; j <=7; j++)
                {
                    Console.Write("{0}\t", i*j);
                }
                Console.Write("\n");
            }

            Console.WriteLine();
            int total = 0;

            for (int y = 0; y < LIMIT; ++y)
            {
                total += y;
                //total=total+y
                Console.WriteLine(total);
            }

            Console.WriteLine();
            total = 0;
            for (int m = 0; m < LIMIT; m++)
            {
                if (m==2)
                {
                    break;// stops all the loop (doesn't do the statements below and doesn't return to the loop
                }
                total += m;
                Console.WriteLine(total);
            }

            Console.WriteLine();
            total = 0;
            for (int n = 0; n < LIMIT; n++)
            {
                //any number if is equal - will be skipped! here output: 0 - 1 - 4
                if (n == 2)
                {
                    continue; // skips the statements below and returns to the loop
                }
                total += n;
                Console.WriteLine(total);
            }

            Console.WriteLine();

            const int MIN = 1;
            const int MAX = 11;
            Random random = new Random();

            int rNumber = random.Next(MIN, MAX);// больше чем MIN и меньше чем MAX - method .Next (between 2 numbers) - generates a random number

            while (true)// while (answer=="yes")
            {
                Console.Write("Enter a number: ");
                int answer = Int32.Parse(Console.ReadLine());

                if (answer < MIN || answer > MAX)
                {
                    Console.WriteLine("Answers must be between {0} and {1}.", MIN, MAX - 1); // random number doesn't consider the last number - 
                    //so if looking for random between 1 and 10 - need to choose MAX=11, and minus 1 in the formula
          
                }
                else if (answer < rNumber)
                {
                    Console.WriteLine("Your answer was too low");
                }
                else if (answer > rNumber)
                {
                    Console.WriteLine("Your answer was too high");
                }
                else
                {
                    Console.WriteLine("Your answer was correct!");
                    break;// break works on while - loop and stops the loop.
                }
                Console.WriteLine("Try again!"); // wouldn't be printed with correct answer- after break!
            }

            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }
    }
}
