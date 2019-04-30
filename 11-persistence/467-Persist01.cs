// Adrián Navarro Gabino

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
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
        IFormatter formatter = new BinaryFormatter();
        Stream file = new FileStream(fileName,
            FileMode.Create, FileAccess.Write,
            FileShare.None);
        formatter.Serialize(file, p);
        file.Close();
    }
    
    public static Person Load(string fileName)
    {
        Person p;
        IFormatter formatter = new BinaryFormatter();
        Stream file = new FileStream(fileName,
            FileMode.Open, FileAccess.Read,
            FileShare.Read);
        p = (Person)formatter.Deserialize(file);
        file.Close();
        
        return p;
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
