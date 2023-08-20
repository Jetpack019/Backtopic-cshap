#nullable enable

using System;

class Nullable
{
    static void Main()
    {
        string? nullableString = null;
        string nonNullableString = nullableString ?? "Default Value";

        Console.WriteLine("Nullable String: " + nullableString);
        Console.WriteLine("Non-Nullable String: " + nonNullableString);
    }
}
