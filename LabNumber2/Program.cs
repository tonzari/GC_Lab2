using System;

namespace LabNumber2
{
    class Program
    {
        // Lab 2: Room Calculator
        // Antonio Manzari

        // Task: Calculate the perimeter and area of various classrooms at Grand Circus
        // Assume user will input valid numbers, and in a decimal format.
        static void Main(string[] args)
        {


            // Main Sequence 
            PrintWelcomeMessage();
            Console.WriteLine(CalculateArea(2.5,2));


            void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
                Console.WriteLine("\n"); // Comsemetic padding
            }

            double CalculateArea(double length, double width)
            {
                return length * width;
            }

        }
    }
}
