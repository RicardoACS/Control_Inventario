/*
 * Usuario: Ricardo Carrasco
 * Fecha: 30-06-2015
 * Hora: 13:06
 */
using System;

namespace ControlInsumos.DLL
{
	/// <summary>
	/// Description of RebajarStock.
	/// </summary>
	public class RebajarStock
	{
		private int idRebajarStock;
		private int idItem;
		private int idLocal;
		private int cantidad;
        private string fecha;
        private int nroGuia;
        private string fechaGuia;  
		
		public RebajarStock()
		{
			
		}
        
		
		public RebajarStock(int idRebajarStock, int idItem, int idLocal, int cantidad)
		{
			this.idRebajarStock = idRebajarStock;
			this.idItem = idItem;
			this.idLocal = idLocal;
			this.cantidad = cantidad;
		}

        public string FechaGuia
        {
            get { return fechaGuia; }
            set { fechaGuia = value; }
        }


        public int NroGuia
        {
            get { return nroGuia; }
            set { nroGuia = value; }
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

		public int IdRebajarStock {
			get { return idRebajarStock; }
			set { idRebajarStock = value; }
		}
		
		public int IdItem {
			get { return idItem; }
			set { idItem = value; }
		}
		
		public int IdLocal {
			get { return idLocal; }
			set { idLocal = value; }
		}
		
		public int Cantidad {
			get { return cantidad; }
			set { cantidad = value; }
		}
		
		
	}
}
