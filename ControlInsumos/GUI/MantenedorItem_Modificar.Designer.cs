namespace Control_Inventario.GUI
{
    partial class MantenedorItem_Modificar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxItem = new System.Windows.Forms.ComboBox();
            this.cboxArticulo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtItemNuevo = new System.Windows.Forms.TextBox();
            this.cboxArticuloNuevo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxItem);
            this.groupBox1.Controls.Add(this.cboxArticulo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliga Artículo e Item";
            // 
            // cboxItem
            // 
            this.cboxItem.FormattingEnabled = true;
            this.cboxItem.Location = new System.Drawing.Point(114, 45);
            this.cboxItem.Name = "cboxItem";
            this.cboxItem.Size = new System.Drawing.Size(181, 21);
            this.cboxItem.TabIndex = 1;
            this.cboxItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxItem_KeyDown);
            // 
            // cboxArticulo
            // 
            this.cboxArticulo.FormattingEnabled = true;
            this.cboxArticulo.Location = new System.Drawing.Point(114, 20);
            this.cboxArticulo.Name = "cboxArticulo";
            this.cboxArticulo.Size = new System.Drawing.Size(180, 21);
            this.cboxArticulo.TabIndex = 0;
            this.cboxArticulo.SelectedValueChanged += new System.EventHandler(this.cboxArticulo_SelectedValueChanged);
            this.cboxArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxArticulo_KeyDown);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Item";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Artículo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtItemNuevo);
            this.groupBox2.Controls.Add(this.cboxArticuloNuevo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingrese los nuevos Valores";
            // 
            // txtItemNuevo
            // 
            this.txtItemNuevo.Location = new System.Drawing.Point(117, 49);
            this.txtItemNuevo.Name = "txtItemNuevo";
            this.txtItemNuevo.Size = new System.Drawing.Size(179, 20);
            this.txtItemNuevo.TabIndex = 2;
            this.txtItemNuevo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemNuevo_KeyDown);
            // 
            // cboxArticuloNuevo
            // 
            this.cboxArticuloNuevo.FormattingEnabled = true;
            this.cboxArticuloNuevo.Location = new System.Drawing.Point(116, 19);
            this.cboxArticuloNuevo.Name = "cboxArticuloNuevo";
            this.cboxArticuloNuevo.Size = new System.Drawing.Size(180, 21);
            this.cboxArticuloNuevo.TabIndex = 1;
            this.cboxArticuloNuevo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxArticuloNuevo_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nuevo Nombre";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Artículo Nuevo";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(127, 187);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // MantenedorItem_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 222);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantenedorItem_Modificar";
            this.Text = "Modificar Item";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxItem;
        private System.Windows.Forms.ComboBox cboxArticulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtItemNuevo;
        private System.Windows.Forms.ComboBox cboxArticuloNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificar;
    }
}