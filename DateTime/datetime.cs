using System;

class DateandTime{
    static void Main(){
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddHours(3);
        
        Console.WriteLine($"Current Time: {currentTime}");
        Console.WriteLine($"Future Time: {futureTime}");

        TimeSpan timeDifference = futureTime - currentTime;
        Console.WriteLine($"Time Difference: {timeDifference.TotalHours} hours");
    }
}