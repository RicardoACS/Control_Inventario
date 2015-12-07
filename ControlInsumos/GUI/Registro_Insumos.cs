/*
 * Usuario: rcarrasco
 * Fecha: 03-12-2015
 * Hora: 13:15
 * 
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Control_Inventario.GUI
{
	/// <summary>
	/// Description of Insumos.
	/// </summary>
	public partial class Registro_Insumos : Form
	{
		public Registro_Insumos()
		{
            InitializeComponent();
            
			
		}
        //Llamado DLL Base de datos
        BaseDeDatosLite b = new BaseDeDatosLite();

        Control_Inventario.DAL.InsumosDal insumosDal = new Control_Inventario.DAL.InsumosDal();
        ControlInsumos.DAL.ArticuloDal artDal = new ControlInsumos.DAL.ArticuloDal();
        ControlInsumos.DAL.ItemDal itemDal = new ControlInsumos.DAL.ItemDal();
        ControlInsumos.DAL.CentroCostoDal centroCostoDal = new ControlInsumos.DAL.CentroCostoDal();
        ControlInsumos.DAL.CompraDal compraDal = new ControlInsumos.DAL.CompraDal();

        void RegistroInsumosLoad(object sender, EventArgs e)
        {
            cargarDGV();
            cargarArticulo();
            cargarItem();
            cboxArticulo.Focus();
            cargarCC();
        }
        public void cargarDGV()
        {
            //Carga de los elementos en la GUI
            dgvRegistroInsumos.DataSource = b.SelectDataTable(insumosDal.loadDataGV(cboxItem.Text));
            //Elimina primera fila [*] del DataView
            dgvRegistroInsumos.RowHeadersVisible = false;
            //Ancho de las columnas
            dgvRegistroInsumos.Columns[0].Width = 30;
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

        public void insertInsumos()
        { 
            try
            {
                Control_Inventario.DLL.Insumo i = new DLL.Insumo();

                if (insumosDal.countInsumo() <= 1)
                {
                    i.IdInsumos = insumosDal.countInsumo();
                }
                else
                {
                    i.IdInsumos = insumosDal.maxInsumo();
                }
                i.NroGuia = int.Parse(txtGuia.Text);
                string fechaGuia = DateTime.Parse(dtFechaGuia.Text).ToString("yyyy/MM/dd");
                i.FechaGuia = fechaGuia;
                i.Cantidad = int.Parse(txtCantidad.Text);
                string fechaHoy = DateTime.Now.ToString("yyyy/MM/dd");
                i.FechaRealizacion = fechaHoy;
                i.IdArticulo = int.Parse(cboxArticulo.SelectedValue.ToString());
                i.IdItem = int.Parse(cboxItem.SelectedValue.ToString());
                i.IdLocal = int.Parse(cboxCentroCosto.SelectedValue.ToString());
                insumosDal.insertInsumo(i);
            }
            catch(Exception e)
            {

            }
            
        }

        private void cboxArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarItem();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarDGV();
        }

        private void btnRebajar_Click(object sender, EventArgs e)
        {
            insertInsumos();
        }

        private void cboxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDGV();
        }
	}
}
