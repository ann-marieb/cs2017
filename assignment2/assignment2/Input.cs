//Input.cs
//by Ann-Marie Bergström 2017-10-08
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Input
    {
        //<summary>
        //Reads input from console until a correct integer is received.
        //</summary>
        public static int ReadIntegerConsole()
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
                return input;
            else
                Console.Write("\t Wrong input, please try again: ");
            return ReadIntegerConsole();
        }//close method ReadIntegerConsole
  
        //<summary>
         //Reads input from console until a correct double is received.
         //</summary>
        public static double ReadDoubleConsole()
        {
            double input;
            if (double.TryParse(Console.ReadLine(), out input))
                return input;
            else
                Console.Write("\t Wrong input, please try again: ");
            return ReadDoubleConsole();
        }//close method ReadDoubleConsole

    }//close class
}//close namespace
