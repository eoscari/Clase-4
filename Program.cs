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
			
			mascota masco;
			peso peso_mas;
			vacuna vacuna_mas;
			historial historial_mas1;
			historial historial_mas2;
			int opcion=0;
			int cod=-1;
			List<cliente> ListaC = new List<cliente>();
			List <DateTime> fechas;
			
			Console.WriteLine();			
			Console.WriteLine("CLÍNICA VETERINARIA: SUPER ANIMALS");
			//Agregar Datos para correr la aplicación y hacer que funcione correctamente
			//Considerar Casos de Prueba para el problema.
			do
			{
				Console.WriteLine();
				Console.WriteLine("************MENU*************");
				Console.WriteLine();
				Console.WriteLine("Elija la opcion que desee: ");
				Console.WriteLine();
				Console.WriteLine("1.Cargar Cliente ");
				Console.WriteLine("2.Cargar Mascota");
				Console.WriteLine("3.Informar datos de mascotas");
				Console.WriteLine("4.Salir del sistema");
				Console.WriteLine();
				opcion=Int32.Parse(Console.ReadLine());
				switch (opcion)
				{				
					case 1:
					{
						Console.WriteLine("----------Ingrese datos de cliente----------");
						Console.Write("Ingrese Nombre: ");
						String n =(Console.ReadLine());
						Console.Write("Ingrese telefono: ");
						String t=(Console.ReadLine());
						Console.Write("Ingrese Dni: ");
						String d=(Console.ReadLine());
						Console.WriteLine();						
						ListaC.Add(new cliente(n,t,d));						
						break;
					}
					case 2:
					{
						Console.Write("Ingrese Dni del cliente: ");//BUSCA CLIENTE PARA AGREGARLE SUS MASCOTAS
						string d=(Console.ReadLine());
						Console.WriteLine();	
						ListaC[ListaC.LastIndexOf(d.ToString)];
												
						if (cliente1 != null)
						{
							String resp="SI";
							Console.WriteLine("----------Ingrese datos de mascota ----------");
							while (resp != "NO")
							{
								Console.Write("Ingrese Especie del Animal (Gato,Perro,Conejo,Roedor, Etc): ");
								String e=(Console.ReadLine());
								Console.Write("Ingrese Nombre: ");
								String no=(Console.ReadLine());
								Console.Write("Ingrese Raza: ");
								String r=(Console.ReadLine());
								Console.Write("Ingrese Fecha de Nacimiento: ");
								DateTime fn=DateTime.Parse(Console.ReadLine());
								Console.WriteLine();
								masco=new mascota(no,e,r,cod++,fn);
								
								//fechas=new List <DateTime>();
								//DateTime fe_p1;
								//DateTime fe_p2;
								DateTime fe=DateTime.Now;
								Console.Write("Ingrese descripcion de visita: ");//datos de la visita
								string dvi=Console.ReadLine();			
								Boolean bandera1= true;
								Boolean bandera2=true;
								
								
								do
								{
									
									Console.WriteLine();
									Console.WriteLine("Elija la opcion que desee: ");
									Console.WriteLine();
									Console.WriteLine("1.Cargar Peso");
									Console.WriteLine("2.Cargar Vacuna");
									Console.WriteLine("3.Salir");
									Console.WriteLine();
									opcion=Int32.Parse(Console.ReadLine());
									//switch (opcion)			
									if ((opcion==1) && (bandera1))
									{
										//case 1:
										//{
											Console.WriteLine("----------Ingrese Peso de mascota ----------");
											Console.Write("Ingrese el Peso: ");
											float pe=float.Parse(Console.ReadLine());
											//Console.Write("Ingrese fecha de la proxima control: ");
											//DateTime fe_p1=DateTime.Parse(Console.ReadLine());
											//fechas.Add(fe_p1);
											peso_mas=new peso(pe,fe);//,fe_p1);
											masco.agregarPeso(peso_mas);
											Console.WriteLine();
											bandera1=false;
											//break;
									}
									else if ((opcion==2) && (bandera2))
										//case 2:
										{
											Console.WriteLine("----------Ingrese vacuna de mascota ----------");
											Console.Write("Ingrese descripcion de vacuna: ");
											string dv=Console.ReadLine();
											Console.Write("Ingrese fecha de la proxima vacuna: ");
											DateTime fe_p2=DateTime.Parse(Console.ReadLine());
											//fechas.Add(fe_p2);
											vacuna_mas=new vacuna(fe,dv,fe_p2);
											masco.agregarVacuna(vacuna_mas);
											Console.WriteLine();
											bandera2=false;
											Console.WriteLine("ultima fecha de vacuna "+masco.ultimaVacuna());
											
											//break;
										}
									else
									{	//default:
											Console.WriteLine("Esa opcion no es o ya no es valida");
											//Console.ReadKey(true);
											//break;
									}
								}while (opcion != 3);
								Console.Write("Ingrese fecha de la proxima visita: ");
								DateTime fe_p1=DateTime.Parse(Console.ReadLine());
								//if (fechas.Count==1)
								//{
								historial_mas1=new historial(dvi,fe, fe_p1);//fechas[0]);
									//masco.agregarVisita(historial_mas1);		
								//}
								//else 
								//{
								//	if (fechas[0]>fechas[1])
								//	{
								//		historial_mas2=new historial(dvi,fe,fechas[1]);
								//		masco.agregarVisita(historial_mas2);		
								//	}
								//}
											
								
								Console.Write("Desea agregar otra mascota? Resp: SI/NO: ");
								resp=(Console.ReadLine());
								Console.WriteLine();				
								Console.WriteLine("------------------------------------------------------");
								cliente1.agregarMascota(masco);
								
								cliente1.debeVolver();
								//cli.debeVolver();													
							}
						}
						else 
						{
							Console.WriteLine("Ese cliente no esta cargado");
						}		
						break;	
					}
					case 3: 
					{	//INFORMAR LAS MASCOTAS QUE TIENEN CONTROL EN LOS ULTIMOS 3 DIAS
						
						break;
					}
					default: 
						Console.Write("La opcion elejida no es valida");
						break;
				}
					
			}while (opcion != 4);
			
			//Console.ReadKey(true);
		}
	}
}