/*
 * Usuario: rcarrasco
 * Fecha: 03-12-2015
 * Hora: 13:10
 * 
 */

using System;

namespace Control_Inventario.DAL
{
    /// <summary>
    /// Description of InsumosDal.
    /// </summary>
    public class InsumosDal
    {
        BaseDeDatosLite b = new BaseDeDatosLite();

        //Modificar Registro Insumo
        public string nroGuia;
        public string fecha;
        public string centroCosto;
        public string nombreCC;
        public string cantidad;
        //Fin modificar

        public string loadDataGV(string item)
        {
            //Cargará el DataView con los datos
            string select = "SELECT i.idInsumos AS 'ID', i.fechaGuia AS 'Fecha' , i.nroGuia AS 'Guía', substr(c.nombreCentroCosto,8,20) AS 'Local', i.cantidad AS 'Cantidad',  CAST(round(i.cantidad * c.precio,0) AS INT) AS 'Total' "
                          + "FROM insumos i INNER JOIN centroCosto c ON i.idLocal = c.idLocal INNER JOIN item it ON i.idItem = it.idItem LEFT JOIN compras c ON c.idItem = it.idItem "
                          + "WHERE it.descripcion = '" + item + "';";

            return select;
        }
        public int insertInsumo(DLL.Insumo i)
        {
            string sql = "INSERT INTO insumos VALUES (" + i.IdInsumos + "," + i.NroGuia + ",'" + i.FechaGuia + "'," + i.Cantidad + ",'" + i.FechaRealizacion + "'," + i.IdArticulo + ", " + i.IdItem + "," + i.IdLocal + "); ";
            return b.executecommand(sql);
        }
        public int countInsumo()
        {
            string sql = "SELECT COUNT(idInsumos)+1 FROM insumos;";
            int count = int.Parse(b.selectstring(sql));
            return count;
        }
        public int maxInsumo()
        {
            string sql = "SELECT MAX(idInsumos)+1 FROM insumos;";
            int max = int.Parse(b.selectstring(sql));
            return max;
        }
        public int eliminarRegistro(int idLocal)
        {
            string sql = "DELETE FROM insumos WHERE Idlocal = " + idLocal + ";";
            return b.executecommand(sql);
        }

        public int modificarRegistro(DLL.Insumo i)
        {
            string sql = "UPDATE insumos SET nroGuia = " + i.NroGuia + ", fechaGuia = '" + i.FechaGuia + "', cantidad = " + i.Cantidad + " , idLocal = " + i.IdLocal + " WHERE idInsumos = " + i.IdInsumos + ";";
            return b.executecommand(sql);
        }

        public int eliminarRegistroXIDInsumos(int idInsumos)
        {
            string sql = "DELETE FROM insumos WHERE idInsumos = " + idInsumos + ";";
            return b.executecommand(sql);
        }


        public void modificarDGV(string idRegistroInsumos)
        {
            string returnNroGuia = "SELECT nroGuia FROM insumos WHERE idInsumos = " + idRegistroInsumos + ";";
            string returnFechaGuia = "SELECT fechaGuia FROM insumos WHERE idInsumos = " + idRegistroInsumos + ";";
            string returnCC = "SELECT idLocal FROM insumos WHERE idInsumos = " + idRegistroInsumos + ";";
            string returnCantidad = "SELECT cantidad FROM insumos WHERE idInsumos = " + idRegistroInsumos + ";";
            string returnNombreCC = "SELECT c.nombreCentroCosto FROM insumos i INNER JOIN centroCosto c ON i.idLocal = c.idLocal WHERE i.idInsumos = " + idRegistroInsumos + ";";
            nroGuia = b.selectstring(returnNroGuia);
            fecha = b.selectstring(returnFechaGuia);
            centroCosto = b.selectstring(returnCC);
            nombreCC = b.selectstring(returnNombreCC);
            cantidad = b.selectstring(returnCantidad);
        }

        public string reporteInsumos(int repeteciones, string nombreArticulo)
        {
            for (int i = repeteciones; i <= repeteciones; i++)
            {

                if (i == 1)
                {
                    string sql = "SELECT ce.nombreCentroCosto AS 'Local', a.descripcion AS 'Articulo',  (c.precio * ins.cantidad) AS 'Total' "
                               + "FROM insumos ins "
                               + "INNER JOIN centroCosto ce ON ins.idLocal = ce.idLocal "
                               + "INNER JOIN item i ON ins.idItem = i.idItem "
                               + "LEFT JOIN compras c ON i.idItem = c.IdItem "
                               + "INNER JOIN articulo a ON a.idArticulo = ins.idArticulo "
                               + "GROUP BY 2 "
                               + "ORDER BY 2;";
                    return sql;
                }
                string sql1 = "SELECT ins.nroGuia AS 'Guía', ins.fechaGuia AS 'Fecha',i.descripcion AS 'Descripción', "
                            + "ce.nombreCentroCosto AS 'Local', ins.cantidad AS 'Cantidad', (c.precio * ins.cantidad) AS 'Total' "
                            + "FROM insumos ins "
                            + "INNER JOIN centroCosto ce ON ins.idLocal = ce.idLocal "
                            + "INNER JOIN item i ON ins.idItem = i.idItem "
                            + "LEFT JOIN compras c ON i.idItem = c.IdItem "
                            + "INNER JOIN articulo a ON a.idArticulo = ins.idArticulo "
                            + "WHERE a.descripcion = '" + nombreArticulo + "' "
                            + "ORDER BY 4;";
                return sql1;
            }
            return null;
        }
    }
}