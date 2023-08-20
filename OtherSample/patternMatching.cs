using System;

class PatternMatching
{
    static void Main()
    {
        object value = "Hello";

        if (value is int intValue)
        {
            Console.WriteLine("It's an integer: " + intValue);
        }
        else if (value is string strValue)
        {
            Console.WriteLine("It's a string: " + strValue);
        }
        else
        {
            Console.WriteLine("It's something else.");
        }
    }
}
