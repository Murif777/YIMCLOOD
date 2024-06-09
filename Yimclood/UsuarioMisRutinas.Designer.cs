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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioMisRutinas));
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbRutinas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnAgregarRutinas = new Presentacion.botones.botones();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.lblDescripcion.Location = new System.Drawing.Point(472, 97);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(145, 30);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "DESCRIPCION";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.lblNombre.Location = new System.Drawing.Point(160, 97);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 30);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "NOMBRE";
            // 
            // cbRutinas
            // 
            this.cbRutinas.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14F);
            this.cbRutinas.FormattingEnabled = true;
            this.cbRutinas.Location = new System.Drawing.Point(528, 34);
            this.cbRutinas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRutinas.Name = "cbRutinas";
            this.cbRutinas.Size = new System.Drawing.Size(192, 36);
            this.cbRutinas.TabIndex = 3;
            this.cbRutinas.SelectedIndexChanged += new System.EventHandler(this.cbRutinas_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label3.Location = new System.Drawing.Point(290, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 30F);
            this.label2.Location = new System.Drawing.Point(199, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elija una rutina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Desktop;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(209, 169);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(511, 401);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnAgregarRutinas
            // 
            this.btnAgregarRutinas.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarRutinas.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarRutinas.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarRutinas.BorderRadius = 10;
            this.btnAgregarRutinas.BorderSize = 2;
            this.btnAgregarRutinas.FlatAppearance.BorderSize = 0;
            this.btnAgregarRutinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRutinas.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.btnAgregarRutinas.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRutinas.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarRutinas.Image")));
            this.btnAgregarRutinas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRutinas.Location = new System.Drawing.Point(773, 260);
            this.btnAgregarRutinas.Name = "btnAgregarRutinas";
            this.btnAgregarRutinas.Size = new System.Drawing.Size(187, 54);
            this.btnAgregarRutinas.TabIndex = 10;
            this.btnAgregarRutinas.Text = "Mis rutinas";
            this.btnAgregarRutinas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarRutinas.TextColor = System.Drawing.Color.White;
            this.btnAgregarRutinas.UseVisualStyleBackColor = false;
            this.btnAgregarRutinas.Click += new System.EventHandler(this.btnAgregarRutinas_Click);
            // 
            // UsuarioMisRutinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(992, 590);
            this.Controls.Add(this.btnAgregarRutinas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
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
        private ListView listView1;
        private botones.botones btnAgregarRutinas;
    }
}