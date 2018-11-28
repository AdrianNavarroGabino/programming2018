/*
Calculate the minimum number of posts needed to fence an area by
knowing how much it measures and how often a post needs to be placed.
*/

/*
Example of input
10 10 10
6 6 10
10 15 10
0 0 0
Example of output
4
4
6
*/

// Adrián Navarro Gabino

#include <iostream>

using namespace std;

int main()
{
    int ancho, alto, dist;
    cin >> ancho >> alto >> dist;
    
    int postes = 0;
    
    while(ancho != 0 || alto != 0 || dist != 0)
    {
        postes += (ancho / dist) * 2;
        postes += ancho % dist == 0 ? 0 : 2;
        postes += (alto / dist) * 2;
        postes += alto % dist == 0 ? 0 : 2;
        
        cout << postes << endl;
        
        cin >> ancho >> alto >> dist;
        postes = 0;
    }
    
    return 0;
}
