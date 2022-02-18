using Microsoft.VisualBasic;

namespace Almacenar_datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int datos;
        string[] nombres { get; set; }
        double[] edad { get; set; }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtvalor.Text.Trim() != "")
                {
                    datos = int.Parse(txtvalor.Text.Trim());
                    nombres = new string[datos];
                    edad = new double[datos];
                    for (int i = 0; i < datos; i++)
                    {
                        
                        nombres[i] = Interaction.InputBox("Escriba el nombre del Alumno: ");
                        edad[i] = double.Parse(Interaction.InputBox("Ingrese la Edad"));
                        cbxlista.Items.Add("Nombre: " + nombres[i] + "  Edad: " + edad[i]);
                    }                 
                }
            }
            catch (Exception ex) {
               
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtvalor.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbxlista.Items.Clear();
        }

    }
}