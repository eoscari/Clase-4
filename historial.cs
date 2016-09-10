/*
 * Created by SharpDevelop.
 * User: franco
 * Date: 2/9/2016
 * Time: 10:49 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CodigoActividad3
{
	/// <summary>
	/// Description of historial.
	/// </summary>
	public class historial
	{
		private DateTime fechaVisita;
		private string descripcion;
		private DateTime fechaProximaVisita;
		
		public historial(string descripcion, DateTime fechaVisita, DateTime fechaproximaVisita)
		{
			this.descripcion = descripcion;
			this.FechaProximaVisita = fechaproximaVisita;
			this.FechaVisita = fechaVisita;
			// Son dos formas de inicializar los atributos utilizando los setters o bien 
			// Referenciando directamente el atributo.
		}
		
		public DateTime FechaProximaVisita{
			//Getter y Setter del atributo fechaProximaVisita
			get{return fechaProximaVisita;}
			set{fechaProximaVisita = value;}
		}
		public string Descripcion{
			//Getter y Setter del atributo Descripcion
			get{return descripcion;}
			set{descripcion = value;}
		}
		public DateTime FechaVisita{
			//Getter y Setter del atributo fechaVisita
			get{return fechaVisita;}
			set{fechaVisita = value;}
		}
	}
}
