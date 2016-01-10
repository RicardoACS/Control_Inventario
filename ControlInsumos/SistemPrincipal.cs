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
        BaseDeDatosLite b = new BaseDeDatosLite();
        Control_Inventario.DLL.InformeExcel informeExcel = new Control_Inventario.DLL.InformeExcel();
        Control_Inventario.DAL.InsumosDal insumosDal = new Control_Inventario.DAL.InsumosDal();

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
            toolStripStatusLabel1.Text = DateTime.Now.ToString("hh:mm");
            toolStripStatusLabel2.Text = DateTime.Now.ToString("dd/MM/yyyy");
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

        public void crearExcelReporteInsumos()
        {
            ControlInsumos.DAL.ArticuloDal artDal = new ControlInsumos.DAL.ArticuloDal();

            int veces = artDal.countArt() - 1;
            string nombreArchivo = "Reporte Insumos." + DateTime.Now.ToShortDateString();
            try
            {
                // creating Excel Application

                Excel._Application app = new Excel.Application();

                object misValue = System.Reflection.Missing.Value;

                // creating new WorkBook within Excel application

                Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

                // creating new Excelsheet in workbook

                Excel._Worksheet worksheet = null;

                // see the excel sheet behind the program

                app.Visible = false;

                // get the reference of first sheet. By default its name is Sheet1.

                // store its reference to worksheet
                for (int r = 1; r <= veces; r++)
                {
                    string nombreArticulo = artDal.nombreArticulo(r - 1);

                    dgvInformes.DataSource = b.SelectDataTable(insumosDal.reporteInsumos(r, nombreArticulo));

                    worksheet = (Excel._Worksheet)workbook.Sheets["hoja" + r];

                    //worksheet = (Excel._Worksheet)workbook.ActiveSheet;

                    // changing the name of active sheet
                    if (r == 1)
                    {
                        worksheet.Name = "Resumen Insumos";
                    }
                    else
                    {
                        worksheet.Name = nombreArticulo;
                    }

                    // storing header part in Excel

                    for (int i = 1; i < dgvInformes.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dgvInformes.Columns[i - 1].HeaderText;
                    }
                    // storing Each row and column value to excel sheet

                    for (int i = 0; i < dgvInformes.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvInformes.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgvInformes.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
                // save the application
                workbook.SaveAs(nombreArchivo + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                workbook.Close(true, misValue, misValue);
                MessageBox.Show("El archivo: " + nombreArchivo + ", se ha guardado en Mis Documentos", "Informes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Exit from the application

                app.Quit();
            }
            catch (Exception e)
            {
                
            }
        }


        private void totalAFacturarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            crearExcelReporteInsumos();


        }

        private void menuStockDisponible_Click(object sender, EventArgs e)
        {
            Control_Inventario.GUI.informeStockDisponible isd = new Control_Inventario.GUI.informeStockDisponible();
            isd.MdiParent = this;
            isd.Show();
        }

        private void menuConsumido_Click(object sender, EventArgs e)
        {
            Control_Inventario.GUI.informeConsumo ic = new Control_Inventario.GUI.informeConsumo();
            ic.MdiParent = this;
            ic.Show();
        }
    }
}