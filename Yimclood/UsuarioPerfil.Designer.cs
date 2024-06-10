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
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fotoPerfil = new System.Windows.Forms.PictureBox();
            this.pnlPadre = new System.Windows.Forms.Panel();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.btnAgregarDatos = new Presentacion.botones.botones();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).BeginInit();
            this.pnlPadre.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(388, 418);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 33);
            this.label2.TabIndex = 35;
            this.label2.Text = "Kg";
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fotoPerfil
            // 
            this.fotoPerfil.BackColor = System.Drawing.Color.White;
            this.fotoPerfil.Location = new System.Drawing.Point(343, 71);
            this.fotoPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.fotoPerfil.Name = "fotoPerfil";
            this.fotoPerfil.Size = new System.Drawing.Size(242, 212);
            this.fotoPerfil.TabIndex = 28;
            this.fotoPerfil.TabStop = false;
            // 
            // pnlPadre
            // 
            this.pnlPadre.Controls.Add(this.fotoPerfil);
            this.pnlPadre.Controls.Add(this.lblEstatura);
            this.pnlPadre.Controls.Add(this.btnAgregarDatos);
            this.pnlPadre.Controls.Add(this.lblCorreo);
            this.pnlPadre.Controls.Add(this.label1);
            this.pnlPadre.Controls.Add(this.lblPeso);
            this.pnlPadre.Controls.Add(this.lblNombreApellido);
            this.pnlPadre.Controls.Add(this.label2);
            this.pnlPadre.Controls.Add(this.lblFecha);
            this.pnlPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPadre.Location = new System.Drawing.Point(0, 0);
            this.pnlPadre.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPadre.Name = "pnlPadre";
            this.pnlPadre.Size = new System.Drawing.Size(794, 611);
            this.pnlPadre.TabIndex = 49;
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
            // lblEstatura
            // 
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.BackColor = System.Drawing.Color.Transparent;
            this.lblEstatura.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblEstatura.Location = new System.Drawing.Point(358, 383);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(26, 33);
            this.lblEstatura.TabIndex = 49;
            this.lblEstatura.Text = "-";
            this.lblEstatura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregarDatos
            // 
            this.btnAgregarDatos.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarDatos.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarDatos.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarDatos.BorderRadius = 17;
            this.btnAgregarDatos.BorderSize = 3;
            this.btnAgregarDatos.FlatAppearance.BorderSize = 0;
            this.btnAgregarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDatos.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.btnAgregarDatos.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDatos.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDatos.Image")));
            this.btnAgregarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDatos.Location = new System.Drawing.Point(343, 482);
            this.btnAgregarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarDatos.Name = "btnAgregarDatos";
            this.btnAgregarDatos.Size = new System.Drawing.Size(285, 71);
            this.btnAgregarDatos.TabIndex = 48;
            this.btnAgregarDatos.Text = "Actualizar datos";
            this.btnAgregarDatos.TextColor = System.Drawing.Color.White;
            this.btnAgregarDatos.UseVisualStyleBackColor = false;
            this.btnAgregarDatos.Click += new System.EventHandler(this.btnAgregarDatos_Click);
            // 
            // UsuarioPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(794, 611);
            this.Controls.Add(this.pnlPadre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsuarioPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInterfaz";
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).EndInit();
            this.pnlPadre.ResumeLayout(false);
            this.pnlPadre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label2;
        private Label lblFecha;
        private PictureBox fotoPerfil;
        private Label label1;
        private botones.botones btnAgregarDatos;
        private Panel pnlPadre;
        private Label lblNombreApellido;
        private Label lblPeso;
        private Label lblCorreo;
        private Label lblEstatura;
    }
}