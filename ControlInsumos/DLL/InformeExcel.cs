using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_Inventario.DLL
{
    class InformeExcel
    {
        public void informeExcel(DataGridView dataGridView, String nombreArchivo)
        {
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

                app.Visible = true;

                // get the reference of first sheet. By default its name is Sheet1.

                // store its reference to worksheet

                worksheet = (Excel._Worksheet)workbook.Sheets["Hoja1"];

                worksheet = (Excel._Worksheet)workbook.ActiveSheet;

                // changing the name of active sheet

                worksheet.Name = "Stock";

                // storing header part in Excel

                for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet

                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();

                    }
                }
                // save the application
                workbook.SaveAs(nombreArchivo + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                workbook.Close(true, misValue, misValue);
                MessageBox.Show("El archivo: " + nombreArchivo + ", se ha guardado en Mis Documentos", "Informes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Exit from the application

                app.Quit();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }
    }
}
