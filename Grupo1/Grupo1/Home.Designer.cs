namespace Grupo1
{
    partial class Home
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
            this.crearZapas = new System.Windows.Forms.Button();
            this.crearGorras = new System.Windows.Forms.Button();
            this.editarProductos = new System.Windows.Forms.Button();
            this.realizarVentas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crearZapas
            // 
            this.crearZapas.Location = new System.Drawing.Point(27, 95);
            this.crearZapas.Name = "crearZapas";
            this.crearZapas.Size = new System.Drawing.Size(113, 55);
            this.crearZapas.TabIndex = 0;
            this.crearZapas.Text = "Crear Zapatillas";
            this.crearZapas.UseVisualStyleBackColor = true;
            this.crearZapas.Click += new System.EventHandler(this.crearZapas_Click);
            // 
            // crearGorras
            // 
            this.crearGorras.Location = new System.Drawing.Point(158, 95);
            this.crearGorras.Name = "crearGorras";
            this.crearGorras.Size = new System.Drawing.Size(110, 55);
            this.crearGorras.TabIndex = 1;
            this.crearGorras.Text = "Crear Gorras";
            this.crearGorras.UseVisualStyleBackColor = true;
            this.crearGorras.Click += new System.EventHandler(this.crearGorras_Click);
            // 
            // editarProductos
            // 
            this.editarProductos.Location = new System.Drawing.Point(298, 95);
            this.editarProductos.Name = "editarProductos";
            this.editarProductos.Size = new System.Drawing.Size(114, 55);
            this.editarProductos.TabIndex = 2;
            this.editarProductos.Text = "Editar productos";
            this.editarProductos.UseVisualStyleBackColor = true;
            this.editarProductos.Click += new System.EventHandler(this.editarProductos_Click);
            // 
            // realizarVentas
            // 
            this.realizarVentas.Location = new System.Drawing.Point(27, 190);
            this.realizarVentas.Name = "realizarVentas";
            this.realizarVentas.Size = new System.Drawing.Size(113, 48);
            this.realizarVentas.TabIndex = 3;
            this.realizarVentas.Text = "Realizar ventas";
            this.realizarVentas.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cerrar sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.realizarVentas);
            this.Controls.Add(this.editarProductos);
            this.Controls.Add(this.crearGorras);
            this.Controls.Add(this.crearZapas);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button crearZapas;
        private System.Windows.Forms.Button crearGorras;
        private System.Windows.Forms.Button editarProductos;
        private System.Windows.Forms.Button realizarVentas;
        private System.Windows.Forms.Button button1;
    }
}