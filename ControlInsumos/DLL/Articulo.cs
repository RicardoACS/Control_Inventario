/*
 * Usuario: Ricardo Carrasco
 * Fecha: 30-06-2015
 * Hora: 13:06
 */
using System;

namespace ControlInsumos.DLL
{
	/// <summary>
	/// Description of Articulo.
	/// </summary>
	public class Articulo
	{
		private int idArticulo;
		private string nombreArticulo;
		
		public Articulo()
		{	



		}	
		
		public Articulo(int idArticulo, string nombreArticulo)
		{
			this.idArticulo = idArticulo;
			this.nombreArticulo = nombreArticulo;
		}
		
		public int IdArticulo 
		{
			get { return idArticulo; }
			set { idArticulo = value; }
		}
		
		public string NombreArticulo
		{
			get { return nombreArticulo; }
			set { nombreArticulo = value; }
		}
		
		public int insertArt (Articulo a)
		{
			DAL.ArticuloDal art = new DAL.ArticuloDal();
			int resultado = art.insertArt(a);
			return resultado;
		}
	}
}
