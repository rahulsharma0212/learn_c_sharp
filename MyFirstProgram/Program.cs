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
            // Console.Write("Hey,");
            // Console.WriteLine("\tI likes\b c# \nso much");

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
            // int x; //declaration
            // x = 25; // initialization
            // int y = 35; // declaration + initialization
            // int z = x + y;
            // int age = 24;
            // double height = 254.8;
            // bool alive = true;
            // char symbol = '@';
            // string name = "Rahul Sharma";
            // Console.WriteLine("Hello " + name);
            // Console.WriteLine("Your age is :: " + age);
            // Console.WriteLine("Your height is :: " + height + " cm");
            // Console.WriteLine("Are you Alive :: " + alive);
            // Console.WriteLine("Your symbol is :: " + symbol);
            // string userName = symbol + name;
            // Console.WriteLine("Your userName is :: " + userName);

            /******************
            (4) constants
            *******************/
            // const double PI = 3.14159;
            // // PI = 420; // Give Errors
            // Console.WriteLine(PI);

            /******************
            (5) type Casting
            *******************/
            // double a = 3.14;
            // int b = Convert.ToInt32(a);
            // int c = 123;
            // double d = Convert.ToDouble(c) + 0.1;
            // string e = Convert.ToString(c);
            // string f = "$";
            // char g = Convert.ToChar(f);
            // string h = "true";
            // bool i = Convert.ToBoolean(h);

            // Console.WriteLine(a.GetType());
            // Console.WriteLine(b.GetType());
            // Console.WriteLine(d.GetType());
            // Console.WriteLine(e.GetType());
            // Console.WriteLine(g.GetType());
            // Console.WriteLine(i.GetType());

            /******************
            (6) user input
            *******************/
            // Console.WriteLine("What's your name?");
            // string Name = Convert.ToString(Console.ReadLine());
            // Console.WriteLine("What's your Age?");
            // int Age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Hello " + Name);
            // Console.WriteLine("You are " + Age + " years old");

            /******************
            (7) airthematic
            *******************/
            // int friendsCount = 5;
            // // friendsCount = friendsCount +2;
            // friendsCount += 2;
            // friendsCount++;
            // // friendsCount = friendsCount - 1;
            // friendsCount -= 1;
            // friendsCount--;

            // Console.WriteLine(friendsCount);
            // double rem = friendsCount % 5;
            // Console.WriteLine(rem);

            /******************
            (8) Math class
            *******************/
            // double x_1 = 3;
            // double ans_power = Math.Pow(x_1, 3);
            // double ans_sqrt = Math.Sqrt(x_1);
            // double ans_abs = Math.Abs(x_1 - 8.1);
            // double ans_round = Math.Round(2.56);
            // double ans_ceil = Math.Ceiling(2.56);
            // double ans_floor = Math.Floor(2.56);
            // double ans_max = Math.Max(12, 13);
            // double ans_min = Math.Min(12, 13);
            // Console.WriteLine("ans_power :: " + ans_power);
            // Console.WriteLine("ans_sqrt :: " + ans_sqrt);
            // Console.WriteLine("ans_abs :: " + ans_abs);
            // Console.WriteLine("ans_round :: " + ans_round);
            // Console.WriteLine("ans_ceil :: " + ans_ceil);
            // Console.WriteLine("ans_floor :: " + ans_floor);
            // Console.WriteLine("ans_max :: " + ans_max);
            // Console.WriteLine("ans_min :: " + ans_min);

            /******************
            (9) Random Number
            *******************/
            // Random random = new Random();
            // int num1 = random.Next(1, 7);
            // double num2 = random.NextDouble();
            // Console.WriteLine(num1);
            // Console.WriteLine(num2);

            /******************
            (10) Hypotenous calculate program
            *******************/
            // Console.WriteLine("Enter side A");
            // double sideA = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Enter side B");
            // double sideB = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("The hypotenuse is :: " + Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2)));
        }
    }
}