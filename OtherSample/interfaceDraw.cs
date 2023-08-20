using System;

interface IDrawable
{
    void Draw();
}

interface IWritable
{
    void Write(string text);
}

class ShapeINTERFACE : IDrawable, IWritable
{
    public void Draw()
    {
        Console.WriteLine("Drawing shape...");
    }

    public void Write(string text)
    {
        Console.WriteLine($"Writing: {text}");
    }
}

class ShapeInterface
{
    static void Main()
    {
        ShapeINTERFACE shape = new ShapeINTERFACE();
        shape.Draw();
        shape.Write("Hello, world!");
    }
}
