using System;
public interface IFLyable
{
    void Fly();
}
public interface ISwimmable
{
    void Swim();
}
public class Duck : IFLyable, ISwimmable{
    public void Fly()
    {
        Console.WriteLine("Duck is flying.");
    }
    public void Swim()
    {
        Console.WriteLine("Duck is swimming.");
    }
}