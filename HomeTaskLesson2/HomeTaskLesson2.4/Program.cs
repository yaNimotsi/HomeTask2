using System;

namespace HomeTaskLesson2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            string productName = "Джинсы";
            double price = 4690.00;
            
            int Cash = 5000;
            int change = 310;

            Console.WriteLine("ООО \" ЮНАЙТЕД ТРЕЙДИНГ\"");
            Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ !");
            Console.WriteLine("ЧЕК ПРОДАЖИ");

            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
            
            Console.WriteLine("Дата продажи " + Convert.ToString(today));
            Console.WriteLine();
            Console.Write("Кол-во: 1;  ");
            Console.WriteLine($"Товар:     {productName}");
            Console.WriteLine($"Стоимость _ _ _ _ _ _ _  {Convert.ToString(price)}");
            Console.WriteLine("Продавец:");
            Console.WriteLine($"Итого: _ _ _ _ _ _ _ _ _ {Convert.ToString(price)}");
            Console.WriteLine($"Наличными: _ _ _ _ _ _ _ {Convert.ToString(Cash)}");
            Console.WriteLine($"Сдача: _ _ _ _ _ _ _ _ _ {Convert.ToString(change)}");
        }
    }
}
