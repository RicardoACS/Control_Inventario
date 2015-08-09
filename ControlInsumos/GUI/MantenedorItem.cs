/*
 * Usuario: Ricardo Carrasco
 * Fecha: 30-06-2015
 * Hora: 13:06
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlInsumos.GUI
{
	/// <summary>
	/// Description of Ingresar_Item.
	/// </summary>
	public partial class fromIngresarItem : Form
	{
		public fromIngresarItem()
		{
			InitializeComponent();
			cargarArticulo();
		}
		DAL.ArticuloDal artDal = new ControlInsumos.DAL.ArticuloDal();
		DAL.ItemDal itemDal = new ControlInsumos.DAL.ItemDal();
		public void cargarArticulo()
		{
			cboxArticulo.DataSource = artDal.listArt();
            cboxArticulo.DisplayMember = "NombreArticulo";
            cboxArticulo.ValueMember = "IdArticulo";
            cboxArticulo.SelectedIndex = -1;
		}
		public void insertItem()
		{
			try 
			{
                if(txtDescripcion.Text.Length > 0)
                {
				    DLL.Item i = new ControlInsumos.DLL.Item();
				    i.IdItem 		= itemDal.countItem();
				    i.Descripcion 	= txtDescripcion.Text;
				    i.IdArticulo 	= int.Parse(cboxArticulo.SelectedValue.ToString());
				
				    int resultado = i.insertItem(i);
				
					    switch (resultado) 
					    {
						    case  1 :
							    MessageBox.Show("Registro Correcto","Mantención Item",MessageBoxButtons.OK,MessageBoxIcon.Information);
							    limpiar();
							    break;
						    case 19: 
							    MessageBox.Show("Ya existe este Item","Mantención Item",MessageBoxButtons.OK,MessageBoxIcon.Warning);
							    break;
					    }
                }
                else
                {
                    MessageBox.Show("Recuerde llenar todos los campos", "Mantención Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
			} 
			catch (NullReferenceException)
			{
				MessageBox.Show("Seleccione un Artículo","Mantención Item",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				cboxArticulo.Focus();
			}
			
		}
		public void limpiar()
		{
			cboxArticulo.SelectedIndex = -1;
			txtDescripcion.Clear();
		}
			
		void BtnIngresarClick(object sender, EventArgs e)
		{
			insertItem();
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Dispose();
		}
		
		void CboxArticuloKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				this.SelectNextControl(cboxArticulo,true,true,true,true);		
			}
		}
		
		void TxtDescripcionKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				this.SelectNextControl(txtDescripcion,true,true,false,false);		
			}
		}
	}
}
