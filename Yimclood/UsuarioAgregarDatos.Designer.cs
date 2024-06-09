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
    partial class UsuarioAgregarDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioAgregarDatos));
            this.lblPeso = new System.Windows.Forms.Label();
            this.fotoPerfil = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPantorrillas = new System.Windows.Forms.Label();
            this.txtGluteos = new System.Windows.Forms.Label();
            this.txtAntebrazos = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHombros = new System.Windows.Forms.TextBox();
            this.txtAbdominales = new System.Windows.Forms.TextBox();
            this.txtBiceps = new System.Windows.Forms.TextBox();
            this.txtPecho = new System.Windows.Forms.TextBox();
            this.txtPiernas = new System.Windows.Forms.TextBox();
            this.txtEspalda = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtTriceps = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.botones1 = new Presentacion.botones.botones();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 30F);
            this.lblPeso.ForeColor = System.Drawing.Color.Black;
            this.lblPeso.Location = new System.Drawing.Point(7, 245);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(116, 60);
            this.lblPeso.TabIndex = 30;
            this.lblPeso.Text = "Peso";
            this.lblPeso.Click += new System.EventHandler(this.lblPeso_Click);
            // 
            // fotoPerfil
            // 
            this.fotoPerfil.BackColor = System.Drawing.Color.White;
            this.fotoPerfil.Location = new System.Drawing.Point(240, 76);
            this.fotoPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.fotoPerfil.Name = "fotoPerfil";
            this.fotoPerfil.Size = new System.Drawing.Size(219, 170);
            this.fotoPerfil.TabIndex = 28;
            this.fotoPerfil.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 35F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 71);
            this.label1.TabIndex = 27;
            this.label1.Text = "Agregar datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(478, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 41);
            this.label3.TabIndex = 49;
            this.label3.Text = "Fecha";
            // 
            // fecha
            // 
            this.fecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fecha.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(485, 152);
            this.fecha.Margin = new System.Windows.Forms.Padding(4);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(185, 48);
            this.fecha.TabIndex = 50;
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.txtPeso.Location = new System.Drawing.Point(240, 307);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(219, 48);
            this.txtPeso.TabIndex = 53;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPeso.TextChanged += new System.EventHandler(this.cbPeso_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 30F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 357);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 60);
            this.label2.TabIndex = 54;
            this.label2.Text = "Medidas";
            // 
            // lblsd
            // 
            this.lblsd.AutoSize = true;
            this.lblsd.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblsd.ForeColor = System.Drawing.Color.Black;
            this.lblsd.Location = new System.Drawing.Point(160, 428);
            this.lblsd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsd.Name = "lblsd";
            this.lblsd.Size = new System.Drawing.Size(137, 41);
            this.lblsd.TabIndex = 56;
            this.lblsd.Text = "Hombros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(160, 487);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 41);
            this.label5.TabIndex = 57;
            this.label5.Text = "Pecho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(161, 546);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 41);
            this.label6.TabIndex = 58;
            this.label6.Text = "Biceps";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(161, 603);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(190, 41);
            this.label7.TabIndex = 59;
            this.label7.Text = "Abdominales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(161, 657);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(120, 41);
            this.label8.TabIndex = 60;
            this.label8.Text = "Piernas";
            // 
            // txtPantorrillas
            // 
            this.txtPantorrillas.AutoSize = true;
            this.txtPantorrillas.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.txtPantorrillas.ForeColor = System.Drawing.Color.Black;
            this.txtPantorrillas.Location = new System.Drawing.Point(512, 657);
            this.txtPantorrillas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPantorrillas.Name = "txtPantorrillas";
            this.txtPantorrillas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPantorrillas.Size = new System.Drawing.Size(176, 41);
            this.txtPantorrillas.TabIndex = 65;
            this.txtPantorrillas.Text = "Pantorrillas";
            // 
            // txtGluteos
            // 
            this.txtGluteos.AutoSize = true;
            this.txtGluteos.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.txtGluteos.ForeColor = System.Drawing.Color.Black;
            this.txtGluteos.Location = new System.Drawing.Point(512, 603);
            this.txtGluteos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtGluteos.Name = "txtGluteos";
            this.txtGluteos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGluteos.Size = new System.Drawing.Size(117, 41);
            this.txtGluteos.TabIndex = 64;
            this.txtGluteos.Text = "Gluteos";
            // 
            // txtAntebrazos
            // 
            this.txtAntebrazos.AutoSize = true;
            this.txtAntebrazos.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.txtAntebrazos.ForeColor = System.Drawing.Color.Black;
            this.txtAntebrazos.Location = new System.Drawing.Point(512, 546);
            this.txtAntebrazos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAntebrazos.Name = "txtAntebrazos";
            this.txtAntebrazos.Size = new System.Drawing.Size(169, 41);
            this.txtAntebrazos.TabIndex = 63;
            this.txtAntebrazos.Text = "Antebrazos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(511, 487);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 41);
            this.label12.TabIndex = 62;
            this.label12.Text = "Triceps";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(511, 428);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 41);
            this.label13.TabIndex = 61;
            this.label13.Text = "Espalda";
            // 
            // txtHombros
            // 
            this.txtHombros.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtHombros.Location = new System.Drawing.Point(356, 428);
            this.txtHombros.Name = "txtHombros";
            this.txtHombros.Size = new System.Drawing.Size(82, 38);
            this.txtHombros.TabIndex = 66;
            this.txtHombros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAbdominales
            // 
            this.txtAbdominales.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtAbdominales.Location = new System.Drawing.Point(356, 603);
            this.txtAbdominales.Name = "txtAbdominales";
            this.txtAbdominales.Size = new System.Drawing.Size(82, 38);
            this.txtAbdominales.TabIndex = 67;
            this.txtAbdominales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBiceps
            // 
            this.txtBiceps.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtBiceps.Location = new System.Drawing.Point(356, 546);
            this.txtBiceps.Name = "txtBiceps";
            this.txtBiceps.Size = new System.Drawing.Size(82, 38);
            this.txtBiceps.TabIndex = 68;
            this.txtBiceps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPecho
            // 
            this.txtPecho.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtPecho.Location = new System.Drawing.Point(356, 487);
            this.txtPecho.Name = "txtPecho";
            this.txtPecho.Size = new System.Drawing.Size(82, 38);
            this.txtPecho.TabIndex = 69;
            this.txtPecho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPiernas
            // 
            this.txtPiernas.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtPiernas.Location = new System.Drawing.Point(356, 657);
            this.txtPiernas.Name = "txtPiernas";
            this.txtPiernas.Size = new System.Drawing.Size(82, 38);
            this.txtPiernas.TabIndex = 70;
            this.txtPiernas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEspalda
            // 
            this.txtEspalda.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtEspalda.Location = new System.Drawing.Point(683, 431);
            this.txtEspalda.Name = "txtEspalda";
            this.txtEspalda.Size = new System.Drawing.Size(82, 38);
            this.txtEspalda.TabIndex = 66;
            this.txtEspalda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.textBox6.Location = new System.Drawing.Point(683, 606);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(82, 38);
            this.textBox6.TabIndex = 67;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.textBox7.Location = new System.Drawing.Point(683, 549);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(82, 38);
            this.textBox7.TabIndex = 68;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTriceps
            // 
            this.txtTriceps.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtTriceps.Location = new System.Drawing.Point(683, 490);
            this.txtTriceps.Name = "txtTriceps";
            this.txtTriceps.Size = new System.Drawing.Size(82, 38);
            this.txtTriceps.TabIndex = 69;
            this.txtTriceps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.textBox9.Location = new System.Drawing.Point(683, 660);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(82, 38);
            this.textBox9.TabIndex = 70;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // botones1
            // 
            this.botones1.BackColor = System.Drawing.Color.SpringGreen;
            this.botones1.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.botones1.BorderColor = System.Drawing.Color.Black;
            this.botones1.BorderRadius = 10;
            this.botones1.BorderSize = 2;
            this.botones1.FlatAppearance.BorderSize = 0;
            this.botones1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botones1.ForeColor = System.Drawing.Color.White;
            this.botones1.Image = ((System.Drawing.Image)(resources.GetObject("botones1.Image")));
            this.botones1.Location = new System.Drawing.Point(853, 625);
            this.botones1.Name = "botones1";
            this.botones1.Size = new System.Drawing.Size(82, 73);
            this.botones1.TabIndex = 71;
            this.botones1.TextColor = System.Drawing.Color.White;
            this.botones1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(464, 310);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 41);
            this.label4.TabIndex = 73;
            this.label4.Text = "Kg";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(441, 433);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 30);
            this.label9.TabIndex = 74;
            this.label9.Text = "cm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(441, 492);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 30);
            this.label10.TabIndex = 75;
            this.label10.Text = "cm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(441, 551);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 30);
            this.label11.TabIndex = 76;
            this.label11.Text = "cm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(441, 605);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 30);
            this.label14.TabIndex = 77;
            this.label14.Text = "cm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(441, 659);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 30);
            this.label15.TabIndex = 78;
            this.label15.Text = "cm";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(767, 436);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 30);
            this.label16.TabIndex = 79;
            this.label16.Text = "cm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(767, 495);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 30);
            this.label17.TabIndex = 80;
            this.label17.Text = "cm";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(767, 551);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 30);
            this.label18.TabIndex = 81;
            this.label18.Text = "cm";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(767, 608);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 30);
            this.label19.TabIndex = 82;
            this.label19.Text = "cm";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(767, 662);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 30);
            this.label20.TabIndex = 83;
            this.label20.Text = "cm";
            // 
            // UsuarioAgregarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(992, 764);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botones1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.txtPiernas);
            this.Controls.Add(this.txtTriceps);
            this.Controls.Add(this.txtPecho);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.txtBiceps);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtAbdominales);
            this.Controls.Add(this.txtEspalda);
            this.Controls.Add(this.txtHombros);
            this.Controls.Add(this.txtPantorrillas);
            this.Controls.Add(this.txtGluteos);
            this.Controls.Add(this.txtAntebrazos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fotoPerfil);
            this.Controls.Add(this.lblPeso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsuarioAgregarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInterfaz";
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblPeso;
        private PictureBox fotoPerfil;
        private Label label1;
        private Label label3;
        private DateTimePicker fecha;
        private TextBox txtPeso;
        private Label label2;
        private Label lblsd;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label txtPantorrillas;
        private Label txtGluteos;
        private Label txtAntebrazos;
        private Label label12;
        private Label label13;
        private TextBox txtHombros;
        private TextBox txtAbdominales;
        private TextBox txtBiceps;
        private TextBox txtPecho;
        private TextBox txtPiernas;
        private TextBox txtEspalda;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox txtTriceps;
        private TextBox textBox9;
        private botones.botones botones1;
        private Label label4;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
    }
}