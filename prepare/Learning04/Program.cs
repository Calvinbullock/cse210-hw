using System;

namespace Learning04
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create a base "Assignment" object
            Assignment a1 = new Assignment("James Jimmey", "Algabra");
            Console.WriteLine(a1.GetSummary());

            // Now create the derived class assignments
            MathAssignment a2 = new MathAssignment("Foo Bar", "decimals", "4.6", "4-30");
            Console.WriteLine(a2.GetSummary());
            Console.WriteLine(a2.GetHomeworkList());

            WritingAssignment a3 = new WritingAssignment("Jean Grey", "Mutant History", "Mutant Cures Histry");
            Console.WriteLine(a3.GetSummary());
            Console.WriteLine(a3.GetWritingInformation());
        }
    }
}