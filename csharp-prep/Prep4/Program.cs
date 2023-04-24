// using System;
using System.Collections.Generic;


class Program
{

    // This will take a list of ints and return the sum as an int.
    private static int ListSum(List<int> numsList)
    {
        int sum = 0;
        for (int i = 0; i < numsList.Count; i++)
        {
            sum = sum + numsList[i];
        }

        return sum;
    }

    // This will take a list of ints and return the average as a float.
    private static float ListAverage(List<int> numsList)
    {
        float average = 0;
        int sum = ListSum(numsList);
        average = (float)sum / numsList.Count;
        return average;
    }

    // This will take a list of ints and return the largest int.
    private static int ListMaxNum(List<int> numsList)
    {
        int max = 0;
        numsList.Sort();
        max = numsList[numsList.Count - 1];
        return max;
    }

    static void Main(string[] args)
    {
        // Inisalizes numsList.
        List<int> numsList;
        numsList = new List<int>();

        // Insalizes numIn for use outside the scope of the do while loop.
        int numIn;

        // Test case ------------
        numsList.Add(18);
        numsList.Add(36);
        numsList.Add(2);
        numsList.Add(48);
        numsList.Add(6);
        numsList.Add(12);
        numsList.Add(9);
        numsList.Add(0);

        // Loops until the User enters 0.
        // do
        // {
        //     // Takes input from user parses it to a int and adds it to numsList.
        //     Console.Write("Enter number, please: ");
        //     string numInput = Console.ReadLine();
        //     numIn = int.Parse(numInput);
        //     numsList.Add(numIn);
        // } while (numIn != 0);

        // Prints out the sum, avrage and largest int of numsList.
        Console.WriteLine($"The sum is: {ListSum(numsList)}");
        Console.WriteLine($"The average is: {ListAverage(numsList)}");
        Console.WriteLine($"The largest number is:: {ListMaxNum(numsList)}");

    }
}