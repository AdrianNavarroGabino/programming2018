// Adrián Navarro Gabino

import java.util.*;

public class Base1
{
    public static void main(String[] args)
    {
        int n;
        
        Scanner entrada = new Scanner(System.in);
        
        do
        {
            n = entrada.nextInt();
            
            for(int i = 0; i < n; i++)
                System.out.print(1);
            System.out.println();
        } while(n != 0);
    }
}
