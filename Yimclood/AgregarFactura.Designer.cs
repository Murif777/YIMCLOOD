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
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCantidadDisponible = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarFactura = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarPro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCantidadDisp = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label3.Location = new System.Drawing.Point(1659, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 41);
            this.label3.TabIndex = 20;
            this.label3.Text = "CANTIDAD POR COMPRAR:";
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownCantidad.AutoSize = true;
            this.numericUpDownCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numericUpDownCantidad.Location = new System.Drawing.Point(2309, 212);
            this.numericUpDownCantidad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(100, 36);
            this.numericUpDownCantidad.TabIndex = 19;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label4.Location = new System.Drawing.Point(2001, 346);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 41);
            this.label4.TabIndex = 23;
            this.label4.Text = "TOTAL:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label5.Location = new System.Drawing.Point(1751, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 41);
            this.label5.TabIndex = 24;
            this.label5.Text = "PRECIO POR UNIDAD:";
            // 
            // lblCantidadDisponible
            // 
            this.lblCantidadDisponible.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidadDisponible.AutoSize = true;
            this.lblCantidadDisponible.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblCantidadDisponible.Location = new System.Drawing.Point(1709, 123);
            this.lblCantidadDisponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadDisponible.Name = "lblCantidadDisponible";
            this.lblCantidadDisponible.Size = new System.Drawing.Size(325, 41);
            this.lblCantidadDisponible.TabIndex = 17;
            this.lblCantidadDisponible.Text = "CANTIDAD DISPONIBLE:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(20, 528);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1087, 519);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.Image")));
            this.btnAgregarProducto.Location = new System.Drawing.Point(2229, 463);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(56, 52);
            this.btnAgregarProducto.TabIndex = 25;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label1.Location = new System.Drawing.Point(8, 449);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "CEDULA: ";
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxProductos.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(1463, 455);
            this.comboBoxProductos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(456, 48);
            this.comboBoxProductos.TabIndex = 14;
            // 
            // txtCedula
            // 
            this.txtCedula.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCedula.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.txtCedula.Location = new System.Drawing.Point(259, 463);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCedula.Multiline = true;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(375, 41);
            this.txtCedula.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(656, 455);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(37, 46);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label2.Location = new System.Drawing.Point(1145, 449);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 51);
            this.label2.TabIndex = 15;
            this.label2.Text = "PRODUCTOS: ";
            // 
            // btnRegistrarFactura
            // 
            this.btnRegistrarFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(219)))), ((int)(((byte)(132)))));
            this.btnRegistrarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarFactura.FlatAppearance.BorderSize = 0;
            this.btnRegistrarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarFactura.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarFactura.Image")));
            this.btnRegistrarFactura.Location = new System.Drawing.Point(1051, 1077);
            this.btnRegistrarFactura.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRegistrarFactura.Name = "btnRegistrarFactura";
            this.btnRegistrarFactura.Size = new System.Drawing.Size(175, 85);
            this.btnRegistrarFactura.TabIndex = 27;
            this.btnRegistrarFactura.UseVisualStyleBackColor = false;
            this.btnRegistrarFactura.Click += new System.EventHandler(this.btnRegistrarFactura_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(20, 39);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(109, 52);
            this.btnsalir.TabIndex = 28;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnEliminarPro);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblCantidadDisp);
            this.panel1.Controls.Add(this.lblPrecioUnitario);
            this.panel1.Controls.Add(this.lblPrecioTotal);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.btnRegistrarFactura);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.comboBoxProductos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAgregarProducto);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lblCantidadDisponible);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numericUpDownCantidad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1848, 788);
            this.panel1.TabIndex = 28;
            // 
            // btnEliminarPro
            // 
            this.btnEliminarPro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarPro.Location = new System.Drawing.Point(2313, 486);
            this.btnEliminarPro.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEliminarPro.Name = "btnEliminarPro";
            this.btnEliminarPro.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarPro.TabIndex = 34;
            this.btnEliminarPro.Text = "Eliminar";
            this.btnEliminarPro.UseVisualStyleBackColor = true;
            this.btnEliminarPro.Click += new System.EventHandler(this.btnEliminarPro_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnsalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1848, 84);
            this.panel2.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 40F);
            this.label6.Location = new System.Drawing.Point(1055, -5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(530, 81);
            this.label6.TabIndex = 29;
            this.label6.Text = "AGREGAR FACTURA";
            // 
            // lblCantidadDisp
            // 
            this.lblCantidadDisp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidadDisp.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.lblCantidadDisp.Location = new System.Drawing.Point(2297, 123);
            this.lblCantidadDisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadDisp.Name = "lblCantidadDisp";
            this.lblCantidadDisp.Size = new System.Drawing.Size(53, 63);
            this.lblCantidadDisp.TabIndex = 32;
            this.lblCantidadDisp.Text = "-";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.lblPrecioUnitario.Location = new System.Drawing.Point(2297, 272);
            this.lblPrecioUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrecioUnitario.Size = new System.Drawing.Size(40, 51);
            this.lblPrecioUnitario.TabIndex = 31;
            this.lblPrecioUnitario.Text = "-";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.lblPrecioTotal.Location = new System.Drawing.Point(2297, 346);
            this.lblPrecioTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(40, 51);
            this.lblPrecioTotal.TabIndex = 30;
            this.lblPrecioTotal.Text = "-";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView2.Location = new System.Drawing.Point(1157, 528);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1291, 519);
            this.dataGridView2.TabIndex = 29;
            // 
            // AgregarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 788);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgregarFactura";
            this.Text = "AgregarFactura";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCantidadDisponible;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarFactura;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblCantidadDisp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminarPro;
    }
}