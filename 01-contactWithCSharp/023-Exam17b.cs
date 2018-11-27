/* 
 * Adrián Navarro Gabino
 * 19/09/2017
*/

using System;

public class Exam17b
{
	public static void Main()
	{
	int libras;
	int onzas, gramosPorMil;
	
	Console.Write("Introduce un número: ");
	libras = Convert.ToInt32(Console.ReadLine());
	
	onzas = libras * 16;
	gramosPorMil = libras * 453592;
	
	System.Console.WriteLine("{0} libras son {1} onzas", libras, onzas);
	System.Console.WriteLine("{0} libras son {1} gramos", libras,
        gramosPorMil /1000.0);
	}
}
