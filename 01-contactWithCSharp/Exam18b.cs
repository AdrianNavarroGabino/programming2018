// Adrián Navarro Gabino
// 20/09/2018

public class examen01anavarro2
{
	public static void Main()
	{
		int millas; // input
		int yardas, pies;//result
		int yardasMillares, yardasCien, piesMillares, piesCien; //result2
		
		System.Console.Write("Introduce la distancia en millas: ");
		millas = System.Convert.ToInt32(System.Console.ReadLine());
		
		yardas = millas * 1760;
		pies = millas * 1760 * 3; // O bien, pies = yardas * 3;
		
		System.Console.WriteLine("{0} millas son {1} yardas", millas, yardas);
		System.Console.WriteLine("{0} millas son {1} pies", millas, pies);
		
		yardasMillares = yardas / 1000;
		yardasCien = yardas - yardasMillares * 1000;
		piesMillares = pies / 1000;
		piesCien = pies - piesMillares * 1000;
		
		System.Console.WriteLine("{0} millas son {1}.{2} yardas",
            millas, yardasMillares, yardasCien);
		System.Console.WriteLine("{0} millas son {1}.{2} pies",
            millas, piesMillares, piesCien);
	}
}
