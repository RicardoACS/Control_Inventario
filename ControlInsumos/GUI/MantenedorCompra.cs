/*
 * Usuario: Ricardo Carrasco
 * Fecha: 30-06-2015
 * Hora: 13:06
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
            try
            {
                cboxItem.SelectedIndex = -1;
                cboxItem.DataSource = itemDal.listItem(int.Parse(cboxArticulo.SelectedValue.ToString()));
			    cboxItem.DisplayMember = "Descripcion";
                cboxItem.ValueMember = "IdItem";
            }
            catch(Exception)
            {

            }
            
		}
		public void insertCompra()			
		{
			try 
			{
				DLL.Compra c 		= new ControlInsumos.DLL.Compra();

                if(compraDal.countCompra() <= 1)
                {
                    c.IdCompra = compraDal.countCompra();
                }
                else
                {
                    c.IdCompra = compraDal.maxCompra();
                }
				c.NumeroDoc 		= int.Parse(txtNumeroDoc.Text);
                c.Fecha             = dtFecha.Text;
				c.IdArticulo 		= int.Parse(cboxArticulo.SelectedValue.ToString());
				c.IdItem 			= int.Parse(cboxItem.SelectedValue.ToString());
				c.Cantidad 			= int.Parse(txtCantidad.Text);
                double precio = Convert.ToDouble(txtPrecio.Text.Replace(".", ",").Replace(",",","));
                c.Precio = (txtPrecio.Text.Replace(".", ".").Replace(",", "."));
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
                dtFecha.Focus();
			}
			catch(NullReferenceException)
			{
				MessageBox.Show("Debe seleccionar un valor correcto en:\nArticulo o Item","Mantención Compras",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				cboxArticulo.Focus();
			}
		}
		public void limpiar()
		{
			//txtNumeroDoc.Clear();
			txtCantidad.Clear();
			txtPrecio.Clear();
			cboxArticulo.Focus();
			//cboxArticulo.SelectedIndex = -1;
			//cboxItem.Text = null;
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
			
		}

		
		void TxtFechaKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				this.SelectNextControl(dtFecha,true,true,true,true);		
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

