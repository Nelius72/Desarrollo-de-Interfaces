namespace Ejercicio_8._Productos
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

        private void buttonOperacion_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(textBox3.Text);
            double precio2 = Convert.ToDouble(textBox4.Text);
            double precio3 = Convert.ToDouble(textBox7.Text);
            double cantidad = Convert.ToDouble(textBox2.Text);
            double cantidad2 = Convert.ToDouble(textBox5.Text);
            double cantidad3 = Convert.ToDouble(textBox8.Text);
            
            textBox10.Text = ((precio*cantidad)+(precio2*cantidad2)+(precio3*cantidad3))*1.21 + " €";
        }
    }
}