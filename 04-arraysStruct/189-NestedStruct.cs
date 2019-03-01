// Adrián Navarro Gabino

using System;

public class NestedStruct
{
    struct date
    {
        public int day;
        public int month;
        public int year;
    }

    struct person
    {
        public string name;
        public date birthday;
    }

    public static void Main()
    {
        const int SIZE = 1000;
        person[] people = new person[SIZE];

        for (int i = 0; i < 2; i++)
        {
            Console.Write("Enter the name for person {0}:", i+1 );
            people[i].name = Console.ReadLine();

            Console.Write("Enter the birthday (1-day) for person {0}:", i + 1);
            people[i].birthday.day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the birthday (2-month) for person {0}:", i + 1);
            people[i].birthday.month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the birthday (3-year) for person {0}:", i + 1);
            people[i].birthday.year = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Name: "+ people[i].name);
            Console.WriteLine("Birthday: " +
                people[i].birthday.day +"/"+ 
                people[i].birthday.month + "/" +
                people[i].birthday.year);
        }
    }
}
