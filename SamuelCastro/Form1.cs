using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamuelCastro
{
    public partial class Form1 : Form
    {
        string[] mes = new string[13];



        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            
            double cantidad = 300000;
            
            mes[0] = "Enero";
            mes[1] = "Febrero";
            mes[2] = "Marzo";
            mes[3] = "Abril";
            mes[4] = "Mayo";
            mes[5] = "Junio";
            mes[6] = "Julio";
            mes[7] = "Agosto";
            mes[8] = "Septiembre";
            mes[9] = "Octubre";
            mes[10] = "Noviembre";
            mes[11] = "Diciembre";

            Calcular(cantidad);

                
        }
        public void Calcular(double cantidad)
        {
         
            double[] interes = new double[12];
            double Inversion = cantidad;

            for (int i = 0; i < interes.Length; i++)
            {
                interes[i] = (cantidad * (2.5 / 100) * i);
            }

            for (int i = 0; i < interes.Length; i++)
            {
                lvResultado.Items.Add("La cantidad depositada es: L.300,000 " + " En el mes: " +
                    mes[i] + "   Interes acumulado: " + interes[i]);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvResultado.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
