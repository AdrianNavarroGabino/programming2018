/*
Reto 1.02: Hola mundo (Acepta 116)
Entrada de ejemplo
3
Salida de ejemplo
Hola mundo.
Hola mundo.
Hola mundo.
*/

// Adrián Navarro Gabino

import java.util.*;

public class HolaMundo{
	public static void main(String[] args){
        Scanner entrada = new Scanner(System.in);
        int n = entrada.nextInt();
        
        for(int i = 0; i < n; i++)
            System.out.println("Hola mundo.");
	}
}
