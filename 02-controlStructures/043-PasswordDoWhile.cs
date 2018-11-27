// Password (do-while)
// Adrián Navarro Gabino

using System;

public class PasswordDoWhile
{
    public static void Main()
    {
        int password;
        
        do 
        {
            Console.Write("Enter a Password: ");
            password = Convert.ToInt32(Console.ReadLine());
            
            if(password != 1234)
                Console.Write("Wrong Password, enter again: ");
            
        } while(password != 1234);
        
        Console.WriteLine("Access Granted");
    }
}
