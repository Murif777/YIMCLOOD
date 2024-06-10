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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Btnregresar = new System.Windows.Forms.Button();
            this.numDuracion = new System.Windows.Forms.NumericUpDown();
            this.cbMusculo = new System.Windows.Forms.ComboBox();
            this.btnSubirfoto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nmRepeticiones = new System.Windows.Forms.NumericUpDown();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumSeries)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRepeticiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "MUSCULO:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(204, 139);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(199, 28);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(75, 271);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(228, 129);
            this.txtDescripcion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "DESCRIPCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "REPETICIONES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(529, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 23;
            this.label5.Text = "SERIES";
            // 
            // NumSeries
            // 
            this.NumSeries.Location = new System.Drawing.Point(648, 251);
            this.NumSeries.Margin = new System.Windows.Forms.Padding(2);
            this.NumSeries.Name = "NumSeries";
            this.NumSeries.Size = new System.Drawing.Size(63, 20);
            this.NumSeries.TabIndex = 22;
            this.NumSeries.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(461, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 26);
            this.label6.TabIndex = 24;
            this.label6.Text = "DURACION (en minutos) ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(468, 316);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 26);
            this.label7.TabIndex = 26;
            this.label7.Text = "CATEGORIAS:";
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(648, 316);
            this.cbCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(137, 21);
            this.cbCategorias.TabIndex = 27;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(594, 389);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(110, 59);
            this.btnRegistrar.TabIndex = 28;
            this.btnRegistrar.Text = "AGREGAR EJERCICIO";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Btnregresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 47);
            this.panel1.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(363, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "AGREGAR EJERCICIOS";
            // 
            // Btnregresar
            // 
            this.Btnregresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnregresar.FlatAppearance.BorderSize = 0;
            this.Btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnregresar.Image = ((System.Drawing.Image)(resources.GetObject("Btnregresar.Image")));
            this.Btnregresar.Location = new System.Drawing.Point(10, 0);
            this.Btnregresar.Name = "Btnregresar";
            this.Btnregresar.Size = new System.Drawing.Size(76, 44);
            this.Btnregresar.TabIndex = 7;
            this.Btnregresar.UseVisualStyleBackColor = true;
            // 
            // numDuracion
            // 
            this.numDuracion.Location = new System.Drawing.Point(746, 88);
            this.numDuracion.Margin = new System.Windows.Forms.Padding(2);
            this.numDuracion.Name = "numDuracion";
            this.numDuracion.Size = new System.Drawing.Size(63, 20);
            this.numDuracion.TabIndex = 30;
            this.numDuracion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbMusculo
            // 
            this.cbMusculo.FormattingEnabled = true;
            this.cbMusculo.Location = new System.Drawing.Point(204, 80);
            this.cbMusculo.Margin = new System.Windows.Forms.Padding(2);
            this.cbMusculo.Name = "cbMusculo";
            this.cbMusculo.Size = new System.Drawing.Size(199, 21);
            this.cbMusculo.TabIndex = 31;
            // 
            // btnSubirfoto
            // 
            this.btnSubirfoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirfoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirfoto.Image = ((System.Drawing.Image)(resources.GetObject("btnSubirfoto.Image")));
            this.btnSubirfoto.Location = new System.Drawing.Point(923, 181);
            this.btnSubirfoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubirfoto.Name = "btnSubirfoto";
            this.btnSubirfoto.Size = new System.Drawing.Size(47, 48);
            this.btnSubirfoto.TabIndex = 33;
            this.btnSubirfoto.UseVisualStyleBackColor = true;
            this.btnSubirfoto.Click += new System.EventHandler(this.btnSubirfoto_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(839, 185);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 32);
            this.label9.TabIndex = 32;
            this.label9.Text = "Foto:";
            // 
            // nmRepeticiones
            // 
            this.nmRepeticiones.Location = new System.Drawing.Point(699, 171);
            this.nmRepeticiones.Margin = new System.Windows.Forms.Padding(2);
            this.nmRepeticiones.Name = "nmRepeticiones";
            this.nmRepeticiones.Size = new System.Drawing.Size(63, 20);
            this.nmRepeticiones.TabIndex = 34;
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(822, 251);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(175, 175);
            this.pbFoto.TabIndex = 35;
            this.pbFoto.TabStop = false;
            // 
            // AgregarEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 536);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.nmRepeticiones);
            this.Controls.Add(this.btnSubirfoto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbMusculo);
            this.Controls.Add(this.numDuracion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumSeries);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarEjercicio";
            this.Text = "AgregarEjercicio";
            ((System.ComponentModel.ISupportInitialize)(this.NumSeries)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRepeticiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
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
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btnregresar;
        private System.Windows.Forms.NumericUpDown numDuracion;
        private System.Windows.Forms.ComboBox cbMusculo;
        private System.Windows.Forms.Button btnSubirfoto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmRepeticiones;
        private System.Windows.Forms.PictureBox pbFoto;
    }
}