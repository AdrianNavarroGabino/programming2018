// Adrián Navarro Gabino

import java.util.*;

public class FestivolandiaChallenge
{
    public static void main(String[] args)
    {
        int cases, day, month;
        
        Scanner entrada = new Scanner(System.in);
        
        cases = entrada.nextInt();
        
        for(int i = 0; i < cases; i++)
        {
            day = entrada.nextInt();  
            month = entrada.nextInt();
            
            if( (day % 2 == month % 2) || (day == 25 && month == 12) )
                System.out.println("FESTIVO");
            else
                System.out.println("LABORABLE");
        }
    }
}
