using System;
using System.Text;

namespace ProgrammingWithMoshConsoleApp
{
    class Strings
    {
        // Concatenates to String 
        public static void concat1(string s1)
        {

            // taking a string which 
            // is to be Concatenate 
            String st = "forGeeks"; //Necessary to include System namespace for using String

            // using String.Concat method 
            // you can also replace it with 
            // s1 = s1 + "forgeeks"; 
            s1 = string.Concat(s1, st);
        }

        // Concatenates to StringBuilder 
        public static void concat2(StringBuilder s2)
        {

            // using Append method 
            // of StringBuilder class 
            s2.Append("forGeeks");
        }
    }
}
