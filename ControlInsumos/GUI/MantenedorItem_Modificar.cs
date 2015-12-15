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
    public partial class MantenedorItem_Modificar : Form
    {
        public MantenedorItem_Modificar()
        {
            InitializeComponent();
            cargarArticulo();
        }

        ControlInsumos.DAL.ArticuloDal artDal = new ControlInsumos.DAL.ArticuloDal();
        ControlInsumos.DAL.ItemDal itemDal = new ControlInsumos.DAL.ItemDal();

        public void cargarItem()
        {
            //Carga los item en el ComboBox
            try
            {
                cboxItem.SelectedIndex = -1;
                int id = int.Parse(cboxArticulo.SelectedValue.ToString());
                cboxItem.DataSource = itemDal.listItem(id);
                cboxItem.DisplayMember = "Descripcion";
                cboxItem.ValueMember = "IdItem";
                cboxItem.SelectedIndex = -1;
            }
            catch (Exception)
            {

            }
        }
        public void cargarArticulo()
        {
            //Carga los Articulos en el ComboBox
            cboxArticulo.DataSource = artDal.listArt();
            cboxArticulo.DisplayMember = "NombreArticulo";
            cboxArticulo.ValueMember = "IdArticulo";
            cboxArticulo.SelectedIndex = -1;

            cboxArticuloNuevo.DataSource = artDal.listArt();
            cboxArticuloNuevo.DisplayMember = "NombreArticulo";
            cboxArticuloNuevo.ValueMember = "IdArticulo";
            cboxArticuloNuevo.SelectedIndex = -1;
        }

        public void modificarItem()
        {
            try
            {
                ControlInsumos.DLL.Item i = new ControlInsumos.DLL.Item();
                i.IdItem = int.Parse(cboxItem.SelectedValue.ToString());
                i.Descripcion = txtItemNuevo.Text;
                i.IdArticulo = int.Parse(cboxArticuloNuevo.SelectedValue.ToString());

                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de modificar el Item: " + cboxItem.Text + "?", "Modificar Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int res = itemDal.modificarItem(i);

                    switch (res)
                    {
                        case 1:
                            MessageBox.Show("Modificación realizada con éxito", "Modificar Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                            break;
                        case 19:
                            MessageBox.Show("Ya existe este artículo", "Modificar Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }

                }
            }
            catch (Exception e)
            {
               
            }
        }
        public void limpiar()
        {
            cargarArticulo();
            txtItemNuevo.Clear();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarItem();
        }

        private void cboxArticulo_SelectedValueChanged(object sender, EventArgs e)
        {
            cargarItem();
        }

        private void cboxArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(cboxArticulo, true, true, true, true);
            }
        }

        private void cboxItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(cboxItem, true, true, true, true);
            }
        }

        private void cboxArticuloNuevo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(cboxArticuloNuevo, true, true, true, true);
            }
        }

        private void txtItemNuevo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(txtItemNuevo, true, true, true, true);
            }
        }
    }
}
