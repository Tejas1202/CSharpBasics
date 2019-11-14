using System;
using System.Collections.Generic;

namespace ProgrammingWithMoshConsoleApp.ArraysAndLists
{
    class ListsBasics
    {
        public void ListsIntro()
        {
            var numbers = new List<int>() { 1, 2, 3, 1, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 }); /*As AddRange() method expects IEnumerable(which is an interface) and this 
            interface is implemented by Array/List class, we can supply array/list or any type which is IEnumerable to this method*/

            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));
            Console.WriteLine("Count: " + numbers.Count);

            //To remove an element (removes only the first one if there are more than one instances of that value (1 here)
            numbers.Remove(1);
            foreach (var number in numbers)
                Console.WriteLine(number);

            //You can't modified a collection in a foreach loop
            try
            {
                foreach (var number in numbers)
                {
                    if (number == 1)
                        numbers.Remove(1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            //To remove all elements from the list
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);

        }

        
    }
}
