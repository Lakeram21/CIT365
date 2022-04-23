using System;


namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            //step 2.
            string name = "Lakeram Narine";
            string location = "Rexburg ID";

            //step 3.
            Console.WriteLine($"My name is {name}, I am from {location}");

            //step 4.
            string date = DateTime.Now.ToString("MM-dd-yyyy");
            Console.WriteLine($"The current date is {date}");

            //step 5.

            //calculate days untill christmas
            var date2 = DateTime.Now;
            var date3 = new DateTime(date2.Year, 12, 25);
            var daysUntilChristmas = (date3 - date2).TotalDays;

            Console.WriteLine($"There are days {Math.Ceiling(daysUntilChristmas)} until Christmas!! ");

            //step 6.
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            
            Console.Write("What is the width ?: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("What is the height?: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);


            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine($"The length of the wood is {woodLength} feet");
            Console.WriteLine($"The area of the glass is {glassArea} square metres");

        }
    }
}