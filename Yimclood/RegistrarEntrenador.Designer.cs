namespace Presentacion
{
    partial class RegistrarEntrenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarEntrenador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btnregresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnMujer = new System.Windows.Forms.RadioButton();
            this.rdbtnHombre = new System.Windows.Forms.RadioButton();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.TiposMembresia = new System.Windows.Forms.ComboBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnsubirfoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.Btnregresar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 68);
            this.panel1.TabIndex = 0;
            // 
            // Btnregresar
            // 
            this.Btnregresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnregresar.FlatAppearance.BorderSize = 0;
            this.Btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnregresar.Image = ((System.Drawing.Image)(resources.GetObject("Btnregresar.Image")));
            this.Btnregresar.Location = new System.Drawing.Point(9, 9);
            this.Btnregresar.Margin = new System.Windows.Forms.Padding(2);
            this.Btnregresar.Name = "Btnregresar";
            this.Btnregresar.Size = new System.Drawing.Size(66, 44);
            this.Btnregresar.TabIndex = 28;
            this.Btnregresar.UseVisualStyleBackColor = true;
            this.Btnregresar.Click += new System.EventHandler(this.Btnregresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19F);
            this.label1.Location = new System.Drawing.Point(450, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGREGAR ENTRENADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19F);
            this.label3.Location = new System.Drawing.Point(356, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cedula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19F);
            this.label4.Location = new System.Drawing.Point(356, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19F);
            this.label5.Location = new System.Drawing.Point(356, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19F);
            this.label6.Location = new System.Drawing.Point(356, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sexo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19F);
            this.label7.Location = new System.Drawing.Point(356, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Correo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19F);
            this.label8.Location = new System.Drawing.Point(313, 545);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fecha de nacimiento:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(783, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fechaNacimiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNacimiento.Location = new System.Drawing.Point(587, 552);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(118, 22);
            this.fechaNacimiento.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnMujer);
            this.groupBox1.Controls.Add(this.rdbtnHombre);
            this.groupBox1.Location = new System.Drawing.Point(481, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 54);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // rdbtnMujer
            // 
            this.rdbtnMujer.AutoSize = true;
            this.rdbtnMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMujer.Location = new System.Drawing.Point(129, 19);
            this.rdbtnMujer.Name = "rdbtnMujer";
            this.rdbtnMujer.Size = new System.Drawing.Size(63, 22);
            this.rdbtnMujer.TabIndex = 1;
            this.rdbtnMujer.TabStop = true;
            this.rdbtnMujer.Text = "Mujer";
            this.rdbtnMujer.UseVisualStyleBackColor = true;
            // 
            // rdbtnHombre
            // 
            this.rdbtnHombre.AutoSize = true;
            this.rdbtnHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnHombre.Location = new System.Drawing.Point(26, 19);
            this.rdbtnHombre.Name = "rdbtnHombre";
            this.rdbtnHombre.Size = new System.Drawing.Size(80, 22);
            this.rdbtnHombre.TabIndex = 0;
            this.rdbtnHombre.TabStop = true;
            this.rdbtnHombre.Text = "Hombre";
            this.rdbtnHombre.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(481, 495);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(224, 20);
            this.txtCorreo.TabIndex = 22;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(477, 365);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(226, 20);
            this.txtTelefono.TabIndex = 21;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(477, 306);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(226, 20);
            this.txtApellido.TabIndex = 20;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(477, 246);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // TiposMembresia
            // 
            this.TiposMembresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TiposMembresia.FormattingEnabled = true;
            this.TiposMembresia.Location = new System.Drawing.Point(572, 620);
            this.TiposMembresia.Margin = new System.Windows.Forms.Padding(2);
            this.TiposMembresia.Name = "TiposMembresia";
            this.TiposMembresia.Size = new System.Drawing.Size(149, 21);
            this.TiposMembresia.TabIndex = 17;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(477, 193);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(226, 20);
            this.txtCedula.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19F);
            this.label9.Location = new System.Drawing.Point(356, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 31);
            this.label9.TabIndex = 25;
            this.label9.Text = "Telefono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19F);
            this.label10.Location = new System.Drawing.Point(356, 610);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 31);
            this.label10.TabIndex = 26;
            this.label10.Text = "Tipo de Membresia:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19F);
            this.label11.Location = new System.Drawing.Point(778, 277);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 31);
            this.label11.TabIndex = 27;
            this.label11.Text = "Foto:";
            // 
            // btnsubirfoto
            // 
            this.btnsubirfoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsubirfoto.FlatAppearance.BorderSize = 0;
            this.btnsubirfoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubirfoto.Image = ((System.Drawing.Image)(resources.GetObject("btnsubirfoto.Image")));
            this.btnsubirfoto.Location = new System.Drawing.Point(850, 248);
            this.btnsubirfoto.Name = "btnsubirfoto";
            this.btnsubirfoto.Size = new System.Drawing.Size(80, 78);
            this.btnsubirfoto.TabIndex = 28;
            this.btnsubirfoto.UseVisualStyleBackColor = true;
            this.btnsubirfoto.Click += new System.EventHandler(this.btnsubirfoto_Click_1);
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(783, 354);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(175, 175);
            this.pbFoto.TabIndex = 29;
            this.pbFoto.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(195)))), ((int)(((byte)(77)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(783, 552);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(142, 48);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // RegistrarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1214, 806);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btnsubirfoto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fechaNacimiento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.TiposMembresia);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarEntrenador";
            this.Text = "FormEntrenador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbFoto;
        public System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button Btnregresar;
        public System.Windows.Forms.DateTimePicker fechaNacimiento;
        public System.Windows.Forms.RadioButton rdbtnMujer;
        public System.Windows.Forms.RadioButton rdbtnHombre;
        public System.Windows.Forms.TextBox txtCorreo;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.ComboBox TiposMembresia;
        public System.Windows.Forms.TextBox txtCedula;
        public System.Windows.Forms.Button btnsubirfoto;
    }
}