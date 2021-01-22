using System;

namespace HomeTaskLesson2._1
{
    class Program
    {       
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите минимальную температуру за сутки");
            double minTemperature = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите максимальную температуру за сутки");
            double maxTemperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Среднесуточная температура: " + (minTemperature + maxTemperature)/2);


            Console.ReadLine();

        }
    }
}
