namespace EjercicioTable
{
    partial class Form3Modif
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
            this.label1Modi = new System.Windows.Forms.Label();
            this.label2Modif = new System.Windows.Forms.Label();
            this.textBox1Modif = new System.Windows.Forms.TextBox();
            this.textBoxModif = new System.Windows.Forms.TextBox();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1Modi
            // 
            this.label1Modi.AutoSize = true;
            this.label1Modi.Location = new System.Drawing.Point(56, 63);
            this.label1Modi.Name = "label1Modi";
            this.label1Modi.Size = new System.Drawing.Size(54, 15);
            this.label1Modi.TabIndex = 0;
            this.label1Modi.Text = "Nombre:";
            // 
            // label2Modif
            // 
            this.label2Modif.AutoSize = true;
            this.label2Modif.Location = new System.Drawing.Point(74, 157);
            this.label2Modif.Name = "label2Modif";
            this.label2Modif.Size = new System.Drawing.Size(36, 15);
            this.label2Modif.TabIndex = 1;
            this.label2Modif.Text = "Nota:";
            // 
            // textBox1Modif
            // 
            this.textBox1Modif.Location = new System.Drawing.Point(159, 62);
            this.textBox1Modif.Name = "textBox1Modif";
            this.textBox1Modif.Size = new System.Drawing.Size(100, 23);
            this.textBox1Modif.TabIndex = 2;
            // 
            // textBoxModif
            // 
            this.textBoxModif.Location = new System.Drawing.Point(159, 149);
            this.textBoxModif.Name = "textBoxModif";
            this.textBoxModif.Size = new System.Drawing.Size(100, 23);
            this.textBoxModif.TabIndex = 3;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(125, 284);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(98, 61);
            this.buttonActualizar.TabIndex = 4;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // Form3Modif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 421);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.textBoxModif);
            this.Controls.Add(this.textBox1Modif);
            this.Controls.Add(this.label2Modif);
            this.Controls.Add(this.label1Modi);
            this.Name = "Form3Modif";
            this.Text = "Form3Modif";
            this.Load += new System.EventHandler(this.Form3Modif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1Modi;
        private Label label2Modif;
        private TextBox textBox1Modif;
        private TextBox textBoxModif;
        private Button buttonActualizar;
        private Label label1ModiNombre;
        private Label label2ModiNota;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1Act;
    }
}