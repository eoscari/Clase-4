/*
 * Created by SharpDevelop.
 * User: franco
 * Date: 2/9/2016
 * Time: 10:35 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace CodigoActividad3
{
	/// <summary>
	/// Description of cliente.
	/// </summary>
	public class cliente
	{
		private string nombre;
		private string telefono;
		private List<mascota> mascotas;


        //SACAMOS EL CONSTRUCTOR SIN PARAMETROS PORQUE NO TIENE 
        //SENTIDO UN CONSTRUCTOR SIN PARAMETROS
		/*public cliente()
		{
			mascotas = new List<mascota>();
		}*/
		
		public cliente(string nombre, string telefono)
		{
			this. Telefono = telefono;
			this. Nombre = nombre;
			mascotas = new List<mascota>();
		}

		public string Telefono{
			//Getter y Setter del atributo teléfono
			get{return telefono;}
			set{telefono = value;}
		}

		public string Nombre{
			//Getter y Setter del atributo Nombre
			get{return nombre;}
			set{nombre = value;}
		}
		public List<mascota> Mascotas{
			//Getter y Setter del atributo Lista de Mascota
			get{return mascotas;}
			set{mascotas = value;}
		}
		public void agregarMascota(mascota animal){
		//Agrega una nueva mascota a la colección de mascotas de un determinado cliente
			mascotas.Add(animal);
		}
		public mascota buscaMascota(string nombre){
			for(int i=0; i< mascotas.Count;i++){
				if (mascotas[i].nombre == nombre){
					return mascotas[i];
				}
			}
			return null;
		}
		public void debeVolver(){
			//Muestra por pantalla las mascotas que deben volver al veterinario
			List<mascota> debenVolver = new List<mascota>();
			Boolean porVacunacion = false; //indica que debe volver por temas relacionado a  vacunacion
			Boolean porControl = false; //indica que debe volver para control o temas relacionados
			DateTime ultimaFecha;
			
			for(int i=0; i<mascotas.Count;i++){
				porVacunacion = false;
				porControl = false;
				//Determino si debe volver por que requiere la reapliación de una dosis
				ultimaFecha = mascotas[i].ultimaVacuna();
				if((ultimaFecha<= DateTime.Now) && (DateTime.Now<=ultimaFecha.AddDays(3))){
					porVacunacion = true;
				}
				//Determino si debe volver por control
				ultimaFecha = (DateTime) mascotas[i].ultimaVisita();
				if((ultimaFecha<= DateTime.Now) && (DateTime.Now<=ultimaFecha.AddDays(3))){
					porVacunacion = true;
				}
				if((porVacunacion) && (porControl)){
					debenVolver.Add(mascotas[i]);
				}
			}
			foreach(mascota item in mascotas){
				Console.WriteLine("Mascota ", item.Nombre);
				Console.WriteLine("Especie ", item.Especie);
				Console.WriteLine("Raza ", item.Raza);
			}
		}
	}
}
