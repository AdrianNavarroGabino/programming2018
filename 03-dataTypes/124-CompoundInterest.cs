// Adrián Navarro Gabino

using System;

public class CompoundInterest
{
    public static void Main()
    {
        Console.Write("Enter money: ");
        decimal initialMoney = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter interest (over 1): ");
        float interest = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter years: ");
        byte years = Convert.ToByte(Console.ReadLine());
        
        decimal finalMoney = (decimal)initialMoney;
        
        for(int i = 1; i <= years; i++)
            finalMoney *= (decimal)(1 + interest);
        
        Console.WriteLine("Final money: " + finalMoney.ToString("N2"));
    }
}
