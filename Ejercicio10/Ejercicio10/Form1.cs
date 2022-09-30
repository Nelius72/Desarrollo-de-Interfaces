namespace Ejercicio10
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
        private void buttonOperacion_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(textBox3.Text);
            double precio2 = Convert.ToDouble(textBox4.Text);
            double precio3 = Convert.ToDouble(textBox7.Text);
            double cantidad = Convert.ToDouble(textBox2.Text);
            double cantidad2 = Convert.ToDouble(textBox5.Text);
            double cantidad3 = Convert.ToDouble(textBox8.Text);
            double total = (precio * cantidad) + (precio2 * cantidad2) + (precio3 * cantidad3);
            textBox10.Text = total* 1.21 + " €";

            if(total >100 && total < 200)
            {
                textBoxDescuento.Text = Math.Round((total*0.10),2).ToString()+" €";
                textBox10.Text = (total - Math.Round((total * 0.10), 2)).ToString()+ " €";
            }

        }
    }
}