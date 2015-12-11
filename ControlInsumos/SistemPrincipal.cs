/*
 * Usuario: Ricardo Carrasco
 * Fecha: 30-06-2015
 * Hora: 13:06
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
            cambiarColorMdi();
			timerHora.Enabled = true;         
		}
        MdiClient ctlMDI;
        private void cambiarColorMdi()
        {
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = Color.Aqua;
                }
                catch (InvalidCastException)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
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
			ingresarCompra.ShowDialog();
		}
		
		void CentroCostoToolStripMenuItemClick(object sender, EventArgs e)
		{
            Control_Inventario.GUI.FormMantenedorCentroCosto cc = new Control_Inventario.GUI.FormMantenedorCentroCosto();
			cc.Show();
        }
		
		void TimerHoraTick(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text =  DateTime.Now.ToString("hh:mm");
			toolStripStatusLabel2.Text =  DateTime.Now.ToString("dd/MM/yyyy");
		}
		
		void DevolucionToolStripMenuItemClick(object sender, EventArgs e)
		{
			GUI.formRebajarStock r = new ControlInsumos.GUI.formRebajarStock();
			r.ShowDialog();
		}

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void insumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control_Inventario.GUI.Registro_Insumos r = new Control_Inventario.GUI.Registro_Insumos();
            r.ShowDialog();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.formMantenedorEmpresa me = new ControlInsumos.GUI.formMantenedorEmpresa();
            me.Show();
            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control_Inventario.GUI.MantenedorEmpresa_Modificar em = new Control_Inventario.GUI.MantenedorEmpresa_Modificar();
            em.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control_Inventario.GUI.MantenedorEmpresa_Eliminar el = new Control_Inventario.GUI.MantenedorEmpresa_Eliminar();
            el.Show();
        }
	}
}
