using System;

class ExceptionHandle{
    static void Main(){
        try{
            int numerator = 10;
            int denominator = 0;
            int result = numerator/denominator;
            Console.WriteLine($"Result: {result}");
        }catch(DivideByZeroException ex){
            Console.WriteLine("Error: "+ ex.Message);
        }
    }
}