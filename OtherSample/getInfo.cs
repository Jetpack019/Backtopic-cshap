using System;

class GetUserInfo{
    static (string, int) GetPersonInfo(){
        return ("Alice",30);
    }

    static void Main(){
        var personInfo  = GetPersonInfo();
        Console.WriteLine($"Name: {personInfo.Item1}, Age: {personInfo.Item2}");
    }
}