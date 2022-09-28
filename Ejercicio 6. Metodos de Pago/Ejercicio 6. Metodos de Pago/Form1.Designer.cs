namespace Ejercicio_6._Metodos_de_Pago
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelMétodoPago = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelEntregado = new System.Windows.Forms.Label();
            this.labelCambio = new System.Windows.Forms.Label();
            this.labelNTarjeta = new System.Windows.Forms.Label();
            this.labelFCaducidad = new System.Windows.Forms.Label();
            this.groupBoxEfectivo = new System.Windows.Forms.GroupBox();
            this.textBoxCambio = new System.Windows.Forms.TextBox();
            this.textBoxEntregado = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.groupBoxTarjeta = new System.Windows.Forms.GroupBox();
            this.textBoxFCaducidad = new System.Windows.Forms.TextBox();
            this.textBoxNTarjeta = new System.Windows.Forms.TextBox();
            this.groupBoxEfectivo.SuspendLayout();
            this.groupBoxTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "En Efectivo",
            "Tarjeta"});
            this.comboBox1.Location = new System.Drawing.Point(197, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelMétodoPago
            // 
            this.labelMétodoPago.AutoSize = true;
            this.labelMétodoPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMétodoPago.Location = new System.Drawing.Point(76, 66);
            this.labelMétodoPago.Name = "labelMétodoPago";
            this.labelMétodoPago.Size = new System.Drawing.Size(101, 15);
            this.labelMétodoPago.TabIndex = 1;
            this.labelMétodoPago.Text = "Método de Pago:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.Location = new System.Drawing.Point(17, 30);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(37, 15);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "Total:";
            // 
            // labelEntregado
            // 
            this.labelEntregado.AutoSize = true;
            this.labelEntregado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEntregado.Location = new System.Drawing.Point(17, 66);
            this.labelEntregado.Name = "labelEntregado";
            this.labelEntregado.Size = new System.Drawing.Size(67, 15);
            this.labelEntregado.TabIndex = 3;
            this.labelEntregado.Text = "Entregado:";
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCambio.Location = new System.Drawing.Point(17, 100);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(51, 15);
            this.labelCambio.TabIndex = 4;
            this.labelCambio.Text = "Cambio:";
            // 
            // labelNTarjeta
            // 
            this.labelNTarjeta.AutoSize = true;
            this.labelNTarjeta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNTarjeta.Location = new System.Drawing.Point(18, 31);
            this.labelNTarjeta.Name = "labelNTarjeta";
            this.labelNTarjeta.Size = new System.Drawing.Size(65, 15);
            this.labelNTarjeta.TabIndex = 5;
            this.labelNTarjeta.Text = "Nº Tarjeta:";
            // 
            // labelFCaducidad
            // 
            this.labelFCaducidad.AutoSize = true;
            this.labelFCaducidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFCaducidad.Location = new System.Drawing.Point(18, 63);
            this.labelFCaducidad.Name = "labelFCaducidad";
            this.labelFCaducidad.Size = new System.Drawing.Size(101, 15);
            this.labelFCaducidad.TabIndex = 6;
            this.labelFCaducidad.Text = "Fecha Caducidad:";
            // 
            // groupBoxEfectivo
            // 
            this.groupBoxEfectivo.Controls.Add(this.textBoxCambio);
            this.groupBoxEfectivo.Controls.Add(this.textBoxEntregado);
            this.groupBoxEfectivo.Controls.Add(this.textBoxTotal);
            this.groupBoxEfectivo.Controls.Add(this.labelTotal);
            this.groupBoxEfectivo.Controls.Add(this.labelEntregado);
            this.groupBoxEfectivo.Controls.Add(this.labelCambio);
            this.groupBoxEfectivo.Location = new System.Drawing.Point(76, 113);
            this.groupBoxEfectivo.Name = "groupBoxEfectivo";
            this.groupBoxEfectivo.Size = new System.Drawing.Size(242, 137);
            this.groupBoxEfectivo.TabIndex = 7;
            this.groupBoxEfectivo.TabStop = false;
            this.groupBoxEfectivo.Text = "Efectivo";
            this.groupBoxEfectivo.Visible = false;
            // 
            // textBoxCambio
            // 
            this.textBoxCambio.Location = new System.Drawing.Point(87, 97);
            this.textBoxCambio.Name = "textBoxCambio";
            this.textBoxCambio.Size = new System.Drawing.Size(100, 23);
            this.textBoxCambio.TabIndex = 7;
            this.textBoxCambio.Text = "0";
            // 
            // textBoxEntregado
            // 
            this.textBoxEntregado.Location = new System.Drawing.Point(87, 63);
            this.textBoxEntregado.Name = "textBoxEntregado";
            this.textBoxEntregado.Size = new System.Drawing.Size(100, 23);
            this.textBoxEntregado.TabIndex = 6;
            this.textBoxEntregado.Text = "0";
            this.textBoxEntregado.TextChanged += new System.EventHandler(this.textBoxEntregado_TextChanged);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(87, 30);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 23);
            this.textBoxTotal.TabIndex = 5;
            this.textBoxTotal.Text = "0";
            this.textBoxTotal.TextChanged += new System.EventHandler(this.textBoxTotal_TextChanged);
            // 
            // groupBoxTarjeta
            // 
            this.groupBoxTarjeta.Controls.Add(this.textBoxFCaducidad);
            this.groupBoxTarjeta.Controls.Add(this.textBoxNTarjeta);
            this.groupBoxTarjeta.Controls.Add(this.labelNTarjeta);
            this.groupBoxTarjeta.Controls.Add(this.labelFCaducidad);
            this.groupBoxTarjeta.Location = new System.Drawing.Point(402, 128);
            this.groupBoxTarjeta.Name = "groupBoxTarjeta";
            this.groupBoxTarjeta.Size = new System.Drawing.Size(282, 100);
            this.groupBoxTarjeta.TabIndex = 8;
            this.groupBoxTarjeta.TabStop = false;
            this.groupBoxTarjeta.Text = "Tarjeta";
            this.groupBoxTarjeta.Visible = false;
            // 
            // textBoxFCaducidad
            // 
            this.textBoxFCaducidad.Location = new System.Drawing.Point(135, 60);
            this.textBoxFCaducidad.Name = "textBoxFCaducidad";
            this.textBoxFCaducidad.Size = new System.Drawing.Size(100, 23);
            this.textBoxFCaducidad.TabIndex = 8;
            this.textBoxFCaducidad.Text = "0";
            // 
            // textBoxNTarjeta
            // 
            this.textBoxNTarjeta.Location = new System.Drawing.Point(89, 31);
            this.textBoxNTarjeta.Name = "textBoxNTarjeta";
            this.textBoxNTarjeta.Size = new System.Drawing.Size(182, 23);
            this.textBoxNTarjeta.TabIndex = 7;
            this.textBoxNTarjeta.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(685, 262);
            this.Controls.Add(this.groupBoxTarjeta);
            this.Controls.Add(this.groupBoxEfectivo);
            this.Controls.Add(this.labelMétodoPago);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Ejercicio 6 . Métodos de Pago";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxEfectivo.ResumeLayout(false);
            this.groupBoxEfectivo.PerformLayout();
            this.groupBoxTarjeta.ResumeLayout(false);
            this.groupBoxTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Label labelMétodoPago;
        private Label labelTotal;
        private Label labelEntregado;
        private Label labelCambio;
        private Label labelNTarjeta;
        private Label labelFCaducidad;
        private GroupBox groupBoxEfectivo;
        private TextBox textBoxCambio;
        private TextBox textBoxEntregado;
        private TextBox textBoxTotal;
        private GroupBox groupBoxTarjeta;
        private TextBox textBoxFCaducidad;
        private TextBox textBoxNTarjeta;
    }
}