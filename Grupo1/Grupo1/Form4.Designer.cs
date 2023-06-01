namespace Grupo1.Properties
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
            ((System.ComponentModel.ISupportInitialize)(this.dgIndumentaria)).BeginInit();
            this.gbGorras.SuspendLayout();
            this.gbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ver lista de:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 112);
            this.button2.TabIndex = 1;
            this.button2.Text = "Zapatillas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 112);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gorras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radCurvas
            // 
            this.radCurvas.AutoSize = true;
            this.radCurvas.Location = new System.Drawing.Point(3, 44);
            this.radCurvas.Name = "radCurvas";
            this.radCurvas.Size = new System.Drawing.Size(70, 20);
            this.radCurvas.TabIndex = 3;
            this.radCurvas.TabStop = true;
            this.radCurvas.Text = "Curvas";
            this.radCurvas.UseVisualStyleBackColor = true;
            this.radCurvas.CheckedChanged += new System.EventHandler(this.radCurvas_CheckedChanged);
            // 
            // radPlanas
            // 
            this.radPlanas.AutoSize = true;
            this.radPlanas.Location = new System.Drawing.Point(3, 70);
            this.radPlanas.Name = "radPlanas";
            this.radPlanas.Size = new System.Drawing.Size(70, 20);
            this.radPlanas.TabIndex = 4;
            this.radPlanas.TabStop = true;
            this.radPlanas.Text = "Planas";
            this.radPlanas.UseVisualStyleBackColor = true;
            // 
            // radPiluso
            // 
            this.radPiluso.AutoSize = true;
            this.radPiluso.Location = new System.Drawing.Point(3, 96);
            this.radPiluso.Name = "radPiluso";
            this.radPiluso.Size = new System.Drawing.Size(65, 20);
            this.radPiluso.TabIndex = 5;
            this.radPiluso.TabStop = true;
            this.radPiluso.Text = "Piluso";
            this.radPiluso.UseVisualStyleBackColor = true;
            // 
            // radHombre
            // 
            this.radHombre.AutoSize = true;
            this.radHombre.Location = new System.Drawing.Point(6, 52);
            this.radHombre.Name = "radHombre";
            this.radHombre.Size = new System.Drawing.Size(77, 20);
            this.radHombre.TabIndex = 6;
            this.radHombre.TabStop = true;
            this.radHombre.Text = "Hombre";
            this.radHombre.UseVisualStyleBackColor = true;
            // 
            // radMujer
            // 
            this.radMujer.AutoSize = true;
            this.radMujer.Location = new System.Drawing.Point(6, 78);
            this.radMujer.Name = "radMujer";
            this.radMujer.Size = new System.Drawing.Size(61, 20);
            this.radMujer.TabIndex = 7;
            this.radMujer.TabStop = true;
            this.radMujer.Text = "Mujer";
            this.radMujer.UseVisualStyleBackColor = true;
            // 
            // dgIndumentaria
            // 
            this.dgIndumentaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIndumentaria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colTipo,
            this.colDetalle,
            this.colPrecio});
            this.dgIndumentaria.Location = new System.Drawing.Point(218, 61);
            this.dgIndumentaria.Name = "dgIndumentaria";
            this.dgIndumentaria.RowHeadersWidth = 51;
            this.dgIndumentaria.RowTemplate.Height = 24;
            this.dgIndumentaria.Size = new System.Drawing.Size(781, 551);
            this.dgIndumentaria.TabIndex = 8;
            this.dgIndumentaria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgIndumentaria_CellClick);
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
            // gbGorras
            // 
            this.gbGorras.Controls.Add(this.radSinFg);
            this.gbGorras.Controls.Add(this.radCurvas);
            this.gbGorras.Controls.Add(this.radPlanas);
            this.gbGorras.Controls.Add(this.radPiluso);
            this.gbGorras.Location = new System.Drawing.Point(12, 179);
            this.gbGorras.Name = "gbGorras";
            this.gbGorras.Size = new System.Drawing.Size(200, 121);
            this.gbGorras.TabIndex = 9;
            this.gbGorras.TabStop = false;
            this.gbGorras.Text = "Filtros para Gorras";
            this.gbGorras.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radSinFg
            // 
            this.radSinFg.AutoSize = true;
            this.radSinFg.Location = new System.Drawing.Point(3, 21);
            this.radSinFg.Name = "radSinFg";
            this.radSinFg.Size = new System.Drawing.Size(81, 20);
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
            this.gbGenero.Location = new System.Drawing.Point(12, 424);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(200, 188);
            this.gbGenero.TabIndex = 10;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Filtro para Zapatillas";
            // 
            // radSinFz
            // 
            this.radSinFz.AutoSize = true;
            this.radSinFz.Location = new System.Drawing.Point(6, 26);
            this.radSinFz.Name = "radSinFz";
            this.radSinFz.Size = new System.Drawing.Size(81, 20);
            this.radSinFz.TabIndex = 6;
            this.radSinFz.TabStop = true;
            this.radSinFz.Text = "Sin filtros";
            this.radSinFz.UseVisualStyleBackColor = true;
            // 
            // radMinimal
            // 
            this.radMinimal.AutoSize = true;
            this.radMinimal.Location = new System.Drawing.Point(6, 104);
            this.radMinimal.Name = "radMinimal";
            this.radMinimal.Size = new System.Drawing.Size(102, 20);
            this.radMinimal.TabIndex = 3;
            this.radMinimal.TabStop = true;
            this.radMinimal.Text = "Minimalistas";
            this.radMinimal.UseVisualStyleBackColor = true;
            // 
            // radRunning
            // 
            this.radRunning.AutoSize = true;
            this.radRunning.Location = new System.Drawing.Point(6, 130);
            this.radRunning.Name = "radRunning";
            this.radRunning.Size = new System.Drawing.Size(77, 20);
            this.radRunning.TabIndex = 4;
            this.radRunning.TabStop = true;
            this.radRunning.Text = "Running";
            this.radRunning.UseVisualStyleBackColor = true;
            // 
            // radTenis
            // 
            this.radTenis.AutoSize = true;
            this.radTenis.Location = new System.Drawing.Point(6, 156);
            this.radTenis.Name = "radTenis";
            this.radTenis.Size = new System.Drawing.Size(62, 20);
            this.radTenis.TabIndex = 5;
            this.radTenis.TabStop = true;
            this.radTenis.Text = "Tenis";
            this.radTenis.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1031, 336);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 34);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1028, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Modificar:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(1031, 117);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(193, 22);
            this.textBox_nombre.TabIndex = 13;
            this.textBox_nombre.TextChanged += new System.EventHandler(this.textBox_nombre_TextChanged);
            // 
            // textBox_tipo
            // 
            this.textBox_tipo.Location = new System.Drawing.Point(1031, 170);
            this.textBox_tipo.Name = "textBox_tipo";
            this.textBox_tipo.Size = new System.Drawing.Size(193, 22);
            this.textBox_tipo.TabIndex = 14;
            this.textBox_tipo.TextChanged += new System.EventHandler(this.textBox_tipo_TextChanged);
            // 
            // textBox_detalle
            // 
            this.textBox_detalle.Location = new System.Drawing.Point(1031, 223);
            this.textBox_detalle.Name = "textBox_detalle";
            this.textBox_detalle.Size = new System.Drawing.Size(193, 22);
            this.textBox_detalle.TabIndex = 15;
            // 
            // textBox_precio
            // 
            this.textBox_precio.Location = new System.Drawing.Point(1031, 278);
            this.textBox_precio.Name = "textBox_precio";
            this.textBox_precio.Size = new System.Drawing.Size(193, 22);
            this.textBox_precio.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Buscar por:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1035, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1035, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1035, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Detalle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1035, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Precio";
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.Location = new System.Drawing.Point(386, 21);
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(100, 22);
            this.txtboxNombre.TabIndex = 22;
            this.txtboxNombre.TextChanged += new System.EventHandler(this.txtboxNombre_TextChanged);
            // 
            // txtboxTipo
            // 
            this.txtboxTipo.Location = new System.Drawing.Point(564, 21);
            this.txtboxTipo.Name = "txtboxTipo";
            this.txtboxTipo.Size = new System.Drawing.Size(100, 22);
            this.txtboxTipo.TabIndex = 23;
            // 
            // txtboxPrecio
            // 
            this.txtboxPrecio.Location = new System.Drawing.Point(754, 21);
            this.txtboxPrecio.Name = "txtboxPrecio";
            this.txtboxPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtboxPrecio.TabIndex = 24;
            this.txtboxPrecio.TextChanged += new System.EventHandler(this.txtboxPrecio_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(523, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tipo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(702, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Precio";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(895, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 35);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 641);
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
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgIndumentaria)).EndInit();
            this.gbGorras.ResumeLayout(false);
            this.gbGorras.PerformLayout();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
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
    }
}