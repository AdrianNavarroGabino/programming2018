// Adrián Navarro Gabino

using System;

class Contrasenyas
{
    public static bool ClaveCorrecta(string clave)
    {
        bool minuscula = false;
        bool mayuscula = false;
        bool digito = false;
        
        int longitud = clave.Length;
        if(longitud < 12)
            return false;

        int contador = 0;
        
        while(contador < longitud || !minuscula)
        {
            if(clave[contador] >= 'a' && clave[contador] <= 'z')
                minuscula = true;
            contador++;
        }
        
        if(!minuscula)
            return false;
        
        contador = 0;
        
        while(contador < longitud || !mayuscula)
        {
            if(clave[contador] >= 'A' && clave[contador] <= 'Z')
                mayuscula = true;
            contador++;
        }
        
        if(!mayuscula)
            return false;
            
        contador = 0;
        
        while(contador < longitud || !digito)
        {
            if(clave[contador] >= '0' && clave[contador] <= '9')
                digito = true;
            contador++;
        }
        
        if(!digito)
            return false;
        
        EstaSimbolo(clave);
        
        return true;
    }
    
    public static bool EstaSimbolo(string clave)
    {
        foreach(char c in clave)
        {
            switch(c)
            {
                case '+':
                case '_':
                case ')':
                case '(':
                case '*':
                case '&':
                case '^':
                case '%':
                case '$':
                case '#':
                case '@':
                case '!':
                case '.':
                case '/':
                case ',':
                case ';':
                case '{':
                case '}': return true;
            }
        }
        
        return false;
    }
    
    static void Main()
    {
        int casos = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < casos; i++)
        {
            string clave = Console.ReadLine();
            
            if(ClaveCorrecta(clave))
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
