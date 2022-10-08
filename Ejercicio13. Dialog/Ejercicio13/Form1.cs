namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            String rutaarchivo = openFileDialog1.FileName;
            textBox1.Text=rutaarchivo;
        }

        private void buttonNewWin_Click(object sender, EventArgs e)
        {
            Form2 nuevaVentana= new Form2();
            nuevaVentana.ShowDialog();
        }
    }
}