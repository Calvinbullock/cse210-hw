using System;

namespace Learning02
{

    class Program
    {
        static void Main(string[] args)
        {

            // 1
            Fraction fraction1 = new Fraction(1);
            Console.WriteLine($"{fraction1.GetFractionString()}");
            Console.WriteLine($"{fraction1.GetDecimalValue()}");
            // 5
            Fraction fraction2 = new Fraction(5);
            Console.WriteLine($"{fraction2.GetFractionString()}");
            Console.WriteLine($"{fraction2.GetDecimalValue()}");
            // 3 / 4
            Fraction fraction3 = new Fraction(3, 4);
            Console.WriteLine($"{fraction3.GetFractionString()}");
            Console.WriteLine($"{fraction3.GetDecimalValue()}");
            // 1 / 3
            Fraction fraction4 = new Fraction(1, 3);
            Console.WriteLine($"{fraction4.GetFractionString()}");
            Console.WriteLine($"{fraction4.GetDecimalValue()}");
        }
    }

}
