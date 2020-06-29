using System;

namespace ProgrammingWithMoshConsoleApp.NonPrimitiveTypes
{
    class Basics
    {
        public void BasicConcepts()
        {
            //Person person;
            //Colors colors;
            //int number;
            //Use of unassigned local variable compilation error. Hence no matter what the type is, you cannot use a type untill
            //and unless you intialize it
            //person.Introduce();
            //colors.AllColors();
            //number.GetType(); 

            //At runtime, you'll see that before this line executes, value of person will be null but that will not be the case with color
            // because we're dynamically allocating memory to our object
            var person = new Person
            {
                FirstName = "Jimmy",
                LastName = "Anderson"
            };
            var color = new Colors
            {
                Red = "red",
                Blue = "blue"
            };

            // Reference copied
            var secondPerson = person;
            
            //Copy created
            var secondColor = color;

            secondPerson.FirstName = "Jim";
            secondColor.Red = "Dark red";

            // Both person's and secondPerson's FirstName will be same now as they both are referencing to the same memory in heap
            Console.WriteLine(string.Format("person: {0}, secondPerson: {1}", person.FirstName, secondPerson.FirstName));
            Console.WriteLine(string.Format("color: {0}, secondColor: {1}", color.Red, secondColor.Red));
        }
    }
}
