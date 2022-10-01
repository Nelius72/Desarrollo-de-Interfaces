namespace Ejercicio11._Votaciones
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
            this.radioButtonSi = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonNs = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonVotar = new System.Windows.Forms.Button();
            this.labelOpc = new System.Windows.Forms.Label();
            this.labelPorc = new System.Windows.Forms.Label();
            this.labelSi = new System.Windows.Forms.Label();
            this.labelNo = new System.Windows.Forms.Label();
            this.labelNs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonSi
            // 
            this.radioButtonSi.AutoSize = true;
            this.radioButtonSi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonSi.Location = new System.Drawing.Point(46, 59);
            this.radioButtonSi.Name = "radioButtonSi";
            this.radioButtonSi.Size = new System.Drawing.Size(42, 25);
            this.radioButtonSi.TabIndex = 3;
            this.radioButtonSi.TabStop = true;
            this.radioButtonSi.Text = "Si";
            this.radioButtonSi.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonNo.Location = new System.Drawing.Point(46, 116);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(51, 25);
            this.radioButtonNo.TabIndex = 4;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonNs
            // 
            this.radioButtonNs.AutoSize = true;
            this.radioButtonNs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonNs.Location = new System.Drawing.Point(46, 175);
            this.radioButtonNs.Name = "radioButtonNs";
            this.radioButtonNs.Size = new System.Drawing.Size(76, 25);
            this.radioButtonNs.TabIndex = 5;
            this.radioButtonNs.TabStop = true;
            this.radioButtonNs.Text = "Ns/Nc";
            this.radioButtonNs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(215, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Votos Totales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(247, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            // 
            // buttonVotar
            // 
            this.buttonVotar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVotar.Location = new System.Drawing.Point(46, 232);
            this.buttonVotar.Name = "buttonVotar";
            this.buttonVotar.Size = new System.Drawing.Size(100, 40);
            this.buttonVotar.TabIndex = 8;
            this.buttonVotar.Text = "Votar";
            this.buttonVotar.UseVisualStyleBackColor = true;
            this.buttonVotar.Click += new System.EventHandler(this.buttonVotar_Click);
            // 
            // labelOpc
            // 
            this.labelOpc.AutoSize = true;
            this.labelOpc.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelOpc.Location = new System.Drawing.Point(31, 13);
            this.labelOpc.Name = "labelOpc";
            this.labelOpc.Size = new System.Drawing.Size(91, 25);
            this.labelOpc.TabIndex = 9;
            this.labelOpc.Text = "Opciones";
            // 
            // labelPorc
            // 
            this.labelPorc.AutoSize = true;
            this.labelPorc.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelPorc.Location = new System.Drawing.Point(215, 13);
            this.labelPorc.Name = "labelPorc";
            this.labelPorc.Size = new System.Drawing.Size(110, 25);
            this.labelPorc.TabIndex = 10;
            this.labelPorc.Text = "Porcentajes";
            // 
            // labelSi
            // 
            this.labelSi.AutoSize = true;
            this.labelSi.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSi.Location = new System.Drawing.Point(247, 60);
            this.labelSi.Name = "labelSi";
            this.labelSi.Size = new System.Drawing.Size(22, 25);
            this.labelSi.TabIndex = 11;
            this.labelSi.Text = "0";
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNo.Location = new System.Drawing.Point(247, 117);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(22, 25);
            this.labelNo.TabIndex = 12;
            this.labelNo.Text = "0";
            // 
            // labelNs
            // 
            this.labelNs.AutoSize = true;
            this.labelNs.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNs.Location = new System.Drawing.Point(247, 182);
            this.labelNs.Name = "labelNs";
            this.labelNs.Size = new System.Drawing.Size(22, 25);
            this.labelNs.TabIndex = 13;
            this.labelNs.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 281);
            this.Controls.Add(this.labelNs);
            this.Controls.Add(this.labelNo);
            this.Controls.Add(this.labelSi);
            this.Controls.Add(this.labelPorc);
            this.Controls.Add(this.labelOpc);
            this.Controls.Add(this.buttonVotar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonNs);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonSi);
            this.Name = "Form1";
            this.Text = "Ejercicio11. Votaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radioButtonSi;
        private RadioButton radioButtonNo;
        private RadioButton radioButtonNs;
        private Label label1;
        private Label label2;
        private Button buttonVotar;
        private Label labelOpc;
        private Label labelPorc;
        private Label labelSi;
        private Label labelNo;
        private Label labelNs;
    }
}