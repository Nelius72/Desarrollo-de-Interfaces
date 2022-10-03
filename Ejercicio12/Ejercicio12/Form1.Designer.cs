namespace Ejercicio12
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
            this.textBoxPalabra = new System.Windows.Forms.TextBox();
            this.labelPalabra = new System.Windows.Forms.Label();
            this.textBoxEst = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelEst = new System.Windows.Forms.Label();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBoxPalabra
            // 
            this.textBoxPalabra.Location = new System.Drawing.Point(138, 113);
            this.textBoxPalabra.Name = "textBoxPalabra";
            this.textBoxPalabra.Size = new System.Drawing.Size(122, 23);
            this.textBoxPalabra.TabIndex = 0;
            // 
            // labelPalabra
            // 
            this.labelPalabra.AutoSize = true;
            this.labelPalabra.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPalabra.Location = new System.Drawing.Point(51, 110);
            this.labelPalabra.Name = "labelPalabra";
            this.labelPalabra.Size = new System.Drawing.Size(81, 25);
            this.labelPalabra.TabIndex = 1;
            this.labelPalabra.Text = "Palabra:";
            // 
            // textBoxEst
            // 
            this.textBoxEst.Location = new System.Drawing.Point(520, 101);
            this.textBoxEst.Multiline = true;
            this.textBoxEst.Name = "textBoxEst";
            this.textBoxEst.Size = new System.Drawing.Size(213, 174);
            this.textBoxEst.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(295, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 274);
            this.listBox1.TabIndex = 3;
            // 
            // labelEst
            // 
            this.labelEst.AutoSize = true;
            this.labelEst.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEst.Location = new System.Drawing.Point(574, 59);
            this.labelEst.Name = "labelEst";
            this.labelEst.Size = new System.Drawing.Size(110, 25);
            this.labelEst.TabIndex = 4;
            this.labelEst.Text = "Estadisticas";
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEnviar.Location = new System.Drawing.Point(85, 269);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(136, 52);
            this.buttonEnviar.TabIndex = 5;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 364);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.labelEst);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxEst);
            this.Controls.Add(this.labelPalabra);
            this.Controls.Add(this.textBoxPalabra);
            this.Name = "Form1";
            this.Text = "Ejercicio 12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxPalabra;
        private Label labelPalabra;
        private TextBox textBoxEst;
        private ListBox listBox1;
        private Label labelEst;
        private Button buttonEnviar;
        private OpenFileDialog openFileDialog1;
    }
}