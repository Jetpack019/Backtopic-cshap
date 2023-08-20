using System;

interface IPlayable{
    void Play();
}

class Video : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Playing video...");
    }
}

class Music : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Playing music...");
    }
}   

class SampleInterface{
    static void Main(){
        IPlayable media1 = new Video();
        IPlayable media2 = new Music();

        media1.Play();
        media2.Play();
    }
}