namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            


            String frase = textBoxPalabra.Text;
            int caracteres = 0;
            int espacios=0;
            if (!listBox1.Items.Contains(frase))
            {
                listBox1.Items.Add(frase);
            }

            for(int i = 0; i < listBox1.Items.Count; i++) //Recorre los espacios de la listbox
            {
                String palabra= listBox1.Items[i].ToString(); //Indico la posición de cada linea
                caracteres= listBox1.Items[i].ToString().Length + caracteres;
                for(int j = 0; j <palabra.Length ; j++) //Recorro cada linea
                {
                    if (palabra[j]== " "[0])//Si en la linea hay un espacio se suma uno al contador
                    {
                        espacios++;
                    }
                   
                }
            }
          
         textBoxEst.Text = "Hay "+listBox1.Items.Count+" lineas."+Environment.NewLine+
                "Hay " + caracteres +" caracteres."+Environment.NewLine+ "Hay " + espacios +
                " huecos en blanco.";

        }

        
    }
}