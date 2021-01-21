using System;

namespace HomeTaskLesson2._1
{
    class Program
    {
        [Flags] //Позволяет вывести навыки студента в виде названия перечислений, а не их значений
        public enum Knowledges
        {
            Database = 0b_000001,
            Algorithms = 0b_000010,
            CSharp = 0b_000100,
            JavaScript = 0b_001000,
            Git = 0b_010000,
            Design = 0b_100000
        }
        static void Main(string[] args)
        {
            Knowledges backendRequirements = Knowledges.Database | Knowledges.Algorithms | Knowledges.CSharp
                | Knowledges.Git;
            Knowledges frontendRequirements = Knowledges.Algorithms | Knowledges.JavaScript | Knowledges.Git;
            Knowledges designRequirements = Knowledges.Design | Knowledges.Git;

            Knowledges allKnowledges = (Knowledges)0b011111;

            Knowledges backenderKnoleges = allKnowledges & backendRequirements;
            Knowledges frontenderKnoleges = allKnowledges & frontendRequirements;
            Knowledges desigerKnoleges = allKnowledges & designRequirements;

            bool isBackender = backendRequirements == backenderKnoleges;
            bool isFrontender = backendRequirements == frontenderKnoleges;
            bool isDesigner = backendRequirements == desigerKnoleges;

            Console.WriteLine($"Знания студента: {allKnowledges}");

            if (isBackender)
            {
                Console.WriteLine("Студент может стать backend-разработчиком");
            }
            if (isFrontender)
            {
                Console.WriteLine("Студент может стать frontend-разработчиком");
            }
            if (isDesigner)
            {
                Console.WriteLine("Студент может стать дизайнером");
            }


            Console.WriteLine("Введите минимальную температуру за сутки");
            double minTemperature = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите максимальную температуру за сутки");
            double maxTemperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Среднесуточная температура: " + (minTemperature + maxTemperature)/2);


            Console.ReadLine();

        }
    }
}
