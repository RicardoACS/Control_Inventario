/*
 * Usuario: Ricardo Carrasco
 * Fecha: 30-06-2015
 * Hora: 13:06
 */
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace ControlInsumos.DAL
{
	/// <summary>
	/// Description of ItemDal.
	/// </summary>
	public class ItemDal
	{
		BaseDeDatosLite b = new BaseDeDatosLite();
		Conn conn = new Conn();
		public int insertItem(DLL.Item i)
		{
			string insert = "INSERT INTO item VALUES(" + i.IdItem + ",'" + i.Descripcion + "'," + i.IdArticulo + ");";
			return b.executecommand(insert);
		}
		public int countItem()
		{
			int count = 0;
			string sql = "SELECT count(idItem)+1 FROM item;";
			count = int.Parse(b.selectstring(sql));
			return count;
		}
        public int maxItem()
        {
            int count = 0;
            string sql = "SELECT MAX(idItem)+1 FROM item;";
            count = int.Parse(b.selectstring(sql));
            return count;
        }
		public List<DLL.Item> listItem(int idArt)
		{
			try 
			{
			List<DLL.Item> listaItem = new List<ControlInsumos.DLL.Item>();
			SQLiteCommand sql = new SQLiteCommand("SELECT * FROM item WHERE idArticulo = " + idArt + " ORDER BY 2;", conn.connection());
			SQLiteDataReader reader = sql.ExecuteReader();
               while (reader.Read())
               {
                   DLL.Item item = new DLL.Item();
                   item.IdItem = reader.GetInt32(0);
                   item.Descripcion = reader.GetString(1);
                   listaItem.Add(item);
               }
			return listaItem;
			} 
			catch (Exception)
			{
			 return null;	
			}
		}

        public int modificarItem(DLL.Item i)
        {
            string sql = "UPDATE item SET descripcion = '" + i.Descripcion + "', idArticulo = " + i.IdArticulo + " WHERE idItem = " + i.IdItem + ";";
            return b.executecommand(sql);
        }
	}
}
