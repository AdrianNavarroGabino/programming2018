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
    
    public void Save(string fileName)
    {
        BinaryWriter outputFile = new BinaryWriter(
            File.Open(fileName, FileMode.Create));
        outputFile.Write(name);
        outputFile.Write(age);
        outputFile.Close();
    }
    
    public void Load(string fileName)
    {
        BinaryReader inputFile = new BinaryReader(
            File.Open(fileName, FileMode.Open));
        name = inputFile.ReadString();
        age = inputFile.ReadInt32();
        inputFile.Close();
    }
}

class PersonTest
{
    static void Main()
    {
        Person antonio = new Person("Antonio", 20);
        Console.WriteLine(antonio.GetName() + " - " + antonio.GetAge());
        
        antonio.Save("antonio.txt");
        
        antonio.SetName("Alfredo");
        antonio.SetAge(35);
        Console.WriteLine(antonio.GetName() + " - " + antonio.GetAge());
        
        antonio.Load("antonio.txt");
        
        Console.WriteLine(antonio.GetName() + " - " + antonio.GetAge());
    }
}
