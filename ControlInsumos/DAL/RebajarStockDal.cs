/*
 * Usuario: Ricardo Carrasco
 * Fecha: 30-06-2015
 * Hora: 13:06
 */
using System;

namespace ControlInsumos.DAL
{
	/// <summary>
	/// Description of RebajarStockDal.
	/// </summary>
	public class RebajarStockDal
	{
		BaseDeDatosLite b = new BaseDeDatosLite();
		
		public string loadDataGV(string item)
		{
			
			string select = "SELECT i.descripcion , c.cantidad, c.fecha " +
				"FROM item i INNER JOIN compras c " +
				"ON i.idItem = c.idItem INNER JOIN articulo a " +
				"ON i.idArticulo = a.idArticulo " +
				"WHERE i.descripcion = '" + item + "';";
			
			return select;
		}
		
		public int insertRebaja(DLL.RebajarStock r)
		{
			return 1;
		}
	}
}
