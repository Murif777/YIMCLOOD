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
            this.label6 = new System.Windows.Forms.Label();
            this.rbtDiferencia = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtObjetivo = new System.Windows.Forms.RadioButton();
            this.rbtnActual = new System.Windows.Forms.RadioButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarDatos = new Presentacion.botones.botones();
            this.fotoPerfil = new System.Windows.Forms.PictureBox();
            this.pnlPadre = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(233, 555);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 41);
            this.label2.TabIndex = 35;
            this.label2.Text = "Kg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(429, 555);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 41);
            this.label6.TabIndex = 36;
            this.label6.Text = "Kg";
            // 
            // rbtDiferencia
            // 
            this.rbtDiferencia.AutoSize = true;
            this.rbtDiferencia.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24F);
            this.rbtDiferencia.Location = new System.Drawing.Point(528, 507);
            this.rbtDiferencia.Margin = new System.Windows.Forms.Padding(2);
            this.rbtDiferencia.Name = "rbtDiferencia";
            this.rbtDiferencia.Size = new System.Drawing.Size(201, 52);
            this.rbtDiferencia.TabIndex = 26;
            this.rbtDiferencia.TabStop = true;
            this.rbtDiferencia.Text = "Diferencia";
            this.rbtDiferencia.UseVisualStyleBackColor = true;
            this.rbtDiferencia.CheckedChanged += new System.EventHandler(this.rbtDiferencia_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(628, 555);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 41);
            this.label7.TabIndex = 37;
            this.label7.Text = "+ Kg";
            // 
            // rbtObjetivo
            // 
            this.rbtObjetivo.AutoSize = true;
            this.rbtObjetivo.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24F);
            this.rbtObjetivo.Location = new System.Drawing.Point(345, 507);
            this.rbtObjetivo.Margin = new System.Windows.Forms.Padding(2);
            this.rbtObjetivo.Name = "rbtObjetivo";
            this.rbtObjetivo.Size = new System.Drawing.Size(168, 52);
            this.rbtObjetivo.TabIndex = 25;
            this.rbtObjetivo.TabStop = true;
            this.rbtObjetivo.Text = "Objetivo";
            this.rbtObjetivo.UseVisualStyleBackColor = true;
            this.rbtObjetivo.CheckedChanged += new System.EventHandler(this.rbtObjetivo_CheckedChanged);
            // 
            // rbtnActual
            // 
            this.rbtnActual.AutoSize = true;
            this.rbtnActual.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24F);
            this.rbtnActual.Location = new System.Drawing.Point(169, 507);
            this.rbtnActual.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnActual.Name = "rbtnActual";
            this.rbtnActual.Size = new System.Drawing.Size(141, 52);
            this.rbtnActual.TabIndex = 24;
            this.rbtnActual.TabStop = true;
            this.rbtnActual.Text = "Actual";
            this.rbtnActual.UseVisualStyleBackColor = true;
            this.rbtnActual.CheckedChanged += new System.EventHandler(this.rbtnActual_CheckedChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(490, 398);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 41);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "/2024";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblPeso.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPeso.Location = new System.Drawing.Point(478, 359);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(52, 41);
            this.lblPeso.TabIndex = 30;
            this.lblPeso.Text = "Kg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 35F);
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 71);
            this.label1.TabIndex = 27;
            this.label1.Text = "Datos";
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
            this.btnAgregarDatos.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 30F);
            this.btnAgregarDatos.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDatos.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDatos.Image")));
            this.btnAgregarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDatos.Location = new System.Drawing.Point(742, 507);
            this.btnAgregarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarDatos.Name = "btnAgregarDatos";
            this.btnAgregarDatos.Size = new System.Drawing.Size(192, 89);
            this.btnAgregarDatos.TabIndex = 48;
            this.btnAgregarDatos.Text = "Datos";
            this.btnAgregarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarDatos.TextColor = System.Drawing.Color.White;
            this.btnAgregarDatos.UseVisualStyleBackColor = false;
            // 
            // fotoPerfil
            // 
            this.fotoPerfil.BackColor = System.Drawing.Color.White;
            this.fotoPerfil.Location = new System.Drawing.Point(314, 91);
            this.fotoPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.fotoPerfil.Name = "fotoPerfil";
            this.fotoPerfil.Size = new System.Drawing.Size(302, 265);
            this.fotoPerfil.TabIndex = 28;
            this.fotoPerfil.TabStop = false;
            // 
            // pnlPadre
            // 
            this.pnlPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPadre.Location = new System.Drawing.Point(0, 0);
            this.pnlPadre.Name = "pnlPadre";
            this.pnlPadre.Size = new System.Drawing.Size(992, 764);
            this.pnlPadre.TabIndex = 49;
            // 
            // UsuarioPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(992, 764);
            this.Controls.Add(this.btnAgregarDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fotoPerfil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.rbtDiferencia);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbtObjetivo);
            this.Controls.Add(this.rbtnActual);
            this.Controls.Add(this.pnlPadre);
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

        private Label label2;
        private Label label6;
        private RadioButton rbtDiferencia;
        private Label label7;
        private RadioButton rbtObjetivo;
        private RadioButton rbtnActual;
        private Label lblFecha;
        private Label lblPeso;
        private PictureBox fotoPerfil;
        private Label label1;
        private botones.botones btnAgregarDatos;
        private Panel pnlPadre;
    }
}