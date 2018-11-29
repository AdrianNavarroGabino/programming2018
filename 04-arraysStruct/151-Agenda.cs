// Oversized Array
// Adrián Navarro Gabino

using System;

public class Agenda
{
    public static void Main()
    {
        string[] friends = new string[100];
        byte position = 0;
        byte option;
        
        do
        {
            Console.WriteLine("Elige una opción:");
            Console.WriteLine("1- Add");
            Console.WriteLine("2- Show all");
            Console.WriteLine("3- Exit");
            option = Convert.ToByte(Console.ReadLine());
        
            if(option == 1)
            {
                if(position < 100)
                {
                    Console.WriteLine("Enter the name:");
                    friends[position] = Console.ReadLine();
                    position++;
                }
                else
                {
                    Console.WriteLine("Database full");
                }
            }
            else if(option == 2)
            {
                for(byte i = 0; i < position; i++)
                {
                    Console.WriteLine("Frien " + (i+1) + ": " + friends[i]);
                }
            }
        } while(option != 3);
        
        Console.WriteLine("Adeu-siau");
    }
}
