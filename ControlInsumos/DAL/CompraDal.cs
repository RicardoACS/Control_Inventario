/*
 * Usuario: Ricardo Carrasco
 * Fecha: 30-06-2015
 * Hora: 13:06
 */
using System;

namespace ControlInsumos.DAL
{
    /// <summary>
    /// Description of CompraDal.
    /// </summary>
    public class CompraDal
    {
        BaseDeDatosLite b = new BaseDeDatosLite();
        public int insertCompra(DLL.Compra c)
        {
            string insert = "INSERT INTO compras VALUES(" + c.IdCompra + "," + c.NumeroDoc + ",'" + c.Fecha + "'," + c.IdArticulo + "," + c.IdItem + "," + c.Cantidad + "," + c.Precio + ");";
            return b.executecommand(insert);
        }
        public string fechaMin(int item)
        {
            string sql = "SELECT min(p.fecha) FROM compras p " +
                "INNER JOIN item i " +
                "ON p.idItem = i.idItem " +
                "WHERE cantidad > 0 and i.idItem = " + item + ";";
            return b.selectstring(sql);
        }
        public string fechaMinSinStock(int item)
        {
            string sql = "SELECT min(p.fecha) FROM compras p " +
                "INNER JOIN item i " +
                "ON p.idItem = i.idItem " +
                "WHERE cantidad >= 0 and i.idItem = " + item + ";";
            return b.selectstring(sql);
        }
        public int updateCompra(String fecha, int idItem, int stock)
        {
            string sql = "UPDATE compras SET cantidad = " + stock +
                         " WHERE fecha = '" + fecha + "' AND iditem = " + idItem + ";";
            return b.executecommand(sql);

        }

        public int consultaStock(String fecha, int idItem)
        {
            String sql = "SELECT cantidad from compras  " +
                         "WHERE fecha = '" + fecha + "' AND iditem = " + idItem + " ;";
            return int.Parse(b.selectstring(sql));
        }
        public int countCompra()
        {
            int count = 0;
            string sql = "SELECT COUNT(idCompras)+1  FROM compras";
            count = int.Parse(b.selectstring(sql));
            return count;

        }
        public int maxCompra()
        {
            int count = 0;
            string sql = "SELECT MAX(idCompras)+1  FROM compras";
            count = int.Parse(b.selectstring(sql));
            return count;

        }
    }
}
