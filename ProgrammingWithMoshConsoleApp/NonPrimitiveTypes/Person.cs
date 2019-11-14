using System;

namespace ProgrammingWithMoshConsoleApp.NonPrimitiveTypes
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine("Hi, My name is " + FirstName + " " + LastName);
        }
    }
}