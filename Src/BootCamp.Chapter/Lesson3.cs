using System;
using static BootCamp.Chapter.Checks;

namespace BootCamp.Chapter
{
    public static class Lesson3
    {
        public static void Demo()
        {
            string name = PromptString("Enter your name:");
            string surename = PromptString("Enter your surename:");
            int age = PromptInt("Enter your age:");
            float weight = PromptFloat("Enter your weight [kg]:");
            float height = PromptFloat("Enter your height [m]:");

            float BMI = CalculateBmi(weight, height);
            string BMIStatus = VerifyBmiStatus(BMI);
            
            Console.WriteLine($"\n {name} {surename} is {age} years old, his weight is {weight} kg and his height is {height} m.");
            Console.WriteLine($" Your IBM is {BMI:C2} thats means you are {BMIStatus}.\n\n");
        }
    }
}