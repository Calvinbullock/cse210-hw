/*
Calvin Bullock
April 25th
Prep5

This program asks the user to input there name and favrite number.
It will then square the number and print there name along with 
the square of their favorite number.

*/

using System;

class Program
{
    // Takes an int and returns the square.
    public static int NumberSquared(int num) {
        num = num * num;
        return num;
    } 

    // Prints a welcome statment.
    public static void WelcomeMsg() {
        Console.WriteLine("Welcome to the program!");
    }

    // Prompts user for name then returns the name as a string.
    public static string EnterName() {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Prompts the user for a number then returns that number as an int.
    public static int EnterFavNumber() {
        Console.Write("Please enter your favorite number: ");
        string favNumIn = Console.ReadLine();
        int favNum = int.Parse(favNumIn);
        return favNum;
    }

    // takes an int and a string then prints them out as name and square of number.
    public static void PrintResults(string name, int favNum) {
        Console.WriteLine($"{name}, the square of your number is {favNum}"); // 1764    }
    }

    static void Main(string[] args)
    {
        WelcomeMsg();
        string name = EnterName();
        int favNum = EnterFavNumber();
        int favSquar = NumberSquared(favNum);
        PrintResults(name, favSquar);
    }
}