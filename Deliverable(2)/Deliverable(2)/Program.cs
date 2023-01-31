/*
 Author: Khushi Udupi
Date: 1/26/2023
Description: C# Console application for calculating grades
*/
using System;

namespace Deliverable_2_;
class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter a numeric grade:");

        try
        {
            decimal grade = decimal.Parse(Console.ReadLine());

            string letter;


            if (grade >= 90)
            {
                letter = "A";
                Console.WriteLine("Your exepected letter grade for ISM 4300 is A");

            }
            else if (grade >= 80 && grade < 90)
            {
                letter = "B";
                Console.WriteLine("Your expected letter grade for ISM 4300 is B");
            }

            if (grade >= 70 && grade < 80)
            {
                letter = "C";
                Console.WriteLine("Your expected letter grade for ISM 4300 is C");

            }
            else if (grade >= 60 && grade < 70)
            {
                letter = "D";
                Console.WriteLine("Your expected letter grade for ISM 4300 is D");

            }
            if (grade >=50 && grade < 60)
            {
                letter = "E";
                Console.WriteLine("Your expected letter grade for ISM 4300 is E");
            }
            else if (grade >= 40 && grade <50)
            {
                letter = "F";
                Console.WriteLine("Your expected letter grade for ISM 4300 is F");

            }
        }
        catch
        {
            Console.WriteLine("Enter a numeric value");
        }

    }
}

