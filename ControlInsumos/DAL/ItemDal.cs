/*
 * Creado por SharpDevelop.
 * Usuario: crojo
 * Fecha: 30-06-2015
 * Hora: 12:01
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
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
			string sql = "select count(idItem)+1 from item;";
			count = int.Parse(b.selectstring(sql));
			return count;
		}
		public List<DLL.Item> listItem(int idArt)
		{
			try 
			{
			List<DLL.Item> listaItem = new List<ControlInsumos.DLL.Item>();
			SQLiteCommand sql = new SQLiteCommand("select * from item where idArticulo = " + idArt + ";", conn.connection());
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
	}
}
