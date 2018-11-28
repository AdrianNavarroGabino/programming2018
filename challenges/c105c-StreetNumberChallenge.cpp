// Adrián Navarro Gabino

#include <iostream>

using namespace std;

int main()
{
    int streetNumber;
        
    do
    {
        cin >> streetNumber;
        
        if( (streetNumber != 0) && (streetNumber % 2 == 0) )
            cout << "DERECHA" << endl;
        else if (streetNumber % 2 == 1)
            cout << "IZQUIERDA" << endl;
    } while(streetNumber != 0);

	return 0;
}
