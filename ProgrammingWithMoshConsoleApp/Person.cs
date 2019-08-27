using System;

namespace ProgrammingWithMoshConsoleApp
{
    class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("Hi, My name is " + FirstName + " " + LastName);
        }
    }

}