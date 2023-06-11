using System;
namespace MyFirstProgram;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int x;
        x = 123;
        int y = 321;
        int z = x + y;
        double height = 300.5;
        bool alive = true;
        char symbol = '@';
        String name = "SegunCodes";
        Console.Write(z);
        Console.WriteLine("Your height is "+ height + "cm");
        Console.WriteLine("Are you alive? "+ alive);
        Console.WriteLine("your symbol is "+ symbol);
        Console.WriteLine("My name is "+ name);
        // Console.ReadKey();
    }
}