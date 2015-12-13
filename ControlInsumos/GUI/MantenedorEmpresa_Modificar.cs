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
    public partial class MantenedorEmpresa_Modificar : Form
    {
        public MantenedorEmpresa_Modificar()
        {
            InitializeComponent();
            cargarEmpresa();
        }

        ControlInsumos.DAL.EmpresaDal empresaDal = new ControlInsumos.DAL.EmpresaDal();     
        public void cargarEmpresa()
        {
            cboxEmpresas.DataSource = empresaDal.listEmpresa();
            cboxEmpresas.DisplayMember = "Nombre";
            cboxEmpresas.ValueMember = "IdEmpresa";
            cboxEmpresas.SelectedIndex = -1;
        }

        private void modificarEmpresa()
        {
            try
            {
                ControlInsumos.DLL.Empresa e = new ControlInsumos.DLL.Empresa();
                e.IdEmpresa                  = int.Parse(cboxEmpresas.SelectedValue.ToString());
                e.Nombre                     = txtNuevoNombre.Text;
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de modificar la Empresa?", "Mantenedor Empresa", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int res = empresaDal.updateNombreEmpresa(e);

                    switch (res)
                    {
                        case 1: MessageBox.Show("Cambios Realizados exitosamente!", "Mantenedor Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                            break;
                        default: MessageBox.Show("Error: " + res, "Mantenedor Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        private void limpiar()
        {
            txtNuevoNombre.Clear();
            cargarEmpresa();
            cboxEmpresas.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarEmpresa();
        }
    }
}
