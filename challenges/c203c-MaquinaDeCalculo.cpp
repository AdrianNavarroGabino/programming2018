/*
    Calculates basic operations
*/

/*
Example of input
5
5 + -13
10 / 2
7 * 3
3 / 0
5 - 13
Example of output
-8
5
21
ERROR
-8
*/

// Adrián Navarro Gabino

#include <iostream>

using namespace std;

int main()
{
    int casosPrueba;
    cin >> casosPrueba;
    
    short int dato1, dato2;
    char operacion;
    
    for(int i = 0; i < casosPrueba; i++)
    {
        cin >> dato1 >> operacion >> dato2;
        
        switch(operacion)
        {
            case '+':
                cout << dato1 + dato2 << endl;
                break;
            case '-':
                cout << dato1 - dato2 << endl;
                break;
            case '*':
                cout << dato1 * dato2 << endl;
                break;
            case '/':
                if(dato2 != 0)
                {
                    cout << dato1 / dato2 << endl;
                }
                else
                {
                    cout << "ERROR" << endl;
                }
                break;
            default:
                break;
        }
    }
    
    return 0;
}
