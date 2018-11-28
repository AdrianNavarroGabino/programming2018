/*
Entrada de ejemplo
4
C-3PO
creador
Luke
padre
Princesa
Principe
Luke
Padre
Salida de ejemplo
C-3PO, yo soy tu creador
TOP SECRET
Princesa, yo soy tu Principe
Luke, yo soy tu Padre
*/

// Adrián Navarro Gabino

#include <iostream>

using namespace std;

int main()
{
    int cases;
    cin >> cases;
    
    for(int i = 0; i < cases; i++)
    {
        string name;
        string relationship;
        
        cin >> name >> relationship;
        
        if(name != "Luke" || relationship != "padre")
        {
            cout << name << ", yo soy tu " << relationship << endl;
        }
        else
        {
            cout << "TOP SECRET" << endl;
        }
    }
    return 0;
}
