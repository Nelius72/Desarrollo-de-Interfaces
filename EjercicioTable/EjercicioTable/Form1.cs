namespace EjercicioTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string notas="";
            int media=0;
            for(int i = 0; i < dataGridView1.Rows.Count-1; i++)//Hago un bucle que me recorre las filas
            {
                notas = dataGridView1[1, i].Value+"";
                media = int.Parse(notas)+media;
            }
            media = media / (dataGridView1.RowCount - 1);
            labelNota.Text = "La nota media es: "+media.ToString();
        }
private void buttonAñadir_Click(object sender, EventArgs e)
        {
            Form2Alta alta=new Form2Alta(dataGridView1); //Referenciamos a la nueva ventana el dataGridView
            alta.ShowDialog();

        }
    }
}