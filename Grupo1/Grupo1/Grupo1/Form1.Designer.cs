namespace Grupo1
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.boton_crear = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.txt_stockid = new System.Windows.Forms.TextBox();
            this.generoBox = new System.Windows.Forms.ComboBox();
            this.talleBox = new System.Windows.Forms.ComboBox();
            this.categoriaBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear una nueva zapatilla";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(44, 85);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(158, 22);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.Text = "Ingrese Nombre";
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // boton_crear
            // 
            this.boton_crear.Location = new System.Drawing.Point(242, 279);
            this.boton_crear.Name = "boton_crear";
            this.boton_crear.Size = new System.Drawing.Size(146, 64);
            this.boton_crear.TabIndex = 3;
            this.boton_crear.Text = "Crear";
            this.boton_crear.UseVisualStyleBackColor = true;
            this.boton_crear.Click += new System.EventHandler(this.boton_crear_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(44, 191);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(158, 22);
            this.txt_id.TabIndex = 4;
            this.txt_id.Text = "Ingrese ID";
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(46, 245);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(156, 22);
            this.txt_precio.TabIndex = 5;
            this.txt_precio.Text = "Ingrese precio";
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "VER PRODUCTOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_tipo
            // 
            this.txt_tipo.Location = new System.Drawing.Point(46, 298);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(156, 22);
            this.txt_tipo.TabIndex = 8;
            this.txt_tipo.Text = "Ingrese Tipo";
            this.txt_tipo.TextChanged += new System.EventHandler(this.txt_tipo_TextChanged);
            // 
            // txt_detalle
            // 
            this.txt_detalle.Location = new System.Drawing.Point(46, 141);
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(156, 22);
            this.txt_detalle.TabIndex = 12;
            this.txt_detalle.Text = "Ingrese Detalle";
            this.txt_detalle.TextChanged += new System.EventHandler(this.txt_detalle_TextChanged);
            // 
            // txt_stockid
            // 
            this.txt_stockid.Location = new System.Drawing.Point(253, 245);
            this.txt_stockid.Name = "txt_stockid";
            this.txt_stockid.Size = new System.Drawing.Size(110, 22);
            this.txt_stockid.TabIndex = 13;
            this.txt_stockid.Text = "stock id";
            this.txt_stockid.TextChanged += new System.EventHandler(this.txt_stockid_TextChanged);
            // 
            // generoBox
            // 
            this.generoBox.FormattingEnabled = true;
            this.generoBox.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.generoBox.Location = new System.Drawing.Point(253, 139);
            this.generoBox.Name = "generoBox";
            this.generoBox.Size = new System.Drawing.Size(121, 24);
            this.generoBox.TabIndex = 14;
            this.generoBox.SelectedIndexChanged += new System.EventHandler(this.generoBox_SelectedIndexChanged);
            // 
            // talleBox
            // 
            this.talleBox.FormattingEnabled = true;
            this.talleBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.talleBox.Location = new System.Drawing.Point(253, 85);
            this.talleBox.Name = "talleBox";
            this.talleBox.Size = new System.Drawing.Size(121, 24);
            this.talleBox.TabIndex = 15;
            this.talleBox.SelectedIndexChanged += new System.EventHandler(this.talleBox_SelectedIndexChanged);
            // 
            // categoriaBox
            // 
            this.categoriaBox.FormattingEnabled = true;
            this.categoriaBox.Items.AddRange(new object[] {
            "Tennis",
            "Running",
            "Minimalista"});
            this.categoriaBox.Location = new System.Drawing.Point(253, 189);
            this.categoriaBox.Name = "categoriaBox";
            this.categoriaBox.Size = new System.Drawing.Size(121, 24);
            this.categoriaBox.TabIndex = 16;
            this.categoriaBox.SelectedIndexChanged += new System.EventHandler(this.categoriaBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Seleccione el talle";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Seleccione el genero";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Seleccione la categoria";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ingrese nombre:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ingrese un detalle";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Seleccione el id";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ingrese un precio";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ingrese un tipo";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 503);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoriaBox);
            this.Controls.Add(this.talleBox);
            this.Controls.Add(this.generoBox);
            this.Controls.Add(this.txt_stockid);
            this.Controls.Add(this.txt_detalle);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.boton_crear);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Crear una nueva zapatilla";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button boton_crear;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.TextBox txt_detalle;
        private System.Windows.Forms.TextBox txt_stockid;
        private System.Windows.Forms.ComboBox generoBox;
        private System.Windows.Forms.ComboBox talleBox;
        private System.Windows.Forms.ComboBox categoriaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

