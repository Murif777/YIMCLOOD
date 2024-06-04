namespace Presentacion
{
    partial class MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.Agregarcontenedor = new System.Windows.Forms.Panel();
            this.agregarmembresia = new System.Windows.Forms.Button();
            this.btnAEntrenador = new System.Windows.Forms.Button();
            this.menuanimacion = new System.Windows.Forms.Button();
            this.AgregarUsuario = new System.Windows.Forms.Button();
            this.BntAgregarporducto = new System.Windows.Forms.Button();
            this.ConsultarContenedor = new System.Windows.Forms.Panel();
            this.bntconsultar = new System.Windows.Forms.Button();
            this.btnconsultarentrenador = new System.Windows.Forms.Button();
            this.btn_ConsultarUsuario = new System.Windows.Forms.Button();
            this.btnconsultarfacturas = new System.Windows.Forms.Button();
            this.bnt_ConsultarProducto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.deslizar = new System.Windows.Forms.PictureBox();
            this.panelsuperior = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuTransicion = new System.Windows.Forms.Timer(this.components);
            this.sliderbartransicion = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.consultarTransicion = new System.Windows.Forms.Timer(this.components);
            this.MenuVertical.SuspendLayout();
            this.Agregarcontenedor.SuspendLayout();
            this.ConsultarContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deslizar)).BeginInit();
            this.panelsuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(97)))));
            this.MenuVertical.Controls.Add(this.Agregarcontenedor);
            this.MenuVertical.Controls.Add(this.ConsultarContenedor);
            this.MenuVertical.Controls.Add(this.btnSalir);
            this.MenuVertical.Controls.Add(this.deslizar);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(2);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(300, 718);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // Agregarcontenedor
            // 
            this.Agregarcontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(97)))));
            this.Agregarcontenedor.Controls.Add(this.agregarmembresia);
            this.Agregarcontenedor.Controls.Add(this.btnAEntrenador);
            this.Agregarcontenedor.Controls.Add(this.menuanimacion);
            this.Agregarcontenedor.Controls.Add(this.AgregarUsuario);
            this.Agregarcontenedor.Controls.Add(this.BntAgregarporducto);
            this.Agregarcontenedor.Location = new System.Drawing.Point(1, 176);
            this.Agregarcontenedor.Margin = new System.Windows.Forms.Padding(2);
            this.Agregarcontenedor.Name = "Agregarcontenedor";
            this.Agregarcontenedor.Size = new System.Drawing.Size(299, 47);
            this.Agregarcontenedor.TabIndex = 1;
            // 
            // agregarmembresia
            // 
            this.agregarmembresia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(149)))));
            this.agregarmembresia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarmembresia.FlatAppearance.BorderSize = 0;
            this.agregarmembresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarmembresia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.agregarmembresia.ForeColor = System.Drawing.Color.Black;
            this.agregarmembresia.Image = ((System.Drawing.Image)(resources.GetObject("agregarmembresia.Image")));
            this.agregarmembresia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarmembresia.Location = new System.Drawing.Point(1, 188);
            this.agregarmembresia.Margin = new System.Windows.Forms.Padding(2);
            this.agregarmembresia.Name = "agregarmembresia";
            this.agregarmembresia.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.agregarmembresia.Size = new System.Drawing.Size(299, 47);
            this.agregarmembresia.TabIndex = 9;
            this.agregarmembresia.Text = "AGREGAR MEMBRESIA";
            this.agregarmembresia.UseVisualStyleBackColor = false;
            this.agregarmembresia.Click += new System.EventHandler(this.agregarmembresia_Click);
            // 
            // btnAEntrenador
            // 
            this.btnAEntrenador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(149)))));
            this.btnAEntrenador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAEntrenador.FlatAppearance.BorderSize = 0;
            this.btnAEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAEntrenador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAEntrenador.ForeColor = System.Drawing.Color.Black;
            this.btnAEntrenador.Image = ((System.Drawing.Image)(resources.GetObject("btnAEntrenador.Image")));
            this.btnAEntrenador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAEntrenador.Location = new System.Drawing.Point(0, 141);
            this.btnAEntrenador.Margin = new System.Windows.Forms.Padding(2);
            this.btnAEntrenador.Name = "btnAEntrenador";
            this.btnAEntrenador.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAEntrenador.Size = new System.Drawing.Size(299, 47);
            this.btnAEntrenador.TabIndex = 8;
            this.btnAEntrenador.Text = "AGREGAR ENTRENADOR";
            this.btnAEntrenador.UseVisualStyleBackColor = false;
            this.btnAEntrenador.Click += new System.EventHandler(this.btnAEntrenador_Click);
            // 
            // menuanimacion
            // 
            this.menuanimacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuanimacion.FlatAppearance.BorderSize = 0;
            this.menuanimacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuanimacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuanimacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuanimacion.Image = ((System.Drawing.Image)(resources.GetObject("menuanimacion.Image")));
            this.menuanimacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuanimacion.Location = new System.Drawing.Point(2, 0);
            this.menuanimacion.Margin = new System.Windows.Forms.Padding(2);
            this.menuanimacion.Name = "menuanimacion";
            this.menuanimacion.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.menuanimacion.Size = new System.Drawing.Size(299, 47);
            this.menuanimacion.TabIndex = 0;
            this.menuanimacion.Text = "AGREGAR";
            this.menuanimacion.UseVisualStyleBackColor = true;
            this.menuanimacion.Click += new System.EventHandler(this.menuanimacion_Click);
            // 
            // AgregarUsuario
            // 
            this.AgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(149)))));
            this.AgregarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarUsuario.FlatAppearance.BorderSize = 0;
            this.AgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.AgregarUsuario.ForeColor = System.Drawing.Color.Black;
            this.AgregarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("AgregarUsuario.Image")));
            this.AgregarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarUsuario.Location = new System.Drawing.Point(0, 50);
            this.AgregarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarUsuario.Name = "AgregarUsuario";
            this.AgregarUsuario.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.AgregarUsuario.Size = new System.Drawing.Size(299, 47);
            this.AgregarUsuario.TabIndex = 4;
            this.AgregarUsuario.Text = "AGREGAR USUARIO";
            this.AgregarUsuario.UseVisualStyleBackColor = false;
            this.AgregarUsuario.Click += new System.EventHandler(this.AgregarUsuario_Click);
            // 
            // BntAgregarporducto
            // 
            this.BntAgregarporducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(149)))));
            this.BntAgregarporducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BntAgregarporducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BntAgregarporducto.FlatAppearance.BorderSize = 0;
            this.BntAgregarporducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntAgregarporducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BntAgregarporducto.ForeColor = System.Drawing.Color.Black;
            this.BntAgregarporducto.Image = ((System.Drawing.Image)(resources.GetObject("BntAgregarporducto.Image")));
            this.BntAgregarporducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BntAgregarporducto.Location = new System.Drawing.Point(0, 95);
            this.BntAgregarporducto.Margin = new System.Windows.Forms.Padding(2);
            this.BntAgregarporducto.Name = "BntAgregarporducto";
            this.BntAgregarporducto.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BntAgregarporducto.Size = new System.Drawing.Size(299, 47);
            this.BntAgregarporducto.TabIndex = 6;
            this.BntAgregarporducto.Text = "AGREGAR PRODUCTO";
            this.BntAgregarporducto.UseVisualStyleBackColor = false;
            this.BntAgregarporducto.Click += new System.EventHandler(this.BntAgregarporducto_Click);
            // 
            // ConsultarContenedor
            // 
            this.ConsultarContenedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConsultarContenedor.Controls.Add(this.bntconsultar);
            this.ConsultarContenedor.Controls.Add(this.btnconsultarentrenador);
            this.ConsultarContenedor.Controls.Add(this.btn_ConsultarUsuario);
            this.ConsultarContenedor.Controls.Add(this.btnconsultarfacturas);
            this.ConsultarContenedor.Controls.Add(this.bnt_ConsultarProducto);
            this.ConsultarContenedor.Location = new System.Drawing.Point(1, 253);
            this.ConsultarContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultarContenedor.Name = "ConsultarContenedor";
            this.ConsultarContenedor.Size = new System.Drawing.Size(299, 49);
            this.ConsultarContenedor.TabIndex = 11;
            this.ConsultarContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.ConsultarContenedor_Paint);
            // 
            // bntconsultar
            // 
            this.bntconsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(97)))));
            this.bntconsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntconsultar.FlatAppearance.BorderSize = 0;
            this.bntconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntconsultar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bntconsultar.ForeColor = System.Drawing.Color.Transparent;
            this.bntconsultar.Image = ((System.Drawing.Image)(resources.GetObject("bntconsultar.Image")));
            this.bntconsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntconsultar.Location = new System.Drawing.Point(-2, 1);
            this.bntconsultar.Margin = new System.Windows.Forms.Padding(2);
            this.bntconsultar.Name = "bntconsultar";
            this.bntconsultar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bntconsultar.Size = new System.Drawing.Size(299, 49);
            this.bntconsultar.TabIndex = 8;
            this.bntconsultar.Text = "CONSULTAR";
            this.bntconsultar.UseVisualStyleBackColor = false;
            this.bntconsultar.Click += new System.EventHandler(this.bntconsultar_Click);
            // 
            // btnconsultarentrenador
            // 
            this.btnconsultarentrenador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(149)))));
            this.btnconsultarentrenador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconsultarentrenador.FlatAppearance.BorderSize = 0;
            this.btnconsultarentrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultarentrenador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultarentrenador.ForeColor = System.Drawing.Color.Black;
            this.btnconsultarentrenador.Image = ((System.Drawing.Image)(resources.GetObject("btnconsultarentrenador.Image")));
            this.btnconsultarentrenador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconsultarentrenador.Location = new System.Drawing.Point(1, 191);
            this.btnconsultarentrenador.Margin = new System.Windows.Forms.Padding(2);
            this.btnconsultarentrenador.Name = "btnconsultarentrenador";
            this.btnconsultarentrenador.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnconsultarentrenador.Size = new System.Drawing.Size(299, 47);
            this.btnconsultarentrenador.TabIndex = 10;
            this.btnconsultarentrenador.Text = "    CONSULTAR ENTRENADOR";
            this.btnconsultarentrenador.UseVisualStyleBackColor = false;
            this.btnconsultarentrenador.Click += new System.EventHandler(this.btnconsultarentrenador_Click);
            // 
            // btn_ConsultarUsuario
            // 
            this.btn_ConsultarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(149)))));
            this.btn_ConsultarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConsultarUsuario.FlatAppearance.BorderSize = 0;
            this.btn_ConsultarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConsultarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConsultarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btn_ConsultarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_ConsultarUsuario.Image")));
            this.btn_ConsultarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ConsultarUsuario.Location = new System.Drawing.Point(1, 50);
            this.btn_ConsultarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ConsultarUsuario.Name = "btn_ConsultarUsuario";
            this.btn_ConsultarUsuario.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_ConsultarUsuario.Size = new System.Drawing.Size(299, 47);
            this.btn_ConsultarUsuario.TabIndex = 5;
            this.btn_ConsultarUsuario.Text = "CONSULTAR MIEMBRO";
            this.btn_ConsultarUsuario.UseVisualStyleBackColor = false;
            this.btn_ConsultarUsuario.Click += new System.EventHandler(this.btn_ConsultarUsuario_Click);
            // 
            // btnconsultarfacturas
            // 
            this.btnconsultarfacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(149)))));
            this.btnconsultarfacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconsultarfacturas.FlatAppearance.BorderSize = 0;
            this.btnconsultarfacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultarfacturas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultarfacturas.ForeColor = System.Drawing.Color.Black;
            this.btnconsultarfacturas.Image = ((System.Drawing.Image)(resources.GetObject("btnconsultarfacturas.Image")));
            this.btnconsultarfacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconsultarfacturas.Location = new System.Drawing.Point(1, 144);
            this.btnconsultarfacturas.Margin = new System.Windows.Forms.Padding(2);
            this.btnconsultarfacturas.Name = "btnconsultarfacturas";
            this.btnconsultarfacturas.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnconsultarfacturas.Size = new System.Drawing.Size(299, 47);
            this.btnconsultarfacturas.TabIndex = 9;
            this.btnconsultarfacturas.Text = "CONSULTAR FACTURAS";
            this.btnconsultarfacturas.UseVisualStyleBackColor = false;
            this.btnconsultarfacturas.Click += new System.EventHandler(this.btnconsultarfacturas_Click);
            // 
            // bnt_ConsultarProducto
            // 
            this.bnt_ConsultarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(149)))));
            this.bnt_ConsultarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_ConsultarProducto.FlatAppearance.BorderSize = 0;
            this.bnt_ConsultarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_ConsultarProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_ConsultarProducto.ForeColor = System.Drawing.Color.Black;
            this.bnt_ConsultarProducto.Image = ((System.Drawing.Image)(resources.GetObject("bnt_ConsultarProducto.Image")));
            this.bnt_ConsultarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_ConsultarProducto.Location = new System.Drawing.Point(1, 97);
            this.bnt_ConsultarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_ConsultarProducto.Name = "bnt_ConsultarProducto";
            this.bnt_ConsultarProducto.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.bnt_ConsultarProducto.Size = new System.Drawing.Size(299, 47);
            this.bnt_ConsultarProducto.TabIndex = 7;
            this.bnt_ConsultarProducto.Text = "CONSULTAR PRODUCTO";
            this.bnt_ConsultarProducto.UseVisualStyleBackColor = false;
            this.bnt_ConsultarProducto.Click += new System.EventHandler(this.bnt_ConsultarProducto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(97)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(3, 669);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(38, 47);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // deslizar
            // 
            this.deslizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deslizar.Image = ((System.Drawing.Image)(resources.GetObject("deslizar.Image")));
            this.deslizar.Location = new System.Drawing.Point(5, 6);
            this.deslizar.Margin = new System.Windows.Forms.Padding(2);
            this.deslizar.Name = "deslizar";
            this.deslizar.Size = new System.Drawing.Size(58, 50);
            this.deslizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deslizar.TabIndex = 3;
            this.deslizar.TabStop = false;
            this.deslizar.Click += new System.EventHandler(this.deslizar_Click);
            // 
            // panelsuperior
            // 
            this.panelsuperior.BackColor = System.Drawing.Color.LightBlue;
            this.panelsuperior.Controls.Add(this.pictureBox3);
            this.panelsuperior.Controls.Add(this.Cerrar);
            this.panelsuperior.Controls.Add(this.Minimizar);
            this.panelsuperior.Controls.Add(this.label1);
            this.panelsuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsuperior.Location = new System.Drawing.Point(300, 0);
            this.panelsuperior.Margin = new System.Windows.Forms.Padding(2);
            this.panelsuperior.Name = "panelsuperior";
            this.panelsuperior.Size = new System.Drawing.Size(867, 55);
            this.panelsuperior.TabIndex = 1;
            this.panelsuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.panelsuperior_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(813, 6);
            this.Cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(53, 41);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 2;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(765, 6);
            this.Minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(44, 42);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 2;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(83, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "YIMCLOOD";
            // 
            // menuTransicion
            // 
            this.menuTransicion.Interval = 10;
            this.menuTransicion.Tick += new System.EventHandler(this.menuTransicion_Tick);
            // 
            // sliderbartransicion
            // 
            this.sliderbartransicion.Interval = 10;
            this.sliderbartransicion.Tick += new System.EventHandler(this.sliderbartransicion_Tick);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(300, 55);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(867, 663);
            this.panelContenedor.TabIndex = 2;
            // 
            // consultarTransicion
            // 
            this.consultarTransicion.Interval = 10;
            this.consultarTransicion.Tick += new System.EventHandler(this.consultarTransicion_Tick_1);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 718);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelsuperior);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPrincipal";
            this.Opacity = 0.95D;
            this.Text = "FormMenuR";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuPrincipal_MouseDown);
            this.MenuVertical.ResumeLayout(false);
            this.Agregarcontenedor.ResumeLayout(false);
            this.ConsultarContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deslizar)).EndInit();
            this.panelsuperior.ResumeLayout(false);
            this.panelsuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panelsuperior;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.Button btn_ConsultarUsuario;
        private System.Windows.Forms.Button BntAgregarporducto;
        private System.Windows.Forms.Button bnt_ConsultarProducto;
        private System.Windows.Forms.Button btnAEntrenador;
        private System.Windows.Forms.Timer menuTransicion;
        private System.Windows.Forms.Timer sliderbartransicion;
        private System.Windows.Forms.PictureBox deslizar;
        protected internal System.Windows.Forms.Button AgregarUsuario;
        private System.Windows.Forms.Button menuanimacion;
        private System.Windows.Forms.Panel Agregarcontenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button bntconsultar;
        private System.Windows.Forms.Panel ConsultarContenedor;
        private System.Windows.Forms.Button btnconsultarentrenador;
        private System.Windows.Forms.Button btnconsultarfacturas;
        private System.Windows.Forms.Timer consultarTransicion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button agregarmembresia;
    }
}