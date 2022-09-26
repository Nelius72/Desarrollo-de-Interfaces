namespace Ejercicio2._Numero_Letras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String palabra = textBox1.Text;
            char letra = char.Parse(textBox2.Text);
            int contador=0;

            for(int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i].Equals(letra)) { 
                    contador++; }
            }
            labelTotal.Text="La letra se repite "+contador.ToString()+ " veces.";
        }
    }
}