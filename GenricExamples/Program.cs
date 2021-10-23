using System;

namespace GenricExamples
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the First number:");
            string f =Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string s = Console.ReadLine();

            Console.WriteLine("Enter the third number:");
            string t = Console.ReadLine();

            SimpleClass simple = new SimpleClass(f,s,t);
            simple.findMax();

            
           






        }
    }
}
