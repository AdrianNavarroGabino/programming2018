/*
Entrada de ejemplo
7
90
91
359
2
0
359
91
90
0
180
180
0
90
270
Salida de ejemplo
ASCENDENTE
ASCENDENTE
DESCENDENTE
DESCENDENTE
DA IGUAL
DA IGUAL
DA IGUAL
*/

// Adrián Navarro Gabino

import java.util.*;

public class Prick
{
	 public static void main(String[] args)
	 {
	 	int cases;
	 	int start, prick;

	 	Scanner scan = new Scanner(System.in);

	 	cases = scan.nextInt();

	 	for(int i = 0; i < cases; i++)
	 	{
	 		start = scan.nextInt();
	 		prick = scan.nextInt();

	 		prick -= start;

	 		if(prick == 0 || prick == 180 || prick == -180)
	 		{
	 			System.out.println("DA IGUAL");
	 		}
	 		else if((prick > 0 && prick < 180) ||
                    (prick < -180 && prick > -360))
	 		{
	 			System.out.println("ASCENDENTE");
	 		}
	 		else
	 		{
	 			System.out.println("DESCENDENTE");
	 		}
	 	}
	 }
}
