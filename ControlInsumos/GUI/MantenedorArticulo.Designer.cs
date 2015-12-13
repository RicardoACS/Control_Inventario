/*
 * Creado por SharpDevelop.
 * Usuario: crojo
 * Fecha: 18-06-2015
 * Hora: 15:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ControlInsumos.GUI
{
	partial class formIngresarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formIngresarArticulo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.artTxtArticulo = new System.Windows.Forms.TextBox();
            this.artLblArticulo = new System.Windows.Forms.Label();
            this.artBtnCrear = new System.Windows.Forms.Button();
            this.artBtnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.artTxtArticulo);
            this.groupBox1.Controls.Add(this.artLblArticulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre Articulo";
            // 
            // artTxtArticulo
            // 
            this.artTxtArticulo.Location = new System.Drawing.Point(75, 23);
            this.artTxtArticulo.Name = "artTxtArticulo";
            this.artTxtArticulo.Size = new System.Drawing.Size(139, 20);
            this.artTxtArticulo.TabIndex = 1;
            this.artTxtArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArtTxtArticuloKeyDown);
            // 
            // artLblArticulo
            // 
            this.artLblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artLblArticulo.Location = new System.Drawing.Point(6, 23);
            this.artLblArticulo.Name = "artLblArticulo";
            this.artLblArticulo.Size = new System.Drawing.Size(63, 17);
            this.artLblArticulo.TabIndex = 0;
            this.artLblArticulo.Text = "Artículo";
            // 
            // artBtnCrear
            // 
            this.artBtnCrear.Location = new System.Drawing.Point(151, 99);
            this.artBtnCrear.Name = "artBtnCrear";
            this.artBtnCrear.Size = new System.Drawing.Size(75, 23);
            this.artBtnCrear.TabIndex = 1;
            this.artBtnCrear.Text = "Crear";
            this.artBtnCrear.UseVisualStyleBackColor = true;
            this.artBtnCrear.Click += new System.EventHandler(this.ArtBtnCrearClick);
            // 
            // artBtnSalir
            // 
            this.artBtnSalir.Location = new System.Drawing.Point(21, 99);
            this.artBtnSalir.Name = "artBtnSalir";
            this.artBtnSalir.Size = new System.Drawing.Size(75, 23);
            this.artBtnSalir.TabIndex = 2;
            this.artBtnSalir.Text = "Salir";
            this.artBtnSalir.UseVisualStyleBackColor = true;
            this.artBtnSalir.Click += new System.EventHandler(this.ArtBtnSalirClick);
            // 
            // formIngresarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 134);
            this.Controls.Add(this.artBtnSalir);
            this.Controls.Add(this.artBtnCrear);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formIngresarArticulo";
            this.Text = "Mantenedor Artículo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.TextBox artTxtArticulo;
		private System.Windows.Forms.Button artBtnCrear;
		private System.Windows.Forms.Button artBtnSalir;
		private System.Windows.Forms.Label artLblArticulo;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
