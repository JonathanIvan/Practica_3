using System;
using System.Collections;

namespace Practica4
{
	class PrincipalClass
	{
		static void Main(string[] args)
		{
			Hashtable hashtable = new Hashtable();

			for (int i = 0; i < 4; i++)
			{
				Persona persona = new Persona();
				
				Console.WriteLine("INTRODUZCA EL CODIGO:\n");
				persona.codigo = Console.ReadLine();
				
				Console.WriteLine("\nINTRODUZCA TU NOMBRE:");
				persona.nombre = Console.ReadLine();
				
				Console.WriteLine("\nINTRODUZCA TU DOMICILIO:");
				persona.domicilio = Console.ReadLine();
				
				Console.WriteLine("\nINTRODUZCA EL FACEBOOK:");
				persona.facebook = Console.ReadLine();
				
				Console.WriteLine("\nINTRODUZCA DE CELULAR:");
				persona.telefono = Console.ReadLine();
				
				Console.Clear();
				
				hashtable.Add(persona.codigo,persona);
			} 
			
			
		}
		public void imprimir()
		{
			imprimePersona persona = persona;
			
			Console.WriteLine();
			foreach (object objeto in persona)
			{
				Persona.persona = (Persona)objeto;
				imprimePersona(persona);
				Console.ReadLine(); 
			}
		}
		
		
		private void imprimePersona(Persona persona)
		{
			Console.WriteLine("EL CODIGO ES: ", persona.codigo);
			Console.WriteLine("NOMBRE: ", persona.nombre);
			Console.WriteLine("DOMICILIO: ", persona.domicilio);
			Console.WriteLine("TELEFONO: ",persona.telefono);
			Console.WriteLine("FACEBOOK: ",persona.facebook);
			
			Console.ReadLine();
		}
		
		
		
		public void borrar()
		{
			for (int i = 0; i < 4; i++)
			{
				Console.Clear();
				string codigo = "";
				
				Console.WriteLine("INTRODUZCA EL CODIGO QUE DESEA ELIMINAR \n");
				codigo = Console.ReadLine();
				
				if (hashtable.ContainsKey(codigo))
				{
					Persona persona = persona.codigo;
					imprimePersona(persona);
					
					Console.WriteLine("CONFIRMAR SU ELIMINACION\n",persona.codigo);
				}
				else
				{
					
					Console.WriteLine("ERROR");
				}
			}
		}
		
		public void confirmarsueliminacion(string codigo)
		{
			Console.WriteLine("DESEA ELIMINAR ESTE CODIGO\n");
			Console.WriteLine("0 = NO, 1 = SI");
			string opcion = Console.ReadLine();
			
			if (opcion != "0")
			{
				Console.WriteLine("CODIGO ELIMINADO",persona.codigo);
				Console.ReadLine();
			}
		}
		
		
	}
	
}
