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
    public partial class MantenedorCentroCosto_Eliminar : Form
    {
        public MantenedorCentroCosto_Eliminar()
        {
            InitializeComponent();
            cargarCC();
        }
        ControlInsumos.DAL.CentroCostoDal centroCostoDal    = new ControlInsumos.DAL.CentroCostoDal();
        Control_Inventario.DAL.InsumosDal insumoDal         = new Control_Inventario.DAL.InsumosDal();
        ControlInsumos.DAL.RebajarStockDal rebajarStockDal  = new ControlInsumos.DAL.RebajarStockDal();
        public void cargarCC()
        {
            //Carga los Centro de Costo en el ComboBox
            cboxCC.DataSource = centroCostoDal.listCentroCosto();
            cboxCC.DisplayMember = "Nombre";
            cboxCC.ValueMember = "IdCC";
            cboxCC.SelectedValue = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idLocal = int.Parse(cboxCC.SelectedValue.ToString());

                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de modificar el Centro de Costo?", "Modificar CC", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int res = centroCostoDal.eliminarCC(idLocal);

                    switch (res)
                    {
                        case 1:
                            MessageBox.Show("Centro de Costo Eliminado", "Eliminar CC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            insumoDal.eliminarRegistro(idLocal);
                            rebajarStockDal.eliminarRegistro(idLocal);
                            cargarCC();
                            break;
                        default:
                            MessageBox.Show("Indique el siguiente N°: " + res + " al administrador", "Modificar CC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                
                
            }
        }
    }
}
