// Program.cs
using System;

Person p = new("Alice");
p.SayHello();

public class Person(string name) 
{
    public void SayHello() => Console.WriteLine($"Hi, I'm {name}");
}
