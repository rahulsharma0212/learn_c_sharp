using System;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /******************
            (1) Output in console
            *******************/
            Console.Write("Hey,");
            Console.WriteLine("\tI likes\b c# \nso much");

            /******************
            (2) comments in c#
            *******************/
            // this is single line comment
            /*
                this is multi line comment
             */

            /******************
            (3) variables
            *******************/
            int x; //declaration
            x = 25; // initialization
            int y = 35; // declaration + initialization
            int z = x + y;
            int age = 24;
            double height = 254.8;
            bool alive = true;
            char symbol = '@';
            string name = "Rahul Sharma";
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is :: " + age);
            Console.WriteLine("Your height is :: " + height + " cm");
            Console.WriteLine("Are you Alive :: " + alive);
            Console.WriteLine("Your symbol is :: " + symbol);
            string userName = symbol + name;
            Console.WriteLine("Your userName is :: " + userName);

        }
    }
}