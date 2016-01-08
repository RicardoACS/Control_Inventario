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
        BaseDeDatosLite b                                = new BaseDeDatosLite();
        Control_Inventario.DLL.InformeExcel informeExcel = new Control_Inventario.DLL.InformeExcel();
        Control_Inventario.DAL.InsumosDal insumosDal     = new Control_Inventario.DAL.InsumosDal();
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
                    ctlMDI.BackColor = Color.LightSkyBlue;
                }
                catch (InvalidCastException)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
        }
		void ArticuloToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void ItemToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void CompraToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void CentroCostoToolStripMenuItemClick(object sender, EventArgs e)
		{
            
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
            me.MdiParent = this;
            me.Show();
            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control_Inventario.GUI.MantenedorEmpresa_Modificar em = new Control_Inventario.GUI.MantenedorEmpresa_Modificar();
            em.MdiParent = this;
            em.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control_Inventario.GUI.MantenedorEmpresa_Eliminar el = new Control_Inventario.GUI.MantenedorEmpresa_Eliminar();
            el.MdiParent = this;
            el.Show();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Control_Inventario.GUI.FormMantenedorCentroCosto cc = new Control_Inventario.GUI.FormMantenedorCentroCosto();
            cc.MdiParent = this;
            cc.Show();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Control_Inventario.GUI.MantenedorCentroCosto_Modificar cc = new Control_Inventario.GUI.MantenedorCentroCosto_Modificar();
            cc.MdiParent = this;
            cc.Show();       
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Control_Inventario.GUI.MantenedorCentroCosto_Eliminar cc = new Control_Inventario.GUI.MantenedorCentroCosto_Eliminar();
            cc.MdiParent = this;
            cc.Show();
        }

        private void crearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GUI.formIngresarArticulo art = new ControlInsumos.GUI.formIngresarArticulo();
            art.MdiParent = this;
            art.Show();
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Control_Inventario.GUI.Articulo_Modificar art = new Control_Inventario.GUI.Articulo_Modificar();
            art.MdiParent = this;
            art.Show();
        }

        private void crearToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            GUI.fromIngresarItem ingresarItem = new ControlInsumos.GUI.fromIngresarItem();
            ingresarItem.MdiParent = this;
            ingresarItem.Show();
        }

        private void ingresarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUI.fromIngresarCompra ingresarCompra = new ControlInsumos.GUI.fromIngresarCompra();
            ingresarCompra.ShowDialog();
        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Control_Inventario.GUI.MantenedorItem_Modificar it = new Control_Inventario.GUI.MantenedorItem_Modificar();
            it.MdiParent = this;
            it.Show();
        }

        private void totalAFacturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvInformes.DataSource = b.SelectDataTable(insumosDal.reporteInsumos());
            informeExcel.informeExcel(dgvInformes, "Informe Insumos " + DateTime.Now);
        }
	}
}
