namespace Ejercicio_5
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

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            String palabra= textBox1.Text;

            for(int i = 0; i < comboBox1.Items.Count; i++)
            {
                if(comboBox1.Items[i].ToString() == palabra)
                {
                    MessageBox.Show("Error!! Palabra Repetida","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
            comboBox1.Items.Add(palabra);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelResultado.Text= "La palabra seleccionada es "+comboBox1.SelectedItem.ToString()
                +" que se encuentra en la posición "+ comboBox1.SelectedIndex.ToString();
                
        }
    }
}