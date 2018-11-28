// Adrián Navarro Gabino

import java.util.*;

public class BufferChallenge
{
    public static void main(String[] args)
    {
        int cases, urinals, numberOfMen;
        
        Scanner entrada = new Scanner(System.in);
        
        cases = entrada.nextInt();
        
        for(int i = 0; i < cases; i++)
        {
            urinals = entrada.nextInt();
            numberOfMen = urinals % 2 == 0 ? urinals / 2 : (urinals + 1) / 2;
            System.out.println(numberOfMen);
        }
    }
}
