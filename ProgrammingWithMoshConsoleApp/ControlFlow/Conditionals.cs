using System;
using static ProgrammingWithMoshConsoleApp.NonPrimitiveTypes.Enums;

namespace ProgrammingWithMoshConsoleApp.ControlFlow
{
    class Conditionals
    {
        public void SwitchCaseExample()
        {
            var method = ShippingMethod.RegularAirMail;

            switch (method)
            {
                case ShippingMethod.RegularAirMail:
                case ShippingMethod.RegisteredAirMail:
                    Console.WriteLine("It's an air mail");
                    break;
                case ShippingMethod.Express:
                    Console.WriteLine("It's express");
                    break;
                default:
                    Console.WriteLine("I don't recognize it");
                    break;
            }

        }
    }
}
