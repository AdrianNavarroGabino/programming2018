/*
Entrada de ejemplo
8
100 -10
-10 -100
-10 100
100 -1000
2500 -2490
9500 -9500
-100 99
50 -50
Salida de ejemplo
SI
NO
SI
NO
SI
SI
NO
SI
*/

// Adrián Navarro Gabino

#include <iostream>

using namespace std;

int main()
{
    // En C++ no hacen falta arrays para leer en una línea
    
    int casosPrueba;
    cin >> casosPrueba;
    
    int dineroActual;
    int gastosPrevistos;
    
    string respuesta;
    
    for(int i = 0; i < casosPrueba; i++)
    {
        cin >> dineroActual >> gastosPrevistos;
        
        respuesta = dineroActual + gastosPrevistos >= 0 ? "SI" : "NO";
        
        cout << respuesta << endl;
    }
    
    return 0;
}
