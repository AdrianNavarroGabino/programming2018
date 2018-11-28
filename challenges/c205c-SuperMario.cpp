/*
Entrada de ejemplo
3
8
1 4 2 2 3 5 3 4
2
9 9
5
1 2 3 4 5
Salida de ejemplo
4 2
0 0
4 0
*/

// Adrian Navarro Gabino

#include <iostream>

using namespace std;

int main()
{
    short int casosPrueba;
    cin >> casosPrueba;
    
    int tamanyo;
    
    int saltoUp, saltoDown;
    
    for(int i = 0; i < casosPrueba; i++)
    {
        saltoUp = 0;
        saltoDown = 0;
        
        cin >> tamanyo;
        
        int muros[tamanyo];
        
        for(int j = 0; j < tamanyo; j++)
        {
            cin >> muros[j];
        }
        
        for(int j = 1; j < tamanyo; j++)
        {
            if(muros[j] < muros[j-1])
            {
                saltoDown++;
            }
            else if(muros[j] > muros[j-1])
            {
                saltoUp++;
            }
        }
        
        cout << saltoUp << " " << saltoDown << endl;
    }
    
    
}
