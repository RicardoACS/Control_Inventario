/*
 * Creado por SharpDevelop.
 * Usuario: crojo
 * Fecha: 17-06-2015
 * Hora: 17:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ControlInsumos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			timerHora.Enabled = true;
		}
		
		void ArticuloToolStripMenuItemClick(object sender, EventArgs e)
		{
			GUI.formIngresarArticulo art = new ControlInsumos.GUI.formIngresarArticulo();
			art.Show();
		}
		
		void ItemToolStripMenuItemClick(object sender, EventArgs e)
		{
			GUI.fromIngresarItem ingresarItem = new ControlInsumos.GUI.fromIngresarItem();
			ingresarItem.Show();
		}
		
		void CompraToolStripMenuItemClick(object sender, EventArgs e)
		{
			GUI.fromIngresarCompra ingresarCompra = new ControlInsumos.GUI.fromIngresarCompra();
			ingresarCompra.Show();
		}
		
		void CentroCostoToolStripMenuItemClick(object sender, EventArgs e)
		{
			GUI.formMantenedorCC cc = new ControlInsumos.GUI.formMantenedorCC();
			cc.Show();
		}
		
		void EmpresaToolStripMenuItemClick(object sender, EventArgs e)
		{
			GUI.formMantenedorEmpresa me = new ControlInsumos.GUI.formMantenedorEmpresa();
			me.Show();
		}
		
		void TimerHoraTick(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text =  DateTime.Now.ToString("hh:mm");
			toolStripStatusLabel2.Text =  DateTime.Now.ToString("dd/mm/yyyy");
		}
		
		void DevolucionToolStripMenuItemClick(object sender, EventArgs e)
		{
			GUI.formRebajarStock r = new ControlInsumos.GUI.formRebajarStock();
			r.Show();
		}
	}
}
