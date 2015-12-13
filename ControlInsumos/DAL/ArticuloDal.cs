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
	/// Description of ArticuloDal.
	/// </summary>
	public class ArticuloDal
	{
		ControlInsumos.DAL.Conn conn = new ControlInsumos.DAL.Conn();
		BaseDeDatosLite b = new BaseDeDatosLite();
		public int insertArt(DLL.Articulo a)
		{	
				string sql = "INSERT INTO articulo VALUES(" + a.IdArticulo + ",'" + a.NombreArticulo + "');";
				return b.executecommand(sql);
						    
		}
		public int countArt()
		{		
			int count = 0;
			string sql = "SELECT count(idArticulo)+1  FROM articulo";
			count = int.Parse(b.selectstring(sql));			
			return count;
				
		}
		public List<DLL.Articulo> listArt()
		{
			try 
			{
			List<DLL.Articulo> listaArt = new List<ControlInsumos.DLL.Articulo>();
			SQLiteCommand sql = new SQLiteCommand("SELECT * FROM articulo", conn.connection());
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
        public int modificarNombreArt(string nombre, int idArt)
        {
            string sql = "UPDATE articulo SET descripcion = '" + nombre + "' WHERE idArticulo = " + idArt + ";";
            return b.executecommand(sql);
        }
	}
}
