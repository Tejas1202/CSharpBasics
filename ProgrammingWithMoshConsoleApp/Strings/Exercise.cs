using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingWithMoshConsoleApp.Strings
{
    class Exercise
    {
        public void GetConsecutives()
        {
            Console.WriteLine("Enter few consecutive numbers seperated by hyphen");
            var input = Console.ReadLine().Split('-');

            var numbers = new List<int>();
            foreach (var number in input)
            {
                numbers.Add(Convert.ToInt32(number));
            }

            if (CheckConsecutives(numbers))
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }

        public void GetDuplicates()
        {
            Console.WriteLine("Enter few numbers seperated by hyphen");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                var inputList = input.Split('-');
                if (CheckDuplicates(inputList))
                {
                    Console.WriteLine("Duplicate");
                }
            }
        }

        public void ValidTime()
        {
            Console.WriteLine("Enter time in a valid format");
            string input = Console.ReadLine();

            if (CheckValidTime(input))
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public void MakePascalCaseVariable()
        {
            Console.WriteLine("Enter some words to make a variable name");
            string input = Console.ReadLine();
            var words = input.Split(' ');
            var stringBuilder = new StringBuilder();
            foreach (var word in words)
            {
                stringBuilder.Append(word[0].ToString().ToUpper());
                for (int i = 1; i < word.Length; i++)
                {
                    stringBuilder.Append(word[i].ToString().ToLower());
                }
            }

            Console.WriteLine("PascalCase variable name is: " + stringBuilder);
        }

        public void CountVowels()
        {
            Console.WriteLine("Enter a word");
            string input = Console.ReadLine().ToLower();
            int vowelCount = 0;
            foreach (var character in input)
            {
                switch (character)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowelCount++;
                        break;
                }
            }

            Console.WriteLine("Vowel count in word {0} is {1}", input, vowelCount);
        }

        private bool CheckConsecutives(List<int> numbers)
        {
            bool isConsecutive = false;
            var difference = numbers[0] - numbers[1];
            if (Math.Abs(difference) != 1)
            {
                return isConsecutive;
            }
            else
            {
                int checkCount = numbers.Count - 1;
                for (int i = 0; i < checkCount; i++)
                {
                    if (numbers[i] - numbers[i + 1] != difference)
                    {
                        return isConsecutive;
                    }
                }
            }

            return true;
        }

        private bool CheckDuplicates(string[] inputList)
        {
            bool isDuplicate = false;
            var listLength = inputList.Length;
            if (listLength > 1)
            {
                for (int i = 0; i < listLength; i++)
                {
                    for (int j = i + 1; j < listLength; j++)
                    {
                        if (inputList[i] == inputList[j])
                        {
                            return isDuplicate = true;
                        }
                    }
                }
            }

            return isDuplicate;
        }

        private bool CheckValidTime(string input)
        {
            bool isValid = false;
            if (!string.IsNullOrWhiteSpace(input) && input.Contains(":"))
            {
                var time = input.Split(':');
                var hours = int.Parse(time[0]);
                var minutes = int.Parse(time[1]);

                if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
                {
                    return true;
                }
            }

            return isValid;
        }
    }
}
