namespace Ejercicio_9._Nómina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            float salario = float.Parse(textBox1.Text);
            int dias=Int32.Parse(textBox2.Text);
            float total = salario * dias;
            double descPens = total * 0.10;
            double descSalud=total*0.15;
            textBox3.Text = Math.Round(descPens,2) + " €";
            textBox4.Text = Math.Round(descSalud,2) + " €";
            textBox5.Text = Math.Round((total-descPens-descSalud),2) + " €";
        }   
    }
}