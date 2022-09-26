namespace Ejercicio_Cuenta
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(label2.Text);
            num++;
            label2.Text = num.ToString();
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            
            if (numero1.Text == "" || numero2.Text=="")
            {
                error.Visible = true;
                numero1.BackColor = Color.IndianRed;
                numero2.BackColor = Color.IndianRed;
            }
            else
            {
                Resultado.Text = "Resultado: " + (Int32.Parse(numero1.Text) + Int32.Parse(numero2.Text)).ToString();
                error.Visible = false;
                numero1.BackColor = Color.Green;
                numero2.BackColor = Color.Green;
            }
        }
    }
}