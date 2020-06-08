using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class BMI
    {
        public Person Person { get; set; }
        public double BodyMassIndex { get; set; }
        public string Status { get; set; }

        public BMI(Person person)
        {
            Person = person;
        }

        public void Calculate_BMI()
        {
            double height = HeightInMeters(Person.Height);

            height = height * height;

            BodyMassIndex = Person.Weight / height;

            WeightStatus();
        }

        private double HeightInMeters(double height)
        {
            return height / 100;
        }

        private void WeightStatus()
        {
            if (BodyMassIndex >= 18.5 || BodyMassIndex <= 29.9)
            {
                if (BodyMassIndex <= 24.9)
                    Status = "Normal";
                else
                    Status = "Overweight";
            }
            else if (BodyMassIndex > 30.0)
                Status = "Obese";
            else
                Status = "Underweight";
        }
    }
}
