//WorkingSchedule.cs
//by Ann-Marie Bergström 2017-10-08
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class WorkingSchedule
    {
        int choice = -1;

        public void Start()
        {
            Heading();

            while (choice != 0)
            {
                MenuChoice();

                //Create object of class based on user choice
                switch (choice)
                {
                    case 1: //menu choice 1
                    {
                        Schedule(1, 3, 52);
                        break;
                    }//close case 1
                    case 2: //menu choice 2
                    {
                        Schedule(6, 5, 52);
                        break;
                    }//close case 2
                }//close switch(choice)
            }//close while(choice != 0)
        }//close method Start

        private void Heading()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\t ++Working Schedule++");
            Console.WriteLine("\t Select from the menu which type of schedule you would like to see.");
            Console.WriteLine("------------------------------------------------------------");
        }//close method Heading

        private void MenuChoice()
        {
            Console.WriteLine();
            Console.WriteLine("\n\t 1 Show a list of the weekends to work");
            Console.WriteLine("\t 2 Show a list of the nights to work");
            Console.WriteLine("\t 0 Return to Main Menu");
            Console.WriteLine("------------------------------------------------------------\n");
            Console.Write("\t Your choice: ");
            choice = Input.ReadIntegerConsole(); //Read user choice
            Console.WriteLine();
        }//close method MenuChoice

        private void Schedule(int week, int step, int stopweek)
        {
            int col = 0;

            Console.WriteLine("\t Your schedule of the above option is as follows:\n");

            //for since the number of iterations is known 
            for (int index = week ; index <= stopweek; index += step)
            {
                Console.Write("\t\t Week" + index);
                col++;
                if (col == 3)
                {
                    Console.WriteLine();
                    col = 0;
                }//close if
            }//close for  loop
        }//close method Schedule
    }//close class
}// close namespace
