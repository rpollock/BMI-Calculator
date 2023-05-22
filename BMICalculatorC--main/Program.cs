using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to the BMI Calculator :)");

            double weight = GetWeight();
            double height = GetHeight();

            double BMI = calculateBMI(weight, height);
            Console.WriteLine("Your final BMI is: " + Math.Round(BMI, 2));
        }

        static double GetWeight()
        {
            Console.WriteLine("Enter your weight in pounds: ");
            double weight = Double.Parse(Console.ReadLine());
            return weight;
        }

        static double GetHeight()
        {
            Console.WriteLine("Enter your height in feet and inches (ex. 5'8\"): ");
            String input = Console.ReadLine();
            String[] split = input.Split("'");
            double feet = Double.Parse(split[0]);
            double inches = Double.Parse(split[1].Trim('"'));
            double height = (feet * 12) + inches;
            return height;
        }

        static double calculateBMI(double weight, double height)
        {
            // Convert inches into meters
            double meterHeight = height * 0.0254;
            // Convert our weight into kilograms
            double kilogramWeight = weight * 0.453592;
            double bmi = kilogramWeight / (meterHeight * meterHeight);
            return bmi;
        }
    }
}
