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

#include <iostream>

using namespace std;

int main()
{
    int segundos, minutos, horas;
    int n, tiempo;
    cin >> n;
        
    for(int i = 0; i < n; i++)
    {
        cin >> tiempo;
        
        horas = tiempo / 3600;
        
        if(horas < 10)
            cout << "0" << horas << ":";
        else
            cout << horas << ":";
        
        minutos = (tiempo % 3600) / 60;
        
        if(minutos < 10)
            cout << "0" << minutos << ":";
        else
            cout << minutos << ":";
            
        segundos = tiempo - horas * 3600 - minutos * 60;
        
        if(segundos < 10)
            cout << "0" << segundos << endl;
        else
            cout << segundos << endl;
    }

	return 0;
}
