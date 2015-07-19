/*
 * Creado por SharpDevelop.
 * Usuario: crojo
 * Fecha: 03-07-2015
 * Hora: 15:30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
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
