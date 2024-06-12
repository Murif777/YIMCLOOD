using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    partial class UsuarioPerfil
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
            System.Windows.Forms.Button btnSalir;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioPerfil));
            this.fotoPerfil = new System.Windows.Forms.PictureBox();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.lblSaldoDebe = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblTiempoRestante = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubir = new Presentacion.botones.botones();
            this.btnAgregarDatos = new Presentacion.botones.botones();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnSalir.BackColor = System.Drawing.Color.Transparent;
            btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSalir.Location = new System.Drawing.Point(1057, 11);
            btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(64, 54);
            btnSalir.TabIndex = 107;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // fotoPerfil
            // 
            this.fotoPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fotoPerfil.BackColor = System.Drawing.Color.White;
            this.fotoPerfil.Location = new System.Drawing.Point(590, 116);
            this.fotoPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.fotoPerfil.Name = "fotoPerfil";
            this.fotoPerfil.Size = new System.Drawing.Size(257, 220);
            this.fotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPerfil.TabIndex = 86;
            this.fotoPerfil.TabStop = false;
            // 
            // lblEstatura
            // 
            this.lblEstatura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.BackColor = System.Drawing.Color.Transparent;
            this.lblEstatura.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblEstatura.ForeColor = System.Drawing.Color.Black;
            this.lblEstatura.Location = new System.Drawing.Point(706, 454);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(104, 33);
            this.lblEstatura.TabIndex = 92;
            this.lblEstatura.Text = "estatura";
            this.lblEstatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblCorreo.ForeColor = System.Drawing.Color.Black;
            this.lblCorreo.Location = new System.Drawing.Point(551, 378);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(84, 33);
            this.lblCorreo.TabIndex = 39;
            this.lblCorreo.Text = "correo";
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 50F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(25)))), ((int)(((byte)(3)))));
            this.label1.Location = new System.Drawing.Point(406, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 81);
            this.label1.TabIndex = 85;
            this.label1.Text = "Informacion personal";
            // 
            // lblPeso
            // 
            this.lblPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblPeso.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblPeso.ForeColor = System.Drawing.Color.Black;
            this.lblPeso.Location = new System.Drawing.Point(551, 454);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(64, 33);
            this.lblPeso.TabIndex = 38;
            this.lblPeso.Text = "peso";
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreApellido.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblNombreApellido.ForeColor = System.Drawing.Color.Black;
            this.lblNombreApellido.Location = new System.Drawing.Point(551, 340);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(96, 33);
            this.lblNombreApellido.TabIndex = 3;
            this.lblNombreApellido.Text = "nombre";
            this.lblNombreApellido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSaldoDebe
            // 
            this.lblSaldoDebe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldoDebe.AutoSize = true;
            this.lblSaldoDebe.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblSaldoDebe.ForeColor = System.Drawing.Color.Black;
            this.lblSaldoDebe.Location = new System.Drawing.Point(897, 602);
            this.lblSaldoDebe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldoDebe.Name = "lblSaldoDebe";
            this.lblSaldoDebe.Size = new System.Drawing.Size(125, 33);
            this.lblSaldoDebe.TabIndex = 87;
            this.lblSaldoDebe.Text = "saldoDebe";
            this.lblSaldoDebe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(774, 602);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(85, 33);
            this.lblEstado.TabIndex = 94;
            this.lblEstado.Text = "estado";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblFechaFinal.ForeColor = System.Drawing.Color.Black;
            this.lblFechaFinal.Location = new System.Drawing.Point(414, 602);
            this.lblFechaFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(121, 33);
            this.lblFechaFinal.TabIndex = 95;
            this.lblFechaFinal.Text = "fechafinal";
            this.lblFechaFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTiempoRestante
            // 
            this.lblTiempoRestante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTiempoRestante.AutoSize = true;
            this.lblTiempoRestante.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblTiempoRestante.ForeColor = System.Drawing.Color.Black;
            this.lblTiempoRestante.Location = new System.Drawing.Point(580, 602);
            this.lblTiempoRestante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiempoRestante.Name = "lblTiempoRestante";
            this.lblTiempoRestante.Size = new System.Drawing.Size(58, 33);
            this.lblTiempoRestante.TabIndex = 96;
            this.lblTiempoRestante.Text = "dias";
            this.lblTiempoRestante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(414, 569);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 33);
            this.label2.TabIndex = 97;
            this.label2.Text = "Caducidad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(580, 569);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 33);
            this.label3.TabIndex = 98;
            this.label3.Text = "Dias restantes:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(897, 569);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 33);
            this.label4.TabIndex = 99;
            this.label4.Text = "Saldo debe:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubir
            // 
            this.btnSubir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubir.BackColor = System.Drawing.Color.Transparent;
            this.btnSubir.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSubir.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubir.BorderRadius = 10;
            this.btnSubir.BorderSize = 0;
            this.btnSubir.FlatAppearance.BorderSize = 0;
            this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubir.ForeColor = System.Drawing.Color.White;
            this.btnSubir.Image = ((System.Drawing.Image)(resources.GetObject("btnSubir.Image")));
            this.btnSubir.Location = new System.Drawing.Point(851, 297);
            this.btnSubir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(66, 42);
            this.btnSubir.TabIndex = 93;
            this.btnSubir.TextColor = System.Drawing.Color.White;
            this.btnSubir.UseVisualStyleBackColor = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnAgregarDatos
            // 
            this.btnAgregarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAgregarDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAgregarDatos.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarDatos.BorderRadius = 17;
            this.btnAgregarDatos.BorderSize = 3;
            this.btnAgregarDatos.FlatAppearance.BorderSize = 0;
            this.btnAgregarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDatos.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.btnAgregarDatos.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDatos.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDatos.Image")));
            this.btnAgregarDatos.Location = new System.Drawing.Point(936, 429);
            this.btnAgregarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarDatos.Name = "btnAgregarDatos";
            this.btnAgregarDatos.Size = new System.Drawing.Size(77, 58);
            this.btnAgregarDatos.TabIndex = 91;
            this.btnAgregarDatos.TextColor = System.Drawing.Color.White;
            this.btnAgregarDatos.UseVisualStyleBackColor = false;
            this.btnAgregarDatos.Click += new System.EventHandler(this.btnAgregarDatos_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(774, 569);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 33);
            this.label5.TabIndex = 100;
            this.label5.Text = "Estado:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Location = new System.Drawing.Point(585, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 227);
            this.panel1.TabIndex = 101;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(25)))), ((int)(((byte)(3)))));
            this.label8.Location = new System.Drawing.Point(589, 516);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 41);
            this.label8.TabIndex = 104;
            this.label8.Text = "Datos membresia";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(551, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 33);
            this.label9.TabIndex = 105;
            this.label9.Text = "Peso:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(699, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 33);
            this.label10.TabIndex = 106;
            this.label10.Text = "Estatura:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsuarioPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1124, 630);
            this.Controls.Add(btnSalir);
            this.Controls.Add(this.lblNombreApellido);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTiempoRestante);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.fotoPerfil);
            this.Controls.Add(this.lblEstatura);
            this.Controls.Add(this.btnAgregarDatos);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblSaldoDebe);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(25)))), ((int)(((byte)(3)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsuarioPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInterfaz";
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private botones.botones btnSubir;
        private PictureBox fotoPerfil;
        private Label lblEstatura;
        private botones.botones btnAgregarDatos;
        private Label lblCorreo;
        private Label label1;
        private Label lblPeso;
        private Label lblNombreApellido;
        private Label lblSaldoDebe;
        private Label lblEstado;
        private Label lblFechaFinal;
        private Label lblTiempoRestante;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}