using System;

namespace Task1
{
    class Program
    {       
       
        static Triangle GetTriangleFromConsole()
        {
            Console.WriteLine("Введите длину стороны \"а\" треугольника:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину стороны \"b\" треугольника:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину стороны \"c\" треугольника:");
            double c = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(a, b, c);

            return triangle;
        }


        static void Main()
        {
            Triangle triangle = null;
            try
            {

                while (triangle == null)
                {
                    triangle = GetTriangleFromConsole();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Каждая сторона треугольника должна быть меньше суммы двух других его сторон!");
                GetTriangleFromConsole();
            }
            var i = "";

                do
                {

                    Console.WriteLine("Длина сторон треугольника - {0}, {1}, {2}", triangle.A, triangle.B, triangle.C);
                    Console.WriteLine("Площадь треугольника = {0}", triangle.Area);
                    Console.WriteLine("Периметр треугольника = {0}", triangle.Perimeter);
                    Console.WriteLine("Если вы хотите поменять длину стороны a - нажмите 1, если стороны b - 2, если c - 3, для выхода нажмите 4");

                    i = Console.ReadLine();
                    switch (i)
                    {
                        case "1":
                            Console.WriteLine("Введите новое значение для a");
                            triangle.A = double.Parse(Console.ReadLine());
                            break;
                        case "2":
                            Console.WriteLine("Введите новое значение для b");
                            triangle.B = double.Parse(Console.ReadLine());
                            break;
                        case "3":
                            Console.WriteLine("Введите новое значение для b");
                            triangle.C = double.Parse(Console.ReadLine());
                            break;
                    }


                }
                while (i != "4");
            
            
           
    }
}
    }
