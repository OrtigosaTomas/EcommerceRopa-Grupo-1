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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.boton_crear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.label8 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelImagen = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.imagenZap = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenZap)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(29, 94);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(204, 30);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.Text = "Ingrese Nombre";
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // boton_crear
            // 
            this.boton_crear.BackColor = System.Drawing.Color.Gray;
            this.boton_crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_crear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton_crear.Location = new System.Drawing.Point(624, 566);
            this.boton_crear.Name = "boton_crear";
            this.boton_crear.Size = new System.Drawing.Size(160, 103);
            this.boton_crear.TabIndex = 3;
            this.boton_crear.Text = "Crear";
            this.boton_crear.UseVisualStyleBackColor = false;
            this.boton_crear.Click += new System.EventHandler(this.boton_crear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 103);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ver Productos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_detalle
            // 
            this.txt_detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_detalle.Location = new System.Drawing.Point(29, 155);
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(202, 30);
            this.txt_detalle.TabIndex = 12;
            this.txt_detalle.Text = "Ingrese Detalle";
            this.txt_detalle.TextChanged += new System.EventHandler(this.txt_detalle_TextChanged);
            // 
            // txt_stockid
            // 
            this.txt_stockid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stockid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_stockid.Location = new System.Drawing.Point(612, 370);
            this.txt_stockid.Name = "txt_stockid";
            this.txt_stockid.Size = new System.Drawing.Size(121, 30);
            this.txt_stockid.TabIndex = 13;
            this.txt_stockid.TextChanged += new System.EventHandler(this.txt_stockid_TextChanged);
            // 
            // generoBox
            // 
            this.generoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generoBox.FormattingEnabled = true;
            this.generoBox.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.generoBox.Location = new System.Drawing.Point(612, 180);
            this.generoBox.Name = "generoBox";
            this.generoBox.Size = new System.Drawing.Size(121, 33);
            this.generoBox.TabIndex = 14;
            this.generoBox.SelectedIndexChanged += new System.EventHandler(this.generoBox_SelectedIndexChanged);
            // 
            // talleBox
            // 
            this.talleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.talleBox.FormattingEnabled = true;
            this.talleBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.talleBox.Location = new System.Drawing.Point(612, 91);
            this.talleBox.Name = "talleBox";
            this.talleBox.Size = new System.Drawing.Size(121, 33);
            this.talleBox.TabIndex = 15;
            this.talleBox.SelectedIndexChanged += new System.EventHandler(this.talleBox_SelectedIndexChanged);
            // 
            // categoriaBox
            // 
            this.categoriaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaBox.FormattingEnabled = true;
            this.categoriaBox.Items.AddRange(new object[] {
            "Tennis",
            "Running",
            "Minimalista"});
            this.categoriaBox.Location = new System.Drawing.Point(612, 274);
            this.categoriaBox.Name = "categoriaBox";
            this.categoriaBox.Size = new System.Drawing.Size(121, 33);
            this.categoriaBox.TabIndex = 16;
            this.categoriaBox.SelectedIndexChanged += new System.EventHandler(this.categoriaBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(378, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Seleccione el talle:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(351, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Seleccione el genero:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(329, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Seleccione la categoria:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(26, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nombre:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(24, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Detalle:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(30, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Precio:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(29, 220);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(202, 30);
            this.txt_precio.TabIndex = 5;
            this.txt_precio.Text = "Ingrese Precio";
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.labelImagen);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.imagenZap);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.generoBox);
            this.groupBox1.Controls.Add(this.txt_stockid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.talleBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.categoriaBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_detalle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_precio);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 548);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Zapatilla";
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Location = new System.Drawing.Point(30, 504);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(0, 38);
            this.labelImagen.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button2.Location = new System.Drawing.Point(128, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 39);
            this.button2.TabIndex = 28;
            this.button2.Text = "Subir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imagenZap
            // 
            this.imagenZap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagenZap.Location = new System.Drawing.Point(33, 322);
            this.imagenZap.Name = "imagenZap";
            this.imagenZap.Size = new System.Drawing.Size(200, 179);
            this.imagenZap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenZap.TabIndex = 27;
            this.imagenZap.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(32, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Imagen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(307, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ingrese cantidad de stock:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(796, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boton_crear);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Crear una nueva Zapatilla";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenZap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button boton_crear;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox imagenZap;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelImagen;
    }
}

