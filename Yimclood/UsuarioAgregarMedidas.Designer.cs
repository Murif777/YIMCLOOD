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
    partial class UsuarioAgregarMedidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioAgregarMedidas));
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblsd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAntebrazos = new System.Windows.Forms.Label();
            this.txtHombros = new System.Windows.Forms.TextBox();
            this.txtPecho = new System.Windows.Forms.TextBox();
            this.txtPiernaIzq = new System.Windows.Forms.TextBox();
            this.txtAntebraIzq = new System.Windows.Forms.TextBox();
            this.btnGuardar = new Presentacion.botones.botones();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnagregarfoto = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txtAntebrazoDe = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBrazoDe = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtBrazoIzq = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtCintura = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtCadera = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtPiernaDe = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtGemeloDe = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtGemeloIzq = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFoto.BackColor = System.Drawing.Color.White;
            this.pbFoto.Location = new System.Drawing.Point(426, 23);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(2);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(192, 173);
            this.pbFoto.TabIndex = 28;
            this.pbFoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 40F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 65);
            this.label1.TabIndex = 27;
            this.label1.Text = "Agregar datos";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(750, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 33);
            this.label3.TabIndex = 49;
            this.label3.Text = "Fecha";
            // 
            // fecha
            // 
            this.fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fecha.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(756, 166);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(149, 40);
            this.fecha.TabIndex = 50;
            // 
            // txtPeso
            // 
            this.txtPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPeso.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.txtPeso.Location = new System.Drawing.Point(427, 218);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(176, 40);
            this.txtPeso.TabIndex = 53;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblsd
            // 
            this.lblsd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsd.AutoSize = true;
            this.lblsd.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblsd.ForeColor = System.Drawing.Color.Black;
            this.lblsd.Location = new System.Drawing.Point(319, 280);
            this.lblsd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsd.Name = "lblsd";
            this.lblsd.Size = new System.Drawing.Size(108, 33);
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
            this.label5.Location = new System.Drawing.Point(319, 327);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 33);
            this.label5.TabIndex = 57;
            this.label5.Text = "Pecho";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(321, 462);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(95, 33);
            this.label8.TabIndex = 60;
            this.label8.Text = "Piernas";
            // 
            // txtAntebrazos
            // 
            this.txtAntebrazos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAntebrazos.AutoSize = true;
            this.txtAntebrazos.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.txtAntebrazos.ForeColor = System.Drawing.Color.Black;
            this.txtAntebrazos.Location = new System.Drawing.Point(616, 364);
            this.txtAntebrazos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAntebrazos.Name = "txtAntebrazos";
            this.txtAntebrazos.Size = new System.Drawing.Size(134, 33);
            this.txtAntebrazos.TabIndex = 63;
            this.txtAntebrazos.Text = "Antebrazos";
            // 
            // txtHombros
            // 
            this.txtHombros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHombros.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtHombros.Location = new System.Drawing.Point(476, 280);
            this.txtHombros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHombros.Name = "txtHombros";
            this.txtHombros.Size = new System.Drawing.Size(66, 32);
            this.txtHombros.TabIndex = 66;
            this.txtHombros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPecho
            // 
            this.txtPecho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPecho.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtPecho.Location = new System.Drawing.Point(476, 327);
            this.txtPecho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPecho.Name = "txtPecho";
            this.txtPecho.Size = new System.Drawing.Size(66, 32);
            this.txtPecho.TabIndex = 69;
            this.txtPecho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPiernaIzq
            // 
            this.txtPiernaIzq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPiernaIzq.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtPiernaIzq.Location = new System.Drawing.Point(420, 463);
            this.txtPiernaIzq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPiernaIzq.Name = "txtPiernaIzq";
            this.txtPiernaIzq.Size = new System.Drawing.Size(66, 32);
            this.txtPiernaIzq.TabIndex = 70;
            this.txtPiernaIzq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAntebraIzq
            // 
            this.txtAntebraIzq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAntebraIzq.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtAntebraIzq.Location = new System.Drawing.Point(763, 368);
            this.txtAntebraIzq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAntebraIzq.Name = "txtAntebraIzq";
            this.txtAntebraIzq.Size = new System.Drawing.Size(66, 32);
            this.txtAntebraIzq.TabIndex = 68;
            this.txtAntebraIzq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnGuardar.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.btnGuardar.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.BorderRadius = 10;
            this.btnGuardar.BorderSize = 2;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(763, 462);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(66, 58);
            this.btnGuardar.TabIndex = 71;
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(607, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 33);
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
            this.label9.Location = new System.Drawing.Point(544, 284);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 24);
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
            this.label10.Location = new System.Drawing.Point(544, 331);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 24);
            this.label10.TabIndex = 75;
            this.label10.Text = "cm";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(490, 472);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 24);
            this.label15.TabIndex = 78;
            this.label15.Text = "cm";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(849, 373);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 24);
            this.label18.TabIndex = 81;
            this.label18.Text = "cm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 35F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 338);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 57);
            this.label2.TabIndex = 54;
            this.label2.Text = "Medidas";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 35F);
            this.lblPeso.ForeColor = System.Drawing.Color.Black;
            this.lblPeso.Location = new System.Drawing.Point(9, 201);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(112, 57);
            this.lblPeso.TabIndex = 30;
            this.lblPeso.Text = "Peso";
            // 
            // btnagregarfoto
            // 
            this.btnagregarfoto.BackColor = System.Drawing.Color.Transparent;
            this.btnagregarfoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarfoto.FlatAppearance.BorderSize = 0;
            this.btnagregarfoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarfoto.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarfoto.Image = ((System.Drawing.Image)(resources.GetObject("btnagregarfoto.Image")));
            this.btnagregarfoto.Location = new System.Drawing.Point(622, 119);
            this.btnagregarfoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnagregarfoto.Name = "btnagregarfoto";
            this.btnagregarfoto.Size = new System.Drawing.Size(90, 64);
            this.btnagregarfoto.TabIndex = 84;
            this.btnagregarfoto.UseVisualStyleBackColor = false;
            this.btnagregarfoto.Click += new System.EventHandler(this.btnsubirfoto_Click_1);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(948, 376);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 24);
            this.label21.TabIndex = 86;
            this.label21.Text = "cm";
            // 
            // txtAntebrazoDe
            // 
            this.txtAntebrazoDe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAntebrazoDe.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtAntebrazoDe.Location = new System.Drawing.Point(878, 366);
            this.txtAntebrazoDe.Margin = new System.Windows.Forms.Padding(2);
            this.txtAntebrazoDe.Name = "txtAntebrazoDe";
            this.txtAntebrazoDe.Size = new System.Drawing.Size(66, 32);
            this.txtAntebrazoDe.TabIndex = 85;
            this.txtAntebrazoDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(948, 332);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 24);
            this.label22.TabIndex = 91;
            this.label22.Text = "cm";
            // 
            // txtBrazoDe
            // 
            this.txtBrazoDe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrazoDe.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtBrazoDe.Location = new System.Drawing.Point(878, 322);
            this.txtBrazoDe.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrazoDe.Name = "txtBrazoDe";
            this.txtBrazoDe.Size = new System.Drawing.Size(66, 32);
            this.txtBrazoDe.TabIndex = 90;
            this.txtBrazoDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(849, 329);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 24);
            this.label23.TabIndex = 89;
            this.label23.Text = "cm";
            // 
            // txtBrazoIzq
            // 
            this.txtBrazoIzq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrazoIzq.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtBrazoIzq.Location = new System.Drawing.Point(763, 323);
            this.txtBrazoIzq.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrazoIzq.Name = "txtBrazoIzq";
            this.txtBrazoIzq.Size = new System.Drawing.Size(66, 32);
            this.txtBrazoIzq.TabIndex = 88;
            this.txtBrazoIzq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(645, 322);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 33);
            this.label24.TabIndex = 87;
            this.label24.Text = "Brazos";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(545, 426);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(34, 24);
            this.label25.TabIndex = 94;
            this.label25.Text = "cm";
            // 
            // txtCintura
            // 
            this.txtCintura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCintura.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtCintura.Location = new System.Drawing.Point(477, 422);
            this.txtCintura.Margin = new System.Windows.Forms.Padding(2);
            this.txtCintura.Name = "txtCintura";
            this.txtCintura.Size = new System.Drawing.Size(66, 32);
            this.txtCintura.TabIndex = 93;
            this.txtCintura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(321, 422);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(92, 33);
            this.label26.TabIndex = 92;
            this.label26.Text = "Cintura";
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(544, 385);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 24);
            this.label27.TabIndex = 97;
            this.label27.Text = "cm";
            // 
            // txtCadera
            // 
            this.txtCadera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCadera.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtCadera.Location = new System.Drawing.Point(476, 381);
            this.txtCadera.Margin = new System.Windows.Forms.Padding(2);
            this.txtCadera.Name = "txtCadera";
            this.txtCadera.Size = new System.Drawing.Size(66, 32);
            this.txtCadera.TabIndex = 96;
            this.txtCadera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(320, 381);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(91, 33);
            this.label28.TabIndex = 95;
            this.label28.Text = "Cadera";
            // 
            // txtPiernaDe
            // 
            this.txtPiernaDe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPiernaDe.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtPiernaDe.Location = new System.Drawing.Point(528, 463);
            this.txtPiernaDe.Margin = new System.Windows.Forms.Padding(2);
            this.txtPiernaDe.Name = "txtPiernaDe";
            this.txtPiernaDe.Size = new System.Drawing.Size(66, 32);
            this.txtPiernaDe.TabIndex = 98;
            this.txtPiernaDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(598, 472);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(34, 24);
            this.label29.TabIndex = 99;
            this.label29.Text = "cm";
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(598, 508);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(34, 24);
            this.label30.TabIndex = 104;
            this.label30.Text = "cm";
            // 
            // txtGemeloDe
            // 
            this.txtGemeloDe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGemeloDe.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtGemeloDe.Location = new System.Drawing.Point(528, 499);
            this.txtGemeloDe.Margin = new System.Windows.Forms.Padding(2);
            this.txtGemeloDe.Name = "txtGemeloDe";
            this.txtGemeloDe.Size = new System.Drawing.Size(66, 32);
            this.txtGemeloDe.TabIndex = 103;
            this.txtGemeloDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(490, 508);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(34, 24);
            this.label31.TabIndex = 102;
            this.label31.Text = "cm";
            // 
            // txtGemeloIzq
            // 
            this.txtGemeloIzq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGemeloIzq.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtGemeloIzq.Location = new System.Drawing.Point(420, 499);
            this.txtGemeloIzq.Margin = new System.Windows.Forms.Padding(2);
            this.txtGemeloIzq.Name = "txtGemeloIzq";
            this.txtGemeloIzq.Size = new System.Drawing.Size(66, 32);
            this.txtGemeloIzq.TabIndex = 101;
            this.txtGemeloIzq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(310, 501);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label32.Size = new System.Drawing.Size(106, 33);
            this.label32.TabIndex = 100;
            this.label32.Text = "Gemelos";
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(841, 280);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(34, 24);
            this.label33.TabIndex = 107;
            this.label33.Text = "cm";
            // 
            // txtAltura
            // 
            this.txtAltura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAltura.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.txtAltura.Location = new System.Drawing.Point(763, 277);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(2);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(66, 32);
            this.txtAltura.TabIndex = 106;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(649, 280);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(81, 33);
            this.label34.TabIndex = 105;
            this.label34.Text = "Altura";
            // 
            // UsuarioAgregarMedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.txtGemeloDe);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.txtGemeloIzq);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.txtPiernaDe);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtCadera);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtCintura);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtBrazoDe);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtBrazoIzq);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtAntebrazoDe);
            this.Controls.Add(this.btnagregarfoto);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPiernaIzq);
            this.Controls.Add(this.txtPecho);
            this.Controls.Add(this.txtAntebraIzq);
            this.Controls.Add(this.txtHombros);
            this.Controls.Add(this.txtAntebrazos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.lblPeso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsuarioAgregarMedidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInterfaz";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pbFoto;
        private Label label1;
        private Label label3;
        private DateTimePicker fecha;
        private TextBox txtPeso;
        private Label lblsd;
        private Label label5;
        private Label label8;
        private Label txtAntebrazos;
        private TextBox txtHombros;
        private TextBox txtPecho;
        private TextBox txtPiernaIzq;
        private TextBox txtAntebraIzq;
        private botones.botones btnGuardar;
        private Label label4;
        private Label label9;
        private Label label10;
        private Label label15;
        private Label label18;
        private Label label2;
        private Label lblPeso;
        private Button btnagregarfoto;
        private Label label21;
        private TextBox txtAntebrazoDe;
        private Label label22;
        private TextBox txtBrazoDe;
        private Label label23;
        private TextBox txtBrazoIzq;
        private Label label24;
        private Label label25;
        private TextBox txtCintura;
        private Label label26;
        private Label label27;
        private TextBox txtCadera;
        private Label label28;
        private TextBox txtPiernaDe;
        private Label label29;
        private Label label30;
        private TextBox txtGemeloDe;
        private Label label31;
        private TextBox txtGemeloIzq;
        private Label label32;
        private Label label33;
        private TextBox txtAltura;
        private Label label34;
    }
}