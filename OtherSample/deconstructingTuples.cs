using System;

class DeconstructingTuples
{
    static (string, int) GetPersonInfo()
    {
        return ("Bob", 25);
    }

    static void Main()
    {
        var personInfo = GetPersonInfo();
        var (name, age) = personInfo;

        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
