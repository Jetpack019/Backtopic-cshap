using System;

class Car{
    public string Make {get;set;}
    public string Model {get;set;}

    public void Start(){
        Console.WriteLine($"The {Make} {Model} is starting");
    }
}

class CarOpen{
    static void Main(){
        Car myCar = new Car();
        myCar.Make = "Toyota";
        myCar.Model = "Camry";

        myCar.Start();
    }   
}