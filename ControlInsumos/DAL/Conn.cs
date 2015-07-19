/*
 * Creado por SharpDevelop.
 * Usuario: Rcarrasco
 * Fecha: 18-06-2015
 * Hora: 16:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Data.SQLite;

namespace ControlInsumos.DAL
{
	/// <summary>
	/// Description of Conn.
	/// </summary>
	public class Conn
	{
		
		private SQLiteConnection conn;
		
		public Conn()
		{
		}
		public SQLiteConnection connection()
		{
			try 
			{
			    conn = new SQLiteConnection("Data Source=|DataDirectory|dbinsumos.db;Version=3;New=False;Compress=True;");
			    conn.Open();
			} 
			catch(SQLiteException ex) 
			{
			    Console.Write(ex.Message);
			}
			return conn;
		}
	}
}
