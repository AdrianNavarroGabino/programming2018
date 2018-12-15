/*
Sample inputs
9,10,10,9
8,9
0,0,0,0,0,0,0,0,0,0,0,0,0
10,10,10,10
7,7,10,10,4,6,4,6,0,6,7,4,6,6,9
Outputs for those inputs
0
4
247
0
101
*/

// Adrián Navarro Gabino

import java.util.*;

public class LookingForTheTen
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        
        String[] marks = sc.nextLine().split(",");
        
        int denominator = marks.length;
        
        int sum = 0;
        
        for(int i = 0; i < denominator; i++)
        {
            sum += Integer.parseInt(marks[i]);
        }
        
        double currentAverage = (double)sum / denominator;
        
        if(currentAverage >= 9.5)
        {
            System.out.println(0);
        }
        else
        {
            int tasks = 19 * denominator - 2 * sum;
                
            System.out.println(tasks);
        }
    }
}
