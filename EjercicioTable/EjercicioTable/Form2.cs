using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioTable
{
    public partial class Form2Alta : Form
    {
        DataGridView nuevo; //Vamos a hacer referencia al DataGridView de la otra ventana
        public Form2Alta(DataGridView d)
        {
            InitializeComponent();
            nuevo = d;
        }
        


        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            string nombre=textBox1.Text;
            string nota=textBox2.Text;
     
            nuevo.Rows.Add(nombre,nota); //Añadimos los valores a la tabla de la otra ventana
            
        }


    }
}
