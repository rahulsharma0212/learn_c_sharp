using System;
using System.Net;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /******************
            TOPIC (1) Output in console
            *******************/
            // Console.Write("Hey,");
            // Console.WriteLine("\tI likes\b c# \nso much");

            /******************
            TOPIC (2) comments in c#
            *******************/
            // this is single line comment
            /*
                this is multi line comment
             */

            /******************
            TOPIC (3) variables
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
            TOPIC (4) constants
            *******************/
            // const double PI = 3.14159;
            // // PI = 420; // Give Errors
            // Console.WriteLine(PI);

            /******************
            TOPIC (5) type Casting
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
            TOPIC (6) user input
            *******************/
            // Console.WriteLine("What's your name?");
            // string Name = Convert.ToString(Console.ReadLine());
            // Console.WriteLine("What's your Age?");
            // int Age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Hello " + Name);
            // Console.WriteLine("You are " + Age + " years old");

            /******************
            TOPIC (7) airthematic
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
            TOPIC (8) Math class
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
            TOPIC (9) Random Number
            *******************/
            // Random random = new Random();
            // int num1 = random.Next(1, 7);
            // double num2 = random.NextDouble();
            // Console.WriteLine(num1);
            // Console.WriteLine(num2);

            /******************
            TOPIC (10) Hypotenous calculate program
            *******************/
            // Console.WriteLine("Enter side A");
            // double sideA = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Enter side B");
            // double sideB = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("The hypotenuse is :: " + Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2)));

            /******************
            TOPIC (11) String methods
            *******************/
            // string full_name = "Rahul Sharma";
            // string phone_number = "123-456-7890";
            // Console.WriteLine(full_name.ToUpper());
            // Console.WriteLine(full_name.ToLower());
            // Console.WriteLine(phone_number.Replace("-", ""));
            // Console.WriteLine(full_name.Insert(0, "Mr. "));
            // Console.WriteLine(full_name.Length);
            // Console.WriteLine(full_name.Substring(0, 5));
            // Console.WriteLine(full_name.Substring(6));

            /******************
            TOPIC (12) If Statement
            *******************/
            // Console.WriteLine("Please enter your age :: ");
            // int i_age = Convert.ToInt32(Console.ReadLine());
            // if (i_age > 100)
            // {
            //     Console.WriteLine("You are too old to signed up!");
            // }
            // else if (i_age > 18)
            // {
            //     Console.WriteLine("You are now signed Up!");
            // }
            // else if (i_age < 0)
            // {
            //     Console.WriteLine("You are not born yet");
            // }
            // else
            // {
            //     Console.WriteLine("You must be at least 18 years old to sign up!");
            // }

            /******************
            TOPIC (13) Switch Statement
            *******************/
            // Console.WriteLine("What day is it today?");
            // string? input = Console.ReadLine();
            // string day = input != null ? input.ToUpper() : "";
            // switch (day)
            // {
            //     case "MONDAY":
            //         Console.WriteLine("It's Monday!");
            //         break;
            //     case "TUESDAY":
            //         Console.WriteLine("It's Tuesday!");
            //         break;
            //     case "WEDNESDAY":
            //         Console.WriteLine("It's Wednesday!");
            //         break;
            //     case "THURSDAY":
            //         Console.WriteLine("It's Thursday!");
            //         break;
            //     case "FRIDAY":
            //         Console.WriteLine("It's Friday!");
            //         break;
            //     case "SATURDAY":
            //         Console.WriteLine("It's Saturday!");
            //         break;
            //     default:
            //         Console.WriteLine(day + " is not a valid day");
            //         break;
            // }

            /******************
            TOPIC (14) logical operator
            *******************/
            // Console.WriteLine("What's the temprature outside: (c) ");
            // double temp = Convert.ToDouble(Console.ReadLine());
            // if (temp >= 10 && temp <= 25)
            // {
            //     Console.WriteLine("It's warm outside!");
            // }
            // else if (temp <= -50 || temp >= 50)
            // {
            //     Console.WriteLine("It's too cold or too hot outside!");
            // }

            /******************
            TOPIC (15) While Loops
            *******************/
            // Console.Write("Enter your name :: ");
            // string? name = Console.ReadLine();
            // while (name == "")
            // {
            //     Console.Write("Enter your name :: ");
            //     name = Console.ReadLine();
            // }
            // Console.WriteLine("Hello " + name);

            /******************
            TOPIC (16) For Loops
            *******************/
            // for (int i = 1; i <= 10; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // for (int i = 10; i > 0; i--)
            // {
            //     Console.WriteLine("New Year comes in " + i);
            // }
            // Console.WriteLine("Happy New Year".ToUpper());

            /******************
            TOPIC (17) nested For Loops
            *******************/
            // Console.Write("Enter the number of rows :: ");
            // int rows = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Enter the number of columns :: ");
            // int columns = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Enter the symbol :: ");
            // string? symbol = Console.ReadLine();

            // for (int i = 0; i < rows; i++)
            // {
            //     for (int j = 0; j < columns; j++)
            //     {
            //         Console.Write(symbol);
            //     }
            //     Console.WriteLine();
            // }

            /******************
            TOPIC (18) number guessing game
            *******************/
            // Random random = new Random();
            // bool playAgain = true;
            // int min = 1, max = 100, guess, number, guesses;
            // string response;

            // while (playAgain)
            // {
            //     guess = 0;
            //     guesses = 0;
            //     response = "";
            //     number = random.Next(min, max + 1);
            //     while (number != guess)
            //     {
            //         Console.WriteLine("Guess a number between " + min + " and " + max);
            //         guess = Convert.ToInt32(Console.ReadLine());
            //         Console.WriteLine("Guess :: " + guess);
            //         if (guess < number)
            //         {
            //             Console.WriteLine(guess + " is too low!");
            //         }
            //         else if (guess > number)
            //         {
            //             Console.WriteLine(guess + " is too high!");
            //         }
            //         guesses++;
            //     }
            //     Console.WriteLine("Number :: " + number);
            //     Console.WriteLine("YOU WIN !!");
            //     Console.WriteLine("Guesses :: " + guesses);

            //     Console.WriteLine("Would you like to play again (Y/N)");
            //     response = Console.ReadLine()!.ToUpper();
            //     if (response == "Y")
            //     {
            //         playAgain = true;
            //     }
            //     else
            //     {
            //         playAgain = false;
            //     }
            // }
            // Console.WriteLine("Thanks for playing! ... I guess");

            /******************
            TOPIC (19) rock paper scissor game
            *******************/
            // Random random = new Random();
            // bool playAgain = true;
            // string player, computer, response;
            // while (playAgain)
            // {
            //     player = "";
            //     computer = "";
            //     response = "";
            //     while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            //     {
            //         Console.Write("Enter ROCK, PAPER, or SCISSORS :: ");
            //         player = Console.ReadLine()!.ToUpper();
            //     }
            //     switch (random.Next(1, 4))
            //     {
            //         case 1:
            //             computer = "ROCK";
            //             break;
            //         case 2:
            //             computer = "PAPER";
            //             break;
            //         case 3:
            //             computer = "SCISSORS";
            //             break;
            //     }
            //     Console.WriteLine("Player :: " + player);
            //     Console.WriteLine("Computer :: " + computer);
            //     switch (player)
            //     {
            //         case "ROCK":
            //             if (computer == "ROCK")
            //             {
            //                 Console.WriteLine("It's a draw!");
            //             }
            //             else if (computer == "PAPER")
            //             {
            //                 Console.WriteLine("You lose!");
            //             }
            //             else
            //             {
            //                 Console.WriteLine("You win!");
            //             }
            //             break;
            //         case "PAPER":
            //             if (computer == "PAPER")
            //             {
            //                 Console.WriteLine("It's a draw!");
            //             }
            //             else if (computer == "SCISSORS")
            //             {
            //                 Console.WriteLine("You lose!");
            //             }
            //             else
            //             {
            //                 Console.WriteLine("You win!");
            //             }
            //             break;
            //         case "SCISSORS":
            //             if (computer == "SCISSORS")
            //             {
            //                 Console.WriteLine("It's a draw!");
            //             }
            //             else if (computer == "ROCK")
            //             {
            //                 Console.WriteLine("You lose!");
            //             }
            //             else
            //             {
            //                 Console.WriteLine("You win!");
            //             }
            //             break;
            //     }
            //     Console.WriteLine("Would you like to play again (Y/N)");
            //     response = Console.ReadLine()!.ToUpper();
            //     if (response == "Y")
            //     {
            //         playAgain = true;
            //     }
            //     else
            //     {
            //         playAgain = false;
            //     }
            // }
            // Console.WriteLine("Thanks for playing! ... I guess");

            /******************
            TOPIC (20) calculator game
            *******************/
            // Console.WriteLine("----------------------");
            // Console.WriteLine("calculator program");
            // Console.WriteLine("----------------------");

            // do
            // {
            //     Console.Write("Enter number 1 :: ");
            //     double num1 = Convert.ToDouble(Console.ReadLine());
            //     Console.Write("Enter number 2 :: ");
            //     double num2 = Convert.ToDouble(Console.ReadLine());

            //     Console.WriteLine("Enter an option :: ");
            //     Console.WriteLine("\t+ (Add)");
            //     Console.WriteLine("\t- (Subtract)");
            //     Console.WriteLine("\t* (multiply)");
            //     Console.WriteLine("\t/ (divide)");

            //     switch (Console.ReadLine())
            //     {
            //         case "+":
            //             Console.WriteLine($"Your result : {num1} + {num2} = {num1 + num2}");
            //             break;
            //         case "-":
            //             Console.WriteLine($"Your result : {num1} - {num2} = {num1 - num2}");
            //             break;
            //         case "*":
            //             Console.WriteLine($"Your result : {num1} * {num2} = {num1 * num2}");
            //             break;
            //         case "/":
            //             Console.WriteLine($"Your result : {num1} / {num2} = {num1 / num2}");
            //             break;
            //         default:
            //             Console.WriteLine("Invalid option");
            //             break;
            //     }
            //     Console.WriteLine("Do you want to continue to use ? (Y/N)");
            // } while (Console.ReadLine()!.ToUpper() == "Y");

            /******************
            TOPIC (21) Arrays
            *******************/
            // string[] cars = { "BMW", "AUDI", "MUSTANG" };
            // string[] cars_2 = new string[3];
            // cars_2[0] = "BMW";
            // cars_2[1] = "TESLA";
            // cars_2[2] = "MERCEDES";
            // int lengthOfArray = cars.Length;
            // Console.WriteLine($"cars[] type => {cars.GetType()}");
            // Console.WriteLine("lengthOfArray :: " + lengthOfArray);
            // cars[1] = "HONDA";
            // for (int i = 0; i < lengthOfArray; i++)
            // {
            //     Console.WriteLine($"cars :: index -> {i} value -> {cars[i]}");
            // }
            // for (int i = 0; i < cars_2.Length; i++)
            // {
            //     Console.WriteLine($"cars_2[{i}] = {cars[i]}");
            // }

            /******************
            TOPIC (22) foreach loop
            *******************/
            // string[] cars = { "BMW", "AUDI", "MUSTANG" };
            // foreach (string car in cars)
            // {
            //     Console.WriteLine(car);
            // }

            /******************
            TOPIC (23) methods
            *******************/
            // string name = "Vikal";
            // int age = 24;
            // singHappyBirthday(name, age);

            /******************
            TOPIC (24) return Keyword
            *******************/
            // double num1 = 2, num2 = 4;
            // double res = Multiply(num1, num2);
            // Console.WriteLine(res);

            /******************
            TOPIC (25) method overloading
            *******************/
            // double num1 = 2, num2 = 4, num3 = 8;
            // double res = Multiply(num1, num2, num3);
            // Console.WriteLine(res);

            /******************
            TOPIC (26) params keyword
            *******************/
            // double total = checkout(2, 8, 1, 1, 56, 65);
            // Console.WriteLine("total price :: " + total);

            /******************
            TOPIC (27) exception handling
            *******************/
            // int x, y;
            // double result;
            // try
            // {
            //     Console.WriteLine("Enter first number :: ");
            //     x = Convert.ToInt32(Console.ReadLine());

            //     Console.WriteLine("Enter second number :: ");
            //     y = Convert.ToInt32(Console.ReadLine());

            //     result = x / y;
            //     Console.WriteLine("result :: " + result);
            // }
            // catch (FormatException e)
            // {
            //     Console.WriteLine("Enter only numbers PLEASE!");
            // }
            // catch (DivideByZeroException e)
            // {
            //     Console.WriteLine("You can't divide by zero!");
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine("Something went wrong!");
            // }
            // finally
            // {
            //     Console.WriteLine("Thanks For Visiting");
            // }

            /******************
            TOPIC (28) conditional operators
            *******************/
            // double temprature = 20;
            // string message;
            // message = (temprature > 15) ? "It's Warm outside" : "It's cold outside";
            // Console.WriteLine(message);

            /******************
            TOPIC (29) string Interpolation
            *******************/
            // string firstName = "Rahul";
            // string lastName = "Sharma";
            // int age = 24;
            // Console.WriteLine($"My name is {firstName} {lastName} and I am {age,10} years old"); // number represents space in front of the string
            // Console.WriteLine($"My name is {firstName} {lastName} and I am {age,-10} years old");

            /******************
            TOPIC (30) multidimensional arrays
            *******************/
            // string[,] parkingLot = {
            //     {"Mustang","F-150","Tesla"},
            //     {"GTR","Mustang","F-150"},
            //     {"Audi","Tesla","F-150"}
            // };
            // // foreach (string cars in parkingLot)
            // // {
            // //     Console.WriteLine(cars);
            // // }
            // for (int i = 0; i < parkingLot.GetLength(0); i++)
            // {
            //     for (int j = 0; j < parkingLot.GetLength(1); j++)
            //     {
            //         Console.Write($"parkingLot[{i}, {j}] = {parkingLot[i, j]} ");
            //     }
            //     Console.WriteLine();
            // }
        }

        static void singHappyBirthday(string birthdayBoy, int yearsOld)
        {
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday dear " + birthdayBoy);
            Console.WriteLine("You are " + yearsOld + " years old");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine();
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }
        static double Multiply(double x, double y, double z)
        {
            return x * y * z;
        }
        static double checkout(params double[] prices)
        {
            double total = 0;
            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }
    }
}