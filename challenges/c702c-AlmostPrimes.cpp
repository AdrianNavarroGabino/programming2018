// Adrián Navarro Gabino

#include <iostream>
#include <math.h>

using namespace std;

bool IsPrime(int number)
{
    for(int i = 2; i <= sqrt(number); i++)
    {
        if(number % i == 0)
            return false;
    }
    
    return true;
}

bool IsAlmostPrime(int number)
{
    for(int i = 2; i <= sqrt(number); i++)
        if(number % i == 0 && IsPrime(i))
            if(IsPrime(number / i))
                return true;
    
    return false;
}
    
    
int main()
{
    int cases;
    cin >> cases;
    
    for(int currentCase = 0; currentCase < cases; currentCase++)
    {
        int lowerLimit;
        int upperLimit;
        
        cin >> lowerLimit >> upperLimit;
        
        int count = 0;
        
        for(int i = lowerLimit; i <= upperLimit; i++)
        {
            if(IsAlmostPrime(i))
                count++;
        }
        
        cout << count << endl;
    }
}
