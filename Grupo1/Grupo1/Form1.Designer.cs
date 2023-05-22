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
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.boton_crear = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.boton_form2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear una nueva zapatilla";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(81, 100);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(110, 22);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.Text = "Ingrese Nombre";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(81, 143);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(110, 22);
            this.txt_descripcion.TabIndex = 2;
            this.txt_descripcion.Text = "Ingrese Descripcion";
            this.txt_descripcion.TextChanged += new System.EventHandler(this.txt_descripcion_TextChanged);
            // 
            // boton_crear
            // 
            this.boton_crear.Location = new System.Drawing.Point(81, 299);
            this.boton_crear.Name = "boton_crear";
            this.boton_crear.Size = new System.Drawing.Size(75, 23);
            this.boton_crear.TabIndex = 3;
            this.boton_crear.Text = "Crear";
            this.boton_crear.UseVisualStyleBackColor = true;
            this.boton_crear.Click += new System.EventHandler(this.boton_crear_Click);
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(81, 191);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(110, 22);
            this.txt_id.TabIndex = 4;
            this.txt_id.Text = "Ingrese ID";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(81, 241);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(110, 22);
            this.txt_precio.TabIndex = 5;
            this.txt_precio.Text = "Ingrese precio";
            // 
            // boton_form2
            // 
            this.boton_form2.Location = new System.Drawing.Point(253, 386);
            this.boton_form2.Name = "boton_form2";
            this.boton_form2.Size = new System.Drawing.Size(107, 39);
            this.boton_form2.TabIndex = 6;
            this.boton_form2.Text = "button1";
            this.boton_form2.UseVisualStyleBackColor = true;
            this.boton_form2.Click += new System.EventHandler(this.boton_form2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boton_form2);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.boton_crear);
            this.Controls.Add(this.txt_descripcion);
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
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Button boton_crear;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Button boton_form2;
        private System.Windows.Forms.Button button1;
    }
}

