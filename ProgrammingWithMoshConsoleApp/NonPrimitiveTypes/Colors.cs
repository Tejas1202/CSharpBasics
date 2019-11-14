using System;

namespace ProgrammingWithMoshConsoleApp.NonPrimitiveTypes
{
    public struct Colors
    {
        public string Red;
        public string Green;
        public string Blue;

        public void AllColors()
        {
            Console.WriteLine(Red + Green + Blue);
        }
    }
}
