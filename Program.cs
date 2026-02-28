using System;

namespace HelloWorld
{

    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine()!;
            
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine()!;
            int age = Convert.ToInt32(ageInput);


            Console.WriteLine("You are " + name + " and your age is " + age);
            
            
        } 
    }
}