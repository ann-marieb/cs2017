//BmrCalculator.cs
//Ann-Marie Bergström 2017-10-26
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class BmrCalculator
    {
        private bool female = true;
        private int activity;
        private int age;
        private double height;
        private double weight;
        private double maintainWeightCalories;

        // Setters
        public void SetFemale(bool value)
        {
            female = value;
        }

        public void SetActivity(int value)
        {
            activity = value;
        }

        public void SetAge(int value)
        {
            age = value;
        }

        public void SetHeight(double value)
        {
            height = value;
        }

        public void SetWeight(double value)
        {
            weight = value;
        }

        // Create the result to be output.
        public string ResultOutput(string name)
        {
            string Text = $"BMR results for {name}".ToUpper();
            Text += "\n";
            Text += "\n";
            Text += BmrRepRow("Your BMR (calories/day)", CalcBmr());
            Text += BmrRepRow("Calories to maintain your weight", CalcCalories());
            Text += BmrRepRow("Calories to lose 0,5 kg per week", CalcCalories() - 500);
            Text += BmrRepRow("Calories to lose 1 kg per week", CalcCalories() - 1000);
            Text += BmrRepRow("Calories to gain 0,5 kg per week", CalcCalories() + 500);
            Text += BmrRepRow("Calories to gain 1 kg per week", CalcCalories() + 1000);
            Text += "\nLosing more than 1000 calories per day is to be avoided.";
            return Text;
        }

        // Calculate BMR
        public double CalcBmr()
        {
            double bmr = (10 * weight) + (6.25 * height) - (5 * age); // weight in kg, height in cm
            if (female == true)
                bmr = bmr - 161;
            else
                bmr = bmr + 5;
            return (bmr);
        }

        //Calculate the calories needed to maintain weight.
        public double CalcCalories()
        {
            switch (activity)
            {
                case 0:
                    maintainWeightCalories = CalcBmr() * 1.2;
                    break;
                case 1:
                    maintainWeightCalories = CalcBmr() * 1.375;
                    break;
                case 2:
                    maintainWeightCalories = CalcBmr() * 1.55;
                    break;
                case 3:
                    maintainWeightCalories = CalcBmr() * 1.725;
                    break;
                default:
                    maintainWeightCalories = CalcBmr() * 1.9;
                    break;
            }
            return (maintainWeightCalories);
        }

        string BmrRepRow(string what, double value)
        {
            string s = $"{what,-40} {value,6:f1}\n";
            return s;
        }
    } // close class
} //close namespace
