namespace EjercicioTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int index=0;
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
        private void buttonA�adir_Click(object sender, EventArgs e)
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
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
           var result= MessageBox.Show("�Desea eliminar la informaci�n?", "Atenci�n!!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (DialogResult.Yes == result) {
            int newData = dataGridView1.SelectedRows[index].Index;
            
            dataGridView1.Rows.RemoveAt(newData);
            }
            else
            {
                MessageBox.Show("Has cancelado la eliminaci�n", "Atenci�n!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        { //Con esto gestionamos que cuando no haya una fila seleccionada los botones est�n apagados
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
        }
    }
}