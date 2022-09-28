namespace Ejercicio_6._Metodos_de_Pago
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                groupBoxEfectivo.Visible = true;
                groupBoxTarjeta.Visible = false;

            }
            if (comboBox1.SelectedIndex == 1)
            {
                groupBoxTarjeta.Visible = true;
                groupBoxEfectivo.Visible = false;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {
            int total = Int32.Parse(textBoxTotal.Text);
            int entregado = Int32.Parse(textBoxEntregado.Text);
            calcCambio(total, entregado);
        }

        private void textBoxEntregado_TextChanged(object sender, EventArgs e)
        {
            int total = Int32.Parse(textBoxTotal.Text);
            int entregado = Int32.Parse(textBoxEntregado.Text);
            calcCambio(total, entregado);

        }
        private void calcCambio (int total, int entregado)
        {

            if (total > 0 & entregado > 0)
            {
                int cambio = total - entregado;
                textBoxCambio.Text = cambio.ToString();
            }
        }
    }
}