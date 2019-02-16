/*
Create a class "House", with an attribute "area", a constructor that 
sets its value and a method "ShowData" to display "I am a house, my 
area is 200 m2" (instead of 200, it will show the real surface). 
Include getters an setters for the area, too.
The "House" will contain a door. Each door will have an attribute 
"color" (a string), and a method "ShowData" which will display "I am a 
door, my color is brown" (or whatever color it really is). Include a 
getter and a setter. Also, create a "GetDoor" in the house.
A "SmallApartment" is a subclass of House, with a preset area of 50 m2.
Also create a class Person, with a name (string). Each person will have 
a house. The method "ShowData" for a person will display his/her name, 
show the data of his/her house and the data of the door of that house.
Write a Main to create a SmallApartment, a person to live in it, and to 
show the data of the person.
*/

// Adrián Navarro Gabino

using System;

class House
{
    protected int area;
    protected Door door;
    
    public House(int area)
    {
        this.area = area;
    }
    
    public void SetArea(int area) { this.area = area; }
    public void SetDoor(Door d) { this.door = d; }
    
    public int GetArea() { return area; }
    public Door GetDoor() { return door; }
    
    public void ShowData()
    {
        Console.Write("I am a house, my area is " + this.area +" m2");
    }
}

class Door
{
    protected string color;
    
    public Door(string color)
    {
        this.color = color;
    }
    
    public void SetColor(string color) { this.color = color; }
    public string GetColor() { return color; }
    
    public void ShowData()
    {
        Console.Write("I am a door, my color is " + this.color);
    }
}

class SmallApartment : House
{
    public SmallApartment() : base(50)
    {
    }
}

class Person
{
    protected string name;
    protected House house;
    
    public Person(string name)
    {
        this.name = name;
    }
    
    public void SetName(string name) { this.name = name; }
    public void SetHouse(House house) { this.house = house; }
    
    public string GetName() { return name; }
    public House GetHouse() { return house; }
    
    public void ShowData()
    {
        /*
        Console.Write("I am a person, my name is " + this.name +
            "the area of my house is " + house.GetArea() +
            "m2, the color of the door is " +
            house.GetDoor().GetColor());
        */
            
        Console.Write("I am a person, my name is " + this.name +
            ". About my house: ");
        house.ShowData();
        Console.Write(". About its door: ");
        house.GetDoor().ShowData();
    }
}

class Test
{
    static void Main()
    {
        SmallApartment apartment = new SmallApartment();
        Door d = new Door("red");
        apartment.SetDoor(d);
        
        Person person = new Person("James");
        person.SetHouse( apartment );
        person.ShowData();
    }
}
