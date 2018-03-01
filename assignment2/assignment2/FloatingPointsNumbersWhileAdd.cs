//FloatingPointsNumbersWhileAdd.cs
//by Ann-Marie Bergström 2017-10-08
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    //<summary>
    //Sums a number of values.
    //Alternative 0 results in exit from the menu.
    //</summary>
    public class FloatingPointsNumbersWhileAdd
    {
        private double sum; //result of addition
        public void Start()
        {
            WriteProgramInfo();
            ReadInputandSumNumbers();
            WriteResult();
        }//close method Start

         //void method to write info on console
        private void WriteProgramInfo()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\t ++Summation of real numbers++");
            Console.WriteLine("\t   using a while statement\n");
            Console.WriteLine("\t Write 0 to finish!");
            Console.WriteLine("\t Make sure to use correct decimal character.", 3.14);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();//blank line
        }//close method WriteProgramInfo

        private void ReadInputandSumNumbers()
        {
            //local variables
            bool done = false;
            
            while (!done)
            {
                Console.Write("\t Write an amount to sum or zero to finish  ");
                double num = Input.ReadDoubleConsole();
                if ((Math.Round(num, 7) == 0.0))
                    done = true;
                else
                    sum += num;
            }//close while loop
        }//close ReadInputandSumNumbers
        private void WriteResult()
        {
            //writes result
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\t The sum is \t{0}", sum);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
        }//close method WriteResult

    }//close class
}//close namespace
