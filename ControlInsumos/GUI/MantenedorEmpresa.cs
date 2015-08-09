/*
/*
 * Usuario: Ricardo Carrasco
 * Fecha: 30-06-2015
 * Hora: 13:06
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlInsumos.GUI
{
	/// <summary>
	/// Description of MantenedorEmpresa.
	/// </summary>
	public partial class formMantenedorEmpresa : Form
	{
		DAL.EmpresaDal empresaDal = new DAL.EmpresaDal();
		public formMantenedorEmpresa()
		{
			InitializeComponent();
		}
		
		public void insertEmpresa()
		{
			try 
			{
                if(txtNombre.Text.Length > 0 )
                {            
				    DLL.Empresa e = new ControlInsumos.DLL.Empresa();
				    e.IdEmpresa = empresaDal.countEmp();
				    e.Nombre = txtNombre.Text;
				    int resultado = e.insertEmpresa(e);
				
				    switch (resultado) 
				    {
					    case  1 :
						    MessageBox.Show("Registro Correcto","Mantención Empresas",MessageBoxButtons.OK,MessageBoxIcon.Information);
						    txtNombre.Clear();
						    break;
					    case 19: 
						    MessageBox.Show("Ya existe esta Empresa","Mantención Empresas",MessageBoxButtons.OK,MessageBoxIcon.Warning);
						    break;
				    }
                }
                else
                {
                    MessageBox.Show("Debe llenar el campo", "Mantención Empresas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                }
			} 
			catch (Exception)
			{
				
			}
			
		}
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			txtNombre.Focus();
			insertEmpresa();
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Dispose();
		}
		
		void TxtNombreKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				this.SelectNextControl(txtNombre,true,true,false,false);
			}
		}
	}
}
