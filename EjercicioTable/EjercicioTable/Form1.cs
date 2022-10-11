namespace EjercicioTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        int index=0;
=======
        int index;
>>>>>>> 402bed43a65f6a0a8d3b82e14a86ad5f08c1df4c
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

<<<<<<< HEAD
      

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
           var result= MessageBox.Show("¿Desea eliminar la información?", "Atención!!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (DialogResult.Yes == result) {
            int newData = dataGridView1.SelectedRows[index].Index;
            
            dataGridView1.Rows.RemoveAt(newData);
            }
            else
            {
                MessageBox.Show("Has cancelado la eliminación", "Atención!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.ClearSelection();

            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        { //Con esto gestionamos que cuando no haya una fila seleccionada los botones estén apagados
            if (dataGridView1.Rows[0].IsNewRow)
            {
                buttonModificar.Enabled = false;
                buttonEliminar.Enabled = false;
            }
            else
            {
                buttonModificar.Enabled = true;
                buttonEliminar.Enabled = true;
            }
=======
       private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
          
>>>>>>> 402bed43a65f6a0a8d3b82e14a86ad5f08c1df4c
        }
    }
}