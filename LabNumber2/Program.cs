using System;
using System.Drawing;

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
            // init
            double userLength;
            double userWidth;
            double userHeight;
            bool userWantsToContinue = false;

            // Main Sequence and Loop 
            PrintWelcomeMessage();
            do
            {
                GetUserDimensions();
                PrintCalculations(
                    CalculateArea(userLength, userWidth), 
                    CalculatePerimeter(userLength, userWidth), 
                    CalculateVolume(userLength, userWidth, userHeight));
                CheckUserWantsToContinue();
            }
            while (userWantsToContinue);

            // Methods
            void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!" + Environment.NewLine);
            }

            void GetUserDimensions()
            {
                Console.Write("Enter Length: ");
                userLength = double.Parse(Console.ReadLine());

                Console.Write("Enter Width: ");
                userWidth = double.Parse(Console.ReadLine());

                Console.Write("Enter Height: ");
                userHeight = double.Parse(Console.ReadLine());
            }

            double CalculateArea(double length, double width)
            {
                return length * width;
            }

            double CalculatePerimeter(double length, double width)
            {
                return length * 2 + width * 2;
            }

            double CalculateVolume(double length, double width, double height)
            {
                return length * width * height;
            }

            void PrintCalculations(double area, double perimeter, double volume)
            {
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);
                Console.Write(Environment.NewLine);
            }

            void CheckUserWantsToContinue()
            {
                Console.WriteLine("Continue? (y/n) ");
                char userInput = Console.ReadKey().KeyChar;

                if (userInput.Equals('y'))
                {
                    userWantsToContinue = true;
                    Console.WriteLine(Environment.NewLine);
                }
                else if (userInput.Equals('n'))
                {
                    userWantsToContinue = false;
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Please enter: y or n ");
                    CheckUserWantsToContinue();
                }
            }
        }
    }
}
