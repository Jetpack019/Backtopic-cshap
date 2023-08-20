using System;

class NullableSample{ //Program

    static void Main(){
        int? nullable = null;

        if(nullable.HasValue){
            Console.WriteLine($"Nullable int value: {nullable.Value}");
        }else{
            Console.WriteLine("Nullable int is null");
        }

        int nonNullableInt = nullable ?? 0;
        Console.WriteLine($"Non-nullable int value: {nonNullableInt}");
    }
}