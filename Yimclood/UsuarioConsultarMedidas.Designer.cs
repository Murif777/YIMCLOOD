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
    partial class UsuarioConsultarMedidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioConsultarMedidas));
            this.lblsd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPantorrillas = new System.Windows.Forms.Label();
            this.txtGluteos = new System.Windows.Forms.Label();
            this.fasd = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.asd = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.TextBox();
            this.lblPiernas = new System.Windows.Forms.Label();
            this.lblAbdominales = new System.Windows.Forms.Label();
            this.lblBiceps = new System.Windows.Forms.Label();
            this.lblPecho = new System.Windows.Forms.Label();
            this.lblHombros = new System.Windows.Forms.Label();
            this.lblPantorrillas = new System.Windows.Forms.Label();
            this.lblGluteos = new System.Windows.Forms.Label();
            this.lblAntebrazos = new System.Windows.Forms.Label();
            this.lblTriceps = new System.Windows.Forms.Label();
            this.lblEspalda = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsd
            // 
            this.lblsd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsd.AutoSize = true;
            this.lblsd.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblsd.ForeColor = System.Drawing.Color.Black;
            this.lblsd.Location = new System.Drawing.Point(118, 341);
            this.lblsd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsd.Name = "lblsd";
            this.lblsd.Size = new System.Drawing.Size(137, 41);
            this.lblsd.TabIndex = 56;
            this.lblsd.Text = "Hombros";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(118, 400);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 41);
            this.label5.TabIndex = 57;
            this.label5.Text = "Pecho";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(119, 459);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 41);
            this.label6.TabIndex = 58;
            this.label6.Text = "Biceps";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(119, 516);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(190, 41);
            this.label7.TabIndex = 59;
            this.label7.Text = "Abdominales";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(119, 572);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(120, 41);
            this.label8.TabIndex = 60;
            this.label8.Text = "Piernas";
            // 
            // txtPantorrillas
            // 
            this.txtPantorrillas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPantorrillas.AutoSize = true;
            this.txtPantorrillas.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.txtPantorrillas.ForeColor = System.Drawing.Color.Black;
            this.txtPantorrillas.Location = new System.Drawing.Point(469, 567);
            this.txtPantorrillas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPantorrillas.Name = "txtPantorrillas";
            this.txtPantorrillas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPantorrillas.Size = new System.Drawing.Size(176, 41);
            this.txtPantorrillas.TabIndex = 65;
            this.txtPantorrillas.Text = "Pantorrillas";
            // 
            // txtGluteos
            // 
            this.txtGluteos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGluteos.AutoSize = true;
            this.txtGluteos.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.txtGluteos.ForeColor = System.Drawing.Color.Black;
            this.txtGluteos.Location = new System.Drawing.Point(469, 513);
            this.txtGluteos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtGluteos.Name = "txtGluteos";
            this.txtGluteos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGluteos.Size = new System.Drawing.Size(117, 41);
            this.txtGluteos.TabIndex = 64;
            this.txtGluteos.Text = "Gluteos";
            // 
            // fasd
            // 
            this.fasd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fasd.AutoSize = true;
            this.fasd.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.fasd.ForeColor = System.Drawing.Color.Black;
            this.fasd.Location = new System.Drawing.Point(469, 459);
            this.fasd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fasd.Name = "fasd";
            this.fasd.Size = new System.Drawing.Size(169, 41);
            this.fasd.TabIndex = 63;
            this.fasd.Text = "Antebrazos";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(469, 400);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 41);
            this.label12.TabIndex = 62;
            this.label12.Text = "Triceps";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(469, 341);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 41);
            this.label13.TabIndex = 61;
            this.label13.Text = "Espalda";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(203, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 41);
            this.label4.TabIndex = 73;
            this.label4.Text = "Kg";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(399, 346);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 30);
            this.label9.TabIndex = 74;
            this.label9.Text = "cm";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(399, 405);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 30);
            this.label10.TabIndex = 75;
            this.label10.Text = "cm";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(399, 468);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 30);
            this.label11.TabIndex = 76;
            this.label11.Text = "cm";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(399, 521);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 30);
            this.label14.TabIndex = 77;
            this.label14.Text = "cm";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(399, 580);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 30);
            this.label15.TabIndex = 78;
            this.label15.Text = "cm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 35F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 71);
            this.label2.TabIndex = 54;
            this.label2.Text = "Medidas";
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 35F);
            this.asd.ForeColor = System.Drawing.Color.Black;
            this.asd.Location = new System.Drawing.Point(1, 162);
            this.asd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(137, 71);
            this.asd.TabIndex = 30;
            this.asd.Text = "Peso";
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 35F);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFecha.Location = new System.Drawing.Point(197, 86);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.ReadOnly = true;
            this.lblFecha.Size = new System.Drawing.Size(459, 78);
            this.lblFecha.TabIndex = 84;
            this.lblFecha.Text = "DIA/MES/AÑO";
            this.lblFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPiernas
            // 
            this.lblPiernas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPiernas.AutoSize = true;
            this.lblPiernas.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblPiernas.ForeColor = System.Drawing.Color.Black;
            this.lblPiernas.Location = new System.Drawing.Point(327, 572);
            this.lblPiernas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPiernas.Name = "lblPiernas";
            this.lblPiernas.Size = new System.Drawing.Size(76, 41);
            this.lblPiernas.TabIndex = 89;
            this.lblPiernas.Text = "XX.X";
            // 
            // lblAbdominales
            // 
            this.lblAbdominales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAbdominales.AutoSize = true;
            this.lblAbdominales.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblAbdominales.ForeColor = System.Drawing.Color.Black;
            this.lblAbdominales.Location = new System.Drawing.Point(327, 513);
            this.lblAbdominales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbdominales.Name = "lblAbdominales";
            this.lblAbdominales.Size = new System.Drawing.Size(76, 41);
            this.lblAbdominales.TabIndex = 88;
            this.lblAbdominales.Text = "XX.X";
            // 
            // lblBiceps
            // 
            this.lblBiceps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBiceps.AutoSize = true;
            this.lblBiceps.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblBiceps.ForeColor = System.Drawing.Color.Black;
            this.lblBiceps.Location = new System.Drawing.Point(327, 460);
            this.lblBiceps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBiceps.Name = "lblBiceps";
            this.lblBiceps.Size = new System.Drawing.Size(76, 41);
            this.lblBiceps.TabIndex = 87;
            this.lblBiceps.Text = "XX.X";
            // 
            // lblPecho
            // 
            this.lblPecho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPecho.AutoSize = true;
            this.lblPecho.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblPecho.ForeColor = System.Drawing.Color.Black;
            this.lblPecho.Location = new System.Drawing.Point(327, 397);
            this.lblPecho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPecho.Name = "lblPecho";
            this.lblPecho.Size = new System.Drawing.Size(76, 41);
            this.lblPecho.TabIndex = 86;
            this.lblPecho.Text = "X.XX";
            // 
            // lblHombros
            // 
            this.lblHombros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHombros.AutoSize = true;
            this.lblHombros.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblHombros.ForeColor = System.Drawing.Color.Black;
            this.lblHombros.Location = new System.Drawing.Point(327, 338);
            this.lblHombros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHombros.Name = "lblHombros";
            this.lblHombros.Size = new System.Drawing.Size(76, 41);
            this.lblHombros.TabIndex = 85;
            this.lblHombros.Text = "X.XX";
            // 
            // lblPantorrillas
            // 
            this.lblPantorrillas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPantorrillas.AutoSize = true;
            this.lblPantorrillas.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblPantorrillas.ForeColor = System.Drawing.Color.Black;
            this.lblPantorrillas.Location = new System.Drawing.Point(653, 572);
            this.lblPantorrillas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPantorrillas.Name = "lblPantorrillas";
            this.lblPantorrillas.Size = new System.Drawing.Size(76, 41);
            this.lblPantorrillas.TabIndex = 94;
            this.lblPantorrillas.Text = "XX.X";
            // 
            // lblGluteos
            // 
            this.lblGluteos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGluteos.AutoSize = true;
            this.lblGluteos.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblGluteos.ForeColor = System.Drawing.Color.Black;
            this.lblGluteos.Location = new System.Drawing.Point(653, 513);
            this.lblGluteos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGluteos.Name = "lblGluteos";
            this.lblGluteos.Size = new System.Drawing.Size(76, 41);
            this.lblGluteos.TabIndex = 93;
            this.lblGluteos.Text = "XX.X";
            // 
            // lblAntebrazos
            // 
            this.lblAntebrazos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAntebrazos.AutoSize = true;
            this.lblAntebrazos.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblAntebrazos.ForeColor = System.Drawing.Color.Black;
            this.lblAntebrazos.Location = new System.Drawing.Point(653, 460);
            this.lblAntebrazos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAntebrazos.Name = "lblAntebrazos";
            this.lblAntebrazos.Size = new System.Drawing.Size(76, 41);
            this.lblAntebrazos.TabIndex = 92;
            this.lblAntebrazos.Text = "XX.X";
            // 
            // lblTriceps
            // 
            this.lblTriceps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTriceps.AutoSize = true;
            this.lblTriceps.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblTriceps.ForeColor = System.Drawing.Color.Black;
            this.lblTriceps.Location = new System.Drawing.Point(653, 397);
            this.lblTriceps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTriceps.Name = "lblTriceps";
            this.lblTriceps.Size = new System.Drawing.Size(76, 41);
            this.lblTriceps.TabIndex = 91;
            this.lblTriceps.Text = "X.XX";
            // 
            // lblEspalda
            // 
            this.lblEspalda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEspalda.AutoSize = true;
            this.lblEspalda.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblEspalda.ForeColor = System.Drawing.Color.Black;
            this.lblEspalda.Location = new System.Drawing.Point(653, 338);
            this.lblEspalda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEspalda.Name = "lblEspalda";
            this.lblEspalda.Size = new System.Drawing.Size(76, 41);
            this.lblEspalda.TabIndex = 90;
            this.lblEspalda.Text = "X.XX";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(733, 580);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 30);
            this.label16.TabIndex = 99;
            this.label16.Text = "cm";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(733, 521);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 30);
            this.label17.TabIndex = 98;
            this.label17.Text = "cm";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(733, 468);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 30);
            this.label18.TabIndex = 97;
            this.label18.Text = "cm";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(733, 405);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 30);
            this.label19.TabIndex = 96;
            this.label19.Text = "cm";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(733, 346);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 30);
            this.label20.TabIndex = 95;
            this.label20.Text = "cm";
            // 
            // lblPeso
            // 
            this.lblPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblPeso.ForeColor = System.Drawing.Color.Black;
            this.lblPeso.Location = new System.Drawing.Point(118, 229);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(76, 41);
            this.lblPeso.TabIndex = 100;
            this.lblPeso.Text = "X.XX";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(696, 2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(91, 74);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(791, 5);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 71);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlSuperior.Controls.Add(this.btnMinimizar);
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(881, 81);
            this.pnlSuperior.TabIndex = 101;
            // 
            // UsuarioConsultarMedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(881, 651);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblPantorrillas);
            this.Controls.Add(this.lblGluteos);
            this.Controls.Add(this.lblAntebrazos);
            this.Controls.Add(this.lblTriceps);
            this.Controls.Add(this.lblEspalda);
            this.Controls.Add(this.lblPiernas);
            this.Controls.Add(this.lblAbdominales);
            this.Controls.Add(this.lblBiceps);
            this.Controls.Add(this.lblPecho);
            this.Controls.Add(this.lblHombros);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPantorrillas);
            this.Controls.Add(this.txtGluteos);
            this.Controls.Add(this.fasd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.asd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsuarioConsultarMedidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInterfaz";
            this.Load += new System.EventHandler(this.UsuarioConsultarMedidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblsd;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label txtPantorrillas;
        private Label txtGluteos;
        private Label fasd;
        private Label label12;
        private Label label13;
        private Label label4;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label14;
        private Label label15;
        private Label label2;
        private Label asd;
        private TextBox lblFecha;
        private Label lblPiernas;
        private Label lblAbdominales;
        private Label lblBiceps;
        private Label lblPecho;
        private Label lblHombros;
        private Label lblPantorrillas;
        private Label lblGluteos;
        private Label lblAntebrazos;
        private Label lblTriceps;
        private Label lblEspalda;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label lblPeso;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Panel pnlSuperior;
    }
}