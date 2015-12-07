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
        public string loadDataGV(string item)
        {
            //Cargará el DataView con los datos
            string select = "SELECT i.idInsumos AS 'ID', i.fechaGuia AS 'Fecha' , i.nroGuia AS 'Guía', i.cantidad AS 'Cantidad', substr(c.nombreCentroCosto,8,20) AS 'Local' " 
                          + " FROM insumos i INNER JOIN centroCosto c ON i.idLocal = c.idLocal "
                          + " INNER JOIN item it ON i.idItem = it.idItem WHERE it.descripcion = '" + item + "';";

            return select;
        }
		public int insertInsumo(DLL.Insumo i)
        {
            string sql = "INSERT INTO insumos VALUES (" + i.IdInsumos + "," + i.NroGuia + ",'" + i.FechaGuia + "'," + i.Cantidad + ",'" + i.FechaRealizacion + "'," + i.IdArticulo + ", " + i.IdItem + "," + i.IdLocal + "); ";
            return b.executecommand(sql);
        }
        public int countInsumo()
        {
            return b.executecommand("SELECT COUNT(idInsumos)+1 FROM insumos;");
        }
        public int maxInsumo()
        {
            return b.executecommand("SELECT MAX(idInsumos)+1 FROM insumos;");
        }
	}
}
