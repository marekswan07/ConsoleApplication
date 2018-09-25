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
            //creating variables
            string name, location;

            //asking for data input
            Console.Write("Please enter your Name: ");
            name = Console.ReadLine();

            Console.Write("Please enter your location: ");
            location = Console.ReadLine();

            //output the processed data using string Interpolation
            Console.WriteLine("My name is {0}", name); // one way, better for multiple values
            Console.WriteLine($"I am from { location }");  //another way better for single value

            //runs the Christmas Calculator
            ChristmasCounter();

            //runs the Chp 2 program
            GlazerCalc();

            //makes it so it doesn't exit
            Console.Write("Press <Enter> to exit... ");
            //shamelessly borrowed off documentation by MircoSoft
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

        static void GlazerCalc()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //Entering Data and parsed into usable format
            Console.Write("Please Enter a Width: ");
            widthString = Console.ReadLine();
            width = Double.Parse(widthString);

            Console.Write("Please Enter a height: ");
            heightString = Console.ReadLine();
            height = Double.Parse(heightString);

            //Processing Data/calculation
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            //Display results
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " Square metres");

        }

        static void ChristmasCounter()
        {
            DateTime currentDate = DateTime.Now;
            DateTime ChristmasDate = new DateTime (2018, 12, 25);

            TimeSpan timeToChristmas = ChristmasDate - currentDate;
            Console.WriteLine($"Total Number of till Christmas: {timeToChristmas.Days}" ); // more string interpolation
           
        }
    }
}
