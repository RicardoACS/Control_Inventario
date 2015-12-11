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
    /// Description of RebajarStock.
    /// </summary>
    public partial class formRebajarStock : Form
    {
        public formRebajarStock()
        {
            InitializeComponent();
        }
        //Llamado DLL Base de datos
        BaseDeDatosLite b = new BaseDeDatosLite();

        DAL.RebajarStockDal rebajaDal = new ControlInsumos.DAL.RebajarStockDal();
        DAL.ArticuloDal artDal = new ControlInsumos.DAL.ArticuloDal();
        DAL.ItemDal itemDal = new ControlInsumos.DAL.ItemDal();
        DAL.CentroCostoDal centroCostoDal = new ControlInsumos.DAL.CentroCostoDal();
        DAL.CompraDal compraDal = new ControlInsumos.DAL.CompraDal();

        void RebajarStockLoad(object sender, EventArgs e)
        {
            //Carga de los elementos en la GUI
            dgvItems.DataSource = b.SelectDataTable(rebajaDal.loadDataGV(cboxItem.Text));
            //Elimina primera fila [*] del DataView
            dgvItems.RowHeadersVisible = false;
            cargarArticulo();
            cargarItem();
            cboxArticulo.Focus();
            cargarCC();
        }

        public void cargarItem()
        {
            //Carga los item en el ComboBox
            try
            {
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
        }
        public void cargarCC()
        {
            //Carga los Centro de Costo en el ComboBox
            cboxCentroCosto.DataSource = centroCostoDal.listCentroCosto();
            cboxCentroCosto.DisplayMember = "Nombre";
            cboxCentroCosto.ValueMember = "IdCC";
            cboxCentroCosto.SelectedValue = -1;
        }
        public void rebajarStock()
        {
            try
            {
                //Instancia Clase
                DLL.RebajarStock r = new ControlInsumos.DLL.RebajarStock();
                //Variables que sirve para conocer que se va a rebajar
                string fechaMinima = compraDal.fechaMin(int.Parse(cboxItem.SelectedValue.ToString()));
                if (fechaMinima.Length == 0)
                {
                    fechaMinima = compraDal.fechaMinSinStock(int.Parse(cboxItem.SelectedValue.ToString()));
                }
                int item = int.Parse(cboxItem.SelectedValue.ToString());
                int stockProducto = compraDal.consultaStock(fechaMinima, item);
                //Insert Rebaja
                if (rebajaDal.countRebajaStock() <= 1)
                {
                    r.IdRebajarStock = rebajaDal.countRebajaStock();
                }
                else
                {
                    r.IdRebajarStock = rebajaDal.maxRebajaStock();
                }
                r.IdLocal = int.Parse(cboxCentroCosto.SelectedValue.ToString());
                r.IdItem = int.Parse(cboxItem.SelectedValue.ToString());
                r.Cantidad = int.Parse(txtCantidad.Text);
                r.Fecha = DateTime.Now.ToString("dd/MM/yyyy");

                //Rebajar Stock
                if (stockProducto >= r.Cantidad)
                {
                    if (stockProducto >= 1)
                    {
                        if (compraDal.updateCompra(fechaMinima, int.Parse(cboxItem.SelectedValue.ToString()), stockProducto - int.Parse(txtCantidad.Text)) == 1)
                        {
                            MessageBox.Show("Producto rebajado", "Rebajar Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rebajaDal.insertRebaja(r);
                            dgvItems.DataSource = b.SelectDataTable(rebajaDal.loadDataGV(cboxItem.Text));
                        }
                    }
                    else
                    {
                        MessageBox.Show("No le queda Stock de: " + cboxItem.Text, "Rebajar Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (stockProducto <= 0)
                {
                    MessageBox.Show("Producto Agotado", "Rebajar Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("No puedes rebajar más este producto, solo puedes rebajar: " + stockProducto, "Rebajar Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error: " + e.Message, "Rebajar Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        void BtnRebajarClick(object sender, EventArgs e)
        {
            rebajarStock();
        }

        void BtnActualizarClick(object sender, EventArgs e)
        {
            dgvItems.DataSource = b.SelectDataTable(rebajaDal.loadDataGV(cboxItem.Text));
        }

        void BtnSalirClick(object sender, EventArgs e)
        {
            Dispose();
        }

        void Label4Click(object sender, EventArgs e)
        {

        }

        void CboxArticuloTextChanged(object sender, EventArgs e)
        {
            cargarItem();
        }

        void CboxItemTextChanged(object sender, EventArgs e)
        {
            dgvItems.DataSource = b.SelectDataTable(rebajaDal.loadDataGV(cboxItem.Text));
        }
    }
}
