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
    public partial class informeConsumo : Form
    {
        public informeConsumo()
        {
            InitializeComponent();
        }

        BaseDeDatosLite b = new BaseDeDatosLite();

        public string mes()
        {
            string mes = "00";
            switch (cboxMes.Text)
            {
                case "Enero": mes = "01"; break;
                case "Febrero": mes = "02"; break;
                case "Marzo": mes = "03"; break;
                case "Abril": mes = "04"; break;
                case "Mayo": mes = "05"; break;
                case "Junio": mes = "06"; break;
                case "Julio": mes = "07"; break;
                case "Agosto": mes = "08"; break;
                case "Septiembre": mes = "09"; break;
                case "Octubre": mes = "10"; break;
                case "Noviembre": mes = "11"; break;
                case "Diciembre": mes = "12"; break;
                default: mes = "00"; break;
            }
            return mes;
        }

        public void crearExcelReporteStock()
        {
            ControlInsumos.DAL.RebajarStockDal rebajarStockDal = new ControlInsumos.DAL.RebajarStockDal();

            string nombreArchivo = "";
            string fecha = cboxAño.Text + "-" + mes();
            dgvInforme.DataSource = b.SelectDataTable(rebajarStockDal.reporteConsumo(fecha));
            switch (mes())
            {
                case "01" : nombreArchivo = "Reporte Consumo Enero " + cboxAño.Text; break;
                case "02" : nombreArchivo = "Reporte Consumo Febrero " + cboxAño.Text; break;
                case "03" : nombreArchivo = "Reporte Consumo Marzo " + cboxAño.Text; break;
                case "04" : nombreArchivo = "Reporte Consumo Abril " + cboxAño.Text; break;
                case "05" : nombreArchivo = "Reporte Consumo Mayo " + cboxAño.Text; break;
                case "06" : nombreArchivo = "Reporte Consumo Junio " + cboxAño.Text; break;
                case "07" : nombreArchivo = "Reporte Consumo Julio " + cboxAño.Text; break;
                case "08" : nombreArchivo = "Reporte Consumo Agosto " + cboxAño.Text; break;
                case "09" : nombreArchivo = "Reporte Consumo Septiembre " + cboxAño.Text; break;
                case "10": nombreArchivo = "Reporte Consumo Octubre " + cboxAño.Text; break;
                case "11": nombreArchivo = "Reporte Consumo Noviembre " + cboxAño.Text; break;
                case "12": nombreArchivo = "Reporte Consumo Diciembre " + cboxAño.Text; break;
                default: break;
            }
            
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

                worksheet = (Excel._Worksheet)workbook.Sheets["hoja1"];

                //worksheet = (Excel._Worksheet)workbook.ActiveSheet;

                // changing the name of active sheet

                worksheet.Name = "Resumen Consumo"; 

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
                MessageBox.Show(e.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            crearExcelReporteStock();
        }
    }
}
