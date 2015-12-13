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
    public partial class MantenedorCentroCosto_Modificar : Form
    {
        public MantenedorCentroCosto_Modificar()
        {
            InitializeComponent();
            limpiar();
        }

        ControlInsumos.DAL.EmpresaDal empresaDal = new ControlInsumos.DAL.EmpresaDal();
        ControlInsumos.DAL.CentroCostoDal centroCostoDal = new ControlInsumos.DAL.CentroCostoDal();
        public void cargarEmpresa()
        {
            cboxEmpresa.DataSource = empresaDal.listEmpresa();
            cboxEmpresa.DisplayMember = "Nombre";
            cboxEmpresa.ValueMember = "IdEmpresa";
            cboxEmpresa.SelectedIndex = -1;
        }
        public void cargarCC()
        {
            //Carga los Centro de Costo en el ComboBox
            cboxCC.DataSource = centroCostoDal.listCentroCosto();
            cboxCC.DisplayMember = "Nombre";
            cboxCC.ValueMember = "IdCC";
            cboxCC.SelectedValue = -1;
        }
        public void limpiar()
        {
            cargarEmpresa();
            cargarCC();
            txtNombre.Clear();
            txtNCC.Clear();
            cboxCC.Focus();
        }
        public void modificarCC()
        {
            ControlInsumos.DLL.CentroCosto cc = new ControlInsumos.DLL.CentroCosto();
            try
            {
                int idCCOriginal    = int.Parse(cboxCC.SelectedValue.ToString());
                cc.IdEmpresa        = int.Parse(cboxEmpresa.SelectedValue.ToString());
                cc.Nombre           = txtNCC.Text + " - " +txtNombre.Text;
                cc.IdCC             = int.Parse(txtNCC.Text);
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de modificar el Centro de Costo?", "Modificar CC", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {          
                    int res             = centroCostoDal.modificarCC(cc, idCCOriginal);

                    switch (res)
                    {
                        case 1:
                            MessageBox.Show("Modificación Exitosa", "Modificar CC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                            break;
                        case 19:
                            MessageBox.Show("Este N° de CC ya está en uso", "Modificar CC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtNCC.Focus();
                            break;
                        default:
                            MessageBox.Show("Indique el siguiente N°: " + res + " al administrador", "Modificar CC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Debe escribir algún número en 'Nuevo N°' ", "Modificar CC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNCC.Focus();
            }
            catch (Exception e)
            {
                MessageBox.Show("Indique el siguiente mensaje: " + e.Message + " al administrador", "Modificar CC", MessageBoxButtons.OK, MessageBoxIcon.Warning);           
            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarCC();
        }
    }
}
