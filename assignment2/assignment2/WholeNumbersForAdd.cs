//WholeNumbersForAdd.cs
//by Ann-Marie Bergström 2017-10-08
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    //<summary>
    //Sums a number of whole numbers after asking for how many numbers to sum.
    //</summary>
    public class WholeNumbersForAdd
    {
        private int numOfInput; //number of numbers to be added
        private int sum; //result of addition

        public void Start()
        {
            WriteProgramInfo();
            ReadInput();
            SumNumbers();
            WriteResult();
        }//close method Start     

        //Write info on console
        private void WriteProgramInfo()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\t ++Summation of whole numbers++");
            Console.WriteLine("\t   using a for statement");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();//blank line
        }//close method WriteProgramInfo

        //Read input from user
        private void ReadInput()
        {
            Console.Write("\t Number of values to add? ");
            numOfInput = Input.ReadIntegerConsole(); //Read user choice
            Console.WriteLine();//blank line
        }//close method ReadInput

        //Sum numbers
        private void SumNumbers()
        {
            for (int index = 1; index <= numOfInput; index++)
            {
                Console.Write("\t Please give value nr " + index + " (whole number): ");
                sum += Input.ReadIntegerConsole(); // read integer and add to sum
            }//close for loop
        }//close method SumNumbers

        //writes result
        private void WriteResult()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\t The sum is \t{0}", sum);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
        }//close method WriteResult
        }//close class
    }//close namespace
