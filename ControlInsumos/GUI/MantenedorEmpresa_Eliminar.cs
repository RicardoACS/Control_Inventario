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
    public partial class MantenedorEmpresa_Eliminar : Form
    {
        public MantenedorEmpresa_Eliminar()
        {
            InitializeComponent();
            cargarEmpresa();
        }

        ControlInsumos.DAL.EmpresaDal empresaDal = new ControlInsumos.DAL.EmpresaDal();
        ControlInsumos.DAL.CentroCostoDal centroCostoDal = new ControlInsumos.DAL.CentroCostoDal();
        public void cargarEmpresa()
        {
            cboxEmpresas.DataSource = empresaDal.listEmpresa();
            cboxEmpresas.DisplayMember = "Nombre";
            cboxEmpresas.ValueMember = "IdEmpresa";
            cboxEmpresas.SelectedIndex = -1;
        }

        private void eliminarEmpresa()
        {
            try
            {
                ControlInsumos.DLL.Empresa e = new ControlInsumos.DLL.Empresa();
                int id  = int.Parse(cboxEmpresas.SelectedValue.ToString());
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de eliminar la Empresa " + cboxEmpresas.Text + "?", "Modificar CC", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int res = empresaDal.deleteEmpresa(id);

                    switch (res)
                    {
                        case 1: MessageBox.Show("Empresa Eliminada", "Mantenedor Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            centroCostoDal.eliminarCCXEmpresa(id);
                            cargarEmpresa();
                            break;
                        default: MessageBox.Show("Indique el N°: " + res + "Al administrado", "Mantenedor Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        private void MantenedorEmpresa_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarEmpresa();
        }

        private void cboxEmpresas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(cboxEmpresas, true, true, true, true);
            }
        }
    }
}
