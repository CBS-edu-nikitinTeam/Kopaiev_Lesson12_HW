using System;

namespace Task_004
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(2, 3, "First");
            Point point2 = new Point(8, 9, "Second");
            Point point3 = new Point(7, 7, "Third");
            Point point4 = new Point(9, 8, "Fourth");
            Figure figOne = new Figure(point1,point2,point3,point4);
            
            figOne.PerimeterCalculator();

            //Delay
            Console.ReadKey();
        }
    }
}
