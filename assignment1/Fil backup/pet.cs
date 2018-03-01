//pet.cs
//by Ann-Marie Bergström 2017-09-17

using System;

namespace PetApplication
{
    public class Pet
    {
        private string name;  // pet’s name
        private int age; // pet’s age
        private bool isFemale; // true if female

        private void  ReadandSavePetData()
        {
            Console.Write("What is the name of your pet? ");
            name = Console.ReadLine(); // read name as text

            Console.Write("What is the age of " +name + "? ");
            age = int.Parse(Console.ReadLine()); // read and convert to integer

            Console.Write("Is your pet a female ? (y/n) ");
            char response = char.Parse(Console.ReadLine()); //read and convert to char
            isFemale = (response == 'y' || response == 'Y');
        }// close method ReadandSavePetData

        private void DisplayPetInfo()
        {
            Console.WriteLine();
            Console.WriteLine ("******************************");
            Console.WriteLine("Name:  " + name + "  Age:  " + age);
            if (isFemale == true)
                Console.WriteLine(name + " is a good girl!");
            else
                Console.WriteLine(name + " is a good boy!");
            Console.WriteLine();
            Console.WriteLine("******************************");
            Console.WriteLine();
        } //close method DisplayPetInfo

        public void Start()
        {
            Console.Clear(); //clear screen
            Console.WriteLine();
            Console.WriteLine("Greetings from a Pet object!");
            Console.WriteLine();

            ReadandSavePetData();
            DisplayPetInfo();

            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        } // close method Start

    } //close class Pet

} //close namespace 