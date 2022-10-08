namespace Ejercicio_2_WinForms
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
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelNumsAle = new System.Windows.Forms.Label();
            this.labelAyuda = new System.Windows.Forms.Label();
            this.buttonJugar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelMensajeAyuda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumero.Location = new System.Drawing.Point(52, 133);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(81, 21);
            this.labelNumero.TabIndex = 0;
            this.labelNumero.Text = "Número: ";
            this.labelNumero.Click += new System.EventHandler(this.labelNumero_Click);
            // 
            // labelNumsAle
            // 
            this.labelNumsAle.AutoSize = true;
            this.labelNumsAle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumsAle.Location = new System.Drawing.Point(52, 213);
            this.labelNumsAle.Name = "labelNumsAle";
            this.labelNumsAle.Size = new System.Drawing.Size(450, 21);
            this.labelNumsAle.TabIndex = 1;
            this.labelNumsAle.Text = "Indica los números entre los que seleccionar un Aleatorio:";
            // 
            // labelAyuda
            // 
            this.labelAyuda.AutoSize = true;
            this.labelAyuda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAyuda.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelAyuda.Location = new System.Drawing.Point(52, 298);
            this.labelAyuda.Name = "labelAyuda";
            this.labelAyuda.Size = new System.Drawing.Size(121, 21);
            this.labelAyuda.TabIndex = 2;
            this.labelAyuda.Text = "Info de Ayuda:";
            // 
            // buttonJugar
            // 
            this.buttonJugar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonJugar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonJugar.Location = new System.Drawing.Point(404, 393);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(75, 45);
            this.buttonJugar.TabIndex = 3;
            this.buttonJugar.Text = "JUGAR";
            this.buttonJugar.UseVisualStyleBackColor = true;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(518, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(639, 211);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 6;
            // 
            // labelMensajeAyuda
            // 
            this.labelMensajeAyuda.AutoSize = true;
            this.labelMensajeAyuda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMensajeAyuda.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelMensajeAyuda.Location = new System.Drawing.Point(201, 298);
            this.labelMensajeAyuda.Name = "labelMensajeAyuda";
            this.labelMensajeAyuda.Size = new System.Drawing.Size(139, 21);
            this.labelMensajeAyuda.TabIndex = 7;
            this.labelMensajeAyuda.Text = "Aqui va la Ayuda";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMensajeAyuda);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonJugar);
            this.Controls.Add(this.labelAyuda);
            this.Controls.Add(this.labelNumsAle);
            this.Controls.Add(this.labelNumero);
            this.Name = "Principal";
            this.Text = "Ejercicio 2. Adivina Número ++";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNumero;
        private Label labelNumsAle;
        private Label labelAyuda;
        private Button buttonJugar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label labelMensajeAyuda;
    }
}