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
	/// Description of Mantenedor_Locales.
	/// </summary>
	public partial class formMantenedorCC : Form
	{
		public formMantenedorCC()
		{
			InitializeComponent();
			cargarEmpresa();
		}
		DAL.EmpresaDal empresaDal = new DAL.EmpresaDal();
		DAL.CentroCostoDal CentroCostoDal = new DAL.CentroCostoDal();
		public void cargarEmpresa()
		{
			cboxEmpresa.DataSource = empresaDal.listEmpresa();
			cboxEmpresa.DisplayMember = "Nombre";
            cboxEmpresa.ValueMember = "IdEmpresa";
            cboxEmpresa.SelectedIndex = -1;
		}
		public void insertCC()		
		{
			try 
			{
				DLL.CentroCosto cc 	= new ControlInsumos.DLL.CentroCosto();
				cc.IdCC 			= int.Parse(txtCentroCosto.Text);
				cc.Nombre 			= txtCentroCosto.Text + " - " + txtNombre.Text;
				cc.IdEmpresa 		= int.Parse(cboxEmpresa.SelectedValue.ToString());
				int resultado 		= cc.insertCc(cc);
				switch (resultado) 
				{
					case  1 :
						MessageBox.Show("Registro Correcto","Mantención Centros de Costos",MessageBoxButtons.OK,MessageBoxIcon.Information);
						limpiar();
						break;
					case 19: 
						MessageBox.Show("Ya existe Centro de Costo","Mantención Centros de Costos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
						break;
				}
			} 
			catch (FormatException) 
			{
				MessageBox.Show("Corriga los valores numéricos","Mantención Centros de Costos",MessageBoxButtons.OK,MessageBoxIcon.Warning);	
			}
			catch(NullReferenceException)
			{
				MessageBox.Show("Debe elegir una empresa","Mantención Centros de Costos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				cboxEmpresa.Focus();
			}
			catch(OverflowException)
			{
				MessageBox.Show("Numero de centro costo supera el limite","Mantención Centros de Costos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtCentroCosto.Focus();
			}
			
		}
		public void limpiar()
		{
			txtCentroCosto.Clear();
			txtNombre.Clear();
			cboxEmpresa.SelectedIndex = -1;
			cboxEmpresa.Focus();
		}
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			insertCC();
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}
