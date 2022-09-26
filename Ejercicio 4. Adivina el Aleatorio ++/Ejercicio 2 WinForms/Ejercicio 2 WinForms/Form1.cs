namespace Ejercicio_2_WinForms
{
    public partial class Principal : Form
    {
        int aleatorio;
        public Principal()
        {
            InitializeComponent();
        }

        private void labelNumero_Click(object sender, EventArgs e)
        {

        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(textBox1.Text);
            if (numero == aleatorio)
            {
                buttonJugar.Visible = false;
                labelMensajeAyuda.Text = "HAS GANADO";
                labelAyuda.Visible = false;
            }
            if (numero < aleatorio)
            {
                labelMensajeAyuda.Text = "El número es más grande";

            }
            else if (numero > aleatorio)
            {
                labelMensajeAyuda.Text = "El número es más pequeño";
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            aleatorio = rnd.Next(0, 10);
        }
    }
}