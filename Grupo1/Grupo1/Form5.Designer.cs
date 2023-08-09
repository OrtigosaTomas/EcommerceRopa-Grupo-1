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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
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
            this.talleBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imagenGor = new System.Windows.Forms.PictureBox();
            this.botonSubirG = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_img = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenGor)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(23, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 43;
            this.label8.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(23, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Detalle:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(23, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(319, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Seleccione la categoria:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(368, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Seleccione el talle:";
            // 
            // categoriaBox1
            // 
            this.categoriaBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaBox1.FormattingEnabled = true;
            this.categoriaBox1.Items.AddRange(new object[] {
            "Piluso",
            "Plana",
            "Curva"});
            this.categoriaBox1.Location = new System.Drawing.Point(601, 268);
            this.categoriaBox1.Name = "categoriaBox1";
            this.categoriaBox1.Size = new System.Drawing.Size(121, 33);
            this.categoriaBox1.TabIndex = 36;
            // 
            // txt_stockid1
            // 
            this.txt_stockid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stockid1.Location = new System.Drawing.Point(601, 463);
            this.txt_stockid1.Name = "txt_stockid1";
            this.txt_stockid1.Size = new System.Drawing.Size(121, 30);
            this.txt_stockid1.TabIndex = 33;
            this.txt_stockid1.TextChanged += new System.EventHandler(this.txt_stockid1_TextChanged);
            // 
            // txt_detalle1
            // 
            this.txt_detalle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_detalle1.Location = new System.Drawing.Point(28, 155);
            this.txt_detalle1.Name = "txt_detalle1";
            this.txt_detalle1.Size = new System.Drawing.Size(196, 30);
            this.txt_detalle1.TabIndex = 32;
            this.txt_detalle1.Text = "Ingrese Detalle";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 103);
            this.button1.TabIndex = 30;
            this.button1.Text = "Ver Productos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_precio1
            // 
            this.txt_precio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio1.Location = new System.Drawing.Point(28, 216);
            this.txt_precio1.Name = "txt_precio1";
            this.txt_precio1.Size = new System.Drawing.Size(196, 30);
            this.txt_precio1.TabIndex = 29;
            this.txt_precio1.Text = "Ingrese Precio";
            this.txt_precio1.TextChanged += new System.EventHandler(this.txt_precio1_TextChanged);
            // 
            // boton_crear1
            // 
            this.boton_crear1.BackColor = System.Drawing.Color.Gray;
            this.boton_crear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_crear1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton_crear1.Location = new System.Drawing.Point(578, 570);
            this.boton_crear1.Name = "boton_crear1";
            this.boton_crear1.Size = new System.Drawing.Size(179, 103);
            this.boton_crear1.TabIndex = 27;
            this.boton_crear1.Text = "Crear";
            this.boton_crear1.UseVisualStyleBackColor = false;
            this.boton_crear1.Click += new System.EventHandler(this.boton_crear_Click_1);
            // 
            // txt_nombre1
            // 
            this.txt_nombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre1.Location = new System.Drawing.Point(28, 94);
            this.txt_nombre1.Name = "txt_nombre1";
            this.txt_nombre1.Size = new System.Drawing.Size(196, 30);
            this.txt_nombre1.TabIndex = 26;
            this.txt_nombre1.Text = "Ingrese Nombre";
            this.txt_nombre1.TextChanged += new System.EventHandler(this.txt_nombre1_TextChanged);
            // 
            // talleBox2
            // 
            this.talleBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.talleBox2.FormattingEnabled = true;
            this.talleBox2.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60"});
            this.talleBox2.Location = new System.Drawing.Point(601, 94);
            this.talleBox2.Name = "talleBox2";
            this.talleBox2.Size = new System.Drawing.Size(121, 33);
            this.talleBox2.TabIndex = 45;
            this.talleBox2.SelectedIndexChanged += new System.EventHandler(this.talleBox2_SelectedIndexChanged1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.imagenGor);
            this.groupBox1.Controls.Add(this.botonSubirG);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBox_img);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.talleBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_stockid1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.categoriaBox1);
            this.groupBox1.Controls.Add(this.txt_detalle1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_precio1);
            this.groupBox1.Controls.Add(this.txt_nombre1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 539);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Gorra";
            // 
            // imagenGor
            // 
            this.imagenGor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagenGor.Location = new System.Drawing.Point(28, 309);
            this.imagenGor.Name = "imagenGor";
            this.imagenGor.Size = new System.Drawing.Size(200, 159);
            this.imagenGor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenGor.TabIndex = 52;
            this.imagenGor.TabStop = false;
            // 
            // botonSubirG
            // 
            this.botonSubirG.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSubirG.ForeColor = System.Drawing.SystemColors.WindowText;
            this.botonSubirG.Location = new System.Drawing.Point(112, 264);
            this.botonSubirG.Name = "botonSubirG";
            this.botonSubirG.Size = new System.Drawing.Size(105, 39);
            this.botonSubirG.TabIndex = 51;
            this.botonSubirG.Text = "Subir";
            this.botonSubirG.UseVisualStyleBackColor = true;
            this.botonSubirG.Click += new System.EventHandler(this.botonSubirG_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(23, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Imagen";
            // 
            // txtBox_img
            // 
            this.txtBox_img.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_img.Location = new System.Drawing.Point(28, 476);
            this.txtBox_img.Name = "txtBox_img";
            this.txtBox_img.Size = new System.Drawing.Size(196, 30);
            this.txtBox_img.TabIndex = 47;
            this.txtBox_img.TextChanged += new System.EventHandler(this.txtBox_img_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(274, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ingrese la cantidad de stock:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(769, 685);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boton_crear1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Crear una nueva Gorra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenGor)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox talleBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_img;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonSubirG;
        private System.Windows.Forms.PictureBox imagenGor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}