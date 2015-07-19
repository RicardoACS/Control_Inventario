/*
 * Creado por SharpDevelop.
 * Usuario: Rcarrasco
 * Fecha: 18-06-2015
 * Hora: 16:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace ControlInsumos.DAL
{
	/// <summary>
	/// Description of ArticuloDal.
	/// </summary>
	public class ArticuloDal
	{
		ControlInsumos.DAL.Conn conn = new ControlInsumos.DAL.Conn();
		BaseDeDatosLite b = new BaseDeDatosLite();
		public int insertArt(DLL.Articulo a)
		{	
				string sql = "insert into articulo values(" + a.IdArticulo + ",'" + a.NombreArticulo + "');";
				return b.executecommand(sql);
						    
		}
		public int countArt()
		{		
			int count = 0;
			string sql = "select count(idArticulo)+1  from articulo";
			count = int.Parse(b.selectstring(sql));			
			return count;
				
		}
		public List<DLL.Articulo> listArt()
		{
			try 
			{
			List<DLL.Articulo> listaArt = new List<ControlInsumos.DLL.Articulo>();
			SQLiteCommand sql = new SQLiteCommand("select * from articulo", conn.connection());
			SQLiteDataReader reader = sql.ExecuteReader();
               while (reader.Read())
               {
                   DLL.Articulo art = new DLL.Articulo();
                   art.IdArticulo = reader.GetInt32(0);
                   art.NombreArticulo = reader.GetString(1);
                   listaArt.Add(art);
               }
			return listaArt;
			} 
			catch (Exception)
			{
			 return null;	
			}
		}
	}
}
