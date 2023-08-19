using System;
using System.IO;

class FileRead{
    static void Main(){
        string filepath = "example.txt";

        using (StreamWriter writer = new StreamWriter(filepath)){
            writer.WriteLine("Hello, file!");
        }

        using (StreamReader reader = new StreamReader(filepath)){
            string content = reader.ReadToEnd();
            Console.WriteLine("Content of the file:");
            Console.WriteLine(content);
        }
    }

}