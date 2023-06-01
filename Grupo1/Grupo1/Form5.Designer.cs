using System;

namespace Grupo1
{
    partial class Form5
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
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoriaBox1 = new System.Windows.Forms.ComboBox();
            this.txt_stockid1 = new System.Windows.Forms.TextBox();
            this.txt_detalle1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_precio1 = new System.Windows.Forms.TextBox();
            this.boton_crear1 = new System.Windows.Forms.Button();
            this.txt_nombre1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.talleBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Ingrese un precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Ingrese un detalle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Ingrese nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Seleccione la categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Seleccione el talle";
            // 
            // categoriaBox1
            // 
            this.categoriaBox1.FormattingEnabled = true;
            this.categoriaBox1.Items.AddRange(new object[] {
            "Piluso",
            "Plana",
            "Curva"});
            this.categoriaBox1.Location = new System.Drawing.Point(278, 219);
            this.categoriaBox1.Name = "categoriaBox1";
            this.categoriaBox1.Size = new System.Drawing.Size(121, 24);
            this.categoriaBox1.TabIndex = 36;
            // 
            // txt_stockid1
            // 
            this.txt_stockid1.Location = new System.Drawing.Point(278, 275);
            this.txt_stockid1.Name = "txt_stockid1";
            this.txt_stockid1.Size = new System.Drawing.Size(110, 22);
            this.txt_stockid1.TabIndex = 33;
            this.txt_stockid1.Text = "stock id";
            this.txt_stockid1.TextChanged += new System.EventHandler(this.txt_stockid1_TextChanged);
            // 
            // txt_detalle1
            // 
            this.txt_detalle1.Location = new System.Drawing.Point(71, 171);
            this.txt_detalle1.Name = "txt_detalle1";
            this.txt_detalle1.Size = new System.Drawing.Size(156, 22);
            this.txt_detalle1.TabIndex = 32;
            this.txt_detalle1.Text = "Ingrese Detalle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 40);
            this.button1.TabIndex = 30;
            this.button1.Text = "VER PRODUCTOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_precio1
            // 
            this.txt_precio1.Location = new System.Drawing.Point(71, 275);
            this.txt_precio1.Name = "txt_precio1";
            this.txt_precio1.Size = new System.Drawing.Size(156, 22);
            this.txt_precio1.TabIndex = 29;
            this.txt_precio1.Text = "Ingrese precio";
            this.txt_precio1.TextChanged += new System.EventHandler(this.txt_precio1_TextChanged);
            // 
            // boton_crear1
            // 
            this.boton_crear1.Location = new System.Drawing.Point(267, 309);
            this.boton_crear1.Name = "boton_crear1";
            this.boton_crear1.Size = new System.Drawing.Size(146, 64);
            this.boton_crear1.TabIndex = 27;
            this.boton_crear1.Text = "Crear";
            this.boton_crear1.UseVisualStyleBackColor = true;
            this.boton_crear1.Click += new System.EventHandler(this.boton_crear_Click_1);
            // 
            // txt_nombre1
            // 
            this.txt_nombre1.Location = new System.Drawing.Point(69, 115);
            this.txt_nombre1.Name = "txt_nombre1";
            this.txt_nombre1.Size = new System.Drawing.Size(158, 22);
            this.txt_nombre1.TabIndex = 26;
            this.txt_nombre1.Text = "Ingrese Nombre";
            this.txt_nombre1.TextChanged += new System.EventHandler(this.txt_nombre1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Crear una nueva gorra";
            // 
            // talleBox2
            // 
            this.talleBox2.FormattingEnabled = true;
            this.talleBox2.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60"});
            this.talleBox2.Location = new System.Drawing.Point(278, 115);
            this.talleBox2.Name = "talleBox2";
            this.talleBox2.Size = new System.Drawing.Size(121, 24);
            this.talleBox2.TabIndex = 45;
            this.talleBox2.SelectedIndexChanged += new System.EventHandler(this.talleBox2_SelectedIndexChanged1);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 506);
            this.Controls.Add(this.talleBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoriaBox1);
            this.Controls.Add(this.txt_stockid1);
            this.Controls.Add(this.txt_detalle1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_precio1);
            this.Controls.Add(this.boton_crear1);
            this.Controls.Add(this.txt_nombre1);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void talleBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categoriaBox1;
        private System.Windows.Forms.TextBox txt_stockid1;
        private System.Windows.Forms.TextBox txt_detalle1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_precio1;
        private System.Windows.Forms.Button boton_crear1;
        private System.Windows.Forms.TextBox txt_nombre1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox talleBox2;
    }
}