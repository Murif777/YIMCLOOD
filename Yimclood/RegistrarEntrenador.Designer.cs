﻿namespace Presentacion
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.Btnregresar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1619, 84);
            this.panel1.TabIndex = 0;
            // 
            // Btnregresar
            // 
            this.Btnregresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnregresar.FlatAppearance.BorderSize = 0;
            this.Btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnregresar.Image = ((System.Drawing.Image)(resources.GetObject("Btnregresar.Image")));
            this.Btnregresar.Location = new System.Drawing.Point(12, 30);
            this.Btnregresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btnregresar.Name = "Btnregresar";
            this.Btnregresar.Size = new System.Drawing.Size(88, 54);
            this.Btnregresar.TabIndex = 28;
            this.Btnregresar.UseVisualStyleBackColor = true;
            this.Btnregresar.Click += new System.EventHandler(this.Btnregresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 40F);
            this.label1.Location = new System.Drawing.Point(788, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGREGAR ENTRENADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label3.Location = new System.Drawing.Point(487, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cedula:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label4.Location = new System.Drawing.Point(471, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 51);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label5.Location = new System.Drawing.Point(468, 341);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 51);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label6.Location = new System.Drawing.Point(524, 534);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 51);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sexo:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label7.Location = new System.Drawing.Point(490, 631);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 51);
            this.label7.TabIndex = 6;
            this.label7.Text = "Correo:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label8.Location = new System.Drawing.Point(268, 747);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(361, 51);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fecha de nacimiento:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(219)))), ((int)(((byte)(132)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1044, 526);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 59);
            this.button1.TabIndex = 15;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fechaNacimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fechaNacimiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fechaNacimiento.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNacimiento.Location = new System.Drawing.Point(796, 750);
            this.fechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(297, 48);
            this.fechaNacimiento.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rdbtnMujer);
            this.groupBox1.Controls.Add(this.rdbtnHombre);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F);
            this.groupBox1.Location = new System.Drawing.Point(676, 515);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(299, 87);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // rdbtnMujer
            // 
            this.rdbtnMujer.AutoSize = true;
            this.rdbtnMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMujer.Location = new System.Drawing.Point(194, 30);
            this.rdbtnMujer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtnMujer.Name = "rdbtnMujer";
            this.rdbtnMujer.Size = new System.Drawing.Size(79, 28);
            this.rdbtnMujer.TabIndex = 1;
            this.rdbtnMujer.TabStop = true;
            this.rdbtnMujer.Text = "Mujer";
            this.rdbtnMujer.UseVisualStyleBackColor = true;
            // 
            // rdbtnHombre
            // 
            this.rdbtnHombre.AutoSize = true;
            this.rdbtnHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnHombre.Location = new System.Drawing.Point(20, 30);
            this.rdbtnHombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtnHombre.Name = "rdbtnHombre";
            this.rdbtnHombre.Size = new System.Drawing.Size(100, 28);
            this.rdbtnHombre.TabIndex = 0;
            this.rdbtnHombre.TabStop = true;
            this.rdbtnHombre.Text = "Hombre";
            this.rdbtnHombre.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtCorreo.Location = new System.Drawing.Point(676, 639);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(297, 45);
            this.txtCorreo.TabIndex = 22;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtTelefono.Location = new System.Drawing.Point(676, 444);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(300, 45);
            this.txtTelefono.TabIndex = 21;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtApellido.Location = new System.Drawing.Point(676, 349);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(300, 45);
            this.txtApellido.TabIndex = 20;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtNombre.Location = new System.Drawing.Point(676, 258);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 45);
            this.txtNombre.TabIndex = 19;
            // 
            // TiposMembresia
            // 
            this.TiposMembresia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TiposMembresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TiposMembresia.FormattingEnabled = true;
            this.TiposMembresia.Location = new System.Drawing.Point(797, 848);
            this.TiposMembresia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TiposMembresia.Name = "TiposMembresia";
            this.TiposMembresia.Size = new System.Drawing.Size(299, 46);
            this.TiposMembresia.TabIndex = 17;
            // 
            // txtCedula
            // 
            this.txtCedula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtCedula.Location = new System.Drawing.Point(676, 166);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(300, 45);
            this.txtCedula.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label9.Location = new System.Drawing.Point(468, 438);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 51);
            this.label9.TabIndex = 25;
            this.label9.Text = "Telefono:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label10.Location = new System.Drawing.Point(295, 843);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(334, 51);
            this.label10.TabIndex = 26;
            this.label10.Text = "Tipo de Membresia:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label11.Location = new System.Drawing.Point(1035, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 51);
            this.label11.TabIndex = 27;
            this.label11.Text = "Foto:";
            // 
            // btnsubirfoto
            // 
            this.btnsubirfoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsubirfoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsubirfoto.FlatAppearance.BorderSize = 0;
            this.btnsubirfoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubirfoto.Image = ((System.Drawing.Image)(resources.GetObject("btnsubirfoto.Image")));
            this.btnsubirfoto.Location = new System.Drawing.Point(1334, 393);
            this.btnsubirfoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsubirfoto.Name = "btnsubirfoto";
            this.btnsubirfoto.Size = new System.Drawing.Size(107, 96);
            this.btnsubirfoto.TabIndex = 28;
            this.btnsubirfoto.UseVisualStyleBackColor = true;
            this.btnsubirfoto.Click += new System.EventHandler(this.btnsubirfoto_Click_1);
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFoto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(1044, 234);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(304, 255);
            this.pbFoto.TabIndex = 29;
            this.pbFoto.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(1044, 526);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(189, 59);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.fechaNacimiento);
            this.panel2.Controls.Add(this.txtCorreo);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.txtCedula);
            this.panel2.Controls.Add(this.TiposMembresia);
            this.panel2.Controls.Add(this.pbFoto);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.btnsubirfoto);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtApellido);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1619, 992);
            this.panel2.TabIndex = 31;
            // 
            // RegistrarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1619, 992);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistrarEntrenador";
            this.Text = "FormEntrenador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
    }
}