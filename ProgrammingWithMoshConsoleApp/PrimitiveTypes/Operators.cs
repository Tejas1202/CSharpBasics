using System;

namespace ProgrammingWithMoshConsoleApp.PrimitiveTypes
{
    class Operators
    {
        private void OperatorsExample()
        {
            #region postfix and prefix
            int i = 2;
            int b = i++;
            int c = ++i;
            Console.WriteLine(b + "\n" + c);
            #endregion

            #region some type conversions when using operators
            var @string = "3" + 1; //string + int
            var @int = 'a' + 'b'; //char + char
            var  @intOne = @int + 'c'; //int + char
            #endregion
        }
    }
}
