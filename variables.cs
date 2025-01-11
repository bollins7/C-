using System;

namespace Variables
{
class Program
{
    static void Main(string[] args)
    {
        int x; //declaration
        x = 123; //initialization

        int y = 321; //declaration + initialization

        bool alive = false; //true or false
        char symbol = '@';
        String name = "Chris";

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine("Your symbol is: " + symbol);
        Console.WriteLine("Are you alive? " + alive);

        String userName = symbol + name;

        Console.WriteLine("Your username is: " + name);
        }  
    }
}
