//FuelCalculator.cs
//Ann-Marie Bergström 2017-10-26
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    // Fuel calculations
    class FuelCalculator
    {
        //corresponding the input textboxes
        double currReading = 0;
        double prevReading = 0;
        double fuelAmount = 0;
        double unitPrice = 0;

        // Setters
        public void SetCurrentReading(double value)
        {
            currReading = value;
        }
        public void SetPreviousReading(double value)
        {
            prevReading = value;
        }
        public void SetFuelAmount(double value)
        {
                fuelAmount = value;
        }
        public void SetUnitPrice(double value)
        {
                unitPrice = value;
        }

        // Validate that current reading is larger than previous reading.
        public bool ValidateOdometerValues()
        {
            if (currReading > prevReading)
                return true;
            else
                return false;
        }

        // Calculate distance driven.
        private double Distance()
        {
            return (currReading - prevReading);
        }

        // Calculate fuel consumption: liters per kilometer.
        public double CalcFuelLiterPerKm()
        {
            double litPerKm = fuelAmount / Distance();
            return (litPerKm);
        }

        // Calculate fuel consumption: kilometer per liter.
        public double CalcFuelKmPerLiter()
        {
            double kmPerLit = Distance() / fuelAmount;
            return (kmPerLit);
        }

        // Calculate fuel consumption: liter per mile.
        public double CalcFuelLiterPerMile()
        {
            const double kmToMileFactor = 0.621371192;
            double litPerMile = CalcFuelLiterPerKm() / kmToMileFactor;
            return (litPerMile);
        }

        // Calculate fuel consumption: liter per Swedish mil.
        public double CalcFuelLiterPerSweMil()
        {
            double litPerSweMil = CalcFuelLiterPerKm() * 10;
            return (litPerSweMil);
        }

        // Calculate fuel cost per kilometer.
        public double CalcFuelCostPerKm()
        {
            double costPerKm = CalcFuelLiterPerKm() * unitPrice;
            return (costPerKm);
        }
    } // close class
} // close namespace
