namespace Presentacion
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnMMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMCerrar = new System.Windows.Forms.PictureBox();
            this.btnMRestaurar = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.btnMMaximizar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelMYIMCLOOD = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuVertical.SuspendLayout();
            this.panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.menuVertical.Controls.Add(this.button3);
            this.menuVertical.Controls.Add(this.button2);
            this.menuVertical.Controls.Add(this.labelMYIMCLOOD);
            this.menuVertical.Controls.Add(this.button1);
            this.menuVertical.Controls.Add(this.pictureBox3);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(250, 450);
            this.menuVertical.TabIndex = 0;
            this.menuVertical.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuVertical_MouseDown);
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelBarra.Controls.Add(this.btnMRestaurar);
            this.panelBarra.Controls.Add(this.btnMMaximizar);
            this.panelBarra.Controls.Add(this.btnMMinimizar);
            this.panelBarra.Controls.Add(this.btnMCerrar);
            this.panelBarra.Controls.Add(this.btnSlide);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(250, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(550, 50);
            this.panelBarra.TabIndex = 1;
            this.panelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMMinimizar
            // 
            this.btnMMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMMinimizar.Image")));
            this.btnMMinimizar.Location = new System.Drawing.Point(453, 14);
            this.btnMMinimizar.Name = "btnMMinimizar";
            this.btnMMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMMinimizar.TabIndex = 1;
            this.btnMMinimizar.TabStop = false;
            this.btnMMinimizar.Click += new System.EventHandler(this.btnMMinimizar_Click);
            // 
            // btnMCerrar
            // 
            this.btnMCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnMCerrar.Image")));
            this.btnMCerrar.Location = new System.Drawing.Point(518, 12);
            this.btnMCerrar.Name = "btnMCerrar";
            this.btnMCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnMCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMCerrar.TabIndex = 2;
            this.btnMCerrar.TabStop = false;
            this.btnMCerrar.Click += new System.EventHandler(this.btnMCerrar_Click);
            // 
            // btnMRestaurar
            // 
            this.btnMRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnMRestaurar.Image")));
            this.btnMRestaurar.Location = new System.Drawing.Point(487, 14);
            this.btnMRestaurar.Name = "btnMRestaurar";
            this.btnMRestaurar.Size = new System.Drawing.Size(23, 23);
            this.btnMRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMRestaurar.TabIndex = 0;
            this.btnMRestaurar.TabStop = false;
            this.btnMRestaurar.Visible = false;
            this.btnMRestaurar.Click += new System.EventHandler(this.btnMRestaurar_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnSlide.Image")));
            this.btnSlide.Location = new System.Drawing.Point(6, 9);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // btnMMaximizar
            // 
            this.btnMMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMMaximizar.Image")));
            this.btnMMaximizar.Location = new System.Drawing.Point(487, 12);
            this.btnMMaximizar.Name = "btnMMaximizar";
            this.btnMMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMMaximizar.TabIndex = 3;
            this.btnMMaximizar.TabStop = false;
            this.btnMMaximizar.Click += new System.EventHandler(this.btnMMaximizar_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "REGISTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMYIMCLOOD
            // 
            this.labelMYIMCLOOD.AutoSize = true;
            this.labelMYIMCLOOD.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMYIMCLOOD.ForeColor = System.Drawing.Color.DimGray;
            this.labelMYIMCLOOD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMYIMCLOOD.Location = new System.Drawing.Point(52, 9);
            this.labelMYIMCLOOD.Name = "labelMYIMCLOOD";
            this.labelMYIMCLOOD.Size = new System.Drawing.Size(178, 37);
            this.labelMYIMCLOOD.TabIndex = 1;
            this.labelMYIMCLOOD.Text = "YIMCLOOD";
            this.labelMYIMCLOOD.Click += new System.EventHandler(this.labelMYIMCLOOD_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(550, 400);
            this.panelContenedor.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "CONSULTAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-3, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 45);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuVertical.ResumeLayout(false);
            this.menuVertical.PerformLayout();
            this.panelBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.PictureBox btnMRestaurar;
        private System.Windows.Forms.PictureBox btnMMinimizar;
        private System.Windows.Forms.PictureBox btnMCerrar;
        private System.Windows.Forms.PictureBox btnMMaximizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMYIMCLOOD;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}