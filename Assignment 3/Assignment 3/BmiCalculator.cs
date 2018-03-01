//BmiCalculator.cs
//Ann-Marie Bergström 2017-10-26
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    // BMI calculations
    class BmiCalculator
    {
        private bool metric = true;
        private double height;
        private double weight;

        // Setters
        public void SetMetric(bool value)
        {
            metric = value;
        }
        public void SetHeight (double value)
        {
            height = value;
        }

        public void SetWeight(double value)
        {
            weight = value;
        }

        // Calculate BMI
        public double CalcBmi()
        {
            if (metric == true)
            {
                double yourBmi = weight / ((height) * (height)); //weight in kg, height in meters
                return (yourBmi);
            }
            else
            {
                double yourBmi = 703.0 * weight / (height * height); //weight in pounds, height in inches
                return (yourBmi);
            }
        }

        // Body fat category
        public string Category()
        {
            double bmi = CalcBmi();
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi <= 24.9)
                return "Normal weight";
            else if (bmi <= 29.9)
                return "Overweight (pre-obesity)";
            else if (bmi <= 34.9)
                return "Obesity class I";
            else if (bmi <= 39.9)
                return "Obesity class II";
            else
                return "Obesity class III";
        }
    } //close class
} // close namespace
