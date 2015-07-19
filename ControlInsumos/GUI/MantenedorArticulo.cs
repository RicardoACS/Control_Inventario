/*
 * Creado por SharpDevelop.
 * Usuario: Rcarrasco
 * Fecha: 18-06-2015
 * Hora: 15:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlInsumos.GUI
{
	/// <summary>
	/// Description of Ingresar_Factura.
	/// </summary>
	public partial class formIngresarArticulo : Form
	{
		public formIngresarArticulo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void createArticulo()
		{
			//Instancia de la Clase Articulo
			ControlInsumos.DLL.Articulo art = new ControlInsumos.DLL.Articulo();
			//Instancia de la Clase ArticuloDal
			ControlInsumos.DAL.ArticuloDal artDal = new ControlInsumos.DAL.ArticuloDal();
			try 
			{
				if (artTxtArticulo.Text.Length > 0) 
				{
					art.IdArticulo = artDal.countArt();
					art.NombreArticulo = artTxtArticulo.Text;
					//Inserción de Articulo a la Base de datos
					int resultado = art.insertArt(art);
					switch (resultado) 
					{
						case  1 :
							MessageBox.Show("Registro Correcto","Mantención Artículo",MessageBoxButtons.OK,MessageBoxIcon.Information);
							limpiar();
							break;
						case 19: 
							MessageBox.Show("Ya existe este artículo","Mantención Artículo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
							break;
					}
				}
			}
			catch (Exception e) 
			{
				MessageBox.Show("decimelo: "+ e.Message,"Mantención Centros de Costos",MessageBoxButtons.OK,MessageBoxIcon.Information);
						
			}
		}
			//Seteos de la Clase Articulo para su posterior inserción
			
		public void limpiar()
		{
			artTxtArticulo.Clear();
		}
		void ArtBtnCrearClick(object sender, EventArgs e)
		{
			createArticulo();
		}
		
		void ArtBtnSalirClick(object sender, EventArgs e)
		{
			Dispose();
		}
		
		void ArtTxtArticuloKeyDown(object sender, KeyEventArgs e)
		{
			//sirve para ir cambiando de control como el TAB
			if (e.KeyCode == Keys.Enter ) 
			{
				this.SelectNextControl(artTxtArticulo,true,true,false,false);
			}		
		}
	}
}
