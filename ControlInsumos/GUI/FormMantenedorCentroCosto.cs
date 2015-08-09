using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_Inventario.GUI
{
    public partial class FormMantenedorCentroCosto : Form
    {
        public FormMantenedorCentroCosto()
        {
            InitializeComponent();
            cargarEmpresa();
        }
        ControlInsumos.DAL.EmpresaDal empresaDal = new ControlInsumos.DAL.EmpresaDal();
		ControlInsumos.DAL.CentroCostoDal CentroCostoDal = new ControlInsumos.DAL.CentroCostoDal();
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
                if(txtNombre.Text.Length > 0)
                {
				    ControlInsumos.DLL.CentroCosto cc 	= new ControlInsumos.DLL.CentroCosto();
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
                else
                {
                    MessageBox.Show("Debe Llenar todos los campos", "Mantención Centros de Costos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
			} 
			catch (FormatException) 
			{
				MessageBox.Show("Recuerde asignar un número en Centro de Costo","Mantención Centros de Costos",MessageBoxButtons.OK,MessageBoxIcon.Warning);	
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
		
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            insertCC();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
	}
    
}
