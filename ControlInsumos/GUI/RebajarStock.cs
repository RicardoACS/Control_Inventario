/*
 * Creado por SharpDevelop.
 * Usuario: crojo
 * Fecha: 03-07-2015
 * Hora: 15:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
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
		BaseDeDatosLite b = new BaseDeDatosLite();
		
		DAL.RebajarStockDal rebajaDal = new ControlInsumos.DAL.RebajarStockDal();
		DAL.ArticuloDal artDal = new ControlInsumos.DAL.ArticuloDal();
		DAL.ItemDal itemDal = new ControlInsumos.DAL.ItemDal();
		DAL.CentroCostoDal centroCostoDal = new ControlInsumos.DAL.CentroCostoDal();
		DAL.CompraDal compraDal = new ControlInsumos.DAL.CompraDal();
		
		void RebajarStockLoad(object sender, EventArgs e)
		{
			dgvItems.DataSource = b.SelectDataTable(rebajaDal.loadDataGV(cboxItem.Text));			
			cargarArticulo();
			cargarItem();
			cboxArticulo.Focus();
			cargarCC();
		}
		
		public void cargarItem()
		{
			cboxItem.DataSource = itemDal.listItem(cboxArticulo.SelectedIndex+1);
			cboxItem.DisplayMember = "Descripcion";
            cboxItem.ValueMember = "IdItem";
            //cboxItem.SelectedIndex = -1;
		}
		public void cargarArticulo()
		{
			cboxArticulo.DataSource = artDal.listArt();
            cboxArticulo.DisplayMember = "NombreArticulo";
            cboxArticulo.ValueMember = "IdArticulo";
            //cboxArticulo.SelectedIndex = -1;
		}
		public void cargarCC()
		{
			cboxCentroCosto.DataSource = centroCostoDal.listCentroCosto();
            cboxCentroCosto.DisplayMember = "Nombre";
            cboxCentroCosto.ValueMember = "IdCC";
            cboxCentroCosto.SelectedValue = -1;
		}
		public void rebajarStock()
		{
			DLL.RebajarStock r = new ControlInsumos.DLL.RebajarStock();
			string fechaMin = compraDal.fechaMin(int.Parse(cboxItem.SelectedValue.ToString()));
			int item = int.Parse(cboxItem.SelectedValue.ToString());
			int stockP = compraDal.consultaStock(fechaMin,item);
			r.IdRebajarStock = 1;
			r.IdLocal = cboxCentroCosto.SelectedIndex+1;
			r.IdItem = cboxItem.SelectedIndex+1;
			r.Cantidad = int.Parse(txtCantidad.Text);
			if (compraDal.updateCompra(fechaMin,int.Parse(cboxItem.SelectedValue.ToString()),stockP-int.Parse(txtCantidad.Text)) == 1)
			{
				MessageBox.Show("Update");
			}
		}
		void BtnRebajarClick(object sender, EventArgs e)
		{
			rebajarStock();
		}
		
		void BtnActualizarClick(object sender, EventArgs e)
		{
			
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
