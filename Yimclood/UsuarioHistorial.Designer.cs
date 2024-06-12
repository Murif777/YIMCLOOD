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
    partial class UsuarioHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioHistorial));
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSiguiente = new Presentacion.botones.botones();
            this.btnAnterior = new Presentacion.botones.botones();
            this.btnAgregar = new Presentacion.botones.botones();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LBDATE = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daycontainer
            // 
            this.daycontainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.daycontainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.daycontainer.Location = new System.Drawing.Point(115, 185);
            this.daycontainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(1176, 510);
            this.daycontainer.TabIndex = 10;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSiguiente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSiguiente.BorderColor = System.Drawing.Color.Black;
            this.btnSiguiente.BorderRadius = 10;
            this.btnSiguiente.BorderSize = 1;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.btnSiguiente.ForeColor = System.Drawing.Color.Black;
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(1229, 703);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(65, 72);
            this.btnSiguiente.TabIndex = 20;
            this.btnSiguiente.TextColor = System.Drawing.Color.Black;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnterior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAnterior.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAnterior.BorderColor = System.Drawing.Color.Black;
            this.btnAnterior.BorderRadius = 10;
            this.btnAnterior.BorderSize = 1;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.btnAnterior.ForeColor = System.Drawing.Color.Black;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(1160, 703);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(61, 72);
            this.btnAnterior.TabIndex = 11;
            this.btnAnterior.TextColor = System.Drawing.Color.Black;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.BorderRadius = 15;
            this.btnAgregar.BorderSize = 1;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(1314, 625);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 70);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.TextColor = System.Drawing.Color.Black;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 30F);
            this.label7.Location = new System.Drawing.Point(1338, 618);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 60);
            this.label7.TabIndex = 24;
            this.label7.Text = "Rutina";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label8.Location = new System.Drawing.Point(146, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 45);
            this.label8.TabIndex = 31;
            this.label8.Text = "Domingo";
            // 
            // LBDATE
            // 
            this.LBDATE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LBDATE.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 30F);
            this.LBDATE.Location = new System.Drawing.Point(512, 65);
            this.LBDATE.Name = "LBDATE";
            this.LBDATE.Size = new System.Drawing.Size(414, 69);
            this.LBDATE.TabIndex = 30;
            this.LBDATE.Text = "MES | AÑO";
            this.LBDATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label5.Location = new System.Drawing.Point(999, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 39);
            this.label5.TabIndex = 29;
            this.label5.Text = "Viernes";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label1.Location = new System.Drawing.Point(1166, 134);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(129, 45);
            this.label1.TabIndex = 28;
            this.label1.Text = "Sabado";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label3.Location = new System.Drawing.Point(647, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 39);
            this.label3.TabIndex = 27;
            this.label3.Text = "Miercoles";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label4.Location = new System.Drawing.Point(828, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 42);
            this.label4.TabIndex = 26;
            this.label4.Text = "Jueves";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label2.Location = new System.Drawing.Point(332, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 43);
            this.label2.TabIndex = 25;
            this.label2.Text = "Lunes";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label9.Location = new System.Drawing.Point(492, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 35);
            this.label9.TabIndex = 24;
            this.label9.Text = "Martes";
            // 
            // UsuarioHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1875, 992);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LBDATE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.daycontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsuarioHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInterfaz";
            this.Load += new System.EventHandler(this.UsuarioHistorial_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private botones.botones btnAnterior;
        private FlowLayoutPanel daycontainer;
        private botones.botones btnSiguiente;
        private botones.botones btnAgregar;
        private Label label7;
        private Label label8;
        private Label LBDATE;
        private Label label5;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label9;
    }
}