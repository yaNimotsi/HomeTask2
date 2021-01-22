using System;

namespace HomeTaskLesson2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки");
            double minTemperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите максимальную температуру за сутки");
            double maxTemperature = Convert.ToDouble(Console.ReadLine());

            double averegeVal = (minTemperature + maxTemperature) / 2;

            Console.WriteLine($"Среднесуточная температура: {averegeVal}");

            Console.WriteLine("Введите номер текущего месяца");
            int userMonth = Convert.ToInt32(Console.ReadLine());

            switch (userMonth)
            {
                case 1:
                    Console.WriteLine("Текущий месяц - Январь");
                    break;
                case 2:
                    Console.WriteLine("Текущий месяц - Февраль");
                    break;
                case 3:
                    Console.WriteLine("Текущий месяц - Март");
                    break;
                case 4:
                    Console.WriteLine("Текущий месяц - Апрель");
                    break;
                case 5:
                    Console.WriteLine("Текущий месяц - Май");
                    break;
                case 6:
                    Console.WriteLine("Текущий месяц - Июнь");
                    break;
                case 7:
                    Console.WriteLine("Текущий месяц - Июль");
                    break;
                case 8:
                    Console.WriteLine("Текущий месяц - Август");
                    break;
                case 9:
                    Console.WriteLine("Текущий месяц - Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Текущий месяц - Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Текущий месяц - Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Текущий месяц - Декабрь");
                    break;
            }

            if ((userMonth == 1 || userMonth == 11 || userMonth == 12) && (averegeVal > 0))
                Console.WriteLine("Дождливая зима");
        }
    }
}
