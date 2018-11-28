// Adrián Navarro Gabino

#include <iostream>

using namespace std;

int main()
{
    int casosPrueba;
    cin >> casosPrueba;
    
    int art1, art2, art3, art4, art5;
    
    int patasTotales;
    
    for(int i = 0; i < casosPrueba; i++)
    {
        patasTotales = 0;
        
        cin >> art1 >> art2 >> art3 >> art4 >> art5;
        
        patasTotales = art1 * 6 + art2 * 8 + art3 * 10 + art4 * art5* 2;
        
        cout << patasTotales << endl;
    }
    
    return 0;
}
