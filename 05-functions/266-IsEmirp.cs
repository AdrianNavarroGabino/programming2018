// Adrián Navarro Gabino

using System;

class IsEmirp
{
    static bool IsEmirp(int num)
    {
        bool emirp = false;
        int i;
        int count1 = 0;
        int count2 = 0;
        int originalNumber = num;
        
        //getting prime in regular number
        for (i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                count1++;
            }
        }
        
        //reversing number
        int reverseNum = 0;
        int rest;
        
        while (num > 0)
        {
            rest = num % 10;
            reverseNum = (reverseNum * 10) + rest;
            num /= 10;
        }
        
        // Must be a different number
        if (reverseNum == originalNumber)
            return false;
        
        //getting prime in reverse num
        for (i = 1; i <= reverseNum; i++)
        {
            if (reverseNum % i == 0)
            {
                count2++;
            }
        }
        
        //matching results
        if (count1 == 2 && count2 == 2)
        {
            emirp = true;
        }
    
        return emirp;
    }   
    
    static void Main()
    {
        Console.WriteLine("Write number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Is " + num + " emirp?: ");
        Console.WriteLine(IsEmirp(num));
        
        // Extra: to test times
        // From 1 to 99999... 00:00:27.3002727 in i7 7700HQ
        bool debugging = true;
        if (debugging)
        {
            int first = 1;
            int last = 99999;
            Console.WriteLine("Measuring times from "+
                first+" to "+last +"...");
            int amount = 0;
            DateTime start = DateTime.Now;
            for(int i = first; i <= last; i++)
            {
                if(IsEmirp(i))
                    amount++;
            }
            Console.WriteLine("Time taken: "+ (DateTime.Now-start));
            Console.WriteLine("Found: "+ amount);
        }
    }
}
