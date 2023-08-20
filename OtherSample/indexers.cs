using System;

class Dictionary{
    private string[] keys = new string[10];
    private string[] values = new string[10];

    public string this[string key]{
        get{
            int index = Array.IndexOf(keys,key);
            if(index != -1){
                return values[index];
            }
            return null;
        }

        set{
            int index = Array.IndexOf(keys,key);
            if(index == -1){
                index = Array.IndexOf(keys,null);
                if(index != 1){
                    keys[index] = key;
                    values[index] = value;
                }
            }
            else{
                values[index] = value;
            }
        }
    }
}

class Indexers{
    static void Main(){
        Dictionary myDictionary = new Dictionary();
        myDictionary["apple"] = "A fruit";

        Console.WriteLine(myDictionary["apple"]);
    }
}