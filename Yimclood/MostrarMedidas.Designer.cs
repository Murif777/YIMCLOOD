namespace Presentacion
{
    partial class MostrarMedidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarMedidas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnEjercicios = new System.Windows.Forms.Button();
            this.btnRutinas = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fotoPerfil = new System.Windows.Forms.PictureBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnMedidas = new Presentacion.botones.botones();
            this.btnAvanzado = new Presentacion.botones.botones();
            this.btnPeso = new Presentacion.botones.botones();
            this.btnSubir = new Presentacion.botones.botones();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new Presentacion.botones.botones();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 38);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(715, 3);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 31);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(758, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 31);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEjercicios
            // 
            this.btnEjercicios.BackColor = System.Drawing.Color.Transparent;
            this.btnEjercicios.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEjercicios.FlatAppearance.BorderSize = 0;
            this.btnEjercicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjercicios.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 17F);
            this.btnEjercicios.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEjercicios.Image = ((System.Drawing.Image)(resources.GetObject("btnEjercicios.Image")));
            this.btnEjercicios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEjercicios.Location = new System.Drawing.Point(5, 5);
            this.btnEjercicios.Margin = new System.Windows.Forms.Padding(0);
            this.btnEjercicios.Name = "btnEjercicios";
            this.btnEjercicios.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEjercicios.Size = new System.Drawing.Size(197, 110);
            this.btnEjercicios.TabIndex = 1;
            this.btnEjercicios.Text = "Ejercicios";
            this.btnEjercicios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEjercicios.UseVisualStyleBackColor = false;
            this.btnEjercicios.Click += new System.EventHandler(this.btnEjercicios_Click);
            // 
            // btnRutinas
            // 
            this.btnRutinas.BackColor = System.Drawing.Color.Transparent;
            this.btnRutinas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRutinas.FlatAppearance.BorderSize = 0;
            this.btnRutinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutinas.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 17F);
            this.btnRutinas.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnRutinas.Image = ((System.Drawing.Image)(resources.GetObject("btnRutinas.Image")));
            this.btnRutinas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRutinas.Location = new System.Drawing.Point(202, 5);
            this.btnRutinas.Margin = new System.Windows.Forms.Padding(0);
            this.btnRutinas.Name = "btnRutinas";
            this.btnRutinas.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRutinas.Size = new System.Drawing.Size(197, 110);
            this.btnRutinas.TabIndex = 2;
            this.btnRutinas.Text = "Rutinas";
            this.btnRutinas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRutinas.UseVisualStyleBackColor = false;
            this.btnRutinas.Click += new System.EventHandler(this.btnRutinas_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.Transparent;
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 17F);
            this.btnHistorial.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Image")));
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHistorial.Location = new System.Drawing.Point(399, 5);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(0);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHistorial.Size = new System.Drawing.Size(197, 110);
            this.btnHistorial.TabIndex = 3;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 17F);
            this.btnPerfil.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.Location = new System.Drawing.Point(596, 5);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(0);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPerfil.Size = new System.Drawing.Size(197, 110);
            this.btnPerfil.TabIndex = 4;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(this.btnPerfil);
            this.panel3.Controls.Add(this.btnHistorial);
            this.panel3.Controls.Add(this.btnRutinas);
            this.panel3.Controls.Add(this.btnEjercicios);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 668);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(798, 120);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 25F);
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cuerpo";
            // 
            // fotoPerfil
            // 
            this.fotoPerfil.BackColor = System.Drawing.Color.White;
            this.fotoPerfil.Location = new System.Drawing.Point(274, 83);
            this.fotoPerfil.Name = "fotoPerfil";
            this.fotoPerfil.Size = new System.Drawing.Size(226, 198);
            this.fotoPerfil.TabIndex = 12;
            this.fotoPerfil.TabStop = false;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F);
            this.lblPeso.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPeso.Location = new System.Drawing.Point(433, 297);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(37, 29);
            this.lblPeso.TabIndex = 14;
            this.lblPeso.Text = "Kg";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14F);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(434, 335);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(52, 23);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Text = "/2024";
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
            this.btnMedidas.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14F);
            this.btnMedidas.ForeColor = System.Drawing.Color.White;
            this.btnMedidas.Location = new System.Drawing.Point(306, 377);
            this.btnMedidas.Name = "btnMedidas";
            this.btnMedidas.Size = new System.Drawing.Size(189, 47);
            this.btnMedidas.TabIndex = 17;
            this.btnMedidas.Text = "Medidas";
            this.btnMedidas.TextColor = System.Drawing.Color.White;
            this.btnMedidas.UseVisualStyleBackColor = false;
            this.btnMedidas.Click += new System.EventHandler(this.btnMedidas_Click);
            // 
            // btnAvanzado
            // 
            this.btnAvanzado.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAvanzado.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAvanzado.BorderColor = System.Drawing.Color.Black;
            this.btnAvanzado.BorderRadius = 10;
            this.btnAvanzado.BorderSize = 3;
            this.btnAvanzado.FlatAppearance.BorderSize = 0;
            this.btnAvanzado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvanzado.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14F);
            this.btnAvanzado.ForeColor = System.Drawing.Color.White;
            this.btnAvanzado.Location = new System.Drawing.Point(486, 377);
            this.btnAvanzado.Name = "btnAvanzado";
            this.btnAvanzado.Size = new System.Drawing.Size(189, 47);
            this.btnAvanzado.TabIndex = 18;
            this.btnAvanzado.Text = "Avanzado";
            this.btnAvanzado.TextColor = System.Drawing.Color.White;
            this.btnAvanzado.UseVisualStyleBackColor = false;
            this.btnAvanzado.Click += new System.EventHandler(this.btnAvanzado_Click);
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
            this.btnPeso.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14F);
            this.btnPeso.ForeColor = System.Drawing.Color.White;
            this.btnPeso.Location = new System.Drawing.Point(124, 377);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(189, 47);
            this.btnPeso.TabIndex = 16;
            this.btnPeso.Text = "Peso";
            this.btnPeso.TextColor = System.Drawing.Color.White;
            this.btnPeso.UseVisualStyleBackColor = false;
            this.btnPeso.Click += new System.EventHandler(this.btnPeso_Click);
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
            this.btnSubir.Location = new System.Drawing.Point(420, 213);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(75, 59);
            this.btnSubir.TabIndex = 13;
            this.btnSubir.TextColor = System.Drawing.Color.White;
            this.btnSubir.UseVisualStyleBackColor = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            this.btnSubir.MouseEnter += new System.EventHandler(this.btnSubir_MouseEnter);
            this.btnSubir.MouseLeave += new System.EventHandler(this.btnSubir_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(124, 430);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 243);
            this.dataGridView1.TabIndex = 25;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(199)))), ((int)(((byte)(56)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(199)))), ((int)(((byte)(56)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.BorderSize = 5;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(724, 615);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 58);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MostrarMedidas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(798, 788);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.btnMedidas);
            this.Controls.Add(this.btnAvanzado);
            this.Controls.Add(this.btnPeso);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.fotoPerfil);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarMedidas";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInterfaz";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PerfilPeso_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEjercicios;
        private System.Windows.Forms.Button btnRutinas;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox fotoPerfil;
        private botones.botones btnSubir;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblFecha;
        private botones.botones btnPeso;
        private botones.botones btnMedidas;
        private botones.botones btnAvanzado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private botones.botones btnAdd;
    }
}