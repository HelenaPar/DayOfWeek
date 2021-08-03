using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            char again = 'd';
            while (again == 'd')
            {
                Console.WriteLine("__________________________________________________");
                Console.WriteLine("Enter the shorted name of the day of the week:    ");
                Console.WriteLine("     (mon, tues, wed, thur, fri, sat, sun)");
                Console.WriteLine("_________________________________________________");
                string day = Console.ReadLine();
                string daynow = Convert.ToString(DateTime.Now.DayOfWeek);
                switch (day)
                {
                    case "mon":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Monday");
                        Console.WriteLine(1);
                        Console.WriteLine("Left 6 days before the weekend!");
                        if (daynow == "Monday")
                        {
                            Console.WriteLine("Look at the calendar, today is Monday!");
                        }
                        Console.ResetColor();
                        break;

                    case "tues":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Tuesday");
                        Console.WriteLine(2);
                        Console.WriteLine("Left 5 days before the weekend!");
                        if (daynow == "Tuesday")
                        {
                            Console.WriteLine("Look at the calendar, today is Tuesday!");
                        }
                        Console.ResetColor();
                        break;

                    case "wed":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Wednesday");
                        Console.WriteLine(3);
                        Console.WriteLine("Left 4 days before the weekend!");
                        if (daynow == "Wednesday")
                        {
                            Console.WriteLine("Look at the calendar, today is Wednesday!");
                        }
                        Console.ResetColor();
                        break;

                    case "thur":
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Thursday");
                        Console.WriteLine(4);
                        Console.WriteLine("Left 3 days before the weekend!");
                        if (daynow == "Thursday")
                        {
                            Console.WriteLine("Look at the calendar, today is Thursday!");
                        }
                        Console.ResetColor();
                        break;

                    case "fri":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Friday");
                        Console.WriteLine(5);
                        Console.WriteLine("Left 2 days before the weekend!");
                        if (daynow == "Friday")
                        {
                            Console.WriteLine("Look at the calendar, today is Friday!");
                        }
                        Console.ResetColor();
                        break;

                    case "sat":
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Saturday");
                        Console.WriteLine(6);
                        Console.WriteLine("Today and tomorrow weekend!");
                        if (daynow == "Saturday")
                        {
                            Console.WriteLine("Look at the calendar, today is Saturday!");
                        }
                        Console.ResetColor();
                        break;

                    case "sun":
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Sunday");
                        Console.WriteLine(7);
                        Console.WriteLine("Up to the next weekend there are 6 days!");
                        if (daynow == "Sunday")
                        {
                            Console.WriteLine("Look at the calendar, today is Sunday!");
                        }
                        Console.ResetColor();
                        break;
                    default: Console.WriteLine("Error!"); break;
                }

            }
        }
    }
}
