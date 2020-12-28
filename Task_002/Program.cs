using System;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, type first side");
            if (!double.TryParse(Console.ReadLine(), out double firstSide))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.WriteLine("Hi, type second side");
            if (!double.TryParse(Console.ReadLine(), out double secondSide))
            {
                Console.WriteLine("Wrong input");
                return; // Подгледел у Володина :)
            }

            Rectangle rectangle = new Rectangle(firstSide, secondSide);
            Console.WriteLine($"Area is {rectangle.Area}");
            Console.WriteLine($"Perimeter is {rectangle.Perimeter}");

            // Delay
            Console.ReadKey();
        }
    }
}
