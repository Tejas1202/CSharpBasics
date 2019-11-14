using System;

namespace ProgrammingWithMoshConsoleApp.ControlFlow
{
    class RandomClass
    {
        public static void RandomClassExample()
        {
            var random = new Random();
            for(var i = 0; i <= 10; i++)
            {
                Console.WriteLine(random.Next());
                Console.WriteLine(random.Next(1, 10));
            }

            Console.WriteLine((int)'a'); //97

            #region to generate passwords from a-z
            for(var j = 0; j <=10; j++)
            {
                Console.Write((char)random.Next(97, 122));
            }

            //A more intuitive approach
            for (var j = 0; j <= 10; j++)
                Console.Write((char)('a' + random.Next(0, 26)));

            //Usage to char array to store in string as it's immutable
            var passwordLength = 10;
            var buffer = new char[passwordLength];
            for(int k = 0; k < passwordLength; k++)
            {
                buffer[k] = (char)('a' + random.Next(0, 26));
            }
            var password = new String(buffer);
            #endregion
        }
    }
}
