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
    partial class UsuarioRutinaPerso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioRutinaPerso));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEjercicios = new System.Windows.Forms.ComboBox();
            this.tablaEjercicios = new System.Windows.Forms.DataGridView();
            this.btnGuadar = new Presentacion.botones.botones();
            this.btnAgregarEjercicio = new Presentacion.botones.botones();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEjercicios)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label3.Location = new System.Drawing.Point(23, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 30F);
            this.label2.Location = new System.Drawing.Point(198, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Crea una rutina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label1.Location = new System.Drawing.Point(23, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtNombre.Location = new System.Drawing.Point(167, 78);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(430, 32);
            this.txtNombre.TabIndex = 14;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtDescripcion.Location = new System.Drawing.Point(167, 125);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(430, 32);
            this.txtDescripcion.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label4.Location = new System.Drawing.Point(23, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ejercicios seleccionados:";
            // 
            // cbEjercicios
            // 
            this.cbEjercicios.FormattingEnabled = true;
            this.cbEjercicios.Location = new System.Drawing.Point(303, 186);
            this.cbEjercicios.Margin = new System.Windows.Forms.Padding(2);
            this.cbEjercicios.Name = "cbEjercicios";
            this.cbEjercicios.Size = new System.Drawing.Size(154, 21);
            this.cbEjercicios.TabIndex = 19;
            // 
            // tablaEjercicios
            // 
            this.tablaEjercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEjercicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaEjercicios.Location = new System.Drawing.Point(29, 239);
            this.tablaEjercicios.Margin = new System.Windows.Forms.Padding(2);
            this.tablaEjercicios.MultiSelect = false;
            this.tablaEjercicios.Name = "tablaEjercicios";
            this.tablaEjercicios.RowHeadersWidth = 51;
            this.tablaEjercicios.RowTemplate.Height = 24;
            this.tablaEjercicios.Size = new System.Drawing.Size(552, 222);
            this.tablaEjercicios.TabIndex = 20;
            this.tablaEjercicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaEjercicios_CellClick);
            // 
            // btnGuadar
            // 
            this.btnGuadar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuadar.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuadar.BorderColor = System.Drawing.Color.Black;
            this.btnGuadar.BorderRadius = 10;
            this.btnGuadar.BorderSize = 2;
            this.btnGuadar.FlatAppearance.BorderSize = 0;
            this.btnGuadar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuadar.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.btnGuadar.ForeColor = System.Drawing.Color.White;
            this.btnGuadar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuadar.Image")));
            this.btnGuadar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuadar.Location = new System.Drawing.Point(601, 305);
            this.btnGuadar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuadar.Name = "btnGuadar";
            this.btnGuadar.Size = new System.Drawing.Size(182, 69);
            this.btnGuadar.TabIndex = 18;
            this.btnGuadar.Text = "Guardar rutina";
            this.btnGuadar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuadar.TextColor = System.Drawing.Color.White;
            this.btnGuadar.UseVisualStyleBackColor = false;
            this.btnGuadar.Click += new System.EventHandler(this.btnGuadar_Click);
            // 
            // btnAgregarEjercicio
            // 
            this.btnAgregarEjercicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAgregarEjercicio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAgregarEjercicio.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarEjercicio.BorderRadius = 10;
            this.btnAgregarEjercicio.BorderSize = 2;
            this.btnAgregarEjercicio.FlatAppearance.BorderSize = 0;
            this.btnAgregarEjercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEjercicio.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.btnAgregarEjercicio.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEjercicio.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEjercicio.Image")));
            this.btnAgregarEjercicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEjercicio.Location = new System.Drawing.Point(461, 163);
            this.btnAgregarEjercicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarEjercicio.Name = "btnAgregarEjercicio";
            this.btnAgregarEjercicio.Size = new System.Drawing.Size(139, 61);
            this.btnAgregarEjercicio.TabIndex = 10;
            this.btnAgregarEjercicio.Text = "Ejercicio";
            this.btnAgregarEjercicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarEjercicio.TextColor = System.Drawing.Color.White;
            this.btnAgregarEjercicio.UseVisualStyleBackColor = false;
            this.btnAgregarEjercicio.Click += new System.EventHandler(this.btnAgregarEjercicio_Click);
            // 
            // UsuarioRutinaPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(794, 472);
            this.Controls.Add(this.tablaEjercicios);
            this.Controls.Add(this.cbEjercicios);
            this.Controls.Add(this.btnGuadar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregarEjercicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsuarioRutinaPerso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInterfaz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tablaEjercicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private botones.botones btnAgregarEjercicio;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Label label4;
        private botones.botones btnGuadar;
        private ComboBox cbEjercicios;
        private DataGridView tablaEjercicios;
    }
}