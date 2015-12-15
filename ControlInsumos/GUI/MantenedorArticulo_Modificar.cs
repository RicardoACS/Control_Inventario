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
    public partial class Articulo_Modificar : Form
    {
        public Articulo_Modificar()
        {
            InitializeComponent();
            cargarArticulo();
        }
        ControlInsumos.DAL.ArticuloDal artDal = new ControlInsumos.DAL.ArticuloDal();
        public void cargarArticulo()
        {
            cboxArticulos.DataSource = artDal.listArt();
            cboxArticulos.DisplayMember = "NombreArticulo";
            cboxArticulos.ValueMember = "IdArticulo";
            cboxArticulos.SelectedIndex = -1;
            artTxtArticulo.Clear();
        }

        public void modificarCC()
        {
            ControlInsumos.DLL.CentroCosto cc = new ControlInsumos.DLL.CentroCosto();
            try
            {
                int idArt           = int.Parse(cboxArticulos.SelectedValue.ToString());
                string nuevoNombre  = artTxtArticulo.Text;
                
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de modificar el Artículo?", "Modificar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int res = artDal.modificarNombreArt(nuevoNombre, idArt);

                    switch (res)
                    {
                        case 1:
                            MessageBox.Show("Modificación Exitosa", "Modificar Articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarArticulo();
                            break;
                        case 19:
                            MessageBox.Show("Este nombre ya está en uso", "Modificar Articulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            artTxtArticulo.Focus();
                            break;
                        default:
                            MessageBox.Show("Indique el siguiente N°: " + res + " al administrador", "Modificar CC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                }
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

        private void cboxArticulos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(cboxArticulos, true, true, true, true);
            }
        }

        private void artTxtArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(artTxtArticulo, true, true, true, true);
            }
        }
    }
}
