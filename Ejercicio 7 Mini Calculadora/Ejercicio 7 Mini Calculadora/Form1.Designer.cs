namespace Ejercicio_7_Mini_Calculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRestar = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiplicar = new System.Windows.Forms.RadioButton();
            this.radioButtonDividir = new System.Windows.Forms.RadioButton();
            this.radioButtonTodas = new System.Windows.Forms.RadioButton();
            this.radioButtonSumar = new System.Windows.Forms.RadioButton();
            this.buttonIntro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sumar 3 Números";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(483, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese 3 Números:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResultado.Location = new System.Drawing.Point(392, 206);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(97, 21);
            this.labelResultado.TabIndex = 2;
            this.labelResultado.Text = "Resultados:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(381, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(508, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(635, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonRestar);
            this.groupBox1.Controls.Add(this.radioButtonMultiplicar);
            this.groupBox1.Controls.Add(this.radioButtonDividir);
            this.groupBox1.Controls.Add(this.radioButtonTodas);
            this.groupBox1.Controls.Add(this.radioButtonSumar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(53, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 294);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // radioButtonRestar
            // 
            this.radioButtonRestar.AutoSize = true;
            this.radioButtonRestar.Location = new System.Drawing.Point(48, 88);
            this.radioButtonRestar.Name = "radioButtonRestar";
            this.radioButtonRestar.Size = new System.Drawing.Size(61, 19);
            this.radioButtonRestar.TabIndex = 8;
            this.radioButtonRestar.TabStop = true;
            this.radioButtonRestar.Text = "Restar";
            this.radioButtonRestar.UseVisualStyleBackColor = true;
            // 
            // radioButtonMultiplicar
            // 
            this.radioButtonMultiplicar.AutoSize = true;
            this.radioButtonMultiplicar.Location = new System.Drawing.Point(48, 142);
            this.radioButtonMultiplicar.Name = "radioButtonMultiplicar";
            this.radioButtonMultiplicar.Size = new System.Drawing.Size(84, 19);
            this.radioButtonMultiplicar.TabIndex = 9;
            this.radioButtonMultiplicar.TabStop = true;
            this.radioButtonMultiplicar.Text = "Multiplicar";
            this.radioButtonMultiplicar.UseVisualStyleBackColor = true;
            // 
            // radioButtonDividir
            // 
            this.radioButtonDividir.AutoSize = true;
            this.radioButtonDividir.Location = new System.Drawing.Point(48, 199);
            this.radioButtonDividir.Name = "radioButtonDividir";
            this.radioButtonDividir.Size = new System.Drawing.Size(62, 19);
            this.radioButtonDividir.TabIndex = 10;
            this.radioButtonDividir.TabStop = true;
            this.radioButtonDividir.Text = "Dividir";
            this.radioButtonDividir.UseVisualStyleBackColor = true;
            // 
            // radioButtonTodas
            // 
            this.radioButtonTodas.AutoSize = true;
            this.radioButtonTodas.Location = new System.Drawing.Point(48, 253);
            this.radioButtonTodas.Name = "radioButtonTodas";
            this.radioButtonTodas.Size = new System.Drawing.Size(56, 19);
            this.radioButtonTodas.TabIndex = 11;
            this.radioButtonTodas.TabStop = true;
            this.radioButtonTodas.Text = "Todas";
            this.radioButtonTodas.UseVisualStyleBackColor = true;
            // 
            // radioButtonSumar
            // 
            this.radioButtonSumar.AutoSize = true;
            this.radioButtonSumar.Location = new System.Drawing.Point(48, 39);
            this.radioButtonSumar.Name = "radioButtonSumar";
            this.radioButtonSumar.Size = new System.Drawing.Size(61, 19);
            this.radioButtonSumar.TabIndex = 7;
            this.radioButtonSumar.TabStop = true;
            this.radioButtonSumar.Text = "Sumar";
            this.radioButtonSumar.UseVisualStyleBackColor = true;
            // 
            // buttonIntro
            // 
            this.buttonIntro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIntro.Location = new System.Drawing.Point(533, 399);
            this.buttonIntro.Name = "buttonIntro";
            this.buttonIntro.Size = new System.Drawing.Size(75, 39);
            this.buttonIntro.TabIndex = 7;
            this.buttonIntro.Text = "Intro";
            this.buttonIntro.UseVisualStyleBackColor = true;
            this.buttonIntro.Click += new System.EventHandler(this.buttonIntro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIntro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "v";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelResultado;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private RadioButton radioButtonRestar;
        private RadioButton radioButtonMultiplicar;
        private RadioButton radioButtonDividir;
        private RadioButton radioButtonTodas;
        private RadioButton radioButtonSumar;
        private Button buttonIntro;
    }
}