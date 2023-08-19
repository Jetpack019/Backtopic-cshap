using System;
using System.Threading;

class Multithread{
    static void Main(){
        Thread thread1 = new Thread(DoWork);
        Thread thread2 = new Thread(DoWork);

        thread1.Start("Thread 1");
        thread2.Start("Thread 2");
    }

    static void DoWork(object threadName){
        for (int i=0;i<5;i++){
            Console.WriteLine($"{threadName} - Count: {i}");
            Thread.Sleep(1000);
        }
    }
}