//MainForm.cs
//Ann-Marie Bergström 2017-10-26

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class MainForm : Form
    {
        //Declare and create object of the Fuel calculator
        private FuelCalculator fuelCalculatorObject = new FuelCalculator();

        //Declare and create object of the BMI calculator
        private BmiCalculator bmiCalculatorObject = new BmiCalculator();

        //Declare and create object of the BMI calculator
        private BmrCalculator bmrCalculatorObject = new BmrCalculator();

        //Declare name variable and st to empty-
        private string name = String.Empty;

        //Constructor
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        // Initialize the user interface for all calculators. 
        private void InitializeGUI()
        {
            this.Text = "Universal Calculator";
            rbtnMetricUnits.Checked = true; //set radio button Metric units as default
            rbtnFemale.Checked = true; // set radio button Female as default
            rbtnGroup0.Checked = true; // set radio button Sedentary as default
        }

        //This region contains fuel methods.
        #region Fuel
        // Called when Calculate button is clicked for fuel calculations.
        private void BtnCalcFuel_Click(object sender, EventArgs e)
        {
            if (ReadInputFuel()) //if returned true, else wait for new input.
               UpdateGuiFuel();
        }

        // Call all methods which read and validate input values for fuel calculation.
        private bool ReadInputFuel()
        {
            if (ReadInputCurrReading() && ReadInputPrevReading() && ReadInputFuelAmount()
                 && ReadInputUnitPrice()) //if all four inputs return true, return true
                return true;
            else
                return false; // else go back and wait for new input.
        }
 
        // Read and validate input for current reading, give an error message if incorrect.
        private bool ReadInputCurrReading()
        {
            double value = 0;
            if (double.TryParse(txtCurrReading.Text, out value) && (value > 0)) // check if value is correct format and >0
            {
                fuelCalculatorObject.SetCurrentReading(value); //call setter to set value currReading
                return true;
            }
            else
            {
                MessageBox.Show("Please give a valid integer value >0 for current reading", "Error"); //error message if value is incorrect
                return false;
            }
        }
       
        // Read and validate input for previous reading, give an error message if incorrect.
        private bool ReadInputPrevReading()
        {
            double value = 0;
            if (double.TryParse(txtPrevReading.Text, out value) && (value >= 0)) // if value is correct format and >=0
            {
                fuelCalculatorObject.SetPreviousReading(value); //call setter to set value prevReading
                return true;
            }
            else
            {
                MessageBox.Show("Please give a valid integer value >=0 for previous reading", "Error");  //error message if value is incorrect
                return false;
            }
        }
        
        // Read and validate input for fuel amount, give an error message if incorrect.
        private bool ReadInputFuelAmount()
        {
            double value = 0;
            if (double.TryParse(txtFuelAmount.Text, out value) && (value > 0)) // if value is correct format and >0
            {
                fuelCalculatorObject.SetFuelAmount(value); //call setter to set variable fuelAmount
                return true;
            }
            else
            {
                MessageBox.Show("Please give a valid double value > 0 for fuel amount", "Error");  //error message if value is incorrect
                return false;
            }
        }
        
        // Read and validate input for unit price, give an error message if incorrect.
        private bool ReadInputUnitPrice()
        {
            double value = 0;
            if (double.TryParse(txtUnitPrice.Text, out value) && (value >= 0)) // if value is correct format and >=0
            {
                fuelCalculatorObject.SetUnitPrice(value); //call setter to set value unitPrice
                return true;
            }
            else
            {
                MessageBox.Show("Please give a valid integer value >= 0 for unit price", "Error"); //error message if value is incorrect
                return false;
            }
        }

        // Call the validation and if correct, call the calculators and write the return values to the result labels.
        private void UpdateGuiFuel()
        {
            bool ok = fuelCalculatorObject.ValidateOdometerValues(); // check that current reading > previous reading
            if (!ok)
                MessageBox.Show("Please give a current reading > previous reading", "Error"); //error message if current reading <= previous reading
            else
            {
                lblkmPerLit.Text = $"{fuelCalculatorObject.CalcFuelKmPerLiter():f2}"; //write km/l 
                lblLitPerKm.Text = $"{fuelCalculatorObject.CalcFuelLiterPerKm():f2}"; //write l/km
                lblLitPerMile.Text = $"{fuelCalculatorObject.CalcFuelLiterPerMile():f2}"; //write l/mile
                lblLitPerSweMil.Text = $"{fuelCalculatorObject.CalcFuelLiterPerSweMil():f2}"; //write l/Swedish mil
                lblcostPerKm.Text = $"{fuelCalculatorObject.CalcFuelCostPerKm():f2}"; //write cost/km (any currency)
            }
        }
        #endregion Fuel

        // This region contains BMI methods.
        #region BMI
        // Called when radio button checked changes.
        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMetricUnits.Checked == true) //if radio button Metric units is chosen.
            {
                bmiCalculatorObject.SetMetric(true); //call setter to set value metric to true
                lblHeight.Text = "Height (cm)"; //write label text for metric units
                lblWeight.Text = "Weight (kg)"; //write label text for metric units
            }
            else //if radio button Metric units is not chosen which means that radio button US units is chosen.
            {
                bmiCalculatorObject.SetMetric(false); //call setter to set value metric to false
                lblHeight.Text = "Height (inch)"; //write label text for US units
                lblWeight.Text = "Weight (lb)"; //write label text for US units
            }
        }

        // Called when Calculate button is clicked for BMI calculations.
        private void BtnCalcBmi_Click(object sender, EventArgs e)
        {
            if (ReadInputBmi()) //if returned true, else wait for new input.

                UpdateGuiBmi();
        }

        /// Call methods which read and validate input values for BMI calculation.
        private bool ReadInputBmi()
        {
            ReadInputName(); // read name
            if (ReadInputHeight() && ReadInputWeight()) // check if both inputs return true, return true
                return true;
            else // else go back and wait for new input.
                return false;
        }

        // Call the calculators and write the return values to the result labels.
        private void UpdateGuiBmi()
        {
            gbxResultBmi.Text = $"Results for {name}"; // write name as heading of the group box
            lblYourBmi.Text = $"{bmiCalculatorObject.CalcBmi():f1}"; // call calculation method and write result
            lblWeightCategory.Text = $"{bmiCalculatorObject.Category()}"; // call category method and write result
        }
        #endregion BMI

        // This region contains BMR methods.
        #region BMR
        // Called when radio button checked changes.
        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalculatorObject.SetFemale(rbtnFemale.Checked); //call setter to set value female
        }

        private void ActivityLevel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnGroup0.Checked) // if radio button Sedentary is chosen.
                bmrCalculatorObject.SetActivity(0); //call setter to set value activity to 0
            else if (rbtnGroup1.Checked) // if radio button Lightly is chosen.
                bmrCalculatorObject.SetActivity(1); //call setter to set value activity to 1
            else if (rbtnGroup2.Checked) // if radio button Moderately is chosen.
                bmrCalculatorObject.SetActivity(2); //call setter to set value activity to 2
            else if (rbtnGroup3.Checked) // if radio button Very is chosen.
                bmrCalculatorObject.SetActivity(3); //call setter to set value activity to 3
            else // if radio button Extra is chosen.
                bmrCalculatorObject.SetActivity(4); //call setter to set value activity to 4
        }

        // Called when Calculate button is clicked for BMR calculations.
        private void BtnCalcBmr_Click(object sender, EventArgs e)
        {
            if (ReadInputBmr()) //if returned true, else wait for new input.

                UpdateGuiBmr();
        }
       
        /// Call methods which read and validate input values for BMI calculation.
        private bool ReadInputBmr()
        {
            ReadInputName(); // read name
            return (ReadInputHeight() && ReadInputWeight() && ReadInputAge()); // check if all inputs return true, return true
        }

        // Read and validate input for age and give an error message if incorrect.
        private bool ReadInputAge()
        {
            int value;
            if (int.TryParse(txtAge.Text, out value) && (value >= 18) && (value <= 100)) // check if  is correct format and adult age
            {
                bmrCalculatorObject.SetAge(value); // call setter to set value for age.
                return true;
            }
            else
            {
                MessageBox.Show("Please give an age between 18 and 100 ", "Error"); //error message if value is incorrect
                return false;
            }
        }

        // Call the BMR calculator and write the return values to the result label.
        private void UpdateGuiBmr()
        {
            lblBmrResult.Text = bmrCalculatorObject.ResultOutput(name);
        }
        #endregion BMR

        // This region contains methods common to BMI and BMR..
        #region common to BMI and BMR

        // Read input for name, set to NoName if empty.
        private void ReadInputName()
        {
            txtName.Text.Trim(); //Read name and trim empty spaces at beginning and end.
            if (string.IsNullOrEmpty(txtName.Text))
                name = "NoName"; // If no name is given set name to NoName
            else
                name = txtName.Text;
        }

        // Read and validate input for height and gives an error message if incorrect.
        private bool ReadInputHeight()
        {
            double value;

            if (double.TryParse(txtHeight.Text, out value)) // check if value is correct format
            {
                if (rbtnMetricUnits.Checked == true) // if radio button Metric units is chosen
                {
                    if (value >= 130 && value <= 220) // if height is reasonable
                    {
                        bmiCalculatorObject.SetHeight(value/100); // call setter to set value for height in meters.
                        bmrCalculatorObject.SetHeight(value); // call setter to set value for height in cm.
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Please give a height between 130 and 220cm", "Error"); //error message if value is incorrect
                        return false;
                    }
                }
                else
                { 
                    if (value >= 50 && value <= 90) // if height is reasonable
                    {
                        bmiCalculatorObject.SetHeight(value); // call setter to set value for height in inches.
                        bmrCalculatorObject.SetHeight(value * 2.54); // call setter to set value for height in centimeters.
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Please give a height between 50 and 90 inches", "Error"); //error message if value is incorrect
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please give a valid double value", "Error"); //error message if value is incorrect
                return false;
            }
        }

        // Read and validate input for weight and give an error message if incorrect.
        private bool ReadInputWeight()
        {
            double value;
            if (double.TryParse(txtWeight.Text, out value)) // check if value is correct format
            {
                if (rbtnMetricUnits.Checked == true)
                {
                    if (value >= 30 && value <= 500) // if weight is reasonable
                    {
                        bmiCalculatorObject.SetWeight(value); // call setter to set value for weight.
                        bmrCalculatorObject.SetWeight(value); // call setter to set value for weight.
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Please give a weight between 30 and 500 kg", "Error"); //error message if value is incorrect
                        return false;
                    }
                }
                else
                {
                    if (value >= 65 && value <= 1100) // vheck if weight is reasonable
                    {
                        bmiCalculatorObject.SetWeight(value); // call setter to set value for weight.
                        bmrCalculatorObject.SetWeight(value * 0.45359237); // call setter to set value for weight in kg.
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Please give a weight between 65 and 1100 pounds", "Error"); //error message if value is incorrect
                        return false;
                    }

                }
            }
            else
            {
                MessageBox.Show("Please give a valid double value", "Error"); //error message if value is incorrect
                return false;
            }
        }
        #endregion common for BMI and BMR

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void gpxName_Enter(object sender, EventArgs e)
        {

        }
    } //close class
} //close namespace
