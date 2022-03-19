using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Accesos;
using Datos.Entidades;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(txtusuario.Text, txtcontraseña.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuario ó contraseña incorrectos");
                return;
            }
            else
            {
                MessageBox.Show("Conectado a la Base de Datos Ejercicio3");
                Form2 frm2 = new Form2();
                frm2.Show();
                return;
            }

          
        }
    }
}
