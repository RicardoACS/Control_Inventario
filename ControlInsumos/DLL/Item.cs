/*
 * Creado por SharpDevelop.
 * Usuario: crojo
 * Fecha: 30-06-2015
 * Hora: 11:59
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ControlInsumos.DLL
{
	/// <summary>
	/// Description of Item.
	/// </summary>
	public class Item
	{
		private int idItem;
		private string descripcion;
		private int idArticulo;
		public Item()
		{
			
		}
		
		public Item(int idItem, string descripcion, int idArticulo)
		{
			this.idItem = idItem;
			this.descripcion = descripcion;
			this.idArticulo = idArticulo;
		}
		public int IdItem 
		{
			get { return idItem; }
			set { idItem = value; }
		}
		
		public string Descripcion 
		{
			get { return descripcion; }
			set { descripcion = value; }
		}
		
		public int IdArticulo 
		{
			get { return idArticulo; }
			set { idArticulo = value; }
		}
		public int insertItem (Item i)
		{
			DAL.ItemDal itemDal = new DAL.ItemDal();
			int resultado = itemDal.insertItem(i);
			return resultado;
		}
			
	}
}
