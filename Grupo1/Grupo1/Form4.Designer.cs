namespace Grupo1.Properties
{
    partial class Form1
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
            this.radCurvas.Location = new System.Drawing.Point(15, 179);
            this.radCurvas.Name = "radCurvas";
            this.radCurvas.Size = new System.Drawing.Size(70, 20);
            this.radCurvas.TabIndex = 3;
            this.radCurvas.TabStop = true;
            this.radCurvas.Text = "Curvas";
            this.radCurvas.UseVisualStyleBackColor = true;
            // 
            // radPlanas
            // 
            this.radPlanas.AutoSize = true;
            this.radPlanas.Location = new System.Drawing.Point(15, 205);
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
            this.radPiluso.Location = new System.Drawing.Point(15, 231);
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
            this.radHombre.Location = new System.Drawing.Point(15, 424);
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
            this.radMujer.Location = new System.Drawing.Point(15, 450);
            this.radMujer.Name = "radMujer";
            this.radMujer.Size = new System.Drawing.Size(61, 20);
            this.radMujer.TabIndex = 7;
            this.radMujer.TabStop = true;
            this.radMujer.Text = "Mujer";
            this.radMujer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 569);
            this.Controls.Add(this.radMujer);
            this.Controls.Add(this.radHombre);
            this.Controls.Add(this.radPiluso);
            this.Controls.Add(this.radPlanas);
            this.Controls.Add(this.radCurvas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}