using System;

namespace Tasks
{
   public class Program1
    {
       
        // Метод для получения значения переменной типа double из консоли.
      public static double GetValue(string message)
       {
           double x;
           bool result;
            do
            {
                Console.WriteLine(message);
                result = double.TryParse(Console.ReadLine(), out x);
                if (!result)
                {
                    Console.WriteLine(("Некорректное значение!"));
                }
            }
            while (!result);
           return x;
        }

        // Метод для создания круга через консоль.
        static Round GetRoundFromConsole()
        {

            double x = GetValue("Введите координату х центра круга:");
            

            double y = GetValue("Введите координату y центра круга:");

            double r = GetValue("Введите радиус:");

            try
            {
                Round round = new Round(x, y, r);
                return round;
            }

            catch (ArgumentException)
            {
                Console.WriteLine("Радиус должен быть >= 0!");
                return GetRoundFromConsole();

            }
        }

        // Метод для изменения параметров круга через консоль.
        private static void SetRoundParametrs(string i, Round round)
        {
            
            try
            {
                switch (i)
                {
                    case "1":                       
                        round.X = GetValue("Введите новое значение для x");
                        break;

                    case "2":
                        round.Y = GetValue("Введите новое значение для y");
                        break;

                    case "3":
                        round.Radius = GetValue("Введите новый радиус");
                        break;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Радиус должен быть >=0!");
                SetRoundParametrs(i, round);
            }
        }

        // Метод для вывода данных экземпляра круга.
        static void ShowRoundData(Round round)
        {
            Console.WriteLine("Координаты центра круга - ({0},{1})", round.X, round.Y);
            Console.WriteLine("Радиус круга = {0}", round.Radius);
            Console.WriteLine("Площадь круга = {0}", round.Area);
            Console.WriteLine("Длина окружности = {0}", round.Lenght);
            Console.WriteLine("Если необходимо поменять \"x\" - нажмите 1, если \"y\" - 2, если радиус - 3, для выхода нажмите 4");
        }

        private static void Main()
        {

            Round round = null;
            while (round == null)
            {
                round = GetRoundFromConsole();
            }

            string i;
            do
            {
                ShowRoundData(round);
                i = Console.ReadLine();
                SetRoundParametrs(i, round);

            }
            while (i != "4");
        }
    }
}
 