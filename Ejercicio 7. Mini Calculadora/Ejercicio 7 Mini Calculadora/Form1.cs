namespace Ejercicio_7_Mini_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonIntro_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(textBox1.Text);
            int n2 = Int32.Parse(textBox2.Text);
            int n3 = Int32.Parse(textBox3.Text);
            
            if (radioButtonSumar.Checked)
            {
                labelResultado.Text = "Resultados: \n"  + (n1 + n2 + n3);
            }
        }
    }
}