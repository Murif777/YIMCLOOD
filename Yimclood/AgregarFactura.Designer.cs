namespace Presentacion
{
    partial class AgregarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarFactura));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCantidadDisponible = new System.Windows.Forms.Label();
            this.txtCantidadDisponible = new System.Windows.Forms.TextBox();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dataGridViewProductosFactura = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrarFactura = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductosFactura)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "CEDULA: ";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(245, 298);
            this.txtCedula.Multiline = true;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(164, 33);
            this.txtCedula.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(39, 437);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(881, 281);
            this.dataGridView1.TabIndex = 12;
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(1112, 309);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(128, 24);
            this.comboBoxProductos.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(875, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 35);
            this.label2.TabIndex = 15;
            this.label2.Text = "PRODUCTOS: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(428, 293);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 46);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCantidadDisponible
            // 
            this.lblCantidadDisponible.AutoSize = true;
            this.lblCantidadDisponible.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDisponible.Location = new System.Drawing.Point(1335, 55);
            this.lblCantidadDisponible.Name = "lblCantidadDisponible";
            this.lblCantidadDisponible.Size = new System.Drawing.Size(193, 17);
            this.lblCantidadDisponible.TabIndex = 17;
            this.lblCantidadDisponible.Text = "CANTIDAD DISPONIBLE:";
            // 
            // txtCantidadDisponible
            // 
            this.txtCantidadDisponible.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadDisponible.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCantidadDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadDisponible.Location = new System.Drawing.Point(1550, 49);
            this.txtCantidadDisponible.Multiline = true;
            this.txtCantidadDisponible.Name = "txtCantidadDisponible";
            this.txtCantidadDisponible.ReadOnly = true;
            this.txtCantidadDisponible.Size = new System.Drawing.Size(91, 40);
            this.txtCantidadDisponible.TabIndex = 18;
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(1556, 138);
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(84, 22);
            this.numericUpDownCantidad.TabIndex = 19;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1335, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "CANTIDAD POR COMPRAR:";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioTotal.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioTotal.Location = new System.Drawing.Point(1433, 256);
            this.txtPrecioTotal.Multiline = true;
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.ReadOnly = true;
            this.txtPrecioTotal.Size = new System.Drawing.Size(95, 40);
            this.txtPrecioTotal.TabIndex = 21;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioUnitario.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(1524, 202);
            this.txtPrecioUnitario.Multiline = true;
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(111, 40);
            this.txtPrecioUnitario.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1335, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "TOTAL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1335, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "PRECIO POR UNIDAD:";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(1338, 340);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(139, 60);
            this.btnAgregarProducto.TabIndex = 25;
            this.btnAgregarProducto.Text = "agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // dataGridViewProductosFactura
            // 
            this.dataGridViewProductosFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductosFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewProductosFactura.Location = new System.Drawing.Point(1105, 405);
            this.dataGridViewProductosFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProductosFactura.MultiSelect = false;
            this.dataGridViewProductosFactura.Name = "dataGridViewProductosFactura";
            this.dataGridViewProductosFactura.RowHeadersWidth = 51;
            this.dataGridViewProductosFactura.RowTemplate.Height = 24;
            this.dataGridViewProductosFactura.Size = new System.Drawing.Size(623, 305);
            this.dataGridViewProductosFactura.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnRegistrarFactura);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.dataGridViewProductosFactura);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.comboBoxProductos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAgregarProducto);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lblCantidadDisponible);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCantidadDisponible);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numericUpDownCantidad);
            this.panel1.Controls.Add(this.txtPrecioUnitario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPrecioTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1891, 873);
            this.panel1.TabIndex = 27;
            // 
            // btnRegistrarFactura
            // 
            this.btnRegistrarFactura.Location = new System.Drawing.Point(1378, 747);
            this.btnRegistrarFactura.Name = "btnRegistrarFactura";
            this.btnRegistrarFactura.Size = new System.Drawing.Size(195, 78);
            this.btnRegistrarFactura.TabIndex = 27;
            this.btnRegistrarFactura.Text = "GENERAR FACTURA";
            this.btnRegistrarFactura.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(13, 13);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(109, 52);
            this.btnsalir.TabIndex = 28;
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // AgregarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1891, 873);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarFactura";
            this.Text = "AgregarFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductosFactura)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCantidadDisponible;
        private System.Windows.Forms.TextBox txtCantidadDisponible;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridView dataGridViewProductosFactura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistrarFactura;
        private System.Windows.Forms.Button btnsalir;
    }
}