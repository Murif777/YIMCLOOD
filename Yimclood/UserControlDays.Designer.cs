namespace Presentacion
{
    partial class UserControlDays
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbldays = new System.Windows.Forms.Label();
            this.lblValorPeso = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F);
            this.lbldays.Location = new System.Drawing.Point(3, 0);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(44, 36);
            this.lbldays.TabIndex = 0;
            this.lbldays.Text = "00";
            // 
            // lblValorPeso
            // 
            this.lblValorPeso.AutoSize = true;
            this.lblValorPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblValorPeso.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.lblValorPeso.Location = new System.Drawing.Point(3, 57);
            this.lblValorPeso.Name = "lblValorPeso";
            this.lblValorPeso.Size = new System.Drawing.Size(65, 30);
            this.lblValorPeso.TabIndex = 1;
            this.lblValorPeso.Text = "Peso:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblPeso.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.lblPeso.Location = new System.Drawing.Point(84, 57);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(108, 30);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "XX.X+\"Kg\"";
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblValorPeso);
            this.Controls.Add(this.lbldays);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(219, 100);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.Label lblValorPeso;
        private System.Windows.Forms.Label lblPeso;
    }
}
