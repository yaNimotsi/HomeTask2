using System;

namespace HomeTaskLesson2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int maskAllDay = 0B_1111100;
           
            int maskOffice1 = 0B_1101000;
            int maskOffice2 = 0B_0010111;
            int maskOffice3 = 0B_1111111;

            int maskWorksOffcie1 = maskOffice1 & maskAllDay;
            int maskWorksOffcie2 = maskOffice2 & maskAllDay;
            int maskWorksOffcie3 = maskOffice3 & maskAllDay;

            Console.WriteLine(maskWorksOffcie1 == maskOffice1);
            Console.WriteLine(maskWorksOffcie2 == maskOffice2);
            Console.WriteLine(maskWorksOffcie3 == maskOffice3);

            Console.ReadLine();
        }
    }
}
