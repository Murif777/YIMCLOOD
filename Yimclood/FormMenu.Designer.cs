using System;
using System.Windows.Forms;

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
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.labelMYIMCLOOD = new System.Windows.Forms.Label();
            this.butonregistrar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnMMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMCerrar = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.menuVertical.Controls.Add(this.buttonConsultar);
            this.menuVertical.Controls.Add(this.labelMYIMCLOOD);
            this.menuVertical.Controls.Add(this.butonregistrar);
            this.menuVertical.Controls.Add(this.pictureBox3);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(276, 647);
            this.menuVertical.TabIndex = 0;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.FlatAppearance.BorderSize = 0;
            this.buttonConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultar.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.ForeColor = System.Drawing.Color.White;
            this.buttonConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConsultar.Location = new System.Drawing.Point(12, 291);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(244, 60);
            this.buttonConsultar.TabIndex = 4;
            this.buttonConsultar.Text = "CONSULTAR";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            // 
            // labelMYIMCLOOD
            // 
            this.labelMYIMCLOOD.AutoSize = true;
            this.labelMYIMCLOOD.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMYIMCLOOD.ForeColor = System.Drawing.Color.DimGray;
            this.labelMYIMCLOOD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMYIMCLOOD.Location = new System.Drawing.Point(69, 9);
            this.labelMYIMCLOOD.Name = "labelMYIMCLOOD";
            this.labelMYIMCLOOD.Size = new System.Drawing.Size(178, 37);
            this.labelMYIMCLOOD.TabIndex = 1;
            this.labelMYIMCLOOD.Text = "YIMCLOOD";
            // 
            // butonregistrar
            // 
            this.butonregistrar.FlatAppearance.BorderSize = 0;
            this.butonregistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.butonregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonregistrar.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonregistrar.ForeColor = System.Drawing.Color.White;
            this.butonregistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butonregistrar.Location = new System.Drawing.Point(12, 183);
            this.butonregistrar.Name = "butonregistrar";
            this.butonregistrar.Size = new System.Drawing.Size(244, 62);
            this.butonregistrar.TabIndex = 0;
            this.butonregistrar.Text = "REGISTRAR";
            this.butonregistrar.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelBarra.Controls.Add(this.btnMMinimizar);
            this.panelBarra.Controls.Add(this.btnMCerrar);
            this.panelBarra.Controls.Add(this.btnSlide);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(276, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(878, 50);
            this.panelBarra.TabIndex = 1;
            // 
            // btnMMinimizar
            // 
            this.btnMMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMMinimizar.Image")));
            this.btnMMinimizar.Location = new System.Drawing.Point(815, 12);
            this.btnMMinimizar.Name = "btnMMinimizar";
            this.btnMMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMMinimizar.TabIndex = 1;
            this.btnMMinimizar.TabStop = false;
            this.btnMMinimizar.Click += new System.EventHandler(this.btnMMinimizar_Click_1);
            // 
            // btnMCerrar
            // 
            this.btnMCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnMCerrar.Image")));
            this.btnMCerrar.Location = new System.Drawing.Point(846, 12);
            this.btnMCerrar.Name = "btnMCerrar";
            this.btnMCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnMCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMCerrar.TabIndex = 2;
            this.btnMCerrar.TabStop = false;
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnSlide.Image")));
            this.btnSlide.Location = new System.Drawing.Point(23, 9);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(276, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(878, 597);
            this.panelContenedor.TabIndex = 2;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 647);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuVertical.ResumeLayout(false);
            this.menuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.ResumeLayout(false);

        }

        private void menuVertical_MouseDown_1(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.PictureBox btnMMinimizar;
        private System.Windows.Forms.PictureBox btnMCerrar;
        private System.Windows.Forms.Button butonregistrar;
        private System.Windows.Forms.Label labelMYIMCLOOD;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Panel panelContenedor;
    }
}