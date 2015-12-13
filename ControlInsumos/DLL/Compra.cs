/*
 * Usuario: Ricardo Carrasco
 * Fecha: 30-06-2015
 * Hora: 13:06
 */
using System;
using System.Globalization;

namespace ControlInsumos.DLL
{
	/// <summary>
	/// Description of Compra.
	/// </summary>
	public class Compra
	{
        private int idCompra;
		private int numeroDoc;
		private string fecha;
		private int idArticulo;
		private int idItem;
		private int cantidad;
		private string precio;
		public Compra()
		{
			
		}
        public int IdCompra
        {
            get { return idCompra; }
            set { idCompra = value; }
        }
		public int NumeroDoc {
			get { return numeroDoc; }
			set { numeroDoc = value; }
		}
		
		public string Fecha {
			get { return fecha; }
			set { fecha = value; }
		}
		
		public int IdArticulo {
			get { return idArticulo; }
			set { idArticulo = value; }
		}
		
		public int IdItem {
			get { return idItem; }
			set { idItem = value; }
		}
		
		public int Cantidad {
			get { return cantidad; }
			set { cantidad = value; }
		}

        public string Precio
        {
			get { return precio; }
			set { precio = value; }
		}
		public int insertCompra (Compra p)
		{
			DAL.CompraDal compraDal = new DAL.CompraDal();
			int resultado = compraDal.insertCompra(p);
			return resultado;
		}
	}
}
