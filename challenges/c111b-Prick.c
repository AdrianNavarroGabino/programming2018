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

#include <stdio.h>

int main()
{
	int cases;
	int start, prick;
	int i;

	scanf("%d", &cases);

	for(i = 0; i < cases; i++)
	{
		scanf("%d", &start);
		scanf("%d", &prick);

		prick -= start;

		if(prick == 0 || prick == 180 || prick == -180)
		{
			printf("DA IGUAL\n");
		}
		else if((prick > 0 && prick < 180) || (prick < -180 && prick > -360))
		{
			printf("ASCENDENTE\n");
		}
		else
		{
			printf("DESCENDENTE\n");
		}
	}

	return 0;
}
