using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program1
    {

        static void Main()
        {
            Console.WriteLine("Введите координату \"x\" центра круга:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату \"y\" центра круга:");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите радиус круга:");
            double r = double.Parse(Console.ReadLine());

            Round round = new Round(x, y, r);
            
            var i = "";
            do
            {
                Console.WriteLine("Координаты центра круга - ({0},{1})", round.X, round.Y);
                Console.WriteLine("Радиус круга = {0}", round.Radius);
                Console.WriteLine("Площадь круга = {0}", round.Area);
                Console.WriteLine("Длина окружности = {0}", round.Lenght);
                Console.WriteLine("Если вы хотите поменять x - нажмите 1, если y - 2, если радиус - 3, для выхода нажмите 4");

                i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        Console.WriteLine("Введите новое значение для x");
                        round.X = double.Parse(Console.ReadLine());
                        break;
                    case "2":
                        Console.WriteLine("Введите новое значение для y");
                        round.Y = double.Parse(Console.ReadLine());
                        break;
                    case "3":
                        Console.WriteLine("Введите новое значение для радиуса");
                        round.Radius = double.Parse(Console.ReadLine());
                        break;
                }
            }
            while (i != "4");
        }
    }
}
 