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
	/// Description of vacuna.
	/// </summary>
	public class vacuna
	{
		private DateTime fechaVacunacion;
		private string descripcion;
		private DateTime fechaProxima;
		
		public vacuna(DateTime fechaVacunacion, string descripcion, DateTime fechaProxima)
		{
			this.fechaProxima = fechaVacunacion;
			this.descripcion = descripcion;
			this.fechaVacunacion = fechaProxima;
		}
		
		public DateTime FechaProxima{
		//Getter y Setter del atributo FechaProxima
			get{return fechaProxima;}
			set{fechaProxima = value;}
		}
		
		public DateTime FechaVacunacion{
		//Getter y Setter del atributo FechaVacunacion
			get{return fechaVacunacion;}
			set{fechaVacunacion = value;}
		}
		public string Descripcion{
		//Getter y Setter del atributo Descripcion
			get{return descripcion;}
			set{descripcion = value;}
		}
	}
}
