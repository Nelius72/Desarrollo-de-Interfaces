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
            int suma = n1 + n2 + n3;
            int resta = n1 - n2 - n3;
            int multi = n1 * n2 * n3;
            double div = n1 / n2 / n3;


            if (radioButtonSumar.Checked)
            {
                labelResultado.Text = "El Resultado de la Suma es : "  + suma;
            }
            if (radioButtonRestar.Checked)
            {
                labelResultado.Text= "El Resultado de la Resta es : " + resta;
            }
            if (radioButtonMultiplicar.Checked)
            {
                labelResultado.Text = "El Resultado de la Multiplicación es : " + multi;
            }
            if (radioButtonDividir.Checked)
            {
                labelResultado.Text = "El Resultado de la División es : " + div;
            }
            if (radioButtonTodas.Checked) { 
                labelResultado.Text= "Los Resultados son: "+ "\nSuma= "+suma +"\nResta = " + resta 
                                    + "\nMultiplicación = " + multi + "\nDivisión= " + div;
            }
        }
        }
    }