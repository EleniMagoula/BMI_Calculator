
using System;

namespace BMI_Calculator
{
    class Person
    {
        public double Height { get; set; }
        public double Weight { get; set; }

        public Person(double height, double weight)
        {
            Height = HeightInMeters(height);
            Weight = weight;
        }

        private double HeightInMeters(double height)
        {
            return height / 100;
        }
    }
}
