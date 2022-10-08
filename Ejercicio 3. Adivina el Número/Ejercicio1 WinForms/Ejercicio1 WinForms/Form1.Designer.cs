namespace Ejercicio1_WinForms
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numero = new System.Windows.Forms.Label();
            this.ayuda = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonJugar = new System.Windows.Forms.Button();
            this.labelTextoAyuda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero.Location = new System.Drawing.Point(120, 99);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(77, 21);
            this.numero.TabIndex = 0;
            this.numero.Text = "Número:";
            // 
            // ayuda
            // 
            this.ayuda.AutoSize = true;
            this.ayuda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ayuda.Location = new System.Drawing.Point(130, 202);
            this.ayuda.Name = "ayuda";
            this.ayuda.Size = new System.Drawing.Size(67, 21);
            this.ayuda.TabIndex = 1;
            this.ayuda.Text = "Ayuda: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // buttonJugar
            // 
            this.buttonJugar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonJugar.Location = new System.Drawing.Point(339, 373);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(162, 36);
            this.buttonJugar.TabIndex = 3;
            this.buttonJugar.Text = "Jugar";
            this.buttonJugar.UseVisualStyleBackColor = true;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // labelTextoAyuda
            // 
            this.labelTextoAyuda.AutoSize = true;
            this.labelTextoAyuda.Location = new System.Drawing.Point(235, 207);
            this.labelTextoAyuda.Name = "labelTextoAyuda";
            this.labelTextoAyuda.Size = new System.Drawing.Size(88, 15);
            this.labelTextoAyuda.TabIndex = 4;
            this.labelTextoAyuda.Text = "Texto de Ayuda";
            this.labelTextoAyuda.Click += new System.EventHandler(this.label1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTextoAyuda);
            this.Controls.Add(this.buttonJugar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ayuda);
            this.Controls.Add(this.numero);
            this.Name = "Principal";
            this.Text = "Ejercicio 1. Adivina el Número";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label numero;
        private Label ayuda;
        private TextBox textBox1;
        private Button buttonJugar;
        private Label labelTextoAyuda;
    }
}