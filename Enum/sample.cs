using System;

enum DaysOfWeek{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Enum{
    static void Main(){
        DaysOfWeek today = DaysOfWeek.Wednesday;
        Console.WriteLine($"Today is {today}");
    }
}