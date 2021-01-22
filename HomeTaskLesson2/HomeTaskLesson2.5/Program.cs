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

            bool winterFlag = false;

            switch (userMonth)
            {
                case 1:
                case 11:
                case 12:
                    winterFlag = true;
                    break;
            }

            if (winterFlag == true && averegeVal > 0)
                Console.WriteLine("Дождливая зима");
        }
    }
}
