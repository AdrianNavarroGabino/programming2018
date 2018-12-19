// Adrián Navarro Gabino

import java.util.*;

public class NextRound
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        
        int players = sc.nextInt();
        int chosenPlayer = sc.nextInt();
        sc.nextLine();
        
        int[] score = new int[players];
        
        for(int i = 0; i < players; i++)
        {
            score[i] = sc.nextInt();
        }
        
        int count = 0;
        
        for(int s: score)
        {
            if(s >= score[chosenPlayer - 1] && s > 0)
                count++;
        }
        
        System.out.println(count);
    }
}
