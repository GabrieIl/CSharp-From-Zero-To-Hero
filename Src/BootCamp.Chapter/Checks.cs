using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Test class is used to test your implementation.
    /// Each homework will have a set of steps that you will have to do.
    /// You can name your functions however you want, but to validate your solution, place them here.
    /// DO NOT CALL FUNCTIONS FROM TESTS CLASS
    /// DO NOT IMPLEMENT FUNCTIONS IN TESTS CLASS
    /// TESTS CLASS FUNCTIONS SHOULD ALL HAVE 1 LINE OF CODE
    /// </summary>
    public static class Checks
    {
        public static int PromptInt(string message)
        {
            // To do: call your implementation.
            Console.Write($" {message} ");
            return int.Parse(Console.ReadLine());
        }

        public static string PromptString(string message)
        {
            // To do: call your implementation. 
            Console.Write($" {message} ");
            return Console.ReadLine();
        }

        public static float PromptFloat(string message)
        {
            // To do: call your implementation. 
            Console.Write($" {message} ");
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public static float CalculateBmi(float weight, float height)
        {
            // To do: call your implementation. 
            return (float)(weight/(Math.Pow(height, 2)));
        }
        
        public static string VerifyBmiStatus(float BMI)
        {
            // To do: call your implementation. 
            if (BMI <= 18.49)
                return "Under weight";
            else if (BMI >= 18.50 && BMI <= 24.99)
                return "Normal weight";
            else if (BMI >= 25 && BMI <= 29.99)
                return "Overweight";
            else 
                return "Obesity";
        }
    }
}
