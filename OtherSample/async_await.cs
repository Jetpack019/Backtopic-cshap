using System;
using System.Threading.Tasks;

class AsyncAwait{
    static async Task Main(){
        Console.WriteLine("Main method started.");
        await PerformAsyncTask();
        Console.WriteLine("Main method completed.");
    }

    static async Task PerformAsyncTask(){
        Console.WriteLine("Async task started.");
        await Task.Delay(2000);
        Console.WriteLine("Async task completed");
    }
}