using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Milan Karki";
            string location = "Rexburg, Idaho";

            Console.WriteLine("My name is {0}, I am from {1}.", fullName, location);


            DateTime today = DateTime.Today;
            DateTime christmas = new DateTime(2022, 12, 25);

            Console.WriteLine("Today's date is " + today.ToString("d")); //print the date

            Console.WriteLine("There are {0} days until Christmas.", (christmas - today).Days);


            //Exercise 2.1.1
            double width, height, woodlength, glassArea;
            string widthString, heightString;

            Console.Write("Enter the width of the window: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Enter the height of the window: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodlength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
                woodlength + " feet" );
            Console.WriteLine("The area of the glass is " +
                glassArea + " sqaure metres");


            Console.Write("Press any key to exit.......");
            Console.ReadKey();

        }
    }
}
