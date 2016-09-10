/*
 * Created by SharpDevelop.
 * User: franco
 * Date: 2/9/2016
 * Time: 10:39 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace CodigoActividad3
{
	/// <summary>
	/// Description of mascota.
	/// </summary>
	public class mascota
	{
		public string nombre;
		private int codigo;
		private string especie;
		private string raza;
		private DateTime fechaNacimiento;
		private List<peso> pesos;
		private List<vacuna> carnetVacunacion;
		private List<historial> ficha;
			
		public mascota(string nombre, string especie, string raza, int codigo, DateTime fecha)
		{
			this.especie = especie;
			this.codigo = codigo;
			this.nombre = nombre;
			this. raza = raza;
			this.fechaNacimiento = fecha;
			pesos = new List<peso>();
			carnetVacunacion = new List<vacuna>();
			ficha = new List<historial>();
		}
		public int Codigo{
			//Getter y Setter del atributo Codigo
			get{return codigo;}
			set{codigo = value;}
		}
		
		public string Nombre{
			//Getter y Setter del atributo Nombre
			get{return nombre;}
			set{nombre = value;}
		}
		
		public string Especie{
			//Getter y Setter del atributo Especie
			get{return especie;}
			set{especie = value;}
		}
		
		public string Raza{
			//Getter y Setter del atributo Raza
			get{return raza;}
			set{raza = value;}
		}
		
		public DateTime Nacimiento{
			//Getter y Setter del atributo Fecha de Nacimiento
			get{return fechaNacimiento;}
			set{fechaNacimiento = value;}
		}
		public void agregarPeso(peso peso){
			//Agregar un nuevo peso de la mascota
			pesos.Add(peso);
		}
		public void agregarVacuna(vacuna vacuna){
			//Agregar una nueva vacuna realizada a la mascota
			carnetVacunacion.Add(vacuna);
		}
		public void agregarVisita(historial visita){
			//Agregar una nueva visita de la mascota
			ficha.Add(visita);
		}
		public float pesoMedio(){
			//Retorna el peso medio de la mascota
			float suma = 0;
			
			foreach(peso item in pesos){
				suma += item.Peso;
			}
			return (suma/(pesos.Count));
		}
		public DateTime ultimaVacuna(){
			//retorna la última fecha de vacunación
			return carnetVacunacion[carnetVacunacion.Count-1].FechaProxima;
		}
		public DateTime ultimaVisita(){
			//retorna la última fecha de vacunación
			return ficha[ficha.Count-1].FechaProximaVisita;
		}
	}
}
