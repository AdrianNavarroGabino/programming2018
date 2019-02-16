// Adrián Navarro Gabino

using System;

class MisionBikini
{
    static void Main()
    {
        int casosDePrueba = Convert.ToInt32(Console.ReadLine());
        
        int[] pesos = new int[casosDePrueba];
        int[] alturas = new int[casosDePrueba];
        
        for(int i = 0; i < casosDePrueba; i++)
        {
            string[] datos = Console.ReadLine().Split();
            
            pesos[i] = Convert.ToInt32(datos[0]);
            alturas[i] = Convert.ToInt32(datos[1]);
        }
        
        for(int i = 0; i < casosDePrueba - 1; i++)
        {
            for(int j = i + 1; j < casosDePrueba; j++)
            {
                if(pesos[i] < pesos[j])
                {
                    int auxPeso = pesos[i];
                    int auxAltura = alturas[i];
                    pesos[i] = pesos[j];
                    alturas[i] = alturas[j];
                    pesos[j] = auxPeso;
                    alturas[j] = auxAltura;
                }
                else if(pesos[i] == pesos[j])
                {
                    if(alturas[i] > alturas[j])
                    {
                        int auxPeso = pesos[i];
                        int auxAltura = alturas[i];
                        pesos[i] = pesos[j];
                        alturas[i] = alturas[j];
                        pesos[j] = auxPeso;
                        alturas[j] = auxAltura;
                    }
                }
            }
        }
        
        for(int i = 0; i < casosDePrueba; i++)
        {
            Console.WriteLine(pesos[i] + " " + alturas[i]);
        }
    }
}
