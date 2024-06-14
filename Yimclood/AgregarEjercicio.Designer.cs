namespace Presentacion
{
    partial class AgregarEjercicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEjercicio));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumSeries = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Btnregresar = new System.Windows.Forms.Button();
            this.numDuracion = new System.Windows.Forms.NumericUpDown();
            this.cbMusculo = new System.Windows.Forms.ComboBox();
            this.btnSubirfoto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nmRepeticiones = new System.Windows.Forms.NumericUpDown();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new Presentacion.botones.botones();
            ((System.ComponentModel.ISupportInitialize)(this.NumSeries)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRepeticiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label1.Location = new System.Drawing.Point(369, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "MUSCULO:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtNombre.Location = new System.Drawing.Point(628, 217);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(264, 46);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label2.Location = new System.Drawing.Point(369, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Location = new System.Drawing.Point(378, 521);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(477, 285);
            this.txtDescripcion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label3.Location = new System.Drawing.Point(369, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 51);
            this.label3.TabIndex = 4;
            this.label3.Text = "DESCRIPCION:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label4.Location = new System.Drawing.Point(976, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 51);
            this.label4.TabIndex = 21;
            this.label4.Text = "REPETICIONES:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label5.Location = new System.Drawing.Point(976, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 51);
            this.label5.TabIndex = 23;
            this.label5.Text = "SERIES:";
            // 
            // NumSeries
            // 
            this.NumSeries.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NumSeries.AutoSize = true;
            this.NumSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NumSeries.Location = new System.Drawing.Point(1244, 298);
            this.NumSeries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumSeries.Name = "NumSeries";
            this.NumSeries.Size = new System.Drawing.Size(75, 36);
            this.NumSeries.TabIndex = 22;
            this.NumSeries.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumSeries.ValueChanged += new System.EventHandler(this.NumSeries_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label6.Location = new System.Drawing.Point(976, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 51);
            this.label6.TabIndex = 24;
            this.label6.Text = "DURACION:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label7.Location = new System.Drawing.Point(976, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 51);
            this.label7.TabIndex = 26;
            this.label7.Text = "CATEGORIA:";
            // 
            // cbCategorias
            // 
            this.cbCategorias.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(1213, 365);
            this.cbCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(512, 46);
            this.cbCategorias.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Btnregresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1847, 100);
            this.panel1.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label8.Location = new System.Drawing.Point(675, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(600, 81);
            this.label8.TabIndex = 8;
            this.label8.Text = "AGREGAR EJERCICIOS";
            // 
            // Btnregresar
            // 
            this.Btnregresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnregresar.FlatAppearance.BorderSize = 0;
            this.Btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnregresar.Image = ((System.Drawing.Image)(resources.GetObject("Btnregresar.Image")));
            this.Btnregresar.Location = new System.Drawing.Point(4, 46);
            this.Btnregresar.Margin = new System.Windows.Forms.Padding(4);
            this.Btnregresar.Name = "Btnregresar";
            this.Btnregresar.Size = new System.Drawing.Size(101, 54);
            this.Btnregresar.TabIndex = 7;
            this.Btnregresar.UseVisualStyleBackColor = true;
            this.Btnregresar.Click += new System.EventHandler(this.Btnregresar_Click);
            // 
            // numDuracion
            // 
            this.numDuracion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numDuracion.AutoSize = true;
            this.numDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDuracion.Location = new System.Drawing.Point(1244, 148);
            this.numDuracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numDuracion.Name = "numDuracion";
            this.numDuracion.Size = new System.Drawing.Size(75, 36);
            this.numDuracion.TabIndex = 30;
            this.numDuracion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuracion.ValueChanged += new System.EventHandler(this.numDuracion_ValueChanged);
            // 
            // cbMusculo
            // 
            this.cbMusculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMusculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbMusculo.FormattingEnabled = true;
            this.cbMusculo.Location = new System.Drawing.Point(628, 143);
            this.cbMusculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMusculo.Name = "cbMusculo";
            this.cbMusculo.Size = new System.Drawing.Size(264, 46);
            this.cbMusculo.TabIndex = 31;
            // 
            // btnSubirfoto
            // 
            this.btnSubirfoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubirfoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirfoto.FlatAppearance.BorderSize = 0;
            this.btnSubirfoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirfoto.Image = ((System.Drawing.Image)(resources.GetObject("btnSubirfoto.Image")));
            this.btnSubirfoto.Location = new System.Drawing.Point(1282, 726);
            this.btnSubirfoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubirfoto.Name = "btnSubirfoto";
            this.btnSubirfoto.Size = new System.Drawing.Size(115, 80);
            this.btnSubirfoto.TabIndex = 33;
            this.btnSubirfoto.UseVisualStyleBackColor = true;
            this.btnSubirfoto.Click += new System.EventHandler(this.btnSubirfoto_Click_1);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label9.Location = new System.Drawing.Point(961, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 51);
            this.label9.TabIndex = 32;
            this.label9.Text = "Foto:";
            // 
            // nmRepeticiones
            // 
            this.nmRepeticiones.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nmRepeticiones.AutoSize = true;
            this.nmRepeticiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nmRepeticiones.Location = new System.Drawing.Point(1244, 218);
            this.nmRepeticiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmRepeticiones.Name = "nmRepeticiones";
            this.nmRepeticiones.Size = new System.Drawing.Size(75, 36);
            this.nmRepeticiones.TabIndex = 34;
            this.nmRepeticiones.ValueChanged += new System.EventHandler(this.nmRepeticiones_ValueChanged);
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFoto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pbFoto.Location = new System.Drawing.Point(970, 521);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(305, 285);
            this.pbFoto.TabIndex = 35;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pbFoto_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.btnRegistrar);
            this.panel2.Controls.Add(this.cbMusculo);
            this.panel2.Controls.Add(this.pbFoto);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nmRepeticiones);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnSubirfoto);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.numDuracion);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.NumSeries);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbCategorias);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1847, 955);
            this.panel2.TabIndex = 36;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(219)))), ((int)(((byte)(132)))));
            this.btnRegistrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(219)))), ((int)(((byte)(132)))));
            this.btnRegistrar.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.BorderRadius = 10;
            this.btnRegistrar.BorderSize = 1;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.Location = new System.Drawing.Point(876, 851);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(72, 65);
            this.btnRegistrar.TabIndex = 36;
            this.btnRegistrar.TextColor = System.Drawing.Color.White;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // AgregarEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1847, 955);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgregarEjercicio";
            this.Text = "AgregarEjercicio";
            this.Load += new System.EventHandler(this.AgregarEjercicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumSeries)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRepeticiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NumSeries;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btnregresar;
        private System.Windows.Forms.NumericUpDown numDuracion;
        private System.Windows.Forms.ComboBox cbMusculo;
        private System.Windows.Forms.Button btnSubirfoto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmRepeticiones;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Panel panel2;
        private botones.botones btnRegistrar;
    }
}