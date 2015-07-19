/*
 * Creado por SharpDevelop.
 * Usuario: crojo
 * Fecha: 30-06-2015
 * Hora: 12:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ControlInsumos.GUI
{
	/// <summary>
	/// Description of Ingresar_Compra.
	/// </summary>
	public partial class fromIngresarCompra : Form
	{
		public fromIngresarCompra()
		{
			InitializeComponent();
			cargarArticulo();
		}
		DAL.ArticuloDal artDal 		= new ControlInsumos.DAL.ArticuloDal();
		DAL.ItemDal itemDal 		= new ControlInsumos.DAL.ItemDal();
		DAL.CompraDal compraDal 	= new ControlInsumos.DAL.CompraDal();
		public void cargarArticulo()
		{
			cboxArticulo.DataSource = artDal.listArt();
			cboxArticulo.DisplayMember = "NombreArticulo";
            cboxArticulo.ValueMember = "IdArticulo";
            cboxArticulo.SelectedIndex = -1;
           
		}
		public void cargarItem()
		{
			cboxItem.DataSource = itemDal.listItem(cboxArticulo.SelectedIndex+1);
			cboxItem.DisplayMember = "Descripcion";
            cboxItem.ValueMember = "IdItem";
            cboxItem.SelectedIndex = -1;
		}
		public void insertCompra()			
		{
			try 
			{
				DLL.Compra c 		= new ControlInsumos.DLL.Compra();
				c.NumeroDoc 		= int.Parse(txtNumeroDoc.Text);
				c.Fecha 			= txtFecha.Text;
				c.IdArticulo 		= int.Parse(cboxArticulo.SelectedValue.ToString());
				c.IdItem 			= int.Parse(cboxItem.SelectedValue.ToString());
				c.Cantidad 			= int.Parse(txtCantidad.Text);
				c.Precio 			= int.Parse(txtPrecio.Text);
				int resultado = c.insertCompra(c);
					switch (resultado) 
					{
						case  1 :
							MessageBox.Show("Registro Correcto","Mantención Compras",MessageBoxButtons.OK,MessageBoxIcon.Information);
							limpiar();
							break;
						case 19: 
							MessageBox.Show("Ya existe esta compra","Mantención Compras",MessageBoxButtons.OK,MessageBoxIcon.Warning);
							break;
					}
			} 
			catch (FormatException)
			{
				MessageBox.Show("Debe completar todos los valores numericos o\nArreglar la Fecha","Mantención Compras",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtFecha.Focus();
			}
			catch(NullReferenceException)
			{
				MessageBox.Show("Debe seleccionar un valor correcto en:\nArticulo o Item","Mantención Compras",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				cboxArticulo.Focus();
			}
		}
		public void limpiar()
		{
			txtFecha.Clear();
			txtNumeroDoc.Clear();
			txtCantidad.Clear();
			txtPrecio.Clear();
			txtFecha.Focus();
			cboxArticulo.SelectedIndex = -1;
			cboxItem.Text = null;
		}
		
		void TxtFechaKeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            //Esto quiere decir si el largo de tu textbox es igual a 2 o 5 le agrega la -
           if(txtFecha.Text.Length.Equals(2) || txtFecha.Text.Length.Equals(5))
           {  	
           		txtFecha.Text = "/" + txtFecha.Text;     
           }
           
		}
		
		
		void CboxArticuloTextChanged(object sender, EventArgs e)
		{
			cargarItem();
		}
		
		void BtnIngresarClick(object sender, EventArgs e)
		{
			insertCompra();
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Dispose();
		}
		
		void TxtNumeroDocKeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
		}
		
		void TxtCantidadKeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
		}
		
		void TxtPrecioKeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
		}

		
		void TxtFechaKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				this.SelectNextControl(txtFecha,true,true,true,true);		
			}
		}
		
		void TxtNumeroDocKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				this.SelectNextControl(txtNumeroDoc,true,true,true,true);		
			}
		}
		
		void CboxArticuloKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				this.SelectNextControl(cboxArticulo,true,true,true,true);		
			}
		}
		
		void CboxItemKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				this.SelectNextControl(cboxItem,true,true,true,true);		
			}
		}
		
		void TxtCantidadKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				this.SelectNextControl(txtCantidad,true,true,true,true);		
			}
		}
		
		void TxtPrecioKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				this.SelectNextControl(txtPrecio,true,true,false,false);		
			}
		}
		
		void TxtFechaLeave(object sender, EventArgs e)
		{
			
		}
	}
}

