﻿namespace Grupo1.Properties
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radCurvas = new System.Windows.Forms.RadioButton();
            this.radPlanas = new System.Windows.Forms.RadioButton();
            this.radPiluso = new System.Windows.Forms.RadioButton();
            this.radHombre = new System.Windows.Forms.RadioButton();
            this.radMujer = new System.Windows.Forms.RadioButton();
            this.dgIndumentaria = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbGorras = new System.Windows.Forms.GroupBox();
            this.radSinFg = new System.Windows.Forms.RadioButton();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.radSinFz = new System.Windows.Forms.RadioButton();
            this.radMinimal = new System.Windows.Forms.RadioButton();
            this.radRunning = new System.Windows.Forms.RadioButton();
            this.radTenis = new System.Windows.Forms.RadioButton();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_tipo = new System.Windows.Forms.TextBox();
            this.textBox_detalle = new System.Windows.Forms.TextBox();
            this.textBox_precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.txtboxTipo = new System.Windows.Forms.TextBox();
            this.txtboxPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBorrar = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.labelImagen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgIndumentaria)).BeginInit();
            this.gbGorras.SuspendLayout();
            this.gbGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ver lista de:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(8, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 108);
            this.button2.TabIndex = 1;
            this.button2.Text = "Zapatillas";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(8, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 102);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gorras";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radCurvas
            // 
            this.radCurvas.AutoSize = true;
            this.radCurvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCurvas.Location = new System.Drawing.Point(5, 62);
            this.radCurvas.Name = "radCurvas";
            this.radCurvas.Size = new System.Drawing.Size(114, 33);
            this.radCurvas.TabIndex = 3;
            this.radCurvas.TabStop = true;
            this.radCurvas.Text = "Curvas";
            this.radCurvas.UseVisualStyleBackColor = true;
            this.radCurvas.CheckedChanged += new System.EventHandler(this.radCurvas_CheckedChanged);
            // 
            // radPlanas
            // 
            this.radPlanas.AutoSize = true;
            this.radPlanas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPlanas.Location = new System.Drawing.Point(6, 101);
            this.radPlanas.Name = "radPlanas";
            this.radPlanas.Size = new System.Drawing.Size(113, 33);
            this.radPlanas.TabIndex = 4;
            this.radPlanas.TabStop = true;
            this.radPlanas.Text = "Planas";
            this.radPlanas.UseVisualStyleBackColor = true;
            // 
            // radPiluso
            // 
            this.radPiluso.AutoSize = true;
            this.radPiluso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPiluso.Location = new System.Drawing.Point(6, 140);
            this.radPiluso.Name = "radPiluso";
            this.radPiluso.Size = new System.Drawing.Size(107, 33);
            this.radPiluso.TabIndex = 5;
            this.radPiluso.TabStop = true;
            this.radPiluso.Text = "Piluso";
            this.radPiluso.UseVisualStyleBackColor = true;
            // 
            // radHombre
            // 
            this.radHombre.AutoSize = true;
            this.radHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radHombre.Location = new System.Drawing.Point(6, 69);
            this.radHombre.Name = "radHombre";
            this.radHombre.Size = new System.Drawing.Size(127, 33);
            this.radHombre.TabIndex = 6;
            this.radHombre.TabStop = true;
            this.radHombre.Text = "Hombre";
            this.radHombre.UseVisualStyleBackColor = true;
            // 
            // radMujer
            // 
            this.radMujer.AutoSize = true;
            this.radMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMujer.Location = new System.Drawing.Point(6, 108);
            this.radMujer.Name = "radMujer";
            this.radMujer.Size = new System.Drawing.Size(100, 33);
            this.radMujer.TabIndex = 7;
            this.radMujer.TabStop = true;
            this.radMujer.Text = "Mujer";
            this.radMujer.UseVisualStyleBackColor = true;
            // 
            // dgIndumentaria
            // 
            this.dgIndumentaria.BackgroundColor = System.Drawing.Color.Gray;
            this.dgIndumentaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIndumentaria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colTipo,
            this.colDetalle,
            this.colPrecio,
            this.colImagen});
            this.dgIndumentaria.Location = new System.Drawing.Point(218, 61);
            this.dgIndumentaria.Name = "dgIndumentaria";
            this.dgIndumentaria.RowHeadersWidth = 51;
            this.dgIndumentaria.RowTemplate.Height = 24;
            this.dgIndumentaria.Size = new System.Drawing.Size(932, 723);
            this.dgIndumentaria.TabIndex = 8;
            this.dgIndumentaria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgIndumentaria_CellClick);
            this.dgIndumentaria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgIndumentaria_CellContentClick);
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 125;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.MinimumWidth = 6;
            this.colTipo.Name = "colTipo";
            this.colTipo.Width = 125;
            // 
            // colDetalle
            // 
            this.colDetalle.HeaderText = "Detalle";
            this.colDetalle.MinimumWidth = 6;
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.Width = 125;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Width = 125;
            // 
            // colImagen
            // 
            this.colImagen.HeaderText = "Imagen";
            this.colImagen.MinimumWidth = 6;
            this.colImagen.Name = "colImagen";
            this.colImagen.Width = 125;
            // 
            // gbGorras
            // 
            this.gbGorras.Controls.Add(this.radSinFg);
            this.gbGorras.Controls.Add(this.radCurvas);
            this.gbGorras.Controls.Add(this.radPlanas);
            this.gbGorras.Controls.Add(this.radPiluso);
            this.gbGorras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGorras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbGorras.Location = new System.Drawing.Point(12, 169);
            this.gbGorras.Name = "gbGorras";
            this.gbGorras.Size = new System.Drawing.Size(200, 218);
            this.gbGorras.TabIndex = 9;
            this.gbGorras.TabStop = false;
            this.gbGorras.Text = "Filtros para Gorras";
            this.gbGorras.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radSinFg
            // 
            this.radSinFg.AutoSize = true;
            this.radSinFg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSinFg.ForeColor = System.Drawing.Color.Red;
            this.radSinFg.Location = new System.Drawing.Point(6, 26);
            this.radSinFg.Name = "radSinFg";
            this.radSinFg.Size = new System.Drawing.Size(144, 33);
            this.radSinFg.TabIndex = 6;
            this.radSinFg.TabStop = true;
            this.radSinFg.Text = "Sin filtros";
            this.radSinFg.UseVisualStyleBackColor = true;
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.radSinFz);
            this.gbGenero.Controls.Add(this.radMinimal);
            this.gbGenero.Controls.Add(this.radRunning);
            this.gbGenero.Controls.Add(this.radHombre);
            this.gbGenero.Controls.Add(this.radTenis);
            this.gbGenero.Controls.Add(this.radMujer);
            this.gbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbGenero.Location = new System.Drawing.Point(12, 511);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(200, 270);
            this.gbGenero.TabIndex = 10;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Filtro para Zapatillas";
            // 
            // radSinFz
            // 
            this.radSinFz.AutoSize = true;
            this.radSinFz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSinFz.ForeColor = System.Drawing.Color.Red;
            this.radSinFz.Location = new System.Drawing.Point(6, 30);
            this.radSinFz.Name = "radSinFz";
            this.radSinFz.Size = new System.Drawing.Size(144, 33);
            this.radSinFz.TabIndex = 6;
            this.radSinFz.TabStop = true;
            this.radSinFz.Text = "Sin filtros";
            this.radSinFz.UseVisualStyleBackColor = true;
            // 
            // radMinimal
            // 
            this.radMinimal.AutoSize = true;
            this.radMinimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMinimal.Location = new System.Drawing.Point(6, 147);
            this.radMinimal.Name = "radMinimal";
            this.radMinimal.Size = new System.Drawing.Size(179, 33);
            this.radMinimal.TabIndex = 3;
            this.radMinimal.TabStop = true;
            this.radMinimal.Text = "Minimalistas";
            this.radMinimal.UseVisualStyleBackColor = true;
            // 
            // radRunning
            // 
            this.radRunning.AutoSize = true;
            this.radRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRunning.Location = new System.Drawing.Point(6, 186);
            this.radRunning.Name = "radRunning";
            this.radRunning.Size = new System.Drawing.Size(130, 33);
            this.radRunning.TabIndex = 4;
            this.radRunning.TabStop = true;
            this.radRunning.Text = "Running";
            this.radRunning.UseVisualStyleBackColor = true;
            // 
            // radTenis
            // 
            this.radTenis.AutoSize = true;
            this.radTenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenis.Location = new System.Drawing.Point(6, 225);
            this.radTenis.Name = "radTenis";
            this.radTenis.Size = new System.Drawing.Size(100, 33);
            this.radTenis.TabIndex = 5;
            this.radTenis.TabStop = true;
            this.radTenis.Text = "Tenis";
            this.radTenis.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gray;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(1156, 527);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(206, 69);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1176, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "Modificar:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(1162, 340);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(193, 22);
            this.textBox_nombre.TabIndex = 13;
            this.textBox_nombre.TextChanged += new System.EventHandler(this.textBox_nombre_TextChanged);
            // 
            // textBox_tipo
            // 
            this.textBox_tipo.Location = new System.Drawing.Point(1162, 393);
            this.textBox_tipo.Name = "textBox_tipo";
            this.textBox_tipo.Size = new System.Drawing.Size(193, 22);
            this.textBox_tipo.TabIndex = 14;
            this.textBox_tipo.TextChanged += new System.EventHandler(this.textBox_tipo_TextChanged);
            // 
            // textBox_detalle
            // 
            this.textBox_detalle.Location = new System.Drawing.Point(1164, 446);
            this.textBox_detalle.Name = "textBox_detalle";
            this.textBox_detalle.Size = new System.Drawing.Size(193, 22);
            this.textBox_detalle.TabIndex = 15;
            // 
            // textBox_precio
            // 
            this.textBox_precio.Location = new System.Drawing.Point(1165, 499);
            this.textBox_precio.Name = "textBox_precio";
            this.textBox_precio.Size = new System.Drawing.Size(193, 22);
            this.textBox_precio.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(281, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Buscar por:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1157, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1157, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1157, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Detalle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(1160, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Precio";
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.Location = new System.Drawing.Point(448, 33);
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(114, 22);
            this.txtboxNombre.TabIndex = 22;
            this.txtboxNombre.TextChanged += new System.EventHandler(this.txtboxNombre_TextChanged);
            // 
            // txtboxTipo
            // 
            this.txtboxTipo.Location = new System.Drawing.Point(616, 33);
            this.txtboxTipo.Name = "txtboxTipo";
            this.txtboxTipo.Size = new System.Drawing.Size(119, 22);
            this.txtboxTipo.TabIndex = 23;
            // 
            // txtboxPrecio
            // 
            this.txtboxPrecio.Location = new System.Drawing.Point(791, 33);
            this.txtboxPrecio.Name = "txtboxPrecio";
            this.txtboxPrecio.Size = new System.Drawing.Size(116, 22);
            this.txtboxPrecio.TabIndex = 24;
            this.txtboxPrecio.TextChanged += new System.EventHandler(this.txtboxPrecio_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(462, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(646, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tipo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(812, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "Precio";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gray;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(945, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 45);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(1198, 611);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 38);
            this.label11.TabIndex = 29;
            this.label11.Text = "Borrar:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(1158, 655);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 31;
            this.label12.Text = "Nombre";
            // 
            // txtBorrar
            // 
            this.txtBorrar.Location = new System.Drawing.Point(1163, 683);
            this.txtBorrar.Name = "txtBorrar";
            this.txtBorrar.Size = new System.Drawing.Size(193, 22);
            this.txtBorrar.TabIndex = 30;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(1156, 715);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 69);
            this.button3.TabIndex = 32;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Location = new System.Drawing.Point(1165, 53);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(182, 178);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 34;
            this.pictureBoxImagen.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(1182, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 38);
            this.label13.TabIndex = 35;
            this.label13.Text = "Imagen:";
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImagen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelImagen.Location = new System.Drawing.Point(1160, 235);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(0, 29);
            this.labelImagen.TabIndex = 36;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1370, 796);
            this.Controls.Add(this.labelImagen);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBorrar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtboxPrecio);
            this.Controls.Add(this.txtboxTipo);
            this.Controls.Add(this.txtboxNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_precio);
            this.Controls.Add(this.textBox_detalle);
            this.Controls.Add(this.textBox_tipo);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.gbGorras);
            this.Controls.Add(this.dgIndumentaria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Lista de indumentaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgIndumentaria)).EndInit();
            this.gbGorras.ResumeLayout(false);
            this.gbGorras.PerformLayout();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radCurvas;
        private System.Windows.Forms.RadioButton radPlanas;
        private System.Windows.Forms.RadioButton radPiluso;
        private System.Windows.Forms.RadioButton radHombre;
        private System.Windows.Forms.RadioButton radMujer;
        private System.Windows.Forms.DataGridView dgIndumentaria;
        private System.Windows.Forms.GroupBox gbGorras;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.RadioButton radMinimal;
        private System.Windows.Forms.RadioButton radRunning;
        private System.Windows.Forms.RadioButton radTenis;
        private System.Windows.Forms.RadioButton radSinFg;
        private System.Windows.Forms.RadioButton radSinFz;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_tipo;
        private System.Windows.Forms.TextBox textBox_detalle;
        private System.Windows.Forms.TextBox textBox_precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.TextBox txtboxTipo;
        private System.Windows.Forms.TextBox txtboxPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBorrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImagen;
        private System.Windows.Forms.Label labelImagen;
    }
}