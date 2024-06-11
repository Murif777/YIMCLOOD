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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioPerfil));
            this.fotoPerfil = new System.Windows.Forms.PictureBox();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnSubir = new Presentacion.botones.botones();
	    this.btnAgregarDatos = new Presentacion.botones.botones();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(358, 350);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(26, 33);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "-";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 30F);
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 48);
            this.label1.TabIndex = 27;
            this.label1.Text = "Informacion personal";
            // 
            // fotoPerfil
            // 
            this.fotoPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fotoPerfil.BackColor = System.Drawing.Color.White;
            this.fotoPerfil.Location = new System.Drawing.Point(627, 175);
            this.fotoPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.fotoPerfil.Name = "fotoPerfil";
            this.fotoPerfil.Size = new System.Drawing.Size(302, 265);
            this.fotoPerfil.TabIndex = 86;
            this.fotoPerfil.TabStop = false;
            // 
            // lblEstatura
            // 
            this.lblEstatura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.BackColor = System.Drawing.Color.Transparent;
            this.lblEstatura.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 30F);
            this.lblEstatura.Location = new System.Drawing.Point(617, 660);
            this.lblEstatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(46, 60);
            this.lblEstatura.TabIndex = 92;
            this.lblEstatura.Text = "-";
            this.lblEstatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 30F);
            this.lblCorreo.ForeColor = System.Drawing.Color.Black;
            this.lblCorreo.Location = new System.Drawing.Point(617, 517);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(46, 60);
            this.lblCorreo.TabIndex = 90;
            this.lblCorreo.Text = "-";
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 50F);
            this.label1.Location = new System.Drawing.Point(412, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 101);
            this.label1.TabIndex = 85;
            this.label1.Text = "Informacion personal";
            // 
            // lblPeso
            // 
            this.lblPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblPeso.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 30F);
            this.lblPeso.Location = new System.Drawing.Point(617, 721);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(46, 60);
            this.lblPeso.TabIndex = 89;
            this.lblPeso.Text = "-";
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreApellido.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 30F);
            this.lblNombreApellido.Location = new System.Drawing.Point(617, 442);
            this.lblNombreApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(46, 60);
            this.lblNombreApellido.TabIndex = 84;
            this.lblNombreApellido.Text = "-";
            this.lblNombreApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 30F);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(617, 593);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 60);
            this.lblFecha.TabIndex = 87;
            this.lblFecha.Text = "-";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubir
            // 
            this.btnSubir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubir.BackColor = System.Drawing.Color.Transparent;
            this.btnSubir.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSubir.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubir.BorderRadius = 10;
            this.btnSubir.BorderSize = 0;
            this.btnSubir.FlatAppearance.BorderSize = 0;
            this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubir.ForeColor = System.Drawing.Color.White;
            this.btnSubir.Image = ((System.Drawing.Image)(resources.GetObject("btnSubir.Image")));
            this.btnSubir.Location = new System.Drawing.Point(861, 389);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(64, 48);
            this.btnSubir.TabIndex = 93;
            this.btnSubir.TextColor = System.Drawing.Color.White;
            this.btnSubir.UseVisualStyleBackColor = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnAgregarDatos
            // 
            this.btnAgregarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnAgregarDatos.Location = new System.Drawing.Point(1039, 692);
            this.btnAgregarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarDatos.Name = "btnAgregarDatos";
            this.btnAgregarDatos.Size = new System.Drawing.Size(113, 89);
            this.btnAgregarDatos.TabIndex = 91;
            this.btnAgregarDatos.TextColor = System.Drawing.Color.White;
            this.btnAgregarDatos.UseVisualStyleBackColor = false;
            this.btnAgregarDatos.Click += new System.EventHandler(this.btnAgregarDatos_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblCorreo.ForeColor = System.Drawing.Color.Black;
            this.lblCorreo.Location = new System.Drawing.Point(358, 318);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(26, 33);
            this.lblCorreo.TabIndex = 39;
            this.lblCorreo.Text = "-";
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblPeso.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblPeso.Location = new System.Drawing.Point(357, 418);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(26, 33);
            this.lblPeso.TabIndex = 38;
            this.lblPeso.Text = "-";
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreApellido.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblNombreApellido.Location = new System.Drawing.Point(358, 285);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(26, 33);
            this.lblNombreApellido.TabIndex = 3;
            this.lblNombreApellido.Text = "-";
            this.lblNombreApellido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UsuarioPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1500, 792);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.fotoPerfil);
            this.Controls.Add(this.lblEstatura);
            this.Controls.Add(this.btnAgregarDatos);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblNombreApellido);
            this.Controls.Add(this.lblFecha);
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
        private Label lblFecha;
    }
}