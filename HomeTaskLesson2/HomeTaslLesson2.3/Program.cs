using System;

namespace HomeTaslLesson2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число!");
            int userValue = Convert.ToInt32(Console.ReadLine());

            if (userValue % 2 == 0)
            {
                Console.WriteLine("Введенное число четное!");
            }
            else
            {
                Console.WriteLine("Введенное число НЕ четное!");
            }    
        }
    }
}
