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
	/// Description of EmpresaDal.
	/// </summary>
	public class EmpresaDal
	{
		
		BaseDeDatosLite b = new BaseDeDatosLite();
		Conn conn = new Conn();
		public int insertEmpresa(DLL.Empresa e)
		{
			string sql = "INSERT INTO empresas VALUES(" + e.IdEmpresa + ",'" + e.Nombre + "');";
			return b.executecommand(sql);
		}
		public List<DLL.Empresa> listEmpresa()
		{
			try 
			{
			List<DLL.Empresa> listaEmp = new List<ControlInsumos.DLL.Empresa>();
			SQLiteCommand sql = new SQLiteCommand("SELECT * FROM empresas", conn.connection());
			SQLiteDataReader reader = sql.ExecuteReader();
               while (reader.Read())
               {
                   DLL.Empresa emp = new DLL.Empresa();
                   emp.IdEmpresa = reader.GetInt32(0);
                   emp.Nombre = reader.GetString(1);
                   listaEmp.Add(emp);
               }
			return listaEmp;
			} 
			catch (Exception)
			{
			 return null;	
			}
		}
		
		public int countEmp()
		{		
			int count = 0;
			string sql = "SELECT count(idEmpresa)+1  FROM empresas";
			count = int.Parse(b.selectstring(sql));
			return count;
				
		}
	}
}
