

using System;

namespace Task_004
{
    class Figure
    {
        private Point[] pointList; // Точнее pointArr, ведь это массив, а не список (List).
        private string figureType;

        // Конечно, если значете как пользоваться классов List, то можно было сделать красивее, через "проваливание"
        // конструктора. Но на данном этапе, так тоже не плохо!
        public Figure(Point point1, Point point2, Point point3)
        {
            pointList = new Point[3];
            pointList[0] = point1;
            pointList[1] = point2;
            pointList[2] = point3;
            figureType = "Triangle";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            pointList = new Point[4];
            pointList[0] = point1;
            pointList[1] = point2;
            pointList[2] = point3;
            pointList[3] = point4;
            figureType = "Quadrangle";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            pointList = new Point[5];
            pointList[0] = point1;
            pointList[1] = point2;
            pointList[2] = point3;
            pointList[3] = point4;
            pointList[4] = point5;
            figureType = "Pentagon";
        }

        double LengthSide(Point A, Point B) 
        {
            int coordX = B.FirstValue - A.FirstValue;
            int coordY = B.SecondValue - A.SecondValue;
            double sideLenght = Math.Sqrt(Math.Pow((double)coordX, 2) + Math.Pow((double)coordY, 2));
            return sideLenght;
        }

        public void PerimeterCalculator()
        {
            double sum = default;

            for (int i = 0; i < pointList.Length - 1; i++)
            {
                sum += LengthSide(pointList[i], pointList[i + 1]);
            }

            sum += LengthSide(pointList[pointList.Length - 1], pointList[0]);
            Console.WriteLine($"\nPerimeter of the {figureType} figure equals {sum}.");

        }


    }
}
