// Login and password, first approach
// Adrián Navarro Gabino

using System;

public class UserAndPass
{
    public static void Main()
    {
        int user;
        int pass;
        
        do
        {
            Console.Write("User: ");
            user = Convert.ToInt32(Console.ReadLine());
            Console.Write("Password: ");
            pass = Convert.ToInt32(Console.ReadLine());
            
            if(user != 1493 || pass != 1234)
                Console.WriteLine("Access denied");
        } while(user != 1493 || pass != 1234);
        
        Console.WriteLine("Access granted");
    }
}
