// Adrián Navarro Gabino

#include <iostream>

using namespace std;

int main()
{
    int cases, day, month;
    
    cin >> cases;
    
    for(int i = 0; i < cases; i++)
    {
        cin >> day;
        cin >> month;
        
        if( (day % 2 == month % 2) || (day == 25 && month == 12) )
            cout << "FESTIVO" << endl;
        else
            cout << "LABORABLE" << endl;
    }

	return 0;
}
