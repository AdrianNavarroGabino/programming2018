// String login
// Adrián Navarro Gabino

using System;

public class NameAndPass
{
    public static void Main()
    {
        string login, pass;
        
        do
        {
            Console.Write("Login: ");
            login = Console.ReadLine();
            
            Console.Write("Password: ");
            pass = Console.ReadLine();
            
            if(login != "login" || pass != "password")
                Console.WriteLine("Access denied");
        } while(login != "login" || pass != "password");
        
        Console.WriteLine("Access granted");
    }
}
