namespace Presentacion
{
    partial class ConsultarMiembro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarMiembro));
            this.dataGridViewMiembro = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Btnregresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CORREO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMiembro)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMiembro
            // 
            this.dataGridViewMiembro.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridViewMiembro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMiembro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.IDENTIFICACION,
            this.TELEFONO,
            this.CORREO});
            this.dataGridViewMiembro.Location = new System.Drawing.Point(68, 235);
            this.dataGridViewMiembro.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMiembro.Name = "dataGridViewMiembro";
            this.dataGridViewMiembro.RowHeadersWidth = 51;
            this.dataGridViewMiembro.RowTemplate.Height = 24;
            this.dataGridViewMiembro.Size = new System.Drawing.Size(679, 161);
            this.dataGridViewMiembro.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(579, 117);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(52, 37);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Btnregresar
            // 
            this.Btnregresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnregresar.FlatAppearance.BorderSize = 0;
            this.Btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnregresar.Image = ((System.Drawing.Image)(resources.GetObject("Btnregresar.Image")));
            this.Btnregresar.Location = new System.Drawing.Point(18, 6);
            this.Btnregresar.Margin = new System.Windows.Forms.Padding(2);
            this.Btnregresar.Name = "Btnregresar";
            this.Btnregresar.Size = new System.Drawing.Size(56, 40);
            this.Btnregresar.TabIndex = 0;
            this.Btnregresar.UseVisualStyleBackColor = true;
            this.Btnregresar.Click += new System.EventHandler(this.Btnregresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(258, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "BUSCAR MIEMBRO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btnregresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 54);
            this.panel1.TabIndex = 4;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(368, 119);
            this.txtCedula.Multiline = true;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(206, 31);
            this.txtCedula.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "IDENTIFICACION:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NOMBRE";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // IDENTIFICACION
            // 
            this.IDENTIFICACION.HeaderText = "IDENNTIFICACION";
            this.IDENTIFICACION.Name = "IDENTIFICACION";
            this.IDENTIFICACION.Width = 150;
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.Name = "TELEFONO";
            // 
            // CORREO
            // 
            this.CORREO.HeaderText = "CORREO";
            this.CORREO.Name = "CORREO";
            this.CORREO.Width = 250;
            // 
            // ConsultarMiembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(812, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewMiembro);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultarMiembro";
            this.Text = "FormCnsultarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMiembro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewMiembro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button Btnregresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDENTIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORREO;
    }
}