class Shape{
    public virtual void Draw(){
        Console.WriteLine("Drawing a shape");
    }
}

class Circle : Shape{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Rectangle : Shape{
    
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

class SampleShape{

    static void Main(){
        Shape[] shapes = {new Circle(),new Rectangle()};

        foreach(Shape shape in shapes){
            shape.Draw();
        }
    }
}