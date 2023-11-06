using System;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {//-----------Exercise 1
         //Name: Allan
         //Favorite Color: Orange
         //Favorite Animal: Eagle
         //Favorite Band: Judas Priest
            Console.WriteLine("Hello! What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Cool! What's your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine("");



            Console.WriteLine($"{userName} got kicked out of school. How you say?");
            Console.WriteLine($"It's what happens when you show up to class with your {animal} on a leash and your hair dyed {color}.");
            Console.WriteLine($"If you really want to test the principal's patience, try wearing a {band} t-shirt instead of the school uniform!!!");

            Console.WriteLine("");


            Console.WriteLine("Give me a number to add:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to add:");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is {sum}");

            Console.WriteLine("");

            Console.WriteLine("Give me a number to multiply:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to multiply:");
            int y = int.Parse(Console.ReadLine());

            int product = Multiply(x, y);
            Console.WriteLine($"The product is {product}");

            Console.WriteLine("");

            Console.WriteLine("Give me a number to subtract:");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to subtract:");
            int num4 = int.Parse(Console.ReadLine());

            int difference = Subtract(num3, num4);
            Console.WriteLine($"The difference is {difference}");

            Console.WriteLine("");

            Console.WriteLine("Give me a number to divide:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to divide:");
            int b = int.Parse(Console.ReadLine());

            int quotient = Divide(a, b);
            Console.WriteLine($"The quotient is {quotient}");

            Console.WriteLine("");

            Console.WriteLine("Give me a new number to divide:");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to see if it divides evenly:");
            int b2 = int.Parse(Console.ReadLine());

            int remainder = Modulus(a1, b2);
            Console.WriteLine($"The remainder is {remainder}");


            Console.WriteLine("");


            Console.WriteLine("Now for something whacky! Give me a new number to add:");
            int num1a = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to add:");
            int num2a = int.Parse(Console.ReadLine());

            int sum1a = Sum(num1a, num2a, 2, 4);
            Console.WriteLine($"This sum will be 6 more than you put in--it's now {sum1a}!");

            Console.WriteLine("");


            Console.WriteLine("Now for something whackier! Give me a new number to add:");
            int num1b = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to add:");
            int num2b = int.Parse(Console.ReadLine());

            int sum1b = Sum(num1b, num2b, 2, 4, 6);
            Console.WriteLine($"This sum will be 12 more than you put in--it's now {sum1b}!");

            Console.WriteLine("");


            Console.WriteLine("Now for something a little less whacky. Give me a new number to add:");
            int num1c = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to add:");
            int num2c = int.Parse(Console.ReadLine());

            int sum1c = Sum(num1c, num2c, 1, 1, 1, 1, 1);
            Console.WriteLine($"This sum will only be 5 more than you put in--it's now {sum1c}!");


        }

        public static int Sum(int num1, int num2)

        { //int sum = num1 + num2;

            //return sum;
            return num1 + num2;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Subtract(int num3, int num4)
        {
            return num3 - num4;
        }


        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static int Modulus(int a1, int b2)
        {
            return a1 % b2;
        }


        public static int Sum(params int[] list)

        {

            int sum = 0;

            for (int i = 0; i < list.Length; i++)

            {
                
                sum = sum + list[i];
            }

            return sum;

        }



    }

}