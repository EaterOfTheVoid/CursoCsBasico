using System;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? Please write it: ");
            string nameUser = Console.ReadLine();

            Console.WriteLine("Welcome: " +  nameUser);
        }
    }
}