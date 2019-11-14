using System;

namespace ProgrammingWithMoshConsoleApp.ArraysAndLists
{
    class Arrays
    {
        private static void ArraysBasics()
        {
            //int numberOne = 1; int numberTwo = 2; int numberThree = 3; (so that we don't have to declare individual variables)
            int[] numbers = new int[3]; //declaring an array, we need to allocate memory to it
            numbers[0] = 1;
            numbers[1] = 2;
            var numbersArray = new int[3] { 1, 2, 3 };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]); //Will show 0

            var names = new string[3] { "Jack", "John", "Jill" };
        }

        public void ArrayTypes()
        {
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            //Length property
            Console.WriteLine(numbers.Length);

            //IndexOf() method
            int index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9 is: " + index);

            //Clear() This method doesn't remove the first two index, instead it sets the first two elements to default value (0 here)
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (var number in numbers)
                Console.WriteLine(number);

            //Copy()
            var copiedArray = new int[3];
            Console.WriteLine("Copied Array");
            Array.Copy(numbers, copiedArray, 3);
            foreach (var number in copiedArray)
                Console.WriteLine(number);

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (var number in numbers)
                Console.WriteLine(number);

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (var number in numbers)
                Console.WriteLine(number);

            //Rectangular 2D array
            var matrix = new int[3, 5]
            {
                { 1,2,3,4,5},
                { 6,7,8,9,10 },
                { 11,12,13,14,15}
            };
            var element = matrix[0, 0];

            //Rectangular 3D array
            var colors = new int[3, 5, 4] { {{ 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 },{ 13,14,15,16 },{17,18,19,20} },
                { {21,22,23,24}, { 25,26,27,28},{ 29,30,31,32},{ 33,34,35,36},{ 37,38,39,40} },
                { { 41,42,43,44},{45,46,47,48},{49,50,51,52 },{ 53,54,55,56},{ 57,58,59,60} }
            };

            //Jagged array
            var jaggedArray = new int[3][];
            jaggedArray[0] = new int[4];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[5];

            jaggedArray[2][3] = 5;
            var jaggedArrayElement = jaggedArray[2][3];
        }
    }
}
