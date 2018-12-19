// Adrián Navarro Gabino

#include <stdio.h>
#include <math.h>

int IsPrime(int number)
{
    for(int i = 2; i <= sqrt(number); i++)
    {
        if(number % i == 0)
            return 0;
    }
    
    return 1;
}

int IsAlmostPrime(int number)
{
    for(int i = 2; i <= sqrt(number); i++)
        if(number % i == 0 && IsPrime(i))
            if(IsPrime(number / i) == 1)
                return 1;
    
    return 0;
}
    
    
int main()
{
    int cases;
    scanf("%d", &cases);
    
    for(int currentCase = 0; currentCase < cases; currentCase++)
    {
        int lowerLimit;
        int upperLimit;
        
        scanf("%d", &lowerLimit);
        scanf("%d", &upperLimit);
        
        int count = 0;
        
        for(int i = lowerLimit; i <= upperLimit; i++)
        {
            if(IsAlmostPrime(i) == 1)
                count++;
        }
        
        printf("%d\n", count);
    }
}
