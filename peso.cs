/*
 * Created by SharpDevelop.
 * User: franco
 * Date: 2/9/2016
 * Time: 10:48 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CodigoActividad3
{
	/// <summary>
	/// Description of peso.
	/// </summary>
	public class peso
	{
		private float pesoMedido;
		private DateTime fecha;
		//private DateTime fechaProxima;
		
		public peso(float peso, DateTime fecha)//,DateTime fecha_p)
		{
			this.Peso = peso;
			this.fecha = fecha;
			//this.fechaProxima=fecha_p;
			// Son dos formas de inicializar los atributos utilizando los setters o bien 
			// Referenciando directamente el atributo.
		}
		
		//public DateTime FechaProxima{
		//Getter y Setter del atributo FechaProxima
		//	get{return fechaProxima;}
		//	set{fechaProxima = value;}
		//}
		
		public float Peso{
		//Getter y Setter del atributo pesoMedido
			get{return pesoMedido;}
			set{pesoMedido = value;}
		}
		
		public DateTime FechaPeso{
		//Getter y Setter del atributo fecha
			get{return fecha;}
			set{fecha = value;}
		}
	}
}
