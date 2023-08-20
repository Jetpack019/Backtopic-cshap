using System;
using System.Collections.Generic;

class SampleDictionary{
    static void Main(){
        Dictionary<string,int> ages = new Dictionary<string,int>();
        ages["Alice"] = 30;
        ages["Bob"] = 25;
        ages["Charlie"] = 28;
        
        foreach (var pair in ages)
        {
            Console.WriteLine($"{pair.Key} is {pair.Value} years old.");
        }
    }
}