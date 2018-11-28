/*
Sample input
3
70
3600
3661
Sample output
00:01:10
01:00:00
01:01:01
*/

// Adrián Navarro Gabino

import java.util.*;

public class RetoGoteras{
	public static void main(String[] args){
        int segundos, minutos, horas;
        int tiempo;
        
        Scanner entrada = new Scanner(System.in);
        int n = entrada.nextInt();
            
        for(int i = 0; i < n; i++)
        {
            tiempo = entrada.nextInt();
            
            horas = tiempo / 3600;
        
            if(horas < 10)
                System.out.print("0" + horas + ":");
            else
                System.out.print(horas + ":");
            
            minutos = (tiempo - horas * 3600) / 60;
            
            if(minutos < 10)
                System.out.print("0" + minutos + ":");
            else
                System.out.print(minutos + ":");
                
            segundos = tiempo - horas * 3600 - minutos * 60;
            
            if(segundos < 10)
                System.out.println("0" + segundos);
            else
                System.out.println(segundos);
        }
	}
}
