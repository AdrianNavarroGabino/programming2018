// Adrián Navarro Gabino

using System;

public class NestedStruct
{
    struct person
    {
        public string name;
        public date birth;
    }
    struct date
    {
        public int day;
        public int month;
        public int year;
    }
    
    public static void Main()
    {
        person[] p = new person[2];
        
        for(int i = 0; i < 2; i++)
        {
            Console.Write("Enter the name of person {0}: ", i+1);
            p[i].name = Console.ReadLine();
            Console.Write("Enter the day of his/her birth: ");
            p[i].birth.day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the month of his/her birth: ");
            p[i].birth.month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the year of his/her birth: ");
            p[i].birth.year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
        
        for(int i = 0; i < 2; i++)
        {
            Console.WriteLine("Person {0}", i+1);
            Console.WriteLine("Name: {0}", p[i].name);
            Console.WriteLine("Day of birth: {0}", p[i].birth.day);
            Console.WriteLine("Month of birth: {0}", p[i].birth.month);
            Console.WriteLine("Year of birth: {0}", p[i].birth.year);
            Console.WriteLine();
        }
    }
}
