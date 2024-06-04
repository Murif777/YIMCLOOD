namespace Presentacion
{
    partial class AgregarMembresia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.rbEntrenadorSi = new System.Windows.Forms.RadioButton();
            this.cbEntrenadores = new System.Windows.Forms.ComboBox();
            this.rbEntrenadoresNo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrpcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duracion en dias:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Entrenador";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(285, 161);
            this.txtValor.Margin = new System.Windows.Forms.Padding(2);
            this.txtValor.Multiline = true;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(168, 28);
            this.txtValor.TabIndex = 6;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(285, 204);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDuracion.Multiline = true;
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(168, 28);
            this.txtDuracion.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(285, 80);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 27);
            this.txtNombre.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(285, 111);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(172, 46);
            this.txtDescripcion.TabIndex = 11;
            // 
            // rbEntrenadorSi
            // 
            this.rbEntrenadorSi.AutoSize = true;
            this.rbEntrenadorSi.Location = new System.Drawing.Point(23, 10);
            this.rbEntrenadorSi.Name = "rbEntrenadorSi";
            this.rbEntrenadorSi.Size = new System.Drawing.Size(14, 13);
            this.rbEntrenadorSi.TabIndex = 12;
            this.rbEntrenadorSi.TabStop = true;
            this.rbEntrenadorSi.UseVisualStyleBackColor = true;
            this.rbEntrenadorSi.CheckedChanged += new System.EventHandler(this.rbEntrenador_CheckedChanged);
            // 
            // cbEntrenadores
            // 
            this.cbEntrenadores.FormattingEnabled = true;
            this.cbEntrenadores.Location = new System.Drawing.Point(281, 274);
            this.cbEntrenadores.Name = "cbEntrenadores";
            this.cbEntrenadores.Size = new System.Drawing.Size(172, 21);
            this.cbEntrenadores.TabIndex = 13;
            // 
            // rbEntrenadoresNo
            // 
            this.rbEntrenadoresNo.AutoSize = true;
            this.rbEntrenadoresNo.Location = new System.Drawing.Point(75, 10);
            this.rbEntrenadoresNo.Name = "rbEntrenadoresNo";
            this.rbEntrenadoresNo.Size = new System.Drawing.Size(14, 13);
            this.rbEntrenadoresNo.TabIndex = 14;
            this.rbEntrenadoresNo.TabStop = true;
            this.rbEntrenadoresNo.UseVisualStyleBackColor = true;
            this.rbEntrenadoresNo.CheckedChanged += new System.EventHandler(this.rbEntrenadoresNo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEntrenadoresNo);
            this.groupBox1.Controls.Add(this.rbEntrenadorSi);
            this.groupBox1.Location = new System.Drawing.Point(312, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 29);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(269, 348);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // AgregarMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbEntrenadores);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarMembresia";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.RadioButton rbEntrenadorSi;
        private System.Windows.Forms.ComboBox cbEntrenadores;
        private System.Windows.Forms.RadioButton rbEntrenadoresNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
    }
}