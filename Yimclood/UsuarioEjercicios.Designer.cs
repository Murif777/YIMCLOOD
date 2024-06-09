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
    partial class UsuarioEjercicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioEjercicios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelBotones = new System.Windows.Forms.TableLayoutPanel();
            this.musculos = new System.Windows.Forms.PictureBox();
            this.listEjercicios = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlGimnasio = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCrearRutina = new Presentacion.botones.botones();
            this.btnPreestablecidas = new Presentacion.botones.botones();
            this.btnPantorrillas = new Presentacion.botones.botones();
            this.btnGluteos = new Presentacion.botones.botones();
            this.btnAntebrazos = new Presentacion.botones.botones();
            this.btnEspalda = new Presentacion.botones.botones();
            this.btnTriceps = new Presentacion.botones.botones();
            this.btnPiernas = new Presentacion.botones.botones();
            this.btnPecho = new Presentacion.botones.botones();
            this.btnAbdominales = new Presentacion.botones.botones();
            this.btnHombros = new Presentacion.botones.botones();
            this.btnBiceps = new Presentacion.botones.botones();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listEjercicios)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlGimnasio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 765);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelBotones
            // 
            this.panelBotones.ColumnCount = 1;
            this.panelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelBotones.Controls.Add(this.btnPantorrillas, 0, 9);
            this.panelBotones.Controls.Add(this.btnGluteos, 0, 8);
            this.panelBotones.Controls.Add(this.btnAntebrazos, 0, 7);
            this.panelBotones.Controls.Add(this.btnEspalda, 0, 5);
            this.panelBotones.Controls.Add(this.btnTriceps, 0, 6);
            this.panelBotones.Controls.Add(this.btnPiernas, 0, 4);
            this.panelBotones.Controls.Add(this.btnPecho, 0, 1);
            this.panelBotones.Controls.Add(this.btnAbdominales, 0, 3);
            this.panelBotones.Controls.Add(this.btnHombros, 0, 0);
            this.panelBotones.Controls.Add(this.btnBiceps, 0, 2);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(2);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.RowCount = 10;
            this.panelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelBotones.Size = new System.Drawing.Size(208, 611);
            this.panelBotones.TabIndex = 0;
            // 
            // musculos
            // 
            this.musculos.BackColor = System.Drawing.Color.Transparent;
            this.musculos.Dock = System.Windows.Forms.DockStyle.Left;
            this.musculos.Image = ((System.Drawing.Image)(resources.GetObject("musculos.Image")));
            this.musculos.Location = new System.Drawing.Point(208, 0);
            this.musculos.Margin = new System.Windows.Forms.Padding(2);
            this.musculos.Name = "musculos";
            this.musculos.Size = new System.Drawing.Size(435, 611);
            this.musculos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.musculos.TabIndex = 10;
            this.musculos.TabStop = false;
            // 
            // listEjercicios
            // 
            this.listEjercicios.AllowUserToAddRows = false;
            this.listEjercicios.AllowUserToDeleteRows = false;
            this.listEjercicios.BackgroundColor = System.Drawing.Color.White;
            this.listEjercicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listEjercicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.listEjercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listEjercicios.DefaultCellStyle = dataGridViewCellStyle1;
            this.listEjercicios.Location = new System.Drawing.Point(645, 0);
            this.listEjercicios.Margin = new System.Windows.Forms.Padding(2);
            this.listEjercicios.Name = "listEjercicios";
            this.listEjercicios.ReadOnly = true;
            this.listEjercicios.RowHeadersWidth = 51;
            this.listEjercicios.RowTemplate.Height = 24;
            this.listEjercicios.Size = new System.Drawing.Size(355, 426);
            this.listEjercicios.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btnCrearRutina);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(645, 518);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 94);
            this.panel3.TabIndex = 31;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(277, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16F);
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crear rutina personalizada";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnlGimnasio
            // 
            this.pnlGimnasio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlGimnasio.Controls.Add(this.btnPreestablecidas);
            this.pnlGimnasio.Controls.Add(this.label1);
            this.pnlGimnasio.Controls.Add(this.pictureBox1);
            this.pnlGimnasio.Location = new System.Drawing.Point(645, 424);
            this.pnlGimnasio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGimnasio.Name = "pnlGimnasio";
            this.pnlGimnasio.Size = new System.Drawing.Size(355, 94);
            this.pnlGimnasio.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16F);
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rutinas preestableciadas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(277, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCrearRutina
            // 
            this.btnCrearRutina.BackColor = System.Drawing.Color.White;
            this.btnCrearRutina.BackgroundColor = System.Drawing.Color.White;
            this.btnCrearRutina.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCrearRutina.BorderRadius = 10;
            this.btnCrearRutina.BorderSize = 3;
            this.btnCrearRutina.FlatAppearance.BorderSize = 0;
            this.btnCrearRutina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearRutina.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14F);
            this.btnCrearRutina.ForeColor = System.Drawing.Color.Black;
            this.btnCrearRutina.Location = new System.Drawing.Point(70, 49);
            this.btnCrearRutina.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearRutina.Name = "btnCrearRutina";
            this.btnCrearRutina.Size = new System.Drawing.Size(160, 39);
            this.btnCrearRutina.TabIndex = 4;
            this.btnCrearRutina.Text = "Crear";
            this.btnCrearRutina.TextColor = System.Drawing.Color.Black;
            this.btnCrearRutina.UseVisualStyleBackColor = false;
            // 
            // btnPreestablecidas
            // 
            this.btnPreestablecidas.BackColor = System.Drawing.Color.White;
            this.btnPreestablecidas.BackgroundColor = System.Drawing.Color.White;
            this.btnPreestablecidas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPreestablecidas.BorderRadius = 10;
            this.btnPreestablecidas.BorderSize = 3;
            this.btnPreestablecidas.FlatAppearance.BorderSize = 0;
            this.btnPreestablecidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreestablecidas.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14F);
            this.btnPreestablecidas.ForeColor = System.Drawing.Color.Black;
            this.btnPreestablecidas.Location = new System.Drawing.Point(70, 48);
            this.btnPreestablecidas.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreestablecidas.Name = "btnPreestablecidas";
            this.btnPreestablecidas.Size = new System.Drawing.Size(160, 39);
            this.btnPreestablecidas.TabIndex = 4;
            this.btnPreestablecidas.Text = "Ver ";
            this.btnPreestablecidas.TextColor = System.Drawing.Color.Black;
            this.btnPreestablecidas.UseVisualStyleBackColor = false;
            this.btnPreestablecidas.Click += new System.EventHandler(this.btnPreestablecidas_Click);
            // 
            // btnPantorrillas
            // 
            this.btnPantorrillas.BackColor = System.Drawing.Color.Transparent;
            this.btnPantorrillas.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPantorrillas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(25)))), ((int)(((byte)(3)))));
            this.btnPantorrillas.BorderRadius = 10;
            this.btnPantorrillas.BorderSize = 3;
            this.btnPantorrillas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPantorrillas.FlatAppearance.BorderSize = 0;
            this.btnPantorrillas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPantorrillas.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.btnPantorrillas.ForeColor = System.Drawing.Color.Black;
            this.btnPantorrillas.Location = new System.Drawing.Point(2, 551);
            this.btnPantorrillas.Margin = new System.Windows.Forms.Padding(2);
            this.btnPantorrillas.Name = "btnPantorrillas";
            this.btnPantorrillas.Size = new System.Drawing.Size(204, 58);
            this.btnPantorrillas.TabIndex = 26;
            this.btnPantorrillas.Text = "Pantorrillas";
            this.btnPantorrillas.TextColor = System.Drawing.Color.Black;
            this.btnPantorrillas.UseVisualStyleBackColor = false;
            this.btnPantorrillas.Click += new System.EventHandler(this.MusculoButton_Click);
            this.btnPantorrillas.MouseEnter += new System.EventHandler(this.MusculoButton_MouseEnter);
            this.btnPantorrillas.MouseLeave += new System.EventHandler(this.MusculoButton_MouseLeave);
            // 
            // btnGluteos
            // 
            this.btnGluteos.BackColor = System.Drawing.Color.Transparent;
            this.btnGluteos.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnGluteos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(25)))), ((int)(((byte)(3)))));
            this.btnGluteos.BorderRadius = 10;
            this.btnGluteos.BorderSize = 3;
            this.btnGluteos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGluteos.FlatAppearance.BorderSize = 0;
            this.btnGluteos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGluteos.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.btnGluteos.ForeColor = System.Drawing.Color.Black;
            this.btnGluteos.Location = new System.Drawing.Point(2, 490);
            this.btnGluteos.Margin = new System.Windows.Forms.Padding(2);
            this.btnGluteos.Name = "btnGluteos";
            this.btnGluteos.Size = new System.Drawing.Size(204, 57);
            this.btnGluteos.TabIndex = 25;
            this.btnGluteos.Text = "Gluteos";
            this.btnGluteos.TextColor = System.Drawing.Color.Black;
            this.btnGluteos.UseVisualStyleBackColor = false;
            this.btnGluteos.Click += new System.EventHandler(this.MusculoButton_Click);
            this.btnGluteos.MouseEnter += new System.EventHandler(this.MusculoButton_MouseEnter);
            this.btnGluteos.MouseLeave += new System.EventHandler(this.MusculoButton_MouseLeave);
            // 
            // btnAntebrazos
            // 
            this.btnAntebrazos.BackColor = System.Drawing.Color.Transparent;
            this.btnAntebrazos.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAntebrazos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(25)))), ((int)(((byte)(3)))));
            this.btnAntebrazos.BorderRadius = 10;
            this.btnAntebrazos.BorderSize = 3;
            this.btnAntebrazos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAntebrazos.FlatAppearance.BorderSize = 0;
            this.btnAntebrazos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAntebrazos.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.btnAntebrazos.ForeColor = System.Drawing.Color.Black;
            this.btnAntebrazos.Location = new System.Drawing.Point(2, 429);
            this.btnAntebrazos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAntebrazos.Name = "btnAntebrazos";
            this.btnAntebrazos.Size = new System.Drawing.Size(204, 57);
            this.btnAntebrazos.TabIndex = 24;
            this.btnAntebrazos.Text = "Antebrazos";
            this.btnAntebrazos.TextColor = System.Drawing.Color.Black;
            this.btnAntebrazos.UseVisualStyleBackColor = false;
            this.btnAntebrazos.Click += new System.EventHandler(this.MusculoButton_Click);
            this.btnAntebrazos.MouseEnter += new System.EventHandler(this.MusculoButton_MouseEnter);
            this.btnAntebrazos.MouseLeave += new System.EventHandler(this.MusculoButton_MouseLeave);
            // 
            // btnEspalda
            // 
            this.btnEspalda.BackColor = System.Drawing.Color.Transparent;
            this.btnEspalda.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEspalda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(25)))), ((int)(((byte)(3)))));
            this.btnEspalda.BorderRadius = 10;
            this.btnEspalda.BorderSize = 3;
            this.btnEspalda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEspalda.FlatAppearance.BorderSize = 0;
            this.btnEspalda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspalda.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.btnEspalda.ForeColor = System.Drawing.Color.Black;
            this.btnEspalda.Location = new System.Drawing.Point(2, 307);
            this.btnEspalda.Margin = new System.Windows.Forms.Padding(2);
            this.btnEspalda.Name = "btnEspalda";
            this.btnEspalda.Size = new System.Drawing.Size(204, 57);
            this.btnEspalda.TabIndex = 22;
            this.btnEspalda.Text = "Espalda";
            this.btnEspalda.TextColor = System.Drawing.Color.Black;
            this.btnEspalda.UseVisualStyleBackColor = false;
            this.btnEspalda.Click += new System.EventHandler(this.MusculoButton_Click);
            this.btnEspalda.MouseEnter += new System.EventHandler(this.MusculoButton_MouseEnter);
            this.btnEspalda.MouseLeave += new System.EventHandler(this.MusculoButton_MouseLeave);
            // 
            // btnTriceps
            // 
            this.btnTriceps.BackColor = System.Drawing.Color.Transparent;
            this.btnTriceps.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnTriceps.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(25)))), ((int)(((byte)(3)))));
            this.btnTriceps.BorderRadius = 10;
            this.btnTriceps.BorderSize = 3;
            this.btnTriceps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTriceps.FlatAppearance.BorderSize = 0;
            this.btnTriceps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriceps.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.btnTriceps.ForeColor = System.Drawing.Color.Black;
            this.btnTriceps.Location = new System.Drawing.Point(2, 368);
            this.btnTriceps.Margin = new System.Windows.Forms.Padding(2);
            this.btnTriceps.Name = "btnTriceps";
            this.btnTriceps.Size = new System.Drawing.Size(204, 57);
            this.btnTriceps.TabIndex = 23;
            this.btnTriceps.Text = "Triceps";
            this.btnTriceps.TextColor = System.Drawing.Color.Black;
            this.btnTriceps.UseVisualStyleBackColor = false;
            this.btnTriceps.Click += new System.EventHandler(this.MusculoButton_Click);
            this.btnTriceps.MouseEnter += new System.EventHandler(this.MusculoButton_MouseEnter);
            this.btnTriceps.MouseLeave += new System.EventHandler(this.MusculoButton_MouseLeave);
            // 
            // btnPiernas
            // 
            this.btnPiernas.BackColor = System.Drawing.Color.Transparent;
            this.btnPiernas.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPiernas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(25)))), ((int)(((byte)(3)))));
            this.btnPiernas.BorderRadius = 4;
            this.btnPiernas.BorderSize = 3;
            this.btnPiernas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPiernas.FlatAppearance.BorderSize = 0;
            this.btnPiernas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPiernas.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.btnPiernas.ForeColor = System.Drawing.Color.Black;
            this.btnPiernas.Location = new System.Drawing.Point(2, 246);
            this.btnPiernas.Margin = new System.Windows.Forms.Padding(2);
            this.btnPiernas.Name = "btnPiernas";
            this.btnPiernas.Size = new System.Drawing.Size(204, 57);
            this.btnPiernas.TabIndex = 22;
            this.btnPiernas.Text = "Piernas";
            this.btnPiernas.TextColor = System.Drawing.Color.Black;
            this.btnPiernas.UseVisualStyleBackColor = false;
            this.btnPiernas.Click += new System.EventHandler(this.MusculoButton_Click);
            this.btnPiernas.MouseEnter += new System.EventHandler(this.MusculoButton_MouseEnter);
            this.btnPiernas.MouseLeave += new System.EventHandler(this.MusculoButton_MouseLeave);
            // 
            // btnPecho
            // 
            this.btnPecho.BackColor = System.Drawing.Color.Transparent;
            this.btnPecho.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPecho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(25)))), ((int)(((byte)(3)))));
            this.btnPecho.BorderRadius = 4;
            this.btnPecho.BorderSize = 3;
            this.btnPecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPecho.FlatAppearance.BorderSize = 0;
            this.btnPecho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPecho.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.btnPecho.ForeColor = System.Drawing.Color.Black;
            this.btnPecho.Location = new System.Drawing.Point(2, 63);
            this.btnPecho.Margin = new System.Windows.Forms.Padding(2);
            this.btnPecho.Name = "btnPecho";
            this.btnPecho.Size = new System.Drawing.Size(204, 57);
            this.btnPecho.TabIndex = 18;
            this.btnPecho.Text = "Pecho";
            this.btnPecho.TextColor = System.Drawing.Color.Black;
            this.btnPecho.UseVisualStyleBackColor = false;
            this.btnPecho.Click += new System.EventHandler(this.MusculoButton_Click);
            this.btnPecho.MouseEnter += new System.EventHandler(this.MusculoButton_MouseEnter);
            this.btnPecho.MouseLeave += new System.EventHandler(this.MusculoButton_MouseLeave);
            // 
            // btnAbdominales
            // 
            this.btnAbdominales.BackColor = System.Drawing.Color.Transparent;
            this.btnAbdominales.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAbdominales.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(25)))), ((int)(((byte)(3)))));
            this.btnAbdominales.BorderRadius = 4;
            this.btnAbdominales.BorderSize = 3;
            this.btnAbdominales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbdominales.FlatAppearance.BorderSize = 0;
            this.btnAbdominales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbdominales.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.btnAbdominales.ForeColor = System.Drawing.Color.Black;
            this.btnAbdominales.Location = new System.Drawing.Point(2, 185);
            this.btnAbdominales.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbdominales.Name = "btnAbdominales";
            this.btnAbdominales.Size = new System.Drawing.Size(204, 57);
            this.btnAbdominales.TabIndex = 21;
            this.btnAbdominales.Text = "Abdominales";
            this.btnAbdominales.TextColor = System.Drawing.Color.Black;
            this.btnAbdominales.UseVisualStyleBackColor = false;
            this.btnAbdominales.Click += new System.EventHandler(this.MusculoButton_Click);
            this.btnAbdominales.MouseEnter += new System.EventHandler(this.MusculoButton_MouseEnter);
            this.btnAbdominales.MouseLeave += new System.EventHandler(this.MusculoButton_MouseLeave);
            // 
            // btnHombros
            // 
            this.btnHombros.BackColor = System.Drawing.Color.Transparent;
            this.btnHombros.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnHombros.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(25)))), ((int)(((byte)(3)))));
            this.btnHombros.BorderRadius = 4;
            this.btnHombros.BorderSize = 3;
            this.btnHombros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHombros.FlatAppearance.BorderSize = 0;
            this.btnHombros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHombros.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.btnHombros.ForeColor = System.Drawing.Color.Black;
            this.btnHombros.Location = new System.Drawing.Point(2, 2);
            this.btnHombros.Margin = new System.Windows.Forms.Padding(2);
            this.btnHombros.Name = "btnHombros";
            this.btnHombros.Size = new System.Drawing.Size(204, 57);
            this.btnHombros.TabIndex = 19;
            this.btnHombros.Text = "Hombros";
            this.btnHombros.TextColor = System.Drawing.Color.Black;
            this.btnHombros.UseVisualStyleBackColor = false;
            this.btnHombros.Click += new System.EventHandler(this.MusculoButton_Click);
            this.btnHombros.MouseEnter += new System.EventHandler(this.MusculoButton_MouseEnter);
            this.btnHombros.MouseLeave += new System.EventHandler(this.MusculoButton_MouseLeave);
            // 
            // btnBiceps
            // 
            this.btnBiceps.BackColor = System.Drawing.Color.Transparent;
            this.btnBiceps.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBiceps.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(25)))), ((int)(((byte)(3)))));
            this.btnBiceps.BorderRadius = 4;
            this.btnBiceps.BorderSize = 3;
            this.btnBiceps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBiceps.FlatAppearance.BorderSize = 0;
            this.btnBiceps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiceps.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F);
            this.btnBiceps.ForeColor = System.Drawing.Color.Black;
            this.btnBiceps.Location = new System.Drawing.Point(2, 124);
            this.btnBiceps.Margin = new System.Windows.Forms.Padding(2);
            this.btnBiceps.Name = "btnBiceps";
            this.btnBiceps.Size = new System.Drawing.Size(204, 57);
            this.btnBiceps.TabIndex = 20;
            this.btnBiceps.Text = "Biceps";
            this.btnBiceps.TextColor = System.Drawing.Color.Black;
            this.btnBiceps.UseVisualStyleBackColor = false;
            this.btnBiceps.Click += new System.EventHandler(this.MusculoButton_Click);
            this.btnBiceps.MouseEnter += new System.EventHandler(this.MusculoButton_MouseEnter);
            this.btnBiceps.MouseLeave += new System.EventHandler(this.MusculoButton_MouseLeave);
            // 
            // UsuarioEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 611);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlGimnasio);
            this.Controls.Add(this.listEjercicios);
            this.Controls.Add(this.musculos);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsuarioEjercicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInterfaz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.musculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listEjercicios)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlGimnasio.ResumeLayout(false);
            this.pnlGimnasio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel panelBotones;
        private botones.botones btnPiernas;
        private botones.botones btnPecho;
        private botones.botones btnAbdominales;
        private botones.botones btnHombros;
        private botones.botones btnBiceps;
        private botones.botones btnGluteos;
        private botones.botones btnEspalda;
        private botones.botones btnAntebrazos;
        private botones.botones btnTriceps;
        private botones.botones btnPantorrillas;
        private PictureBox musculos;
        private DataGridView listEjercicios;
        private Panel pnlGimnasio;
        private botones.botones btnPreestablecidas;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private botones.botones btnCrearRutina;
        private Label label2;
        private PictureBox pictureBox2;
    }
}