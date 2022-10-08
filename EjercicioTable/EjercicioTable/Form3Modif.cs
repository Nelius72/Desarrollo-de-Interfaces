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
    public partial class Form3Modif : Form
    {
        DataGridView oreja;
        int index=0;
        public Form3Modif(DataGridView alfa)
        {
           
            InitializeComponent();
            oreja= alfa;
        }

        private void Form3Modif_Load(object sender, EventArgs e)
        {
            
            textBox1Modif.Text = oreja.SelectedRows[0].Cells[0].Value.ToString();
            textBoxModif.Text = oreja.SelectedRows[0].Cells[1].Value.ToString();
           
        }

       // private void buttonAct_Click(object sender, EventArgs e)
       // {
            
      //  }

       // private void button1Act_Click(object sender, EventArgs e)
       // {
       //     string modifName = textBoxModif.Text;
        //    string modifNote = textBox1Modif.Text;

         //   oreja.Rows.Clear();
         //   oreja.Rows.Add(modifName, modifNote);
       // }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRow newData = oreja.SelectedRows[index];
            newData.Cells[0].Value = textBox1Modif.Text;
            newData.Cells[1].Value = textBoxModif.Text;
           
            

        }
    }
}
