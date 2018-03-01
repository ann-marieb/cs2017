//Wine.cs
//by Ann-Marie Bergström 2017-09-17

using System;

namespace WineApplication
{
    public class Wine
    {
        private string name;  // wine’s name
        private int year; // wine’s year
        private bool isRed; // true if red

        private void ReadandSaveWineData()
        {
            Console.Write("Vad heter vinet? ");
            name = Console.ReadLine(); // read name as text

            Console.Write("Vilken årgång har " + name + "? ");
            year = int.Parse(Console.ReadLine()); // read and convert to integer

            Console.Write("Är vinet rött ? (y/n) ");
            char response = char.Parse(Console.ReadLine()); //read and convert to char
            isRed = (response == 'y' || response == 'Y');
        }// close method ReadandSaveWineData

        private void DisplayWineInfo()
        {
            Console.WriteLine();
            Console.WriteLine("*********************************");
            Console.WriteLine();
            Console.Write("Namn:  " + name + "  Årgång:  " + year);
            if (isRed == true)
                Console.WriteLine(" rött");
            else
                Console.WriteLine(" vitt");
            Console.WriteLine();
            Console.WriteLine("*********************************");
            Console.WriteLine();
        } //close method DisplayWineInfo

        public void Start()
        {
            Console.Clear(); //clear screen
            Console.WriteLine();
            Console.WriteLine("Vininformation");
            Console.WriteLine();

            ReadandSaveWineData();
            DisplayWineInfo();

            Console.WriteLine("Tryck Enter för att avsluta!");
            Console.ReadLine();
        } // close method Start

    } //close class Wine

} //close namespace 
