namespace Control_Inventario.GUI
{
    partial class Articulo_Modificar
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxArticulos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.artTxtArticulo = new System.Windows.Forms.TextBox();
            this.artLblArticulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(101, 119);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxArticulos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.artTxtArticulo);
            this.groupBox1.Controls.Add(this.artLblArticulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Articulo";
            // 
            // cboxArticulos
            // 
            this.cboxArticulos.FormattingEnabled = true;
            this.cboxArticulos.Location = new System.Drawing.Point(116, 25);
            this.cboxArticulos.Name = "cboxArticulos";
            this.cboxArticulos.Size = new System.Drawing.Size(138, 21);
            this.cboxArticulos.TabIndex = 1;
            this.cboxArticulos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxArticulos_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Artículos";
            // 
            // artTxtArticulo
            // 
            this.artTxtArticulo.Location = new System.Drawing.Point(116, 57);
            this.artTxtArticulo.Name = "artTxtArticulo";
            this.artTxtArticulo.Size = new System.Drawing.Size(138, 20);
            this.artTxtArticulo.TabIndex = 2;
            this.artTxtArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.artTxtArticulo_KeyDown);
            // 
            // artLblArticulo
            // 
            this.artLblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artLblArticulo.Location = new System.Drawing.Point(6, 58);
            this.artLblArticulo.Name = "artLblArticulo";
            this.artLblArticulo.Size = new System.Drawing.Size(117, 20);
            this.artLblArticulo.TabIndex = 0;
            this.artLblArticulo.Text = "Nuevo Nombre";
            // 
            // Articulo_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Articulo_Modificar";
            this.Text = "Modificar Articulo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox artTxtArticulo;
        private System.Windows.Forms.Label artLblArticulo;
        private System.Windows.Forms.ComboBox cboxArticulos;
        private System.Windows.Forms.Label label1;
    }
}