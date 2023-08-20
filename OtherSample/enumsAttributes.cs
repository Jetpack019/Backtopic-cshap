using System;

enum Color
{
    [ColorInfo("Red color")]
    Red,
    
    [ColorInfo("Green color")]
    Green,
    
    [ColorInfo("Blue color")]
    Blue
}

[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
class ColorInfoAttribute : Attribute
{
    public string Description { get; }

    public ColorInfoAttribute(string description)
    {
        Description = description;
    }
}

class EnumAttribute
{
    static void Main()
    {
        Color color = Color.Green;
        ColorInfoAttribute attribute = (ColorInfoAttribute)Attribute.GetCustomAttribute(
            typeof(Color).GetField(color.ToString()), typeof(ColorInfoAttribute));

        if (attribute != null)
        {
            Console.WriteLine($"Color: {color}, Description: {attribute.Description}");
        }
    }
}
