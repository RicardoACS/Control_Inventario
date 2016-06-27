namespace Control_Inventario.GUI
{
    partial class InformeReporteInsumos
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxAñoDesde = new System.Windows.Forms.ComboBox();
            this.cboxMesHasta = new System.Windows.Forms.ComboBox();
            this.cboxHasta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxMesDesde = new System.Windows.Forms.ComboBox();
            this.cboxDesde = new System.Windows.Forms.ComboBox();
            this.dgvInformes = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(88, 130);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Reporte";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboxAñoDesde);
            this.groupBox1.Controls.Add(this.cboxMesHasta);
            this.groupBox1.Controls.Add(this.cboxHasta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxMesDesde);
            this.groupBox1.Controls.Add(this.cboxDesde);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros de Busqueda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Año";
            // 
            // cboxAñoDesde
            // 
            this.cboxAñoDesde.FormattingEnabled = true;
            this.cboxAñoDesde.Items.AddRange(new object[] {
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
            this.cboxAñoDesde.Location = new System.Drawing.Point(56, 26);
            this.cboxAñoDesde.Name = "cboxAñoDesde";
            this.cboxAñoDesde.Size = new System.Drawing.Size(58, 21);
            this.cboxAñoDesde.TabIndex = 0;
            this.cboxAñoDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxAñoDesde_KeyDown);
            // 
            // cboxMesHasta
            // 
            this.cboxMesHasta.FormattingEnabled = true;
            this.cboxMesHasta.Items.AddRange(new object[] {
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
            this.cboxMesHasta.Location = new System.Drawing.Point(120, 77);
            this.cboxMesHasta.Name = "cboxMesHasta";
            this.cboxMesHasta.Size = new System.Drawing.Size(82, 21);
            this.cboxMesHasta.TabIndex = 4;
            this.cboxMesHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxMesHasta_KeyDown);
            // 
            // cboxHasta
            // 
            this.cboxHasta.FormattingEnabled = true;
            this.cboxHasta.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cboxHasta.Location = new System.Drawing.Point(56, 77);
            this.cboxHasta.Name = "cboxHasta";
            this.cboxHasta.Size = new System.Drawing.Size(58, 21);
            this.cboxHasta.TabIndex = 3;
            this.cboxHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxHasta_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desde";
            // 
            // cboxMesDesde
            // 
            this.cboxMesDesde.FormattingEnabled = true;
            this.cboxMesDesde.Items.AddRange(new object[] {
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
            this.cboxMesDesde.Location = new System.Drawing.Point(120, 50);
            this.cboxMesDesde.Name = "cboxMesDesde";
            this.cboxMesDesde.Size = new System.Drawing.Size(82, 21);
            this.cboxMesDesde.TabIndex = 2;
            this.cboxMesDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxMesDesde_KeyDown);
            // 
            // cboxDesde
            // 
            this.cboxDesde.FormattingEnabled = true;
            this.cboxDesde.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cboxDesde.Location = new System.Drawing.Point(56, 50);
            this.cboxDesde.Name = "cboxDesde";
            this.cboxDesde.Size = new System.Drawing.Size(58, 21);
            this.cboxDesde.TabIndex = 1;
            this.cboxDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxDesde_KeyDown);
            // 
            // dgvInformes
            // 
            this.dgvInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformes.Location = new System.Drawing.Point(12, 130);
            this.dgvInformes.Name = "dgvInformes";
            this.dgvInformes.Size = new System.Drawing.Size(38, 28);
            this.dgvInformes.TabIndex = 9;
            this.dgvInformes.Visible = false;
            // 
            // InformeReporteInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 163);
            this.Controls.Add(this.dgvInformes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformeReporteInsumos";
            this.Text = "Reporte Insumos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxMesDesde;
        private System.Windows.Forms.ComboBox cboxDesde;
        private System.Windows.Forms.ComboBox cboxHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxAñoDesde;
        private System.Windows.Forms.ComboBox cboxMesHasta;
        private System.Windows.Forms.DataGridView dgvInformes;
    }
}