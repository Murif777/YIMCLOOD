namespace Presentacion
{
    partial class AgregarEjercicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEjercicios));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnRutinas = new System.Windows.Forms.Button();
            this.btnEjercicios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.listaEjercicios = new System.Windows.Forms.DataGridView();
            this.btnRutinaExistente = new Presentacion.botones.botones();
            this.btnNuevaRutina = new Presentacion.botones.botones();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEjercicios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(this.btnPerfil);
            this.panel3.Controls.Add(this.btnHistorial);
            this.panel3.Controls.Add(this.btnRutinas);
            this.panel3.Controls.Add(this.btnEjercicios);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 553);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(945, 120);
            this.panel3.TabIndex = 2;
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
            this.btnPerfil.Location = new System.Drawing.Point(701, 5);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(0);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPerfil.Size = new System.Drawing.Size(232, 110);
            this.btnPerfil.TabIndex = 8;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
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
            this.btnHistorial.Location = new System.Drawing.Point(469, 5);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(0);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHistorial.Size = new System.Drawing.Size(232, 110);
            this.btnHistorial.TabIndex = 7;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
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
            this.btnRutinas.Location = new System.Drawing.Point(237, 5);
            this.btnRutinas.Margin = new System.Windows.Forms.Padding(0);
            this.btnRutinas.Name = "btnRutinas";
            this.btnRutinas.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRutinas.Size = new System.Drawing.Size(232, 110);
            this.btnRutinas.TabIndex = 6;
            this.btnRutinas.Text = "Rutinas";
            this.btnRutinas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRutinas.UseVisualStyleBackColor = false;
            this.btnRutinas.Click += new System.EventHandler(this.btnRutinas_Click);
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
            this.btnEjercicios.Size = new System.Drawing.Size(232, 110);
            this.btnEjercicios.TabIndex = 5;
            this.btnEjercicios.Text = "Ejercicios";
            this.btnEjercicios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEjercicios.UseVisualStyleBackColor = false;
            this.btnEjercicios.Click += new System.EventHandler(this.btnEjercicios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 38);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(864, 6);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 31);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(907, 3);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 31);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // listaEjercicios
            // 
            this.listaEjercicios.BackgroundColor = System.Drawing.Color.LightYellow;
            this.listaEjercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaEjercicios.Location = new System.Drawing.Point(35, 71);
            this.listaEjercicios.Name = "listaEjercicios";
            this.listaEjercicios.RowHeadersWidth = 51;
            this.listaEjercicios.RowTemplate.Height = 24;
            this.listaEjercicios.Size = new System.Drawing.Size(577, 450);
            this.listaEjercicios.TabIndex = 9;
            // 
            // btnRutinaExistente
            // 
            this.btnRutinaExistente.BackColor = System.Drawing.Color.White;
            this.btnRutinaExistente.BackgroundColor = System.Drawing.Color.White;
            this.btnRutinaExistente.BorderColor = System.Drawing.Color.Black;
            this.btnRutinaExistente.BorderRadius = 18;
            this.btnRutinaExistente.BorderSize = 3;
            this.btnRutinaExistente.FlatAppearance.BorderSize = 0;
            this.btnRutinaExistente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutinaExistente.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14F);
            this.btnRutinaExistente.ForeColor = System.Drawing.Color.Black;
            this.btnRutinaExistente.Image = ((System.Drawing.Image)(resources.GetObject("btnRutinaExistente.Image")));
            this.btnRutinaExistente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRutinaExistente.Location = new System.Drawing.Point(640, 328);
            this.btnRutinaExistente.Name = "btnRutinaExistente";
            this.btnRutinaExistente.Size = new System.Drawing.Size(281, 58);
            this.btnRutinaExistente.TabIndex = 11;
            this.btnRutinaExistente.Text = "Rutina Existente";
            this.btnRutinaExistente.TextColor = System.Drawing.Color.Black;
            this.btnRutinaExistente.UseVisualStyleBackColor = false;
            this.btnRutinaExistente.Click += new System.EventHandler(this.btnRutinaExistente_Click);
            this.btnRutinaExistente.MouseEnter += new System.EventHandler(this.btnRutinaExistente_MouseEnter);
            this.btnRutinaExistente.MouseLeave += new System.EventHandler(this.btnRutinaExistente_MouseLeave);
            // 
            // btnNuevaRutina
            // 
            this.btnNuevaRutina.BackColor = System.Drawing.Color.White;
            this.btnNuevaRutina.BackgroundColor = System.Drawing.Color.White;
            this.btnNuevaRutina.BorderColor = System.Drawing.Color.Black;
            this.btnNuevaRutina.BorderRadius = 18;
            this.btnNuevaRutina.BorderSize = 3;
            this.btnNuevaRutina.FlatAppearance.BorderSize = 0;
            this.btnNuevaRutina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaRutina.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14F);
            this.btnNuevaRutina.ForeColor = System.Drawing.Color.Black;
            this.btnNuevaRutina.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaRutina.Image")));
            this.btnNuevaRutina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaRutina.Location = new System.Drawing.Point(640, 248);
            this.btnNuevaRutina.Name = "btnNuevaRutina";
            this.btnNuevaRutina.Size = new System.Drawing.Size(281, 58);
            this.btnNuevaRutina.TabIndex = 12;
            this.btnNuevaRutina.Text = "Nueva rutina";
            this.btnNuevaRutina.TextColor = System.Drawing.Color.Black;
            this.btnNuevaRutina.UseVisualStyleBackColor = false;
            this.btnNuevaRutina.Click += new System.EventHandler(this.btnNuevaRutina_Click);
            this.btnNuevaRutina.MouseEnter += new System.EventHandler(this.btnNuevaRutina_MouseEnter);
            this.btnNuevaRutina.MouseLeave += new System.EventHandler(this.btnNuevaRutina_MouseLeave);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(585, 79);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 435);
            this.vScrollBar1.TabIndex = 13;
            // 
            // AgregarEjercicios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(945, 673);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btnNuevaRutina);
            this.Controls.Add(this.btnRutinaExistente);
            this.Controls.Add(this.listaEjercicios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarEjercicios";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInterfaz";
            this.Load += new System.EventHandler(this.FormInterfaz_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormInterfaz_MouseDown);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEjercicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnRutinas;
        private System.Windows.Forms.Button btnEjercicios;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.DataGridView listaEjercicios;
        private botones.botones btnRutinaExistente;
        private botones.botones btnNuevaRutina;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}