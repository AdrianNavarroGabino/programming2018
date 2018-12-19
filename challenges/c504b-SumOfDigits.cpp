// Adrián Navarro Gabino

#include <iostream>
#include <string>

using namespace std;

int main()
{
    string number;
    int digit;
    
    do
    {
        int sum = 0;
            
        cin>> number;
        
        if(number[0] != '-')
        {
            for(unsigned int i = 0; i < number.length() - 1; i++)
            {
                digit = (int)number[i] - '0';
                
                sum += digit;
                
                cout << digit << " + ";
            }
            
            digit = (int)number[number.length() - 1] - '0';
                
            sum += digit;
            
            cout << digit << " = " << sum << endl;
        }
    } while(number[0] != '-');

    return 0;
}
