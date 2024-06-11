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
    partial class UsuarioMisRutinas
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbRutinas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaEjercicios = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEjercicios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.lblDescripcion.Location = new System.Drawing.Point(744, 150);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(18, 24);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "-";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.lblNombre.Location = new System.Drawing.Point(374, 150);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(18, 24);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "-";
            // 
            // cbRutinas
            // 
            this.cbRutinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRutinas.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.cbRutinas.FormattingEnabled = true;
            this.cbRutinas.Location = new System.Drawing.Point(530, 91);
            this.cbRutinas.Name = "cbRutinas";
            this.cbRutinas.Size = new System.Drawing.Size(402, 41);
            this.cbRutinas.TabIndex = 3;
            this.cbRutinas.DropDown += new System.EventHandler(this.cbRutinas_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label3.Location = new System.Drawing.Point(598, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 30F);
            this.label2.Location = new System.Drawing.Point(266, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elija una rutina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label1.Location = new System.Drawing.Point(269, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tablaEjercicios
            // 
            this.tablaEjercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEjercicios.Location = new System.Drawing.Point(274, 194);
            this.tablaEjercicios.Name = "tablaEjercicios";
            this.tablaEjercicios.RowHeadersWidth = 51;
            this.tablaEjercicios.Size = new System.Drawing.Size(789, 513);
            this.tablaEjercicios.TabIndex = 38;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(981, 152);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 27);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // UsuarioMisRutinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1334, 800);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.tablaEjercicios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRutinas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsuarioMisRutinas";
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
        private ComboBox cbRutinas;
        private Label lblDescripcion;
        private Label lblNombre;
        private DataGridView tablaEjercicios;
        private Button btnEliminar;
    }
}