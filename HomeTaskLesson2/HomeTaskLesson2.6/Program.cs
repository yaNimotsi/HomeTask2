using System;

namespace HomeTaskLesson2._6
{
    class Program
    {
        public enum MasksOffice
        {
            maskAllDay = 0B_1111100,
            maskOffice1 = 0B_1101000,
            maskOffice2 = 0B_0010111,
            maskOffice3 = 0B_1111111
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер офиса (1-3)");
            int numOffice = Convert.ToInt32(Console.ReadLine());

            int maskWorkOffice;

            switch (numOffice)
            {
                case 1:
                    maskWorkOffice = (byte)MasksOffice.maskAllDay & (byte)MasksOffice.maskOffice1;
                    Console.WriteLine($"Флаг работы первого офиса: " + ((byte)maskWorkOffice == (byte)MasksOffice.maskOffice1));
                    break;
                case 2:
                    maskWorkOffice = (byte)MasksOffice.maskAllDay & (byte)MasksOffice.maskOffice2;
                    Console.WriteLine($"Флаг работы первого офиса: " + ((byte)maskWorkOffice == (byte)MasksOffice.maskOffice2));
                    break;
                case 3:
                    maskWorkOffice = (byte)MasksOffice.maskAllDay & (byte)MasksOffice.maskOffice3 ;
                    Console.WriteLine($"Флаг работы первого офиса: " + ((byte)maskWorkOffice == (byte)MasksOffice.maskOffice3));
                    break;
                default:
                    Console.WriteLine("Введенное вами значение не допустимо");
                    break;
            }


            Console.ReadLine();
        }
    }
}
