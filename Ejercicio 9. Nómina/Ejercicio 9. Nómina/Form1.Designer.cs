namespace Ejercicio_9._Nómina
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelSalarioDiario = new System.Windows.Forms.Label();
            this.labelDias = new System.Windows.Forms.Label();
            this.labelPension = new System.Windows.Forms.Label();
            this.labelSalud = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(257, 36);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(176, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Nómina Empleado";
            // 
            // labelSalarioDiario
            // 
            this.labelSalarioDiario.AutoSize = true;
            this.labelSalarioDiario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalarioDiario.Location = new System.Drawing.Point(121, 122);
            this.labelSalarioDiario.Name = "labelSalarioDiario";
            this.labelSalarioDiario.Size = new System.Drawing.Size(105, 19);
            this.labelSalarioDiario.TabIndex = 1;
            this.labelSalarioDiario.Text = "Salario Diario:";
            // 
            // labelDias
            // 
            this.labelDias.AutoSize = true;
            this.labelDias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDias.Location = new System.Drawing.Point(86, 191);
            this.labelDias.Name = "labelDias";
            this.labelDias.Size = new System.Drawing.Size(140, 19);
            this.labelDias.TabIndex = 2;
            this.labelDias.Text = "Nº Días Trabajados:";
            // 
            // labelPension
            // 
            this.labelPension.AutoSize = true;
            this.labelPension.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPension.Location = new System.Drawing.Point(369, 262);
            this.labelPension.Name = "labelPension";
            this.labelPension.Size = new System.Drawing.Size(138, 19);
            this.labelPension.TabIndex = 3;
            this.labelPension.Text = "Descuento Pensión:";
            // 
            // labelSalud
            // 
            this.labelSalud.AutoSize = true;
            this.labelSalud.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalud.Location = new System.Drawing.Point(384, 308);
            this.labelSalud.Name = "labelSalud";
            this.labelSalud.Size = new System.Drawing.Size(123, 19);
            this.labelSalud.TabIndex = 4;
            this.labelSalud.Text = "Descuento Salud:";
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalario.Location = new System.Drawing.Point(377, 365);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(130, 20);
            this.labelSalario.TabIndex = 5;
            this.labelSalario.Text = "Salario a Percibir:";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCalcular.Location = new System.Drawing.Point(86, 305);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(161, 80);
            this.buttonCalcular.TabIndex = 6;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(248, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(528, 262);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(528, 308);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(528, 362);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.labelSalud);
            this.Controls.Add(this.labelPension);
            this.Controls.Add(this.labelDias);
            this.Controls.Add(this.labelSalarioDiario);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.Text = "Ejercicio9. Nómina Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitulo;
        private Label labelSalarioDiario;
        private Label labelDias;
        private Label labelPension;
        private Label labelSalud;
        private Label labelSalario;
        private Button buttonCalcular;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}