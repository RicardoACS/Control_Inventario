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
    public partial class InformeReporteInsumos : Form
    {
        public InformeReporteInsumos()
        {
            InitializeComponent();
        }
        Control_Inventario.DAL.InsumosDal insumosDal = new Control_Inventario.DAL.InsumosDal();
        BaseDeDatosLite b = new BaseDeDatosLite();

        public string mesDesde()
        {
            string mes = "00";
            switch (cboxMesDesde.Text)
            {
                case "Enero"        : mes = "01"; break;
                case "Febrero"      : mes = "02"; break;
                case "Marzo"        : mes = "03"; break;
                case "Abril"        : mes = "04"; break;
                case "Mayo"         : mes = "05"; break;
                case "Junio"        : mes = "06"; break;
                case "Julio"        : mes = "07"; break;
                case "Agosto"       : mes = "08"; break;
                case "Septiembre"   : mes = "09"; break;
                case "Octubre"      : mes = "10"; break;
                case "Noviembre"    : mes = "11"; break;
                case "Diciembre"    : mes = "12"; break;
                default             : mes = "00"; break;
            }
            return mes;
        }

        public string mesHasta()
        {
            string mes = "00";
            switch (cboxMesHasta.Text)
            {
                case "Enero"        : mes = "01"; break;
                case "Febrero"      : mes = "02"; break;
                case "Marzo"        : mes = "03"; break;
                case "Abril"        : mes = "04"; break;
                case "Mayo"         : mes = "05"; break;
                case "Junio"        : mes = "06"; break;
                case "Julio"        : mes = "07"; break;
                case "Agosto"       : mes = "08"; break;
                case "Septiembre"   : mes = "09"; break;
                case "Octubre"      : mes = "10"; break;
                case "Noviembre"    : mes = "11"; break;
                case "Diciembre"    : mes = "12"; break;
                default             : mes = "00"; break;
            }
            return mes;
        }

        public void crearExcelReporteInsumos()
        {
            ControlInsumos.DAL.ArticuloDal artDal = new ControlInsumos.DAL.ArticuloDal();

            int veces = artDal.countArt();
            string desde = cboxAñoDesde.Text + "-" + mesDesde() + "-" + cboxDesde.Text;
            string hasta = cboxAñoDesde.Text + "-" + mesHasta() + "-" + cboxHasta.Text;

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

                    dgvInformes.DataSource = b.SelectDataTable(insumosDal.reporteInsumos(r, nombreArticulo, desde, hasta));

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            crearExcelReporteInsumos();
        }

        private void cboxAñoDesde_KeyDown(object sender, KeyEventArgs e)
        {
            //sirve para ir cambiando de control como el TAB
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(cboxAñoDesde, true, true, true, true);
            }
        }

        private void cboxDesde_KeyDown(object sender, KeyEventArgs e)
        {
            //sirve para ir cambiando de control como el TAB
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(cboxDesde, true, true, true, true);
            }
        }

        private void cboxHasta_KeyDown(object sender, KeyEventArgs e)
        {
            //sirve para ir cambiando de control como el TAB
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(cboxHasta, true, true, true, true);
            }
        }

        private void cboxMesDesde_KeyDown(object sender, KeyEventArgs e)
        {
            //sirve para ir cambiando de control como el TAB
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(cboxMesDesde, true, true, true, true);
            }
        }

        private void cboxMesHasta_KeyDown(object sender, KeyEventArgs e)
        {
            //sirve para ir cambiando de control como el TAB
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(cboxMesHasta, true, true, true, true);
            }
        }
    }
}
