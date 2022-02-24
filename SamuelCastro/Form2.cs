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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string producto = txtproducto.Text;
            int precio = Convert.ToInt32(txtprecio.Text);
            
            Listado(producto, precio);
        }

        public void Listado(string producto, int precio)
        {
            double cantidad = 1;
            double descuento = 0;
            double subtotal = 0;

            descuento = precio * 0.15;
            subtotal = precio - descuento;
            for (int i = 0; i < cantidad; i++)
            {
                lvlfactura.Items.Add(" Producto: " + producto + " Precio: " + precio + " Descuento del 15%:  "+
                    subtotal);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtprecio.Clear();
            txtproducto.Clear();
            lvlfactura.Clear();
        }
    }
}
