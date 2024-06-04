namespace Presentacion
{
    partial class AgregarMedidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarMedidas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnEjercicios = new System.Windows.Forms.Button();
            this.btnRutinas = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(799, 38);
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
            this.panel3.Size = new System.Drawing.Size(799, 120);
            this.panel3.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(463, 122);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // AgregarMedidas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(799, 788);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarMedidas";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInterfaz";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PerfilPeso_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}