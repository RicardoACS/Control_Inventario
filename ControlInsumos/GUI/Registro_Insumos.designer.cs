/*
 * Creado por SharpDevelop.
 * Usuario: rcarrasco
 * Fecha: 03-12-2015
 * Hora: 13:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Control_Inventario.GUI
{
	partial class Registro_Insumos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtFechaGuia = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxArticulo = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRebajar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxCentroCosto = new System.Windows.Forms.ComboBox();
            this.cboxItem = new System.Windows.Forms.ComboBox();
            this.dgvRegistroInsumos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboxMes = new System.Windows.Forms.ComboBox();
            this.cboxAño = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroInsumos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtID);
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
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese Datos";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(191, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(16, 20);
            this.txtID.TabIndex = 14;
            this.txtID.Visible = false;
            // 
            // dtFechaGuia
            // 
            this.dtFechaGuia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaGuia.Location = new System.Drawing.Point(12, 84);
            this.dtFechaGuia.Name = "dtFechaGuia";
            this.dtFechaGuia.Size = new System.Drawing.Size(195, 20);
            this.dtFechaGuia.TabIndex = 1;
            this.dtFechaGuia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtFechaGuia_KeyDown);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha Guía";
            // 
            // txtGuia
            // 
            this.txtGuia.Location = new System.Drawing.Point(12, 43);
            this.txtGuia.MaxLength = 20;
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.Size = new System.Drawing.Size(195, 20);
            this.txtGuia.TabIndex = 0;
            this.txtGuia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGuia_KeyDown);
            this.txtGuia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuia_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nª Guía";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Artículo";
            // 
            // cboxArticulo
            // 
            this.cboxArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboxArticulo.FormattingEnabled = true;
            this.cboxArticulo.Location = new System.Drawing.Point(12, 175);
            this.cboxArticulo.Name = "cboxArticulo";
            this.cboxArticulo.Size = new System.Drawing.Size(195, 21);
            this.cboxArticulo.TabIndex = 4;
            this.cboxArticulo.SelectedIndexChanged += new System.EventHandler(this.cboxArticulo_SelectedIndexChanged);
            this.cboxArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxArticulo_KeyDown);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(12, 264);
            this.txtCantidad.MaxLength = 20;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(195, 20);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(24, 311);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(64, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item";
            // 
            // btnRebajar
            // 
            this.btnRebajar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRebajar.Location = new System.Drawing.Point(131, 311);
            this.btnRebajar.Name = "btnRebajar";
            this.btnRebajar.Size = new System.Drawing.Size(67, 23);
            this.btnRebajar.TabIndex = 7;
            this.btnRebajar.Text = "Asignar";
            this.btnRebajar.UseVisualStyleBackColor = true;
            this.btnRebajar.Click += new System.EventHandler(this.btnRebajar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Centro de Costo";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad";
            // 
            // cboxCentroCosto
            // 
            this.cboxCentroCosto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboxCentroCosto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxCentroCosto.FormattingEnabled = true;
            this.cboxCentroCosto.Location = new System.Drawing.Point(12, 129);
            this.cboxCentroCosto.Name = "cboxCentroCosto";
            this.cboxCentroCosto.Size = new System.Drawing.Size(195, 21);
            this.cboxCentroCosto.TabIndex = 3;
            this.cboxCentroCosto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxCentroCosto_KeyDown);
            // 
            // cboxItem
            // 
            this.cboxItem.FormattingEnabled = true;
            this.cboxItem.Location = new System.Drawing.Point(12, 219);
            this.cboxItem.Name = "cboxItem";
            this.cboxItem.Size = new System.Drawing.Size(195, 21);
            this.cboxItem.TabIndex = 5;
            this.cboxItem.SelectedIndexChanged += new System.EventHandler(this.cboxItem_SelectedIndexChanged);
            this.cboxItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxItem_KeyDown);
            // 
            // dgvRegistroInsumos
            // 
            this.dgvRegistroInsumos.CausesValidation = false;
            this.dgvRegistroInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroInsumos.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvRegistroInsumos.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvRegistroInsumos.Location = new System.Drawing.Point(240, 68);
            this.dgvRegistroInsumos.Name = "dgvRegistroInsumos";
            this.dgvRegistroInsumos.ReadOnly = true;
            this.dgvRegistroInsumos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRegistroInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistroInsumos.Size = new System.Drawing.Size(422, 290);
            this.dgvRegistroInsumos.TabIndex = 1;
            this.dgvRegistroInsumos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroInsumos_CellClick_1);
            this.dgvRegistroInsumos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroInsumos_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Location = new System.Drawing.Point(413, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 49);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar o Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(157, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(41, 19);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboxAño);
            this.groupBox3.Controls.Add(this.cboxMes);
            this.groupBox3.Location = new System.Drawing.Point(240, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 49);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mes a Trabajar";
            // 
            // cboxMes
            // 
            this.cboxMes.FormattingEnabled = true;
            this.cboxMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cboxMes.Location = new System.Drawing.Point(6, 21);
            this.cboxMes.Name = "cboxMes";
            this.cboxMes.Size = new System.Drawing.Size(82, 21);
            this.cboxMes.TabIndex = 0;
            this.cboxMes.SelectedIndexChanged += new System.EventHandler(this.cboxMes_SelectedIndexChanged);
            // 
            // cboxAño
            // 
            this.cboxAño.FormattingEnabled = true;
            this.cboxAño.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050"});
            this.cboxAño.Location = new System.Drawing.Point(94, 21);
            this.cboxAño.Name = "cboxAño";
            this.cboxAño.Size = new System.Drawing.Size(58, 21);
            this.cboxAño.TabIndex = 1;
            this.cboxAño.SelectedIndexChanged += new System.EventHandler(this.cboxAño_SelectedIndexChanged);
            // 
            // Registro_Insumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 371);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRegistroInsumos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registro_Insumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insumos";
            this.Load += new System.EventHandler(this.RegistroInsumosLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroInsumos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.DataGridView dgvRegistroInsumos;
		private System.Windows.Forms.ComboBox cboxItem;
		private System.Windows.Forms.ComboBox cboxCentroCosto;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnRebajar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.ComboBox cboxArticulo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFechaGuia;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboxMes;
        private System.Windows.Forms.ComboBox cboxAño;
	}
}
