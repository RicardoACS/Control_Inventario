/*
 * Creado por SharpDevelop.
 * Usuario: crojo
 * Fecha: 03-07-2015
 * Hora: 15:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ControlInsumos.GUI
{
	partial class formRebajarStock
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cboxItem = new System.Windows.Forms.ComboBox();
			this.cboxCentroCosto = new System.Windows.Forms.ComboBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.btnRebajar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cboxArticulo = new System.Windows.Forms.ComboBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.dgvItems = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(17, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Item";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Centro de Costo";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Cantidad";
			// 
			// cboxItem
			// 
			this.cboxItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboxItem.FormattingEnabled = true;
			this.cboxItem.Location = new System.Drawing.Point(17, 83);
			this.cboxItem.Name = "cboxItem";
			this.cboxItem.Size = new System.Drawing.Size(195, 21);
			this.cboxItem.TabIndex = 2;
			this.cboxItem.TextChanged += new System.EventHandler(this.CboxItemTextChanged);
			// 
			// cboxCentroCosto
			// 
			this.cboxCentroCosto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cboxCentroCosto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboxCentroCosto.FormattingEnabled = true;
			this.cboxCentroCosto.Location = new System.Drawing.Point(17, 127);
			this.cboxCentroCosto.Name = "cboxCentroCosto";
			this.cboxCentroCosto.Size = new System.Drawing.Size(195, 21);
			this.cboxCentroCosto.TabIndex = 3;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(17, 179);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(195, 20);
			this.txtCantidad.TabIndex = 4;
			// 
			// btnRebajar
			// 
			this.btnRebajar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRebajar.Location = new System.Drawing.Point(17, 229);
			this.btnRebajar.Name = "btnRebajar";
			this.btnRebajar.Size = new System.Drawing.Size(55, 23);
			this.btnRebajar.TabIndex = 7;
			this.btnRebajar.Text = "Rebajar";
			this.btnRebajar.UseVisualStyleBackColor = true;
			this.btnRebajar.Click += new System.EventHandler(this.BtnRebajarClick);
			// 
			// btnActualizar
			// 
			this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.Location = new System.Drawing.Point(78, 229);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(64, 23);
			this.btnActualizar.TabIndex = 8;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cboxArticulo);
			this.groupBox1.Controls.Add(this.btnSalir);
			this.groupBox1.Controls.Add(this.txtCantidad);
			this.groupBox1.Controls.Add(this.btnActualizar);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnRebajar);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cboxCentroCosto);
			this.groupBox1.Controls.Add(this.cboxItem);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(223, 276);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ingrese Datos";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(17, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 15);
			this.label4.TabIndex = 10;
			this.label4.Text = "Artículo";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// cboxArticulo
			// 
			this.cboxArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboxArticulo.FormattingEnabled = true;
			this.cboxArticulo.Location = new System.Drawing.Point(17, 41);
			this.cboxArticulo.Name = "cboxArticulo";
			this.cboxArticulo.Size = new System.Drawing.Size(195, 21);
			this.cboxArticulo.TabIndex = 1;
			this.cboxArticulo.SelectedIndexChanged += new System.EventHandler(this.CboxArticuloTextChanged);
			this.cboxArticulo.TextChanged += new System.EventHandler(this.CboxArticuloTextChanged);
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(148, 229);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(64, 23);
			this.btnSalir.TabIndex = 9;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// dgvItems
			// 
			this.dgvItems.CausesValidation = false;
			this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvItems.Location = new System.Drawing.Point(241, 12);
			this.dgvItems.Name = "dgvItems";
			this.dgvItems.ReadOnly = true;
			this.dgvItems.Size = new System.Drawing.Size(393, 276);
			this.dgvItems.TabIndex = 99;
			// 
			// formRebajarStock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(649, 296);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvItems);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "formRebajarStock";
			this.Text = "RebajarStock";
			this.Load += new System.EventHandler(this.RebajarStockLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox cboxArticulo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgvItems;
		private System.Windows.Forms.ComboBox cboxItem;
		private System.Windows.Forms.ComboBox cboxCentroCosto;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Button btnRebajar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
