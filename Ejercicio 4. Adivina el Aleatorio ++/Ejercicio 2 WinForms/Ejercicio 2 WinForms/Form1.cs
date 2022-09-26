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
                labelMensajeAyuda.Text = "El n�mero es m�s grande";

            }
            else if (numero > aleatorio)
            {
                labelMensajeAyuda.Text = "El n�mero es m�s peque�o";
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            aleatorio = rnd.Next(0, 10);
        }
    }
}