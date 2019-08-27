using System;
using System.Text;
using System.Threading;

namespace ProgrammingWithMoshConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new Colors
            {
                Red = "red",
                Green = "green",
                Blue = "blue"
            };

            var person = new Person
            {
                FirstName = "John",
                LastName = "Smith"
            };
            Strings(person.FirstName, person.LastName);
            person.Introduce();
        }

        /// <summary>
        /// Explaining type conversions, data losses during explicit type converions
        /// </summary>
        private static void TypeConversions()
        {
            #region Implicit type
            byte b = 100;
            int i = b;
            Console.WriteLine(b);
            #endregion

            #region Explicit type
            int iOne = 1000;
            byte bOne = (byte)iOne;
            Console.WriteLine(bOne);
            #endregion

            #region Non-compatible type
            var number = "1234";
            int no = Convert.ToInt32(number);
            Console.WriteLine(no);
            #endregion

            try
            {
                byte num = Convert.ToByte(number);
                Console.WriteLine(num);
            }
            catch
            {
                throw;
            }
        }

        private static void Operators()
        {
            var f = "3" + 1;
            int i = 2;
            int b = i++;
            int c = ++i;
            Console.WriteLine(b+"\n" +c);
        }

        private static void Arrays()
        {
            int numberOne = 1;
            int numberTwo = 2;
            int numberThree = 3;

            int[] numbers = new int[3]; //declaring an array, we need to allocate memory to it
            numbers[0] = 1;
            numbers[1] = 2;
            var numbersArray = new int[3] {1,2,3};
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]); //Will show 0

            var names = new string[3] { "Jack", "John", "Jill" };
        }

        private static void Strings(string firstName, string lastName)
        {
            Console.WriteLine(string.Format("{0} {1}", firstName,lastName));

            var numbers = new int[] { 1, 2, 3 };
            string no = string.Join(",", numbers);

            char c = no[1];
            //no[1] = 'm'; won't compile as string is immutable

            string path = "C:\\Program Files\\Microsoft";
            string verbatimString = @"C:\Program Files\Microsoft"; //Verbatim strings
            Console.WriteLine(path + " " + verbatimString);
            path = "abc" + path; //path is concated with abc but it's stored in a different memory location

            firstName = string.Concat(firstName, path);
            StringBuilder sb = new StringBuilder(firstName);
            sb = sb.Append(path);

            String s1 = "Geeks";
            ProgrammingWithMoshConsoleApp.Strings.concat1(s1); // s1 is not changed 
            Console.WriteLine("Using String Class: " + s1);

            StringBuilder s2 = new StringBuilder("Geeks");
            ProgrammingWithMoshConsoleApp.Strings.concat2(s2); // s2 is changed 
            Console.WriteLine("Using StringBuilder Class: " + s2);
        }

        private static void MarioTune()
        {
            Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
        }

    }

}