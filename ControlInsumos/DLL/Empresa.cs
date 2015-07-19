/*
 * Creado por SharpDevelop.
 * Usuario: crojo
 * Fecha: 30-06-2015
 * Hora: 15:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ControlInsumos.DLL
{
	/// <summary>
	/// Description of Empresa.
	/// </summary>
	public class Empresa
	{
		private int idEmpresa;
		private string nombre;
		
		public Empresa()
		{
			
		}
		public int IdEmpresa {
			get { return idEmpresa; }
			set { idEmpresa = value; }
		}
		
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}
		
		public int insertEmpresa (Empresa e)
		{
			DAL.EmpresaDal empresaDal = new DAL.EmpresaDal();
			int resultado = empresaDal.insertEmpresa(e);
			return resultado;
		}
	}
}
