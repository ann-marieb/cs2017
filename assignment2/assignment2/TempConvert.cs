//WorkingSchedule.cs
//by Ann-Marie Bergström 2017-10-08
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    //<summary>
    //Provides a conversion table Fahrenheit to Celsius or Celsius to Fahrenheit.
    //</summary>
    class TempConvert
    {
        int choice = -1;
        double convertedTemp;

        public void Start()
        {
            Heading();

            while (choice != 0)
            {
                MenuChoice(); //display menu and read user choice
                WriteTempList(); //calculate and write list

            }//close while loop
        }//close method Start

        private void Heading()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\t ++Temperature Table++");
            Console.WriteLine("\t Select from the menu ");
            Console.WriteLine("------------------------------------------------------------");
        }//close method Heading
        private void MenuChoice()
        {
            //Console.WriteLine();
            Console.WriteLine("\n\t 1 Fahrenheit to Celsius");
            Console.WriteLine("\t 2 Celsius to Fahrenheit");
            Console.WriteLine("\t 0 Return to Main Menu");
            Console.WriteLine("------------------------------------------------------------\n");
            Console.Write("\t Your choice: ");
            choice = Input.ReadIntegerConsole(); //Read user choice
            Console.WriteLine();
        }//close method MenuChoice

        private void WriteTempList()
        {
            Console.WriteLine("\t Temperature Table");
        
            switch (choice)
            {
                case 1:
                {
                    Console.WriteLine("\t Fahrenheit to Celsius");
                    for (double valueToConvert = 0; valueToConvert < 100; valueToConvert += 4)
                    {
                        convertedTemp = FtoC(valueToConvert);
                        Console.WriteLine("\t {0,6:f2} F = \t {1,6:f2} C", valueToConvert, convertedTemp);
                    }//close for
                    break;
                }//close case 1

                case 2:
                {
                    Console.WriteLine("\t Celsius to Fahrenheit");
                    for (double valueToConvert = 0; valueToConvert < 100; valueToConvert += 4)
                    {
                        CtoF(valueToConvert);
                        Console.WriteLine("\t {0,6:f2} C = \t {1,6:f2} F", valueToConvert, convertedTemp);
                    }//close for
                    break;
                }//close case 2
            }//close switch
        }//close method WriteTempList

        private double FtoC(double fahrenheit)
        {
            convertedTemp = 5.0 / 9.0 * (fahrenheit - 32);
                return (convertedTemp);
        }//close FtoC

        private double CtoF(double celsius)
        {
            convertedTemp = 9.0 / 5.0 * celsius + 32.0;
            return (convertedTemp);
        }//close CtoF

    }//close class
}//close namespace
