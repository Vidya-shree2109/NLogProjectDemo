using System;
namespace NLogDemo
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello World");
            AddNumbers number = new AddNumbers();
            number.Sum(1, 2);
            Console.WriteLine("The sum of two numbers is " + number.Sum(1, 2));
        }
    }
}