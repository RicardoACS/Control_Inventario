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
            //Cargará el DataView con los datos
            string select = "SELECT i.descripcion AS 'Descripción' , c.cantidad AS 'Cantidad', c.fecha AS 'Fecha', c.precio AS 'Precio' " +
				"FROM item i INNER JOIN compras c " +
				"ON i.idItem = c.idItem INNER JOIN articulo a " +
				"ON i.idArticulo = a.idArticulo " +
				"WHERE i.descripcion = '" + item + "';";
			
			return select;
		}
		
		public int insertRebaja(DLL.RebajarStock r)
		{
            //Insertará en la BD la rebaja, esto retornará un número el cual indicará el resultado de la consulta
            string insert = "INSERT INTO rebajarStock VALUES (" + r.IdRebajarStock + "," + r.IdItem + "," + r.IdLocal + "," + r.Cantidad + ",'" + r.Fecha + "');";
            return b.executecommand(insert);
      
			
		}
        public int countRebajaStock()
        {
            int count = 0;
            string sql = "SELECT COUNT(idRebajarStock)+1 FROM rebajarStock;";
            count = int.Parse(b.selectstring(sql));
            return count;
        }
        public int maxRebajaStock()
        {
            int count = 0;
            string sql = "SELECT MAX(idRebajarStock)+1 FROM rebajarStock;";
            count = int.Parse(b.selectstring(sql));
            return count;
        }

	}
}
