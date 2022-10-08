namespace EjercicioTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int index;
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
            Form2Alta alta=new Form2Alta(dataGridView1); //Referenciamos a la nueva ventana el dataGridView y le pasamos la tabla entera
            alta.ShowDialog();

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                Form3Modif modif = new Form3Modif(dataGridView1); //Ventana que sale al clicar modificacion
                
                modif.ShowDialog();
                
               

            }
           
        }

       private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
          
        }
    }
}