using System;
using System.Linq;
using System.Collections.Generic;

class SampleQueryLinq{ //Program
    static void Main(){
        List<int> numbers = new List<int> {5,8,2,10,3,6};

        var evenSquares = numbers.Where(num => num % 2 == 0 ).Select(num => num * num);

        foreach(var square in evenSquares){
            Console.WriteLine($"Even square: {square}");
        }
    }
}