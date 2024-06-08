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
            this.pnlPadre = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlPerfil = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValorPesoIdeal = new System.Windows.Forms.Label();
            this.lbl59 = new System.Windows.Forms.Label();
            this.lblValorGrasa = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblValorBMI = new System.Windows.Forms.Label();
            this.btnSubir = new Presentacion.botones.botones();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtDiferencia = new System.Windows.Forms.RadioButton();
            this.rbtObjetivo = new System.Windows.Forms.RadioButton();
            this.rbtnActual = new System.Windows.Forms.RadioButton();
            this.btnMedidas = new Presentacion.botones.botones();
            this.btnPeso = new Presentacion.botones.botones();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fotoPerfil = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlPadre.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPadre
            // 
            this.pnlPadre.Controls.Add(this.panel1);
            this.pnlPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPadre.Location = new System.Drawing.Point(0, 0);
            this.pnlPadre.Name = "pnlPadre";
            this.pnlPadre.Size = new System.Drawing.Size(1332, 911);
            this.pnlPadre.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 911);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1332, 911);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.pnlPerfil);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1332, 911);
            this.panel3.TabIndex = 0;
            // 
            // pnlPerfil
            // 
            this.pnlPerfil.Controls.Add(this.label5);
            this.pnlPerfil.Controls.Add(this.lblNombre);
            this.pnlPerfil.Controls.Add(this.label3);
            this.pnlPerfil.Controls.Add(this.lblValorPesoIdeal);
            this.pnlPerfil.Controls.Add(this.lbl59);
            this.pnlPerfil.Controls.Add(this.lblValorGrasa);
            this.pnlPerfil.Controls.Add(this.label9);
            this.pnlPerfil.Controls.Add(this.lbl5);
            this.pnlPerfil.Controls.Add(this.lblValorBMI);
            this.pnlPerfil.Controls.Add(this.btnSubir);
            this.pnlPerfil.Controls.Add(this.label7);
            this.pnlPerfil.Controls.Add(this.label6);
            this.pnlPerfil.Controls.Add(this.label2);
            this.pnlPerfil.Controls.Add(this.rbtDiferencia);
            this.pnlPerfil.Controls.Add(this.rbtObjetivo);
            this.pnlPerfil.Controls.Add(this.rbtnActual);
            this.pnlPerfil.Controls.Add(this.btnMedidas);
            this.pnlPerfil.Controls.Add(this.btnPeso);
            this.pnlPerfil.Controls.Add(this.lblFecha);
            this.pnlPerfil.Controls.Add(this.lblPeso);
            this.pnlPerfil.Controls.Add(this.label1);
            this.pnlPerfil.Controls.Add(this.fotoPerfil);
            this.pnlPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPerfil.Location = new System.Drawing.Point(0, 0);
            this.pnlPerfil.Name = "pnlPerfil";
            this.pnlPerfil.Size = new System.Drawing.Size(1332, 911);
            this.pnlPerfil.TabIndex = 26;
            this.pnlPerfil.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPerfil_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label3.Location = new System.Drawing.Point(12, 711);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 51);
            this.label3.TabIndex = 40;
            this.label3.Text = "Diagnostico";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorPesoIdeal
            // 
            this.lblValorPesoIdeal.AutoSize = true;
            this.lblValorPesoIdeal.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblValorPesoIdeal.ForeColor = System.Drawing.Color.Black;
            this.lblValorPesoIdeal.Location = new System.Drawing.Point(1130, 836);
            this.lblValorPesoIdeal.Name = "lblValorPesoIdeal";
            this.lblValorPesoIdeal.Size = new System.Drawing.Size(76, 41);
            this.lblValorPesoIdeal.TabIndex = 46;
            this.lblValorPesoIdeal.Text = "X Kg";
            this.lblValorPesoIdeal.Click += new System.EventHandler(this.lblValorPesoIdeal_Click);
            // 
            // lbl59
            // 
            this.lbl59.AutoSize = true;
            this.lbl59.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24F);
            this.lbl59.ForeColor = System.Drawing.Color.Black;
            this.lbl59.Location = new System.Drawing.Point(865, 795);
            this.lbl59.Name = "lbl59";
            this.lbl59.Size = new System.Drawing.Size(112, 48);
            this.lbl59.TabIndex = 45;
            this.lbl59.Text = "Grasa";
            this.lbl59.Click += new System.EventHandler(this.lbl59_Click);
            // 
            // lblValorGrasa
            // 
            this.lblValorGrasa.AutoSize = true;
            this.lblValorGrasa.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblValorGrasa.ForeColor = System.Drawing.Color.Black;
            this.lblValorGrasa.Location = new System.Drawing.Point(908, 836);
            this.lblValorGrasa.Name = "lblValorGrasa";
            this.lblValorGrasa.Size = new System.Drawing.Size(64, 41);
            this.lblValorGrasa.TabIndex = 44;
            this.lblValorGrasa.Text = "X %";
            this.lblValorGrasa.Click += new System.EventHandler(this.lblValorGrasa_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(697, 795);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 48);
            this.label9.TabIndex = 43;
            this.label9.Text = "BMI";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24F);
            this.lbl5.ForeColor = System.Drawing.Color.Black;
            this.lbl5.Location = new System.Drawing.Point(1066, 795);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(178, 48);
            this.lbl5.TabIndex = 42;
            this.lbl5.Text = "Peso ideal";
            this.lbl5.Click += new System.EventHandler(this.lbl5_Click);
            // 
            // lblValorBMI
            // 
            this.lblValorBMI.AutoSize = true;
            this.lblValorBMI.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblValorBMI.ForeColor = System.Drawing.Color.Black;
            this.lblValorBMI.Location = new System.Drawing.Point(719, 836);
            this.lblValorBMI.Name = "lblValorBMI";
            this.lblValorBMI.Size = new System.Drawing.Size(34, 41);
            this.lblValorBMI.TabIndex = 41;
            this.lblValorBMI.Text = "X";
            this.lblValorBMI.Click += new System.EventHandler(this.lblValorBMI_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.BackColor = System.Drawing.Color.Transparent;
            this.btnSubir.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSubir.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubir.BorderRadius = 20;
            this.btnSubir.BorderSize = 0;
            this.btnSubir.FlatAppearance.BorderSize = 0;
            this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubir.ForeColor = System.Drawing.Color.White;
            this.btnSubir.Image = ((System.Drawing.Image)(resources.GetObject("btnSubir.Image")));
            this.btnSubir.Location = new System.Drawing.Point(1043, 346);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(53, 56);
            this.btnSubir.TabIndex = 29;
            this.btnSubir.TextColor = System.Drawing.Color.White;
            this.btnSubir.UseVisualStyleBackColor = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1110, 609);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 41);
            this.label7.TabIndex = 37;
            this.label7.Text = "+ Kg";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(933, 609);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 41);
            this.label6.TabIndex = 36;
            this.label6.Text = "Kg";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(736, 609);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 41);
            this.label2.TabIndex = 35;
            this.label2.Text = "Kg";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbtDiferencia
            // 
            this.rbtDiferencia.AutoSize = true;
            this.rbtDiferencia.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24F);
            this.rbtDiferencia.Location = new System.Drawing.Point(1010, 561);
            this.rbtDiferencia.Name = "rbtDiferencia";
            this.rbtDiferencia.Size = new System.Drawing.Size(201, 52);
            this.rbtDiferencia.TabIndex = 26;
            this.rbtDiferencia.TabStop = true;
            this.rbtDiferencia.Text = "Diferencia";
            this.rbtDiferencia.UseVisualStyleBackColor = true;
            this.rbtDiferencia.CheckedChanged += new System.EventHandler(this.rbtDiferencia_CheckedChanged);
            // 
            // rbtObjetivo
            // 
            this.rbtObjetivo.AutoSize = true;
            this.rbtObjetivo.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24F);
            this.rbtObjetivo.Location = new System.Drawing.Point(847, 561);
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
            this.rbtnActual.Location = new System.Drawing.Point(673, 561);
            this.rbtnActual.Name = "rbtnActual";
            this.rbtnActual.Size = new System.Drawing.Size(141, 52);
            this.rbtnActual.TabIndex = 24;
            this.rbtnActual.TabStop = true;
            this.rbtnActual.Text = "Actual";
            this.rbtnActual.UseVisualStyleBackColor = true;
            this.rbtnActual.CheckedChanged += new System.EventHandler(this.rbtnActual_CheckedChanged);
            // 
            // btnMedidas
            // 
            this.btnMedidas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMedidas.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMedidas.BorderColor = System.Drawing.Color.Black;
            this.btnMedidas.BorderRadius = 10;
            this.btnMedidas.BorderSize = 3;
            this.btnMedidas.FlatAppearance.BorderSize = 0;
            this.btnMedidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedidas.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.btnMedidas.ForeColor = System.Drawing.Color.White;
            this.btnMedidas.Location = new System.Drawing.Point(920, 492);
            this.btnMedidas.Name = "btnMedidas";
            this.btnMedidas.Size = new System.Drawing.Size(252, 63);
            this.btnMedidas.TabIndex = 33;
            this.btnMedidas.Text = "Medidas";
            this.btnMedidas.TextColor = System.Drawing.Color.White;
            this.btnMedidas.UseVisualStyleBackColor = false;
            this.btnMedidas.Click += new System.EventHandler(this.btnMedidas_Click);
            // 
            // btnPeso
            // 
            this.btnPeso.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPeso.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPeso.BorderColor = System.Drawing.Color.Black;
            this.btnPeso.BorderRadius = 10;
            this.btnPeso.BorderSize = 3;
            this.btnPeso.FlatAppearance.BorderSize = 0;
            this.btnPeso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeso.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.btnPeso.ForeColor = System.Drawing.Color.White;
            this.btnPeso.Location = new System.Drawing.Point(673, 492);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(255, 63);
            this.btnPeso.TabIndex = 32;
            this.btnPeso.Text = "Peso";
            this.btnPeso.TextColor = System.Drawing.Color.White;
            this.btnPeso.UseVisualStyleBackColor = false;
            this.btnPeso.Click += new System.EventHandler(this.btnPeso_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(1005, 444);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 41);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "/2024";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblPeso.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPeso.Location = new System.Drawing.Point(1004, 405);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(52, 41);
            this.lblPeso.TabIndex = 30;
            this.lblPeso.Text = "Kg";
            this.lblPeso.Click += new System.EventHandler(this.lblPeso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label1.Location = new System.Drawing.Point(0, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 51);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cuerpo";
            // 
            // fotoPerfil
            // 
            this.fotoPerfil.BackColor = System.Drawing.Color.White;
            this.fotoPerfil.Location = new System.Drawing.Point(761, 102);
            this.fotoPerfil.Name = "fotoPerfil";
            this.fotoPerfil.Size = new System.Drawing.Size(340, 303);
            this.fotoPerfil.TabIndex = 28;
            this.fotoPerfil.TabStop = false;
            this.fotoPerfil.Click += new System.EventHandler(this.fotoPerfil_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(239, 158);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 16);
            this.lblNombre.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Nombre:";
            // 
            // UsuarioPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1332, 911);
            this.Controls.Add(this.pnlPadre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsuarioPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInterfaz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlPadre.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlPerfil.ResumeLayout(false);
            this.pnlPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlPadre;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel pnlPerfil;
        private Label label3;
        private Label lblValorPesoIdeal;
        private Label lbl59;
        private Label lblValorGrasa;
        private Label label9;
        private Label lbl5;
        private Label lblValorBMI;
        private botones.botones btnSubir;
        private Label label7;
        private Label label6;
        private Label label2;
        private RadioButton rbtDiferencia;
        private RadioButton rbtObjetivo;
        private RadioButton rbtnActual;
        private botones.botones btnMedidas;
        private botones.botones btnPeso;
        private Label lblFecha;
        private Label lblPeso;
        private Label label1;
        private PictureBox fotoPerfil;
        private Label label5;
        private Label lblNombre;
    }
}