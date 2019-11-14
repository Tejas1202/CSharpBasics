using System;

namespace ProgrammingWithMoshConsoleApp.PrimitiveTypes
{
    class TypeConversions
    {
        /// <summary>
        /// Explaining type conversions, data losses during explicit type converions
        /// </summary>
        private static void TypeConversionsExample()
        {
            #region Implicit type
            byte b = 1; //00000001 (seven bits of 0 and one bit of 1)
            int i = b;  //00000000 00000000 00000000 00000001
            Console.WriteLine(b);
            #endregion

            #region Explicit type
            int iOne = 1000;
            byte bOne = (byte)iOne; //Data loss occurs if int is greater than 255
            Console.WriteLine(bOne);
            #endregion

            #region Non-compatible type
            var number = "1234";
            int no = Convert.ToInt32(number);
            Console.WriteLine(no);
            #endregion

            try
            {
                byte num = Convert.ToByte(number);
                Console.WriteLine(num);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Overflowing concept and checked keyword
        /// </summary>
        private void OverFlowing()
        {
            checked
            {
                byte number = 255;
                number += 1;
                Console.WriteLine(number);
            }
        }
    }
}
