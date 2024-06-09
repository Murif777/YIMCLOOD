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
    partial class UsuarioMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioMenuPrincipal));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnMaxRes = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlInferior = new System.Windows.Forms.TableLayoutPanel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnRutinas = new System.Windows.Forms.Button();
            this.btnEjercicios = new System.Windows.Forms.Button();
            this.pnlPadre = new System.Windows.Forms.Panel();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlSuperior.Controls.Add(this.btnMaxRes);
            this.pnlSuperior.Controls.Add(this.btnMinimizar);
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1000, 65);
            this.pnlSuperior.TabIndex = 8;
            this.pnlSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseDown);
            // 
            // btnMaxRes
            // 
            this.btnMaxRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxRes.Location = new System.Drawing.Point(852, 2);
            this.btnMaxRes.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaxRes.Name = "btnMaxRes";
            this.btnMaxRes.Size = new System.Drawing.Size(73, 59);
            this.btnMaxRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaxRes.TabIndex = 11;
            this.btnMaxRes.TabStop = false;
            this.btnMaxRes.Click += new System.EventHandler(this.btnMaxRes_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(776, 2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(73, 59);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(928, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(72, 57);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlInferior
            // 
            this.pnlInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlInferior.ColumnCount = 4;
            this.pnlInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlInferior.Controls.Add(this.btnPerfil, 3, 0);
            this.pnlInferior.Controls.Add(this.btnHistorial, 2, 0);
            this.pnlInferior.Controls.Add(this.btnRutinas, 1, 0);
            this.pnlInferior.Controls.Add(this.btnEjercicios, 0, 0);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 676);
            this.pnlInferior.Margin = new System.Windows.Forms.Padding(2);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.RowCount = 1;
            this.pnlInferior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlInferior.Size = new System.Drawing.Size(1000, 124);
            this.pnlInferior.TabIndex = 9;
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 17F);
            this.btnPerfil.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.Location = new System.Drawing.Point(750, 0);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(0);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnPerfil.Size = new System.Drawing.Size(250, 124);
            this.btnPerfil.TabIndex = 9;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.Transparent;
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 17F);
            this.btnHistorial.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Image")));
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHistorial.Location = new System.Drawing.Point(500, 0);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(0);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnHistorial.Size = new System.Drawing.Size(250, 124);
            this.btnHistorial.TabIndex = 8;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnRutinas
            // 
            this.btnRutinas.BackColor = System.Drawing.Color.Transparent;
            this.btnRutinas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRutinas.FlatAppearance.BorderSize = 0;
            this.btnRutinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutinas.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 17F);
            this.btnRutinas.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnRutinas.Image = ((System.Drawing.Image)(resources.GetObject("btnRutinas.Image")));
            this.btnRutinas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRutinas.Location = new System.Drawing.Point(250, 0);
            this.btnRutinas.Margin = new System.Windows.Forms.Padding(0);
            this.btnRutinas.Name = "btnRutinas";
            this.btnRutinas.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnRutinas.Size = new System.Drawing.Size(250, 124);
            this.btnRutinas.TabIndex = 7;
            this.btnRutinas.Text = "Mis rutinas";
            this.btnRutinas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRutinas.UseVisualStyleBackColor = false;
            this.btnRutinas.Click += new System.EventHandler(this.btnRutinas_Click);
            // 
            // btnEjercicios
            // 
            this.btnEjercicios.BackColor = System.Drawing.Color.Transparent;
            this.btnEjercicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEjercicios.FlatAppearance.BorderSize = 0;
            this.btnEjercicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjercicios.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 17F);
            this.btnEjercicios.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEjercicios.Image = ((System.Drawing.Image)(resources.GetObject("btnEjercicios.Image")));
            this.btnEjercicios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEjercicios.Location = new System.Drawing.Point(0, 0);
            this.btnEjercicios.Margin = new System.Windows.Forms.Padding(0);
            this.btnEjercicios.Name = "btnEjercicios";
            this.btnEjercicios.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnEjercicios.Size = new System.Drawing.Size(250, 124);
            this.btnEjercicios.TabIndex = 6;
            this.btnEjercicios.Text = "Ejercicios";
            this.btnEjercicios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEjercicios.UseVisualStyleBackColor = false;
            this.btnEjercicios.Click += new System.EventHandler(this.btnEjercicios_Click);
            // 
            // pnlPadre
            // 
            this.pnlPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPadre.Location = new System.Drawing.Point(0, 65);
            this.pnlPadre.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPadre.Name = "pnlPadre";
            this.pnlPadre.Size = new System.Drawing.Size(1000, 611);
            this.pnlPadre.TabIndex = 10;
            this.pnlPadre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPadre_MouseDown);
            // 
            // UsuarioMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.pnlPadre);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsuarioMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInterfaz";
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlInferior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private TableLayoutPanel pnlInferior;
        private Button btnEjercicios;
        private Button btnRutinas;
        private Button btnHistorial;
        private Button btnPerfil;
        private Panel pnlPadre;
        private PictureBox btnMaxRes;
    }
}