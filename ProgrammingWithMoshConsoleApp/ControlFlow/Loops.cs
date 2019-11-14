using System;

namespace ProgrammingWithMoshConsoleApp.ControlFlow
{
    class Loops
    {
        public void LoopsExample()
        {
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            var j = 1; /*Here in this case, it's better to prefer for loop when we know how many times we've to iterate
            as we don't have to declare a variable before using it in loop*/
            while (j <= 10)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }

            while (true)
            {
                Console.Write("Type your Name: ");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;

                Console.WriteLine("@Echo: " + input);
            }

            while (true)
            {
                Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;
            }

        }

        public void ForVsForEach()
        {
            var name = "John Smith";

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
        }
    }
}
