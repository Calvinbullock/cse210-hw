using System;

namespace Learning04
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create a base "Assignment" object
            Assignment assign1 = new Assignment("James Jimmey", "Algabra");
            Console.WriteLine(assign1.GetSummary());

            // Now create the derived class assignments
            MathAssignment assign2 = new MathAssignment("Foo Bar", "decimals", "4.6", "4-30");
            Console.WriteLine(assign2.GetSummary());
            Console.WriteLine(assign2.GetHomeworkList());

            WritingAssignment assign3 = new WritingAssignment("Jean Grey", "Mutant History", "Mutant Cures Histry");
            Console.WriteLine(assign3.GetSummary());
            Console.WriteLine(assign3.GetWritingInformation());
        }
    }
}