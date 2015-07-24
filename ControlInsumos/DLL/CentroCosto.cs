/*
 * Usuario: Ricardo Carrasco
 * Fecha: 30-06-2015
 * Hora: 13:06
 */
using System;

namespace ControlInsumos.DLL
{
	/// <summary>
	/// Description of CentroCosto.
	/// </summary>
	public class CentroCosto
	{
		private int idCC;
		private string nombre;
		private int idEmpresa;
		
		public CentroCosto()
		{
			
		}
		
		public int IdCC {
			get { return idCC; }
			set { idCC = value; }
		}
		
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}
		
		public int IdEmpresa {
			get { return idEmpresa; }
			set { idEmpresa = value; }
		}
		
		public int insertCc (CentroCosto c)
		{
			DAL.CentroCostoDal cc = new DAL.CentroCostoDal();
			int resultado = cc.insertCC(c);
			return resultado;
		}
	}
}
