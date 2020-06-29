using System;

namespace ProgrammingWithMoshConsoleApp.NonPrimitiveTypes
{
    public class TypesDifference
    {
        public void ReferenceAndValueTypes()
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("{0} {1}", a, b));

            var arrayOne = new int[] { 1, 2, 3 };
            var arrayTwo = arrayOne;
            arrayTwo[0] = 0;
            Console.WriteLine(string.Format("arrayOne[0] : {0}, arrayTwo[0] : {0}", arrayOne[0], arrayTwo[0]));

            var number = 10;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person
            {
                Age = 20
            };
            Increment(person);
            Console.WriteLine(person.Age);
        }

        private static void Increment(int number)
        {
            number += 10;
        }

        private static void Increment(Person person)
        {
            person.Age += 10;
        }
    }
}
