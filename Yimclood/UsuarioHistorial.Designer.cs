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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.LBDATE = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.botones1 = new Presentacion.botones.botones();
            this.btnSiguiente = new Presentacion.botones.botones();
            this.btnAnterior = new Presentacion.botones.botones();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label5.Location = new System.Drawing.Point(969, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 39);
            this.label5.TabIndex = 18;
            this.label5.Text = "Viernes";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label6.Location = new System.Drawing.Point(1136, 117);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(129, 45);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sabado";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label3.Location = new System.Drawing.Point(617, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 39);
            this.label3.TabIndex = 16;
            this.label3.Text = "Miercoles";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label4.Location = new System.Drawing.Point(800, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 42);
            this.label4.TabIndex = 15;
            this.label4.Text = "Jueves";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label2.Location = new System.Drawing.Point(304, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 43);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lunes";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label1.Location = new System.Drawing.Point(462, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Martes";
            // 
            // daycontainer
            // 
            this.daycontainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.daycontainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.daycontainer.Location = new System.Drawing.Point(103, 163);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(1183, 510);
            this.daycontainer.TabIndex = 10;
            // 
            // LBDATE
            // 
            this.LBDATE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LBDATE.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 30F);
            this.LBDATE.Location = new System.Drawing.Point(482, 48);
            this.LBDATE.Name = "LBDATE";
            this.LBDATE.Size = new System.Drawing.Size(414, 69);
            this.LBDATE.TabIndex = 21;
            this.LBDATE.Text = "MES | AÑO";
            this.LBDATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label8.Location = new System.Drawing.Point(115, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 45);
            this.label8.TabIndex = 22;
            this.label8.Text = "Domingo";
            // 
            // botones1
            // 
            this.botones1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botones1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(219)))), ((int)(((byte)(132)))));
            this.botones1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(219)))), ((int)(((byte)(132)))));
            this.botones1.BorderColor = System.Drawing.Color.Black;
            this.botones1.BorderRadius = 15;
            this.botones1.BorderSize = 2;
            this.botones1.FlatAppearance.BorderSize = 0;
            this.botones1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botones1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.botones1.ForeColor = System.Drawing.Color.Black;
            this.botones1.Image = ((System.Drawing.Image)(resources.GetObject("botones1.Image")));
            this.botones1.Location = new System.Drawing.Point(1292, 618);
            this.botones1.Name = "botones1";
            this.botones1.Size = new System.Drawing.Size(53, 55);
            this.botones1.TabIndex = 23;
            this.botones1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botones1.TextColor = System.Drawing.Color.Black;
            this.botones1.UseVisualStyleBackColor = false;
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
            this.btnSiguiente.Location = new System.Drawing.Point(1234, 679);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(52, 58);
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
            this.btnAnterior.Location = new System.Drawing.Point(1179, 679);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(49, 58);
            this.btnAnterior.TabIndex = 11;
            this.btnAnterior.TextColor = System.Drawing.Color.Black;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
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
            // UsuarioHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1500, 794);
            this.Controls.Add(this.botones1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LBDATE);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.daycontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsuarioHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInterfaz";
            this.Load += new System.EventHandler(this.UsuarioHistorial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private botones.botones btnAnterior;
        private FlowLayoutPanel daycontainer;
        private botones.botones btnSiguiente;
        private Label LBDATE;
        private Label label8;
        private botones.botones botones1;
        private Label label7;
    }
}