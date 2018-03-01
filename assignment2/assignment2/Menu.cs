//Menu.cs
//by Ann-Marie Bergström 2017-10-08

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    //<summary>
    //A menu with alternatives is displayed to the user. Each alternative results in an action.
    //Alternative 0 results in exit from the menu.
    //</summary>
    public class Menu
    {
        public void Start()
        {
            int choice = -1;

            while (choice != 0)
            {
                WriteMenuText(); //Display menu
                choice = Input.ReadIntegerConsole(); //Read user choice

                //Create object of class based on user choice
                switch (choice)
                {
                    case 1: //menu choice 1
                        {
                            //Declare a local reference variable and create an object of WholeNumbersForAdd
                            WholeNumbersForAdd sumObj = new WholeNumbersForAdd();
                            //call the Start method of the object
                            sumObj.Start();
                            break;
                        }//close case 1
                    case 2: //menu choice 2
                        {
                            //Declare a local reference variable and create an object of FloatingPointsNumberWhileAdd
                            FloatingPointsNumbersWhileAdd sumObj = new FloatingPointsNumbersWhileAdd();
                            //call the Start method of the object
                            sumObj.Start();
                            break;
                        }//close case 2
                    case 3: //menu choice 3
                         {
                            //Declare a local reference variable and create an object of CurrencyConverter
                            CurrencyConverter sumObj = new CurrencyConverter();
                            //call the Start method of the object
                            sumObj.Start();
                            break;
                        }//close case 3
                    case 4: //menu choice 4
                         {
                            //Declare a local reference variable and create an object of CurrencyConverter
                            WorkingSchedule sumObj = new WorkingSchedule();
                            //call the Start method of the object
                            sumObj.Start();
                            break;
                         }//close case 4
                    case 5: //menu choice 5
                        {
                            //Declare a local reference variable and create an object of TempConvert
                            TempConvert sumObj = new TempConvert();
                            //call the Start method of the object
                            sumObj.Start();
                            break;
                        }//close case 5
                }//close switch(choice)
            }//close while(choice != 0)
        }//close method Start

        private void WriteMenuText()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\t MAIN MENU");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("\t Whole Numbers with For \t\t : 1");
            Console.WriteLine("\t Floating Point Numbers with While \t : 2");
            Console.WriteLine("\t Currency Converter with Do While \t : 3");
            Console.WriteLine("\t Work Schedule \t\t\t\t : 4");
            Console.WriteLine("\t Temperature Conversion Table \t\t : 5");
            Console.WriteLine("\t Exit the program \t\t\t : 0");
            Console.WriteLine("------------------------------------------------------------");
            Console.Write("\t Your choice: ");
        }//close method WriteMenuText

    }//close class
    }//close namespace
