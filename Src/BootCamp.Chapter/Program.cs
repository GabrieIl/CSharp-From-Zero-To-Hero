using System;


namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            BMIReg();
            BMIReg();
        }

        static void BMIReg()
        {
            Console.Write(" Enter your name: ");
            string name = Console.ReadLine();
            
            Console.Write(" Enter your surename: ");
            string surename = Console.ReadLine();
            
            Console.Write(" Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write(" Enter your weight [kg]: ");
            double weight = double.Parse(Console.ReadLine());
            
            Console.Write(" Enter your height [cm]: ");
            double height = double.Parse(Console.ReadLine());

            double BMI = weight/(Math.Pow(height/100.0, 2));

            string BMIStatus;

            if (BMI <= 18.49)
                BMIStatus = "Under weight";
            else if (BMI >= 18.50 && BMI <= 24.99)
                BMIStatus = "Normal weight";
            else if (BMI >= 25 && BMI <= 29.99)
                BMIStatus = "Overweight";
            else 
                BMIStatus = "Obesity";

            Console.WriteLine($"\n {name} {surename} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
            Console.WriteLine($" Your IBM is {BMI:C2} thats means {BMIStatus}.\n\n");
        }
    }
}
