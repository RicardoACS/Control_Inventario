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
    public partial class informeStockDisponible : Form
    {
        public informeStockDisponible()
        {
            InitializeComponent();
            cargarArticulo();
        }
        BaseDeDatosLite b = new BaseDeDatosLite();
        ControlInsumos.DAL.ArticuloDal artDal = new ControlInsumos.DAL.ArticuloDal();

        public void cargarArticulo()
        {
            //Carga los Articulos en el ComboBox
            cboxArticulo.DataSource = artDal.listArtAll();
            cboxArticulo.DisplayMember = "NombreArticulo";
            cboxArticulo.ValueMember = "IdArticulo";
            cboxArticulo.SelectedIndex = -1;
        }
        public void crearExcelReporteStock()
        {
            ControlInsumos.DAL.RebajarStockDal rebajarStockDal = new ControlInsumos.DAL.RebajarStockDal();

            string nombreArchivo = "Reporte Stock " + cboxArticulo.Text + " " + DateTime.Now.ToShortDateString();
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

                    dgvInforme.DataSource = b.SelectDataTable(rebajarStockDal.reporteStockDisponible(cboxArticulo.Text));

                    worksheet = (Excel._Worksheet)workbook.Sheets["hoja1"];

                    //worksheet = (Excel._Worksheet)workbook.ActiveSheet;

                    // changing the name of active sheet

                    worksheet.Name = "Resumen Stock";                    

                    // storing header part in Excel

                    for (int i = 1; i < dgvInforme.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dgvInforme.Columns[i - 1].HeaderText;
                    }
                    // storing Each row and column value to excel sheet

                    for (int i = 0; i < dgvInforme.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvInforme.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgvInforme.Rows[i].Cells[j].Value.ToString();
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
            crearExcelReporteStock();
        }
    }
}
