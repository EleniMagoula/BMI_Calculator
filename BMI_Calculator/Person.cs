
using System;

namespace BMI_Calculator
{
    class Person
    {
        public double Height { get; set; }
        public double Weight { get; set; }

        public Person(double height, double weight)
        {
            Height = height;
            Weight = weight;
        }
    }
}
