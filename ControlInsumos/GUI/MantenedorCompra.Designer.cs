/*
 * Creado por SharpDevelop.
 * Usuario: crojo
 * Fecha: 30-06-2015
 * Hora: 12:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ControlInsumos.GUI
{
	partial class fromIngresarCompra
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fromIngresarCompra));
            this.Datos_Compra = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cboxItem = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboxArticulo = new System.Windows.Forms.ComboBox();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Datos_Compra.SuspendLayout();
            this.SuspendLayout();
            // 
            // Datos_Compra
            // 
            this.Datos_Compra.Controls.Add(this.txtPrecio);
            this.Datos_Compra.Controls.Add(this.cboxItem);
            this.Datos_Compra.Controls.Add(this.txtCantidad);
            this.Datos_Compra.Controls.Add(this.cboxArticulo);
            this.Datos_Compra.Controls.Add(this.txtNumeroDoc);
            this.Datos_Compra.Controls.Add(this.txtFecha);
            this.Datos_Compra.Controls.Add(this.label6);
            this.Datos_Compra.Controls.Add(this.label5);
            this.Datos_Compra.Controls.Add(this.label4);
            this.Datos_Compra.Controls.Add(this.label3);
            this.Datos_Compra.Controls.Add(this.label2);
            this.Datos_Compra.Controls.Add(this.label1);
            this.Datos_Compra.Location = new System.Drawing.Point(13, 13);
            this.Datos_Compra.Name = "Datos_Compra";
            this.Datos_Compra.Size = new System.Drawing.Size(270, 162);
            this.Datos_Compra.TabIndex = 0;
            this.Datos_Compra.TabStop = false;
            this.Datos_Compra.Text = "Datos Compra";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(172, 127);
            this.txtPrecio.MaxLength = 10;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(72, 20);
            this.txtPrecio.TabIndex = 11;
            this.txtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPrecioKeyDown);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioKeyPress);
            // 
            // cboxItem
            // 
            this.cboxItem.FormattingEnabled = true;
            this.cboxItem.Location = new System.Drawing.Point(63, 98);
            this.cboxItem.Name = "cboxItem";
            this.cboxItem.Size = new System.Drawing.Size(181, 21);
            this.cboxItem.TabIndex = 9;
            this.cboxItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboxItemKeyDown);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(64, 127);
            this.txtCantidad.MaxLength = 10;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(55, 20);
            this.txtCantidad.TabIndex = 9;
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCantidadKeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidadKeyPress);
            // 
            // cboxArticulo
            // 
            this.cboxArticulo.FormattingEnabled = true;
            this.cboxArticulo.Location = new System.Drawing.Point(64, 72);
            this.cboxArticulo.Name = "cboxArticulo";
            this.cboxArticulo.Size = new System.Drawing.Size(180, 21);
            this.cboxArticulo.TabIndex = 8;
            this.cboxArticulo.TextChanged += new System.EventHandler(this.CboxArticuloTextChanged);
            this.cboxArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboxArticuloKeyDown);
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(64, 46);
            this.txtNumeroDoc.MaxLength = 10;
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDoc.TabIndex = 7;
            this.txtNumeroDoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNumeroDocKeyDown);
            this.txtNumeroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroDocKeyPress);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(64, 20);
            this.txtFecha.MaxLength = 10;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(99, 20);
            this.txtFecha.TabIndex = 6;
            this.txtFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFechaKeyDown);
            this.txtFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFechaKeyPress);
            this.txtFecha.Leave += new System.EventHandler(this.TxtFechaLeave);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Artículo";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "N° Doc";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(33, 190);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.BtnIngresarClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(161, 190);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
            // 
            // fromIngresarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 227);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.Datos_Compra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fromIngresarCompra";
            this.Text = "Mantenedor Compra";
            this.Datos_Compra.ResumeLayout(false);
            this.Datos_Compra.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.ComboBox cboxArticulo;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.ComboBox cboxItem;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtNumeroDoc;
		private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox Datos_Compra;
	}
}
