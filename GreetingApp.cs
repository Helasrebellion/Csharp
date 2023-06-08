using System;

namespace GreetingApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Let me greet you!");
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "! Nice to meet you.");
            Console.ReadLine();
        }
    }
}
