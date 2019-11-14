using System;

namespace ProgrammingWithMoshConsoleApp.NonPrimitiveTypes
{
    class Enums
    {
        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }

        public static void EnumExamples()
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
            Console.WriteLine((ShippingMethod)3);
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
