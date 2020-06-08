using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The calculator currently only functions in a metric system (kg and cm).");

            Console.WriteLine("What is your height? (cm)");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your current weight? (kg)");
            double weight = Convert.ToDouble(Console.ReadLine());

            Person person = new Person(height, weight);
            BMI bmi = new BMI(person);
            bmi.Calculate_BMI();


            Console.WriteLine("Your BMI is {0:F1}. You are {1}.", bmi.BodyMassIndex, bmi.Status);
        }
    }
}
