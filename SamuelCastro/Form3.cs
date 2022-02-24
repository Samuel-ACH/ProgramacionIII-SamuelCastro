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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
           

            mostrar(nombre, apellido);
        }

        public void mostrar(string nombre, string apellido)
        {
            
            for (int i = 1; i < 101; i++)
            {
                lbcalcular.Items.Add(i.ToString());
                if (i % 3 == 0)
                {
                    lbcalcular.Items.Add(i.ToString() + nombre);
                }
                if (i % 5 == 0)
                {
                    lbcalcular.Items.Add(i.ToString() + apellido);
                }
                if (i % 3 == 0 & i % 5 == 0)
                {
                    lbcalcular.Items.Add(i.ToString() + nombre + " " +apellido);
                }
            }
           
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            lbcalcular.Items.Clear();
            txtapellido.Clear();
            txtnombre.Clear();
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
