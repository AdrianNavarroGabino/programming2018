/*
 * Suma y producto
 * Adrián Navarro Gabino
*/

using System;

public class examen01anavarro1
{
	public static void Main()
	{
		int a, b; // input
		int suma, prod; // result
		
		Console.Write("Introduce el primer número: ");
		a = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce el segundo número: ");
		b = Convert.ToInt32(Console.ReadLine());
		
		suma = a + b;
		prod = a * b;
		
		Console.Write("Su suma es: ");
		Console.WriteLine(suma);
		Console.Write("Su producto es: ");
		Console.WriteLine(prod);
	}
}
