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
            string insert = "INSERT INTO rebajarStock VALUES (" + r.IdRebajarStock + "," + r.IdItem + "," 
                          +  r.IdLocal + "," + r.Cantidad + ",'" + r.Fecha + "'," + r.NroGuia + ",'" + r.FechaGuia + "');";
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
        public int eliminarRegistro(int idLocal)
        {
            string sql = "DELETE FROM rebajarStock WHERE Idlocal = " + idLocal + ";";
            return b.executecommand(sql);
        }

        public string reporteStockDisponible(string nombreArticulo)
        {
            string sql = "";
            
            if(nombreArticulo.Equals("Todos"))
            {
                sql = "SELECT c.numeroDoc AS 'Nª de Doc', c.fecha AS 'Fecha', i.descripcion AS 'Descripción', " 
                    + "c.precio AS 'Precio Unitario', sum(c.cantidad) AS 'Saldo Físico', (c.precio * SUM(c.cantidad)) AS 'Total Físico' "
                    + "FROM compras c INNER JOIN item i ON c.idItem = i.idItem "
                    + "INNER JOIN articulo a ON c.idArticulo = a.idArticulo "
                    + "GROUP BY i.idItem "
                    + "ORDER BY 3;";
            }
            else
            {
                sql = "SELECT c.numeroDoc AS 'Nª de Doc', c.fecha AS 'Fecha', i.descripcion AS 'Descripción', "
                    + "c.precio AS 'Precio Unitario', sum(c.cantidad) AS 'Saldo Físico', (c.precio * SUM(c.cantidad)) AS 'Total Físico' "
                    + "FROM compras c INNER JOIN item i ON c.idItem = i.idItem "
                    + "INNER JOIN articulo a ON c.idArticulo = a.idArticulo "
                    + "WHERE a.descripcion = '" + nombreArticulo + "' "
                    + "GROUP BY i.idItem "
                    + "ORDER BY 3;";
            }
              
            return sql;
        }     
        public string reporteConsumo(string fecha)
        {
            string sql = "SELECT SUBSTR(ce.nombreCentroCosto, 8, 100) AS 'Local', i.descripcion AS 'Item', a.descripcion AS 'Artículo',"
                       + "r.cantidad AS 'Cantidad', c.precio AS 'Valor Unitario', (c.precio * r.cantidad) AS 'Total' "
                       + "FROM rebajarStock r "
                       + "INNER JOIN centroCosto ce ON r.idLocal = ce.idLocal "
                       + "INNER JOIN item i ON r.idItem = i.idItem "
                       + "INNER JOIN compras c ON c.idItem = i.IdItem "
                       + "INNER JOIN articulo a ON a.IdArticulo = i.idArticulo "
                       + "WHERE r.fechaGuia LIKE '%" + fecha + "%' "
                       + "GROUP BY r.idRebajarStock "
                       + "ORDER BY 1;";
            return sql;

        }
	}

    
}
