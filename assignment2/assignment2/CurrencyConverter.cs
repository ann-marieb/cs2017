//CurrencyConverter.cs
//by Ann-Marie Bergström 2017-10-08

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class CurrencyConverter
    {
        //<summary>
        //Sums a number of values and converts to another currency.
        //Alternative 0 results in exit from the menu.
        //</summary>
        private decimal sum; //Result of addition
        private decimal convertedValue; //Converted sum
        private string currencyName;
        private decimal rate;
        public void Start()
        {
            WriteProgramInfo();
            ReadInputandSumNumbers();
            CurrencyConvert();
            WriteResult();
        }//close method Start

        //void method to write info on console
        private void WriteProgramInfo()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\t ++The Currency Converter++");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\t Write 0 to finish!");
            Console.WriteLine("\t Make sure to use correct decimal character.", 3.14);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();//blank line
        }//close method WriteProgramInfo

        private void ReadInputandSumNumbers()
        {
            //local variables
            bool done = false;

            do
            {
                Console.Write("\t Write an amount to sum or zero to finish  ");
                decimal num = decimal.Parse(Console.ReadLine());
                if (num == 0)
                    done = true;
                else
                    sum += num;
            } while (done == false); //close do while loop
            sum = decimal.Round(sum, 2, MidpointRounding.AwayFromZero);
        }//close ReadInputandSumNumbers

        private void CurrencyConvert()
        {
            Console.WriteLine();
            Console.Write("\t Name of the foreign currency: ");
            currencyName = Console.ReadLine(); // read name as text
            Console.WriteLine();
            Console.Write("\t Exchange rate: ");
            rate = decimal.Parse(Console.ReadLine());
            convertedValue = sum / rate; 
        }//close CurrencyConvert

        private void WriteResult()
        {
            //writes result
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\t The sum is \t{0} kr", sum);
            Console.WriteLine();
            Console.WriteLine("\t {0:f2} kr is converted to {1:f2} {2} at the rate of {3} kr/{2}.", 
                              sum, convertedValue, currencyName, rate);
                Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
        }//close method WriteResult

    }//close class
}//close namespace
