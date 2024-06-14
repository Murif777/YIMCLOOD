namespace Presentacion
{
    partial class Reportes
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
            this.cbTipoReportes = new System.Windows.Forms.ComboBox();
            this.cbReportes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMembresias = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCaducar = new System.Windows.Forms.RadioButton();
            this.rbActivos = new System.Windows.Forms.RadioButton();
            this.rbMora = new System.Windows.Forms.RadioButton();
            this.rbInactivos = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFiltrarFecha = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTipoReportes
            // 
            this.cbTipoReportes.FormattingEnabled = true;
            this.cbTipoReportes.Location = new System.Drawing.Point(223, 187);
            this.cbTipoReportes.Name = "cbTipoReportes";
            this.cbTipoReportes.Size = new System.Drawing.Size(121, 21);
            this.cbTipoReportes.TabIndex = 1;
            this.cbTipoReportes.SelectedIndexChanged += new System.EventHandler(this.CbTipoReportes_SelectedIndexChanged);
            // 
            // cbReportes
            // 
            this.cbReportes.FormattingEnabled = true;
            this.cbReportes.Location = new System.Drawing.Point(47, 187);
            this.cbReportes.Name = "cbReportes";
            this.cbReportes.Size = new System.Drawing.Size(121, 21);
            this.cbReportes.TabIndex = 2;
            this.cbReportes.SelectedIndexChanged += new System.EventHandler(this.CbReportes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad";
            // 
            // cbMembresias
            // 
            this.cbMembresias.FormattingEnabled = true;
            this.cbMembresias.Location = new System.Drawing.Point(139, 234);
            this.cbMembresias.Name = "cbMembresias";
            this.cbMembresias.Size = new System.Drawing.Size(121, 21);
            this.cbMembresias.TabIndex = 8;
            this.cbMembresias.SelectedIndexChanged += new System.EventHandler(this.CbMembresia_SelectedIndexChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(490, 321);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(10, 13);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "-";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(603, 321);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(10, 13);
            this.lblIngresos.TabIndex = 10;
            this.lblIngresos.Text = "-";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(466, 362);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Location = new System.Drawing.Point(139, 304);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtFechaInicio.TabIndex = 12;
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Location = new System.Drawing.Point(139, 347);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtFechaFinal.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha de inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fecha de final";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCaducar);
            this.groupBox1.Controls.Add(this.rbActivos);
            this.groupBox1.Controls.Add(this.rbMora);
            this.groupBox1.Controls.Add(this.rbInactivos);
            this.groupBox1.Location = new System.Drawing.Point(98, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 120);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // rbCaducar
            // 
            this.rbCaducar.AutoSize = true;
            this.rbCaducar.Location = new System.Drawing.Point(56, 88);
            this.rbCaducar.Name = "rbCaducar";
            this.rbCaducar.Size = new System.Drawing.Size(160, 17);
            this.rbCaducar.TabIndex = 3;
            this.rbCaducar.TabStop = true;
            this.rbCaducar.Text = "Membresia pronta a caducar";
            this.rbCaducar.UseVisualStyleBackColor = true;
            this.rbCaducar.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.Location = new System.Drawing.Point(56, 19);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(60, 17);
            this.rbActivos.TabIndex = 2;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UseVisualStyleBackColor = true;
            this.rbActivos.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbMora
            // 
            this.rbMora.AutoSize = true;
            this.rbMora.Location = new System.Drawing.Point(56, 65);
            this.rbMora.Name = "rbMora";
            this.rbMora.Size = new System.Drawing.Size(64, 17);
            this.rbMora.TabIndex = 1;
            this.rbMora.TabStop = true;
            this.rbMora.Text = "En mora";
            this.rbMora.UseVisualStyleBackColor = true;
            this.rbMora.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbInactivos
            // 
            this.rbInactivos.AutoSize = true;
            this.rbInactivos.Location = new System.Drawing.Point(56, 42);
            this.rbInactivos.Name = "rbInactivos";
            this.rbInactivos.Size = new System.Drawing.Size(68, 17);
            this.rbInactivos.TabIndex = 0;
            this.rbInactivos.TabStop = true;
            this.rbInactivos.Text = "Inactivos";
            this.rbInactivos.UseVisualStyleBackColor = true;
            this.rbInactivos.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 189);
            this.dataGridView1.TabIndex = 17;
            // 
            // btnFiltrarFecha
            // 
            this.btnFiltrarFecha.Location = new System.Drawing.Point(185, 373);
            this.btnFiltrarFecha.Name = "btnFiltrarFecha";
            this.btnFiltrarFecha.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarFecha.TabIndex = 18;
            this.btnFiltrarFecha.Text = "Filtrar";
            this.btnFiltrarFecha.UseVisualStyleBackColor = true;
            this.btnFiltrarFecha.Click += new System.EventHandler(this.btnFiltrarFecha_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ingresos";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 520);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFiltrarFecha);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFechaFinal);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cbMembresias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbReportes);
            this.Controls.Add(this.cbTipoReportes);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoReportes;
        private System.Windows.Forms.ComboBox cbReportes;
        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label Ingresos;
        private System.Windows.Forms.ComboBox cbMembresias;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.DateTimePicker dtFechaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbActivos;
        private System.Windows.Forms.RadioButton rbMora;
        private System.Windows.Forms.RadioButton rbInactivos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbCaducar;
        private System.Windows.Forms.Button btnFiltrarFecha;
        private System.Windows.Forms.Label label4;
    }
}