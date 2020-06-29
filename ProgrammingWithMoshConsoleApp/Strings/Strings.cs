using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProgrammingWithMoshConsoleApp.Strings
{
    class Strings
    {
        public static void StringsBasics(string firstName, string lastName)
        {
            Console.WriteLine(string.Format("{0} {1}", firstName, lastName));

            var numbers = new int[] { 1, 2, 3 };
            string no = string.Join(",", numbers);

            char c = no[1];
            //no[1] = 'm'; //won't compile as string is immutable

            string path = "C:\\Program Files\\Microsoft";
            string verbatimString = @"C:\Program Files\Microsoft"; //Verbatim strings
            Console.WriteLine(path + " " + verbatimString);
            path = "abc" + path; //path is concatenated with abc but it's stored in a different memory location

            firstName = string.Concat(firstName, path);
            StringBuilder sb = new StringBuilder(firstName);
            sb.Append(path);

            string s1 = "Geeks";
            Concat1(s1); // s1 is not changed 
            Console.WriteLine("Using String Class: " + s1);

            StringBuilder s2 = new StringBuilder("Geeks");
            Concat2(s2); // s2 is changed 
            Console.WriteLine("Using StringBuilder Class: " + s2);
        }

        public static void StringsBasicsPartTwo()
        {
            var fullName = "Steve Smith ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("Trim: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: {0}, LastName: {1}", firstName, lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: {0}, LastName: {1}", names[0], names[1]);

            Console.WriteLine(fullName.Replace("Steve", "Stefen"));
            Console.WriteLine(fullName.Replace('S', 'I'));

            var input = "25";
            var age = Convert.ToByte(input);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
            Console.WriteLine(price.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

            //Summarizing the text
            var sentence = "This is going to be a really really really really really really long text";
            var summary = SummarizeText(sentence);
            Console.WriteLine(summary);
        }

        private static string SummarizeText(string sentence, int maxLength = 20)
        {
            if (sentence.Length < maxLength)
                return sentence;
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();
                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                        break;
                }

                return string.Join(" ", summaryWords) + "...";
            }
        }

        public static void StringBuilderBasics()
        {
            var builder = new StringBuilder();
            //As all these methods returns StringBuilder type itself, hence we can directly call them one after another
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 5)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);
            Console.WriteLine("First char: " + builder[0]);
        }

        // Concatenates to String 
        private static void Concat1(string s1)
        {
            String st = "forGeeks"; //Necessary to include System namespace for using String
            s1 = string.Concat(s1, st);
        }

        // Concatenates to StringBuilder 
        private static void Concat2(StringBuilder s2)
        {
            s2.Append("forGeeks");
        }
    }
}
