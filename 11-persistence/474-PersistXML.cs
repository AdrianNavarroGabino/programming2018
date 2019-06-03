// Adrián Navarro Gabino

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

[Serializable]
class Person
{
    private string name;
    private int age;

    public string GetName() { return name; }
    public void SetName(string n) { name = n; }

    public int GetAge() { return age; }
    public void SetAge(int a) { age = a; }

    /*
    static public void Save(string fileName, Person p)
    {
        BinaryWriter outputFile = new BinaryWriter(
            File.Open(fileName, FileMode.Create));
        outputFile.Write(p.name);
        outputFile.Write(p.age);
        outputFile.Close();
    }
    */

    public static void Save(string fileName,
        Person p)
    {
        IFormatter formatter = new SoapFormatter();
        Stream outputFile = new FileStream(fileName,
            FileMode.Create, FileAccess.Write,
            FileShare.None);
        formatter.Serialize(outputFile, p);
        outputFile.Close();
    }

    /*
    static public Person Load(string fileName)
    {
        BinaryReader inputFile = new BinaryReader(
            File.Open(fileName, FileMode.Open));
        Person p = new Person();
        p.name = inputFile.ReadString();
        p.age = inputFile.ReadInt32();
        inputFile.Close();
        return p;
    }
    */

    public static Person Load(string fileName)
    {
        Person p;
        IFormatter formatter = new SoapFormatter();
        Stream inputFile = new FileStream(fileName,
            FileMode.Open, FileAccess.Read,
            FileShare.Read);
        p = (Person)formatter.Deserialize(inputFile);
        inputFile.Close();
        return p;
    }
}

class PersonTest
{
    static void Main(string[] args)
    {
        Person p = new Person();
        p.SetName("Yo");
        p.SetAge(20);
        System.Console.WriteLine(p.GetName() + " " + p.GetAge());
        Person.Save("person2.xml", p);

        p.SetName("Tu");
        p.SetAge(21);
        System.Console.WriteLine(p.GetName() + " " + p.GetAge());

        p = Person.Load("person2.xml");
        System.Console.WriteLine(p.GetName() + " " + p.GetAge());
    }
}
