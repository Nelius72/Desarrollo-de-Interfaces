namespace Ejercicio11._Votaciones
{
    public partial class Form1 : Form
    {
        int contador = 0;
        int contadorSi = 0;
        int contadorNo = 0;
        int contadorNs = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonVotar_Click(object sender, EventArgs e)
        {
            
            contador++;
            double porcentajeSi= Convert.ToDouble(labelSi.Text);
            double porcentajeNo = Convert.ToDouble(labelNo.Text);
            double porcentajeNs = Convert.ToDouble(labelNs.Text);

            if (radioButtonSi.Checked)
            {         
                contadorSi++;  
            }
            if (radioButtonNo.Checked)
            {
                contadorNo++; 
            }
            if (radioButtonNs.Checked)
            {
                contadorNs++;
            }
            porcentajeSi = (contadorSi * 100) / contador;
            porcentajeNo = (contadorNo * 100) / contador;
            porcentajeNs = (contadorNs * 100) / contador;
            labelSi.Text = porcentajeSi.ToString();
            labelNo.Text = porcentajeNo.ToString();
            labelNs.Text = porcentajeNs.ToString();
            label2.Text = contador.ToString();
        }
    }
}