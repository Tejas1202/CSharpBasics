using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingWithMoshConsoleApp.ArraysAndLists
{
    class Exercise
    {

        public static void GetNumberOfLikes()
        {
            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("Type a name (or hit Enter to quit)");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    break;
                names.Add(input);
            }

            if (names.Count > 2)
                Console.WriteLine(string.Format("{0},{1} and {2} others like your post", names[0], names[1], names.Count));
            else if (names.Count == 2)
                Console.WriteLine(string.Format("{0} and {1} like your post", names[0], names[1]));
            else if (names.Count == 1)
                Console.WriteLine(names[0] + " likes your post");
            else
                Console.WriteLine();
        }

        public static void ReverseName()
        {
            Console.WriteLine("Enter your name: ");
            var input = Console.ReadLine();
            int length = input.Length;
            var nameArray = new char[length];
            for (int i = length; i > 0; i--)
            {
                nameArray[length - i] = input[i - 1];
            }
            var reversedName = new String(nameArray);
            Console.WriteLine("Your reversed name is " + reversedName);
        }

        //Thought that the input should be taken all at once
        public static void UniqueNumbers()
        {
            Console.WriteLine("Enter 5 unique numbers comma seperated");
            var numbers = Console.ReadLine();
            var numbersArray = numbers.Split(',');
            if (numbersArray.Distinct().Count() < numbersArray.Count())
            {
                Console.WriteLine("Please enter 5 unique numbers");
                UniqueNumbers();
            }
            else
            {
                var list = new List<int>();
                foreach (var number in numbersArray)
                    list.Add(int.Parse(number));
                list.Sort();
                foreach (var number in list)
                    Console.WriteLine(number);
            }
        }

        public static void UniqueNumberContinuous()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter a number:");
                var input = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(input))
                {
                    Console.WriteLine("You've entered this number before");
                    continue;
                }
            }
            numbers.Sort();
            foreach (var number in numbers)
                Console.WriteLine(number);
        }

        public static void ContinuousInput()
        {
            var numbers = new List<int>();
            Console.WriteLine("Enter a number or type Quit to exit");
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                    continue;
                }
                else if (input.Equals("Quit"))
                {
                    var distinctNumbers = numbers.Distinct();
                    foreach (var distinctNumber in distinctNumbers)
                        Console.WriteLine(distinctNumber);
                    break;
                }
            }
        }

        public void ContinuosInputMosh()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in uniques)
                Console.WriteLine(number);
        }

        public static void ValidList()
        {
            while (true)
            {
                Console.WriteLine("Enter 5 or more numbers comma seperated");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Empty input not allowed. Please try again");
                    continue;
                }
                else if (input.Contains(","))
                {
                    var numbers = input.Split(',').ToList();
                    if (numbers.Count() < 5)
                    {
                        Console.WriteLine("Please input atleast 5 numbers");
                        continue;
                    }
                    else
                    {
                        var numbersList = new List<int>();
                        numbersList = numbers.ConvertAll(int.Parse);
                        numbersList.Sort();
                        var topThreeNumbers = numbersList.Take(3);
                        foreach (var top in topThreeNumbers)
                            Console.WriteLine(top);
                        break;
                    }
                }
            }
        }

        public static void ValidListWithOutAnyInbuiltFunctions()
        {
            string[] elements;
            while (true)
            {
                Console.WriteLine("Enter 5 numbers comma seperated");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var list = new List<int>();
            foreach (var element in elements)
                list.Add(int.Parse(element));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                var min = list[0];
                foreach (var number in list)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);
                list.Remove(min);
            }

            Console.WriteLine("the smallest three numbers are: ");
            foreach (var smallest in smallests)
                Console.WriteLine(smallest);

        }

    }
}
