// Adrián Navarro Gabino

using System;
using System.IO;

class Person
{
    protected string name;
    protected int age;
    
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    
    public void SetName(string name)
    {
        this.name = name;
    }
    
    public void SetAge(int age)
    {
        this.age = age;
    }
    
    public string GetName() { return name; }
    public int GetAge() { return age; }
    
    public static void Save(string fileName, Person p)
    {
        BinaryWriter outputFile = new BinaryWriter(
            File.Open(fileName, FileMode.Create));
        outputFile.Write(p.name);
        outputFile.Write(p.age);
        outputFile.Close();
    }
    
    public static Person Load(string fileName)
    {
        BinaryReader inputFile = new BinaryReader(
            File.Open(fileName, FileMode.Open));
        string name = inputFile.ReadString();
        int age = inputFile.ReadInt32();
        inputFile.Close();
        
        return new Person(name, age);
    }
}

class PersonTest
{
    static void Main()
    {
        Person antonio = new Person("Antonio", 20);
        Console.WriteLine(antonio.GetName() + " - " + antonio.GetAge());
        
        Person.Save("antonio.txt", antonio);
        
        antonio.SetName("Alfredo");
        antonio.SetAge(35);
        Console.WriteLine(antonio.GetName() + " - " + antonio.GetAge());
        
        antonio = Person.Load("antonio.txt");
        
        Console.WriteLine(antonio.GetName() + " - " + antonio.GetAge());
    }
}
