using System;

namespace Tasks
{
    class Program
    {       
        static Triangle GetTriangleFromConsole()
        {
            double a = Program1.GetValue("Введите длину стороны \"а\" треугольника:");
            double b = Program1.GetValue("Введите длину стороны \"b\" треугольника:");
            double c = Program1.GetValue("Введите длину стороны \"c\" треугольника:");

            try
            {
                Triangle triangle = new Triangle(a, b, c);
                return triangle;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Каждая сторона треугольника должна быть меньше суммы двух других его сторон и больше нуля!");
                return GetTriangleFromConsole();
            }
            
        }
     
        static void SetTriangleParametrs(string i, Triangle triangle)
        {
            try
            {
                switch (i)
                {
                    case "1":
                        triangle.A = Program1.GetValue("Введите новое значение для a");
                        break;

                    case "2":
                        triangle.B = Program1.GetValue("Введите новое значение для b");
                        break;

                    case "3":
                        triangle.C = Program1.GetValue("Введите новое значение для c");
                        break;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Каждая сторона треугольника должна быть меньше суммы двух других его сторон и больше нуля!");
                SetTriangleParametrs(i,triangle);
            }
        }

        static void ShowTriangleData(Triangle triangle)
        {
            Console.WriteLine("Длина сторон треугольника - {0}, {1}, {2}", triangle.A, triangle.B, triangle.C);
            Console.WriteLine("Площадь треугольника = {0}", triangle.GetArea());
            Console.WriteLine("Периметр треугольника = {0}", triangle.GetPerimeter());
            Console.WriteLine("Если необходимо изменить сторону \"a\" - нажмите 1, если сторону \"b\" - 2, если \"c\" - 3, для выхода нажмите 4");

        }

        static void Main()
        {
            Triangle triangle = null;

            while (triangle == null)
            {                   
                 triangle = GetTriangleFromConsole();                                   
            }
   
                string i;

                do
                {               
                    ShowTriangleData(triangle);
                    i = Console.ReadLine();
                    SetTriangleParametrs(i, triangle);
                }
                while (i != "4");
            }
        }
}
    
