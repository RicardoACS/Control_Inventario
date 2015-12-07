/*
 * Creado por SharpDevelop.
 * Usuario: rcarrasco
 * Fecha: 03-12-2015
 * Hora: 13:11
 * 
 */

using System;

namespace Control_Inventario.DLL
{
	/// <summary>
	/// Description of Insumo.
	/// </summary>
	public class Insumo
	{

		private int idInsumos;
		private int nroGuia;
		private string fechaGuia;
		private int cantidad;
		private string fechaRealizacion;
		private int idArticulo;
		private int idItem;
		private int idLocal;
		
		
		public Insumo()
		{
			
		}
		
		
		public int IdInsumos {
			get { return idInsumos; }
			set { idInsumos = value; }
		}
		
		public int NroGuia {
			get { return nroGuia; }
			set { nroGuia = value; }
		}

        public string FechaGuia
        {
			get { return fechaGuia; }
			set { fechaGuia = value; }
		}
		
		public int Cantidad {
			get { return cantidad; }
			set { cantidad = value; }
		}

        public string FechaRealizacion
        {
			get { return fechaRealizacion; }
			set { fechaRealizacion = value; }
		}
		
		public int IdArticulo {
			get { return idArticulo; }
			set { idArticulo = value; }
		}
		
		public int IdItem {
			get { return idItem; }
			set { idItem = value; }
		}
		
		public int IdLocal {
			get { return idLocal; }
			set { idLocal = value; }
		}
		
	}
}
