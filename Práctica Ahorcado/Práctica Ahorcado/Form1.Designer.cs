namespace Práctica_Ahorcado
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelRonda = new System.Windows.Forms.Label();
            this.labelAciertos = new System.Windows.Forms.Label();
            this.labelErrores = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelPalabra = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.DarkGray;
            this.labelTitulo.Font = new System.Drawing.Font("MV Boli", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Image = ((System.Drawing.Image)(resources.GetObject("labelTitulo.Image")));
            this.labelTitulo.Location = new System.Drawing.Point(257, 18);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(328, 70);
            this.labelTitulo.TabIndex = 7;
            this.labelTitulo.Text = "El Ahorcado";
            // 
            // labelRonda
            // 
            this.labelRonda.AutoSize = true;
            this.labelRonda.BackColor = System.Drawing.Color.DarkGray;
            this.labelRonda.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRonda.ForeColor = System.Drawing.Color.Black;
            this.labelRonda.Image = ((System.Drawing.Image)(resources.GetObject("labelRonda.Image")));
            this.labelRonda.Location = new System.Drawing.Point(608, 142);
            this.labelRonda.Name = "labelRonda";
            this.labelRonda.Size = new System.Drawing.Size(143, 26);
            this.labelRonda.TabIndex = 10;
            this.labelRonda.Text = "Ronda: 0/10";
            // 
            // labelAciertos
            // 
            this.labelAciertos.AutoSize = true;
            this.labelAciertos.BackColor = System.Drawing.Color.DarkGray;
            this.labelAciertos.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAciertos.ForeColor = System.Drawing.Color.Black;
            this.labelAciertos.Image = ((System.Drawing.Image)(resources.GetObject("labelAciertos.Image")));
            this.labelAciertos.Location = new System.Drawing.Point(608, 198);
            this.labelAciertos.Name = "labelAciertos";
            this.labelAciertos.Size = new System.Drawing.Size(131, 26);
            this.labelAciertos.TabIndex = 11;
            this.labelAciertos.Text = "Aciertos: 0";
            // 
            // labelErrores
            // 
            this.labelErrores.AutoSize = true;
            this.labelErrores.BackColor = System.Drawing.Color.DarkGray;
            this.labelErrores.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelErrores.ForeColor = System.Drawing.Color.Black;
            this.labelErrores.Image = ((System.Drawing.Image)(resources.GetObject("labelErrores.Image")));
            this.labelErrores.Location = new System.Drawing.Point(608, 265);
            this.labelErrores.Name = "labelErrores";
            this.labelErrores.Size = new System.Drawing.Size(143, 26);
            this.labelErrores.TabIndex = 12;
            this.labelErrores.Text = "Ronda: 0/10";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.BackColor = System.Drawing.Color.DarkGray;
            this.labelCategoria.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCategoria.ForeColor = System.Drawing.Color.Black;
            this.labelCategoria.Image = ((System.Drawing.Image)(resources.GetObject("labelCategoria.Image")));
            this.labelCategoria.Location = new System.Drawing.Point(302, 142);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(116, 26);
            this.labelCategoria.TabIndex = 13;
            this.labelCategoria.Text = "Categoría:";
            // 
            // labelPalabra
            // 
            this.labelPalabra.AutoSize = true;
            this.labelPalabra.BackColor = System.Drawing.Color.DarkGray;
            this.labelPalabra.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPalabra.ForeColor = System.Drawing.Color.Black;
            this.labelPalabra.Image = ((System.Drawing.Image)(resources.GetObject("labelPalabra.Image")));
            this.labelPalabra.Location = new System.Drawing.Point(302, 213);
            this.labelPalabra.Name = "labelPalabra";
            this.labelPalabra.Size = new System.Drawing.Size(202, 26);
            this.labelPalabra.TabIndex = 14;
            this.labelPalabra.Text = "Aqui va la palabra";
            this.labelPalabra.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 24);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPalabra);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelErrores);
            this.Controls.Add(this.labelAciertos);
            this.Controls.Add(this.labelRonda);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelTitulo;
        private Label labelRonda;
        private Label labelAciertos;
        private Label labelErrores;
        private Label labelCategoria;
        private Label labelPalabra;
        private Button button1;
    }
}