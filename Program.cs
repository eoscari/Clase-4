/*
 * Created by SharpDevelop.
 * User: franco
 * Date: 1/9/2016
 * Time: 6:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace CodigoActividad3
{
	class Program
	{
		public static void Main(string[] args)
		{
			List<cliente> clientes = new List<cliente>();
			Console.WriteLine("CLÍNICA VETERINARIA: SUPERANIMALS");
            Console.Write("Ingrese el cliente: ");
            String cliente = Console.ReadLine();
                       
			Console.ReadKey(true);
		}
	}
}