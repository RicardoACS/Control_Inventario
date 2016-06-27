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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRebajarStock));
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.dtFechaGuia = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Centro de Costo";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad";
            // 
            // cboxItem
            // 
            this.cboxItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboxItem.FormattingEnabled = true;
            this.cboxItem.Location = new System.Drawing.Point(6, 167);
            this.cboxItem.Name = "cboxItem";
            this.cboxItem.Size = new System.Drawing.Size(195, 21);
            this.cboxItem.TabIndex = 4;
            this.cboxItem.SelectedIndexChanged += new System.EventHandler(this.cboxItem_SelectedIndexChanged);
            this.cboxItem.TextChanged += new System.EventHandler(this.CboxItemTextChanged);
            this.cboxItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxItem_KeyDown);
            // 
            // cboxCentroCosto
            // 
            this.cboxCentroCosto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboxCentroCosto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxCentroCosto.FormattingEnabled = true;
            this.cboxCentroCosto.Location = new System.Drawing.Point(6, 211);
            this.cboxCentroCosto.Name = "cboxCentroCosto";
            this.cboxCentroCosto.Size = new System.Drawing.Size(195, 21);
            this.cboxCentroCosto.TabIndex = 5;
            this.cboxCentroCosto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxCentroCosto_KeyDown);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(6, 256);
            this.txtCantidad.MaxLength = 20;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(195, 20);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            // 
            // btnRebajar
            // 
            this.btnRebajar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRebajar.Location = new System.Drawing.Point(121, 291);
            this.btnRebajar.Name = "btnRebajar";
            this.btnRebajar.Size = new System.Drawing.Size(80, 23);
            this.btnRebajar.TabIndex = 7;
            this.btnRebajar.Text = "Rebajar";
            this.btnRebajar.UseVisualStyleBackColor = true;
            this.btnRebajar.Click += new System.EventHandler(this.BtnRebajarClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(6, 291);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(76, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtFechaGuia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGuia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboxArticulo);
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
            this.groupBox1.Size = new System.Drawing.Size(223, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese Datos";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 107);
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
            this.cboxArticulo.Location = new System.Drawing.Point(6, 125);
            this.cboxArticulo.Name = "cboxArticulo";
            this.cboxArticulo.Size = new System.Drawing.Size(195, 21);
            this.cboxArticulo.TabIndex = 3;
            this.cboxArticulo.SelectedIndexChanged += new System.EventHandler(this.CboxArticuloTextChanged);
            this.cboxArticulo.TextChanged += new System.EventHandler(this.CboxArticuloTextChanged);
            this.cboxArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxArticulo_KeyDown);
            // 
            // dgvItems
            // 
            this.dgvItems.CausesValidation = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Enabled = false;
            this.dgvItems.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvItems.Location = new System.Drawing.Point(241, 17);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvItems.Size = new System.Drawing.Size(403, 326);
            this.dgvItems.TabIndex = 1;
            // 
            // dtFechaGuia
            // 
            this.dtFechaGuia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaGuia.Location = new System.Drawing.Point(6, 78);
            this.dtFechaGuia.Name = "dtFechaGuia";
            this.dtFechaGuia.Size = new System.Drawing.Size(195, 20);
            this.dtFechaGuia.TabIndex = 2;
            this.dtFechaGuia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtFechaGuia_KeyDown);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fecha Guía";
            // 
            // txtGuia
            // 
            this.txtGuia.Location = new System.Drawing.Point(6, 37);
            this.txtGuia.MaxLength = 20;
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.Size = new System.Drawing.Size(195, 20);
            this.txtGuia.TabIndex = 1;
            this.txtGuia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGuia_KeyDown);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nª Guía";
            // 
            // formRebajarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 355);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvItems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formRebajarStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rebajar Stock";
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
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechaGuia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.Label label5;
	}
}
