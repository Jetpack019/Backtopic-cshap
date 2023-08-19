using System;

class DelandEvents{
    public delegate void EventHandler(string message);
    
    public event EventHandler MyEvent;

    public void RaiseEvent(string message){
        MyEvent?.Invoke(message);
    }

    static void Main(){
        DelandEvents program = new DelandEvents();
        program.MyEvent += DisplayMessage;

        program.RaiseEvent("Event triggered!");
    }

    static void DisplayMessage(string message){
        Console.WriteLine($"Message received: {message}");
    }
}