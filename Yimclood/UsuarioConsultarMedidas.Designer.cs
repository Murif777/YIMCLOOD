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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAntebrazos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblsd = new System.Windows.Forms.Label();
            this.lblPecho = new System.Windows.Forms.Label();
            this.lblHombros = new System.Windows.Forms.Label();
            this.lblCadera = new System.Windows.Forms.Label();
            this.lblCintura = new System.Windows.Forms.Label();
            this.lblPiernaIzq = new System.Windows.Forms.Label();
            this.lblGemeloIzq = new System.Windows.Forms.Label();
            this.lblPiernasDe = new System.Windows.Forms.Label();
            this.lblGemeloDe = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBrazoIzq = new System.Windows.Forms.Label();
            this.lblBrazoDe = new System.Windows.Forms.Label();
            this.lblAntebrazoIzq = new System.Windows.Forms.Label();
            this.lblAntebrazoDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(305, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 41);
            this.label4.TabIndex = 73;
            this.label4.Text = "Kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 35F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-1, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 71);
            this.label2.TabIndex = 54;
            this.label2.Text = "Medidas:";
            // 
            // lblFecha
            // 
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblFecha.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 35F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(25)))), ((int)(((byte)(3)))));
            this.lblFecha.Location = new System.Drawing.Point(182, 85);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.ReadOnly = true;
            this.lblFecha.Size = new System.Drawing.Size(356, 71);
            this.lblFecha.TabIndex = 84;
            this.lblFecha.Text = "DIA/MES/AÑO";
            this.lblFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPeso
            // 
            this.lblPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblPeso.ForeColor = System.Drawing.Color.Black;
            this.lblPeso.Location = new System.Drawing.Point(233, 208);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(32, 41);
            this.lblPeso.TabIndex = 100;
            this.lblPeso.Text = "-";
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
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlSuperior.Controls.Add(this.btnMinimizar);
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(881, 81);
            this.pnlSuperior.TabIndex = 101;
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFoto.BackColor = System.Drawing.Color.Transparent;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(574, 85);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(2);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(271, 240);
            this.pbFoto.TabIndex = 102;
            this.pbFoto.TabStop = false;
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(307, 573);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(43, 30);
            this.label33.TabIndex = 160;
            this.label33.Text = "cm";
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(802, 457);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(43, 30);
            this.label30.TabIndex = 157;
            this.label30.Text = "cm";
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(669, 457);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(43, 30);
            this.label31.TabIndex = 155;
            this.label31.Text = "cm";
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(433, 449);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label32.Size = new System.Drawing.Size(139, 41);
            this.label32.TabIndex = 153;
            this.label32.Text = "Gemelos:";
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(307, 515);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(43, 30);
            this.label29.TabIndex = 152;
            this.label29.Text = "cm";
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(307, 401);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(43, 30);
            this.label27.TabIndex = 150;
            this.label27.Text = "cm";
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(92, 449);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 41);
            this.label28.TabIndex = 148;
            this.label28.Text = "Cadera:";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(307, 460);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(43, 30);
            this.label25.TabIndex = 147;
            this.label25.Text = "cm";
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(92, 504);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(123, 41);
            this.label26.TabIndex = 145;
            this.label26.Text = "Cintura:";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(478, 203);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 41);
            this.label22.TabIndex = 144;
            this.label22.Text = "cm";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(669, 342);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 30);
            this.label23.TabIndex = 142;
            this.label23.Text = "cm";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(433, 334);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(116, 41);
            this.label24.TabIndex = 140;
            this.label24.Text = "Brazos:";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(802, 393);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 30);
            this.label21.TabIndex = 139;
            this.label21.Text = "cm";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(669, 390);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 30);
            this.label18.TabIndex = 135;
            this.label18.Text = "cm";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(802, 342);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 30);
            this.label15.TabIndex = 132;
            this.label15.Text = "cm";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(307, 345);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 30);
            this.label10.TabIndex = 129;
            this.label10.Text = "cm";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(480, 570);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 30);
            this.label9.TabIndex = 128;
            this.label9.Text = "cm";
            // 
            // txtAntebrazos
            // 
            this.txtAntebrazos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAntebrazos.AutoSize = true;
            this.txtAntebrazos.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.txtAntebrazos.ForeColor = System.Drawing.Color.Black;
            this.txtAntebrazos.Location = new System.Drawing.Point(433, 390);
            this.txtAntebrazos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAntebrazos.Name = "txtAntebrazos";
            this.txtAntebrazos.Size = new System.Drawing.Size(176, 41);
            this.txtAntebrazos.TabIndex = 115;
            this.txtAntebrazos.Text = "Antebrazos:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(92, 562);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(127, 41);
            this.label8.TabIndex = 112;
            this.label8.Text = "Piernas:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(92, 390);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 41);
            this.label5.TabIndex = 109;
            this.label5.Text = "Pecho:";
            // 
            // lblsd
            // 
            this.lblsd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsd.AutoSize = true;
            this.lblsd.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblsd.ForeColor = System.Drawing.Color.Black;
            this.lblsd.Location = new System.Drawing.Point(92, 334);
            this.lblsd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsd.Name = "lblsd";
            this.lblsd.Size = new System.Drawing.Size(144, 41);
            this.lblsd.TabIndex = 108;
            this.lblsd.Text = "Hombros:";
            // 
            // lblPecho
            // 
            this.lblPecho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPecho.AutoSize = true;
            this.lblPecho.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblPecho.ForeColor = System.Drawing.Color.Black;
            this.lblPecho.Location = new System.Drawing.Point(233, 398);
            this.lblPecho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPecho.Name = "lblPecho";
            this.lblPecho.Size = new System.Drawing.Size(32, 41);
            this.lblPecho.TabIndex = 161;
            this.lblPecho.Text = "-";
            // 
            // lblHombros
            // 
            this.lblHombros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHombros.AutoSize = true;
            this.lblHombros.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblHombros.ForeColor = System.Drawing.Color.Black;
            this.lblHombros.Location = new System.Drawing.Point(233, 339);
            this.lblHombros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHombros.Name = "lblHombros";
            this.lblHombros.Size = new System.Drawing.Size(32, 41);
            this.lblHombros.TabIndex = 162;
            this.lblHombros.Text = "-";
            // 
            // lblCadera
            // 
            this.lblCadera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCadera.AutoSize = true;
            this.lblCadera.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblCadera.ForeColor = System.Drawing.Color.Black;
            this.lblCadera.Location = new System.Drawing.Point(233, 460);
            this.lblCadera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCadera.Name = "lblCadera";
            this.lblCadera.Size = new System.Drawing.Size(32, 41);
            this.lblCadera.TabIndex = 164;
            this.lblCadera.Text = "-";
            // 
            // lblCintura
            // 
            this.lblCintura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCintura.AutoSize = true;
            this.lblCintura.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblCintura.ForeColor = System.Drawing.Color.Black;
            this.lblCintura.Location = new System.Drawing.Point(233, 510);
            this.lblCintura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCintura.Name = "lblCintura";
            this.lblCintura.Size = new System.Drawing.Size(32, 41);
            this.lblCintura.TabIndex = 165;
            this.lblCintura.Text = "-";
            // 
            // lblPiernaIzq
            // 
            this.lblPiernaIzq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPiernaIzq.AutoSize = true;
            this.lblPiernaIzq.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblPiernaIzq.ForeColor = System.Drawing.Color.Black;
            this.lblPiernaIzq.Location = new System.Drawing.Point(408, 562);
            this.lblPiernaIzq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPiernaIzq.Name = "lblPiernaIzq";
            this.lblPiernaIzq.Size = new System.Drawing.Size(32, 41);
            this.lblPiernaIzq.TabIndex = 166;
            this.lblPiernaIzq.Text = "-";
            // 
            // lblGemeloIzq
            // 
            this.lblGemeloIzq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGemeloIzq.AutoSize = true;
            this.lblGemeloIzq.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblGemeloIzq.ForeColor = System.Drawing.Color.Black;
            this.lblGemeloIzq.Location = new System.Drawing.Point(606, 449);
            this.lblGemeloIzq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGemeloIzq.Name = "lblGemeloIzq";
            this.lblGemeloIzq.Size = new System.Drawing.Size(32, 41);
            this.lblGemeloIzq.TabIndex = 167;
            this.lblGemeloIzq.Text = "-";
            // 
            // lblPiernasDe
            // 
            this.lblPiernasDe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPiernasDe.AutoSize = true;
            this.lblPiernasDe.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblPiernasDe.ForeColor = System.Drawing.Color.Black;
            this.lblPiernasDe.Location = new System.Drawing.Point(233, 562);
            this.lblPiernasDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPiernasDe.Name = "lblPiernasDe";
            this.lblPiernasDe.Size = new System.Drawing.Size(32, 41);
            this.lblPiernasDe.TabIndex = 168;
            this.lblPiernasDe.Text = "-";
            // 
            // lblGemeloDe
            // 
            this.lblGemeloDe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGemeloDe.AutoSize = true;
            this.lblGemeloDe.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblGemeloDe.ForeColor = System.Drawing.Color.Black;
            this.lblGemeloDe.Location = new System.Drawing.Point(755, 446);
            this.lblGemeloDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGemeloDe.Name = "lblGemeloDe";
            this.lblGemeloDe.Size = new System.Drawing.Size(32, 41);
            this.lblGemeloDe.TabIndex = 169;
            this.lblGemeloDe.Text = "-";
            // 
            // lblAltura
            // 
            this.lblAltura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblAltura.ForeColor = System.Drawing.Color.Black;
            this.lblAltura.Location = new System.Drawing.Point(408, 208);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(32, 41);
            this.lblAltura.TabIndex = 170;
            this.lblAltura.Text = "-";
            // 
            // lblBrazoIzq
            // 
            this.lblBrazoIzq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrazoIzq.AutoSize = true;
            this.lblBrazoIzq.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblBrazoIzq.ForeColor = System.Drawing.Color.Black;
            this.lblBrazoIzq.Location = new System.Drawing.Point(606, 334);
            this.lblBrazoIzq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrazoIzq.Name = "lblBrazoIzq";
            this.lblBrazoIzq.Size = new System.Drawing.Size(32, 41);
            this.lblBrazoIzq.TabIndex = 173;
            this.lblBrazoIzq.Text = "-";
            // 
            // lblBrazoDe
            // 
            this.lblBrazoDe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrazoDe.AutoSize = true;
            this.lblBrazoDe.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblBrazoDe.ForeColor = System.Drawing.Color.Black;
            this.lblBrazoDe.Location = new System.Drawing.Point(755, 334);
            this.lblBrazoDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrazoDe.Name = "lblBrazoDe";
            this.lblBrazoDe.Size = new System.Drawing.Size(32, 41);
            this.lblBrazoDe.TabIndex = 174;
            this.lblBrazoDe.Text = "-";
            // 
            // lblAntebrazoIzq
            // 
            this.lblAntebrazoIzq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAntebrazoIzq.AutoSize = true;
            this.lblAntebrazoIzq.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblAntebrazoIzq.ForeColor = System.Drawing.Color.Black;
            this.lblAntebrazoIzq.Location = new System.Drawing.Point(606, 387);
            this.lblAntebrazoIzq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAntebrazoIzq.Name = "lblAntebrazoIzq";
            this.lblAntebrazoIzq.Size = new System.Drawing.Size(32, 41);
            this.lblAntebrazoIzq.TabIndex = 175;
            this.lblAntebrazoIzq.Text = "-";
            // 
            // lblAntebrazoDe
            // 
            this.lblAntebrazoDe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAntebrazoDe.AutoSize = true;
            this.lblAntebrazoDe.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.lblAntebrazoDe.ForeColor = System.Drawing.Color.Black;
            this.lblAntebrazoDe.Location = new System.Drawing.Point(755, 382);
            this.lblAntebrazoDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAntebrazoDe.Name = "lblAntebrazoDe";
            this.lblAntebrazoDe.Size = new System.Drawing.Size(32, 41);
            this.lblAntebrazoDe.TabIndex = 176;
            this.lblAntebrazoDe.Text = "-";
            // 
            // UsuarioConsultarMedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(881, 651);
            this.Controls.Add(this.lblAntebrazoDe);
            this.Controls.Add(this.lblAntebrazoIzq);
            this.Controls.Add(this.lblBrazoDe);
            this.Controls.Add(this.lblBrazoIzq);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblGemeloDe);
            this.Controls.Add(this.lblPiernasDe);
            this.Controls.Add(this.lblGemeloIzq);
            this.Controls.Add(this.lblPiernaIzq);
            this.Controls.Add(this.lblCintura);
            this.Controls.Add(this.lblCadera);
            this.Controls.Add(this.lblHombros);
            this.Controls.Add(this.lblPecho);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAntebrazos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsd);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsuarioConsultarMedidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInterfaz";
            this.Load += new System.EventHandler(this.UsuarioConsultarMedidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label4;
        private Label label2;
        private TextBox lblFecha;
        private Label lblPeso;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Panel pnlSuperior;
        private PictureBox pbFoto;
        private Label label33;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label29;
        private Label label27;
        private Label label28;
        private Label label25;
        private Label label26;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label21;
        private Label label18;
        private Label label15;
        private Label label10;
        private Label label9;
        private Label txtAntebrazos;
        private Label label8;
        private Label label5;
        private Label lblsd;
        private Label lblPecho;
        private Label lblHombros;
        private Label lblCadera;
        private Label lblCintura;
        private Label lblPiernaIzq;
        private Label lblGemeloIzq;
        private Label lblPiernasDe;
        private Label lblGemeloDe;
        private Label lblAltura;
        private Label lblBrazoIzq;
        private Label lblBrazoDe;
        private Label lblAntebrazoIzq;
        private Label lblAntebrazoDe;
    }
}