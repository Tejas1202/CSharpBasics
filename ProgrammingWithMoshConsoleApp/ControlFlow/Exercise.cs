using System;
using System.Collections.Generic;

namespace ProgrammingWithMoshConsoleApp.ControlFlow
{
    class Exercise
    {
        #region -> Control flow Exercise 42
        public static void EnterNumber()
        {
            Console.WriteLine("Enter a number between 1 to 10");
            var input = int.Parse(Console.ReadLine());

            if (input >= 1 && input <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public static void Maximum(int a, int b)
        {
            var maximum = a > b ? a : b;
            Console.WriteLine("Maximum number is" + maximum);
        }

        public static void ImageType()
        {
            Console.WriteLine("Enter width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            if (width < height)
            {
                Console.WriteLine("It's a portrait");
            }
            else if (width == height)
            {
                Console.WriteLine("It's a square");
            }
            else
            {
                Console.WriteLine("It's a landscape");
            }
        }

        public static void SpeedLimit()
        {
            Console.WriteLine("Enter the speed limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed of car: ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                const int kmPerDemeritPoint = 5;
                int demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }

        }
        #endregion

        #region ->Control flow Exercise 48

        public void DivisibilityByThree()
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("Total numbers divisible by 3 between 1 to 100 is: " + count);
        }

        public void ContinuousUserInput()
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number(or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);
        }

        public static void ComputeFactorials()
        {
            Console.WriteLine("Enter a number: ");
            var input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            long factorial = number;
            try
            {
                checked
                {
                    while (number > 1)
                    {
                        --number;
                        factorial = factorial * number;
                    }
                }
            }
            catch
            {
                throw new OverflowException("overflow");
            }
            Console.WriteLine("Factorial of {0} is {1}", input, factorial);
        }

        public static void ComputeFactorialsMosh()
        {
            Console.WriteLine("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        public static void GuessTheNumber()
        {
            var random = new Random();
            int randomNumber = random.Next(1, 10);
            Console.WriteLine("Program Check. The secret number is: " + randomNumber);
            GuessTheNumberCompute(randomNumber);
            Console.WriteLine("Ok, so let's try again");
            int secondRandomNumber = random.Next(1, 10);
            GuessTheNumberCompute(secondRandomNumber);
        }

        private static void GuessTheNumberCompute(int randomNumber)
        {
            Console.WriteLine("You'll get four chances to win the game");
            bool ifWon = false;
            int userInput;
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Chance " + i);
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == randomNumber)
                {
                    Console.WriteLine("You won");
                    ifWon = true;
                    break;
                }
            }
            if (!ifWon)
            {
                Console.WriteLine("You lost");
            }
        }

        public static void GuessTheNumberMosh()
        {
            var number = new Random().Next(1, 10);

            Console.WriteLine("Secret is " + number);
            for (var i = 0; i < 4; i++)
            {
                Console.Write("Guess the secret number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }

            Console.WriteLine("You lost!");
        }

        public void MaximumNumber()
        {
            Console.WriteLine("Enter numbers seperated by comma");
            var numbers = Console.ReadLine().Split(',');
            var list = new List<int>();
            foreach (var number in numbers)
                list.Add(int.Parse(number));
            var maximum = list[0];
            foreach (var number in list)
            {
                if (maximum < number)
                    maximum = number;
            }
            Console.WriteLine("The maximum number is " + maximum);
        }

        #endregion
    }
}
