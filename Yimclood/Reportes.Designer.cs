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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTipoReportes
            // 
            this.cbTipoReportes.FormattingEnabled = true;
            this.cbTipoReportes.Location = new System.Drawing.Point(371, 288);
            this.cbTipoReportes.Margin = new System.Windows.Forms.Padding(5);
            this.cbTipoReportes.Name = "cbTipoReportes";
            this.cbTipoReportes.Size = new System.Drawing.Size(199, 28);
            this.cbTipoReportes.TabIndex = 1;
            this.cbTipoReportes.SelectedIndexChanged += new System.EventHandler(this.CbTipoReportes_SelectedIndexChanged);
            // 
            // cbReportes
            // 
            this.cbReportes.FormattingEnabled = true;
            this.cbReportes.Location = new System.Drawing.Point(79, 288);
            this.cbReportes.Margin = new System.Windows.Forms.Padding(5);
            this.cbReportes.Name = "cbReportes";
            this.cbReportes.Size = new System.Drawing.Size(199, 28);
            this.cbReportes.TabIndex = 2;
            this.cbReportes.SelectedIndexChanged += new System.EventHandler(this.CbReportes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(836, 448);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad";
            // 
            // cbMembresias
            // 
            this.cbMembresias.FormattingEnabled = true;
            this.cbMembresias.Location = new System.Drawing.Point(231, 360);
            this.cbMembresias.Margin = new System.Windows.Forms.Padding(5);
            this.cbMembresias.Name = "cbMembresias";
            this.cbMembresias.Size = new System.Drawing.Size(199, 28);
            this.cbMembresias.TabIndex = 8;
            this.cbMembresias.SelectedIndexChanged += new System.EventHandler(this.CbMembresia_SelectedIndexChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(947, 448);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(21, 29);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "-";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.Location = new System.Drawing.Point(947, 517);
            this.lblIngresos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(21, 29);
            this.lblIngresos.TabIndex = 10;
            this.lblIngresos.Text = "-";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.Location = new System.Drawing.Point(1065, 646);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(173, 68);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Location = new System.Drawing.Point(306, 469);
            this.dtFechaInicio.Margin = new System.Windows.Forms.Padding(5);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(330, 27);
            this.dtFechaInicio.TabIndex = 12;
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Location = new System.Drawing.Point(306, 535);
            this.dtFechaFinal.Margin = new System.Windows.Forms.Padding(5);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(330, 27);
            this.dtFechaFinal.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 478);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha de inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 534);
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
            this.groupBox1.Location = new System.Drawing.Point(164, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(426, 185);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // rbCaducar
            // 
            this.rbCaducar.AutoSize = true;
            this.rbCaducar.Location = new System.Drawing.Point(94, 135);
            this.rbCaducar.Margin = new System.Windows.Forms.Padding(5);
            this.rbCaducar.Name = "rbCaducar";
            this.rbCaducar.Size = new System.Drawing.Size(244, 24);
            this.rbCaducar.TabIndex = 3;
            this.rbCaducar.TabStop = true;
            this.rbCaducar.Text = "Membresia pronta a caducar";
            this.rbCaducar.UseVisualStyleBackColor = true;
            this.rbCaducar.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.Location = new System.Drawing.Point(94, 29);
            this.rbActivos.Margin = new System.Windows.Forms.Padding(5);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(85, 24);
            this.rbActivos.TabIndex = 2;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UseVisualStyleBackColor = true;
            this.rbActivos.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbMora
            // 
            this.rbMora.AutoSize = true;
            this.rbMora.Location = new System.Drawing.Point(94, 100);
            this.rbMora.Margin = new System.Windows.Forms.Padding(5);
            this.rbMora.Name = "rbMora";
            this.rbMora.Size = new System.Drawing.Size(93, 24);
            this.rbMora.TabIndex = 1;
            this.rbMora.TabStop = true;
            this.rbMora.Text = "En mora";
            this.rbMora.UseVisualStyleBackColor = true;
            this.rbMora.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbInactivos
            // 
            this.rbInactivos.AutoSize = true;
            this.rbInactivos.Location = new System.Drawing.Point(94, 65);
            this.rbInactivos.Margin = new System.Windows.Forms.Padding(5);
            this.rbInactivos.Name = "rbInactivos";
            this.rbInactivos.Size = new System.Drawing.Size(96, 24);
            this.rbInactivos.TabIndex = 0;
            this.rbInactivos.TabStop = true;
            this.rbInactivos.Text = "Inactivos";
            this.rbInactivos.UseVisualStyleBackColor = true;
            this.rbInactivos.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(645, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
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
            this.btnFiltrarFecha.Location = new System.Drawing.Point(231, 605);
            this.btnFiltrarFecha.Margin = new System.Windows.Forms.Padding(5);
            this.btnFiltrarFecha.Name = "btnFiltrarFecha";
            this.btnFiltrarFecha.Size = new System.Drawing.Size(143, 42);
            this.btnFiltrarFecha.TabIndex = 18;
            this.btnFiltrarFecha.Text = "Filtrar";
            this.btnFiltrarFecha.UseVisualStyleBackColor = false;
            this.btnFiltrarFecha.Click += new System.EventHandler(this.btnFiltrarFecha_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(836, 517);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
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
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1444, 800);
            this.Controls.Add(this.Btnregresar);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
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
        private System.Windows.Forms.Button Btnregresar;
    }
}