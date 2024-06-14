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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
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
            this.Btnregresar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSeleccionmem = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTipoReportes
            // 
            this.cbTipoReportes.FormattingEnabled = true;
            this.cbTipoReportes.Location = new System.Drawing.Point(309, 24);
            this.cbTipoReportes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbTipoReportes.Name = "cbTipoReportes";
            this.cbTipoReportes.Size = new System.Drawing.Size(199, 28);
            this.cbTipoReportes.TabIndex = 1;
            // 
            // cbReportes
            // 
            this.cbReportes.FormattingEnabled = true;
            this.cbReportes.Location = new System.Drawing.Point(326, 290);
            this.cbReportes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbReportes.Name = "cbReportes";
            this.cbReportes.Size = new System.Drawing.Size(200, 28);
            this.cbReportes.TabIndex = 2;
            this.cbReportes.SelectedIndexChanged += new System.EventHandler(this.CbReportes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(836, 448);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad";
            // 
            // cbMembresias
            // 
            this.cbMembresias.FormattingEnabled = true;
            this.cbMembresias.Location = new System.Drawing.Point(326, 347);
            this.cbMembresias.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbMembresias.Name = "cbMembresias";
            this.cbMembresias.Size = new System.Drawing.Size(199, 28);
            this.cbMembresias.TabIndex = 8;
            this.cbMembresias.SelectedIndexChanged += new System.EventHandler(this.CbMembresia_SelectedIndexChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCantidad.Location = new System.Drawing.Point(1061, 454);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(42, 58);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "-";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblIngresos.Location = new System.Drawing.Point(1061, 519);
            this.lblIngresos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(42, 58);
            this.lblIngresos.TabIndex = 10;
            this.lblIngresos.Text = "-";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(219)))), ((int)(((byte)(132)))));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Location = new System.Drawing.Point(1069, 631);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(173, 68);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Location = new System.Drawing.Point(229, 106);
            this.dtFechaInicio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(267, 27);
            this.dtFechaInicio.TabIndex = 12;
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Location = new System.Drawing.Point(229, 161);
            this.dtFechaFinal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(267, 27);
            this.dtFechaFinal.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(79, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha de inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(79, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fecha de final";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCaducar);
            this.groupBox1.Controls.Add(this.rbActivos);
            this.groupBox1.Controls.Add(this.rbMora);
            this.groupBox1.Controls.Add(this.rbInactivos);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(114, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(273, 177);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione filtrado";
            // 
            // rbCaducar
            // 
            this.rbCaducar.AutoSize = true;
            this.rbCaducar.Location = new System.Drawing.Point(67, 133);
            this.rbCaducar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rbCaducar.Name = "rbCaducar";
            this.rbCaducar.Size = new System.Drawing.Size(201, 34);
            this.rbCaducar.TabIndex = 3;
            this.rbCaducar.TabStop = true;
            this.rbCaducar.Text = "Pronta a caducar";
            this.rbCaducar.UseVisualStyleBackColor = true;
            this.rbCaducar.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.Location = new System.Drawing.Point(67, 27);
            this.rbActivos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(106, 34);
            this.rbActivos.TabIndex = 2;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UseVisualStyleBackColor = true;
            this.rbActivos.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbMora
            // 
            this.rbMora.AutoSize = true;
            this.rbMora.Location = new System.Drawing.Point(67, 98);
            this.rbMora.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rbMora.Name = "rbMora";
            this.rbMora.Size = new System.Drawing.Size(116, 34);
            this.rbMora.TabIndex = 1;
            this.rbMora.TabStop = true;
            this.rbMora.Text = "En mora";
            this.rbMora.UseVisualStyleBackColor = true;
            this.rbMora.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbInactivos
            // 
            this.rbInactivos.AutoSize = true;
            this.rbInactivos.Location = new System.Drawing.Point(67, 63);
            this.rbInactivos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rbInactivos.Name = "rbInactivos";
            this.rbInactivos.Size = new System.Drawing.Size(122, 34);
            this.rbInactivos.TabIndex = 0;
            this.rbInactivos.TabStop = true;
            this.rbInactivos.Text = "Inactivos";
            this.rbInactivos.UseVisualStyleBackColor = true;
            this.rbInactivos.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(637, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(709, 291);
            this.dataGridView1.TabIndex = 17;
            // 
            // btnFiltrarFecha
            // 
            this.btnFiltrarFecha.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFiltrarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFiltrarFecha.Location = new System.Drawing.Point(569, 148);
            this.btnFiltrarFecha.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFiltrarFecha.Name = "btnFiltrarFecha";
            this.btnFiltrarFecha.Size = new System.Drawing.Size(93, 36);
            this.btnFiltrarFecha.TabIndex = 18;
            this.btnFiltrarFecha.Text = "Filtrar";
            this.btnFiltrarFecha.UseVisualStyleBackColor = false;
            this.btnFiltrarFecha.Click += new System.EventHandler(this.btnFiltrarFecha_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(843, 518);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 58);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ingresos";
            // 
            // Btnregresar
            // 
            this.Btnregresar.FlatAppearance.BorderSize = 0;
            this.Btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnregresar.Image = ((System.Drawing.Image)(resources.GetObject("Btnregresar.Image")));
            this.Btnregresar.Location = new System.Drawing.Point(25, 12);
            this.Btnregresar.Name = "Btnregresar";
            this.Btnregresar.Size = new System.Drawing.Size(82, 54);
            this.Btnregresar.TabIndex = 20;
            this.Btnregresar.UseVisualStyleBackColor = true;
            this.Btnregresar.Click += new System.EventHandler(this.Btnregresar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 291);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Seleccione un reporte*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(348, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "Seleccione un rango de tiempo";
            // 
            // lblSeleccionmem
            // 
            this.lblSeleccionmem.AutoSize = true;
            this.lblSeleccionmem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblSeleccionmem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionmem.ForeColor = System.Drawing.Color.Black;
            this.lblSeleccionmem.Location = new System.Drawing.Point(14, 346);
            this.lblSeleccionmem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSeleccionmem.Name = "lblSeleccionmem";
            this.lblSeleccionmem.Size = new System.Drawing.Size(373, 29);
            this.lblSeleccionmem.TabIndex = 23;
            this.lblSeleccionmem.Text = "Seleccione un tipo de membresia";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.dtFechaInicio);
            this.groupBox2.Controls.Add(this.cbTipoReportes);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtFechaFinal);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnFiltrarFecha);
            this.groupBox2.Location = new System.Drawing.Point(18, 431);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 226);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(569, 54);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 36);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1254, 735);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblSeleccionmem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btnregresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cbMembresias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbReportes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button Btnregresar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSeleccionmem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReset;
    }
}