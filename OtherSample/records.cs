using System;

record Person(string FirstName, string LastName);

class PersonInfo{
    static void Main(){
        Person person1 = new Person("John","Doe");
        Person person2 = new Person("John","James");

        Console.WriteLine($"person1 equals person2: {person1.Equals(person2)}");
    }
}