using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0401_082516
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const double HIGH_SCORE = 95.0;         // High Score value
                double test1, test2, test3, average;    // Variables

                // INPUT
                // Get the test scores
                Console.WriteLine("Enter Three Test Scores");

                Console.WriteLine("Test Score #1: ");
                test1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Test Score #2: ");
                test2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Test Score #3: ");
                test3 = double.Parse(Console.ReadLine());

                // PROCESS
                // Calculate the average test score.
                average = (test1 + test2 + test3) / 3.0;

                // OUTPUT
                // Display the average, rounded to 2 decimal places.
                Console.WriteLine("Average " + average.ToString("n1"));
                Console.ReadLine();

                // If the average is a high score, congratulate
                // the user with a message box.
                if (average > HIGH_SCORE)
                {
                    Console.WriteLine("Congratulations! Great job!");
                    Console.ReadLine();
                }

            }
            catch (Exception ex)
            {
                // Display the defalut error message.
                Console.WriteLine(ex.Message);
                Console.ReadLine();

            }
        }
    }
}
