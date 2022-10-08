namespace Ejercicio1_WinForms
{
    public partial class Principal : Form
    {
        int aleatorio;
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            aleatorio = rnd.Next(0, 51);
        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            
            int numero = Int32.Parse(textBox1.Text);
            if ( numero == aleatorio){
                buttonJugar.Visible = false;
                labelTextoAyuda.Text = "HAS GANADO";
                ayuda.Visible = false;
            }
            if (numero < aleatorio)
            {
                labelTextoAyuda.Text = "El número es más grande";

            }
            else if (numero > aleatorio)
            {
                labelTextoAyuda.Text = "El número es más pequeño";
            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}