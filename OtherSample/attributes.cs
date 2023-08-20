using System;

class CustomAttribute:Attribute{
    public string Description{get;}
    public CustomAttribute(string description){
        Description = description;
    }
}

class MyClass{
    public void MyMethod(){
        Console.WriteLine("Hello from MyMethod!");
    }
}

class AttributeSample{
    static void Main(){
        Type classType = typeof(MyClass);
        var classAttributes = classType.GetCustomAttributes(false);

        foreach(var attribute in classAttributes){
            if(attribute is CustomAttribute customAttr){
                 Console.WriteLine($"Class Attribute: {customAttr.Description}");
            }
        }

        MyClass myInstance = new MyClass();
        myInstance.MyMethod();
    }
}